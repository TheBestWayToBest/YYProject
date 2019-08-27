using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace w_Display
{
    public partial class w_DataReceive : Form
    {
        List<Model_BillInfo> lmb;
        decimal pno = 1;
        public w_DataReceive()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            pno = Convert.ToDecimal(ConfigurationManager.AppSettings["PNo"]);
            try
            {
                lmb = BLL_Data.GetAllBillInfo(pno);
            }
            catch
            {
                MessageBox.Show("数据库连接失败，请检查数据库网络并重新启动程序！");
                foreach (Control item in Controls)
                {
                    item.Enabled = false;
                }
                return;
            }
            DgvOrderData.DataSource = lmb;
            if (lmb.Count > 0)
            {
                Model_BillInfo info = new Model_BillInfo();
                int packageno;
                try
                {
                    packageno = lmb.Where(item => item.LabelingStatus == "未完成").Min(item => item.PackageNo);
                }
                catch
                {
                    packageno = lmb.Where(item => item.LabelingStatus == "已完成").Max(item => item.PackageNo);
                }
                info = lmb.Where(item => item.PackageNo == packageno).FirstOrDefault();
                lblID.Text = "流水编号：" + packageno.ToString();
                lblCusName.Text = "客户名称：" + info.CusName;
                lblCusCount.Text = "商户总量：" + lmb.GroupBy(item => item.BillCode).Select(item => item.Key.Distinct()).Count().ToString();
                lblCusAddress.Text = "客户地址：" + info.CusAddress.ToString();
                lblPackageCount.Text = "总包数：" + lmb.Count().ToString();
            }
        }
        string path = "";
        private void BtnDataReceive_Click(object sender, EventArgs e)
        {
            BGWDataReceive.RunWorkerAsync();
            BtnChooseFile.Enabled = false;
            BtnDataClear.Enabled = false;
            BtnDataReceive.Enabled = false;
            BtnDisplay.Enabled = false;
        }

        private void DgvOrderData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //自动编号，与数据无关
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
               e.RowBounds.Location.Y,
               DgvOrderData.RowHeadersWidth - 4,
               e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,
                  (e.RowIndex + 1).ToString(),
                   DgvOrderData.RowHeadersDefaultCellStyle.Font,
                   rectangle,
                   DgvOrderData.RowHeadersDefaultCellStyle.ForeColor,
                   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void BtnDataClear_Click(object sender, EventArgs e)
        {
            BLL_Data.ClearData(pno);
            lmb = new List<Model_BillInfo>();
            DgvOrderData.DataSource = lmb;
            lblID.Text = "流水编号：";
            lblCusName.Text = "客户名称：";
            lblCusCount.Text = "商户总量：";
            lblCusAddress.Text = "客户地址：";
            lblPackageCount.Text = "总包数：";
        }

        private void DgvOrderData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 != 0)
            {
                foreach (DataGridViewCell item in DgvOrderData.Rows[e.RowIndex].Cells)
                {
                    item.Style.BackColor = Color.LightCyan;
                }
            }
        }

        string choosePath = "";
        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = Application.StartupPath + @"\数据\";
            file.Title = "请选择导入的txt文件";
            file.Filter = "*.txt|";
            file.ShowDialog();
            choosePath = file.FileName;
            lblPath.Text = choosePath;
        }
        w_UnnormalDisplay frmUn;
        w_NormalDisplay frms;
        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            if (pno == 1)
            {
                try
                {
                    if (!FormS.IsOpen)
                    {
                        frmUn = new w_UnnormalDisplay();
                        FormS.IsOpen = true;
                        frmUn.Show();
                    }
                    else
                    {
                        frmUn.Activate();
                    }
                }
                catch
                {

                }
            }

            else
            {
                try
                {
                    if (!FormS.IsOpen)
                    {
                        frms = new w_NormalDisplay();
                        FormS.IsOpen = true;
                        frms.Show();
                    }
                    else
                    {
                        frms.Activate();
                    }
                }
                catch
                {

                }
            }
            
        }

        private void BGWDataReceive_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (choosePath == "")
                {
                    path = Application.StartupPath + @"\数据\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                }
                else
                {
                    path = choosePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            string sr = "";
            if (pno == 1)
            {
                List<Model_Data> lmd = FileRead.ReadUnFile(path, out sr);
                if (sr != "" && lmd.Count == 0)
                {
                    MessageBox.Show(sr);
                    return;
                }
                int index = 0;
                int id = BLL_Data.GetMaxID(pno);
                if (id == 0)
                    index = 0;
                else if (id == lmd.Count)
                {
                    index = lmd.Count;
                    MessageBox.Show("数据已全部接收，如需重新接收数据，请先清除数据");
                }
                else
                    index = id;
                for (int i = index; i < lmd.Count; i++)
                {
                    lmd[i].LabelingStatus = "0";
                    lmd[i].ID = i + 1;
                    lmd[i].PNo = pno;
                    BLL_Data.InsertUnnormalData(lmd[i]);
                }
            }
            else
            {
                List<Model_NormalData> lmdn = FileRead.ReadNormalFile(path, out sr);
                if (sr != "" && lmdn.Count == 0)
                {
                    MessageBox.Show(sr);
                    return;
                }
                int index = 0;
                int id = BLL_Data.GetMaxID(pno);
                if (id == 0)
                    index = 0;
                else if (id == lmdn.Count)
                {
                    index = lmdn.Count;
                    MessageBox.Show("数据已全部接收，如需重新接收数据，请先清除数据");
                    return;
                }
                else
                    index = id;
                for (int i = index; i < lmdn.Count; i++)
                {
                    lmdn[i].LabelingStatus = "0";
                    lmdn[i].ID = i + 1;
                    lmdn[i].PNo = pno;
                    BLL_Data.InsertNormalData(lmdn[i]);
                }
            }
            lmb = new List<Model_BillInfo>();
            lmb = BLL_Data.GetAllBillInfo(pno);

            Model_BillInfo info = new Model_BillInfo();
            int packageno = lmb.Where(item => item.LabelingStatus == "未完成").Min(item => item.PackageNo);
            info = lmb.Where(item => item.PackageNo == packageno).FirstOrDefault();
            lblID.Text = "流水编号：" + packageno.ToString();
            lblCusName.Text = "客户名称：" + info.CusName;
            lblCusCount.Text = "商户总量：" + lmb.GroupBy(item => item.BillCode).Select(item => item.Key.Distinct()).Count().ToString();
            lblCusAddress.Text = "客户地址：" + info.CusAddress.ToString();
            lblPackageCount.Text = "总包数：" + lmb.Count().ToString();

            DgvOrderData.DataSource = lmb;
        }

        private void BGWDataReceive_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BtnChooseFile.Enabled = true;
            BtnDataClear.Enabled = true;
            BtnDataReceive.Enabled = true;
            BtnDisplay.Enabled = true;
        }

        private void w_DataReceive_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BGWDataReceive.IsBusy)
            {
                e.Cancel = true;
                MessageBox.Show("数据接收中，请勿关闭窗口！");
            }
        }
    }
}

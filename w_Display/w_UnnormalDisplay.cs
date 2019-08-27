using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Threading;
using HslCommunication.Profinet.Siemens;
using HslCommunication;

namespace w_Display
{
    public partial class w_UnnormalDisplay : Form
    {
        List<Model_Data> list;
        int index = 0;
        int count;
        decimal pno = 1;
        string imagePath = "";
        string plcIp = "";
        private SiemensS7Net siemensTcpNet = null;
        string db = "";
        OpaqueCommand oc;
        int readTime = 500;
        public w_UnnormalDisplay()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            db = ConfigurationManager.AppSettings["DB"].ToString();
            imagePath = Application.StartupPath + @"\Resources";
            pno = Convert.ToDecimal(ConfigurationManager.AppSettings["PNo"]);
            plcIp= ConfigurationManager.AppSettings["PLCIp"].ToString();
            X = this.Width;//获取窗体的宽度
            Y = this.Height;//获取窗体的高度
            gX = groupBox2.Width;
            gY = groupBox2.Height;
            oc = new OpaqueCommand();
            readTime = Convert.ToInt32(ConfigurationManager.AppSettings["ReadTime"]);
            oc.ShowOpaqueLayer(this, 125, true);
            BgwLoad.RunWorkerAsync();


            SetTag(this);//调用方法
        }

        int k = 0;
        void Display()
        {
            k = 0;
            lblLineName.Text = "线路名称：" + list[index].LineName;
            lblLineTotal.Text = "线路总包数：" + list[index].LinePackageSeq;
            lblLineCusTotal.Text = "线路户数：" + list[index].LineCusCount;
            lblLineSeq.Text = "线路包序：" + list[index].CusTotalPackage;

            lblBillCode.Text = "订单号：" + list[index].BillCode;
            lblCusName.Text = "客户名称：" + list[index].CusName;
            lblPackagenum.Text = "该包数量：" + count;
            lblCus.Text = "客户总包数：" + list[index].LineTotalPackage;

            AddPic();
        }

        void AddPic()
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { AddPic(); }));
                return;
            }
            this.groupBox2.Controls.Clear();

            

            for (int i = 0; i < count; i++)
            {
                int width = Convert.ToInt32(int.Parse(list[index].Width));
                int height = Convert.ToInt32(int.Parse(list[index].Height));
                PictureBox box = new PictureBox();
                box.Width = width;
                box.Height = height;
                try
                {
                    box.Image = Image.FromFile(imagePath + @"\" + list[index].CigCode + ".jpg");
                    box.BorderStyle = BorderStyle.FixedSingle;
                }
                catch
                {
                    box.Paint += Box_Paint;
                    box.BorderStyle = BorderStyle.FixedSingle;
                    box.BackColor = Color.Yellow;
                    k++;
                }

                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Location = new Point(Convert.ToInt32((Convert.ToInt32(double.Parse(list[index].PositionY)) - width / 2)), Convert.ToInt32((gY - double.Parse(list[index].PositionZ))) - 5);
                this.groupBox2.Controls.Add(box);
                index++;
            }
            SetTag(groupBox2);//调用方法


            float newx = (this.groupBox2.Width) / gX; //窗体宽度缩放比例
            float newy = (this.groupBox2.Height) / gY;//窗体高度缩放比例
            SetControls(newx, newy, groupBox2);//随窗体改变控件大小
        }

        private void Box_Paint(object sender, PaintEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            Graphics g = e.Graphics;
            g.DrawString(list[index - k].CigName, new Font("宋体", 20, FontStyle.Bold), new SolidBrush(Color.Red), 0, 15);
            k--;
        }

        #region
        private float X;//当前窗体的宽度

        private float Y;//当前窗体的高度

        private float gX;
        private float gY;

        /// <summary>
        /// 将控件的宽，高，左边距，顶边距和字体大小暂存到tag属性中
        /// </summary>
        /// <param name="cons">递归控件中的控件</param>
        private void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    SetTag(con);
            }
        }
        //根据窗体大小调整控件大小

        private void SetControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                if (con.Name == "groupBox2")
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    //获取控件的Tag属性值，并分割后存储字符串数组
                    float a = System.Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的值，宽度
                    con.Width = (int)a;//宽度
                    a = System.Convert.ToSingle(mytag[1]) * newy;//高度
                    con.Height = (int)(a) + 50;
                    a = System.Convert.ToSingle(mytag[2]) * newx;//左边距离
                    con.Left = (int)(a);
                    a = System.Convert.ToSingle(mytag[3]) * newy;//上边缘距离
                    con.Top = (int)(a);
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                else
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    //获取控件的Tag属性值，并分割后存储字符串数组
                    float a = System.Convert.ToSingle(mytag[0]) * newx;//根据窗体缩放比例确定控件的值，宽度
                    con.Width = (int)a;//宽度
                    a = System.Convert.ToSingle(mytag[1]) * newy;//高度
                    con.Height = (int)(a);
                    a = System.Convert.ToSingle(mytag[2]) * newx;//左边距离
                    con.Left = (int)(a);
                    a = System.Convert.ToSingle(mytag[3]) * newy;//上边缘距离
                    con.Top = (int)(a);
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
        }

        private void w_UnnormalDisplay_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X; //窗体宽度缩放比例
            float newy = (this.Height) / Y;//窗体高度缩放比例
            SetControls(newx, newy, this);//随窗体改变控件大小
        }
        #endregion

        private void BgwReadPlc_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);

            short result = siemensTcpNet.ReadInt16(db).Content;
            if (result == 1)
            {
                SwichPackage();
                siemensTcpNet.Write(db, short.Parse("0"));
            }
        }

        void SwichPackage()
        {
            if (list.Count > 0 && index > 0)
            {
                int packageNo = list[index - 1].PackageNo;
                BLL_Data.UpdateLabelingStatus(packageNo, pno);
            }

            if (index < list.Count)
            {
                count = int.Parse(list[index].PackageNum);
                Display();
            }


            SetTag(groupBox2);//调用方法


            //float newx = (this.groupBox2.Width) / gX; //窗体宽度缩放比例
            //float newy = (this.groupBox2.Height) / gY;//窗体高度缩放比例
            //SetControls(newx, newy, groupBox2);//随窗体改变控件大小
        }

        private void BgwReadPlc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(readTime);
            BgwReadPlc.RunWorkerAsync();
        }

        private void BgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1200)
            {
                IpAddress = plcIp,
                Rack = byte.Parse("0"),
                Slot = byte.Parse("0")
            };
            OperateResult result = siemensTcpNet.ConnectServer();
            if (!result.IsSuccess)
            {
                SetTag(this);//调用方法
                MessageBox.Show("PLC连接失败，请检查PLC网络");
                Close();
                return;
            }
            list = new List<Model_Data>();
            list = BLL_Data.GetData(pno);
            if (list.Count <= 0)
            {
                MessageBox.Show("请先接收数据！");
            }
            else
            {
                try
                {
                    index = list.Where(item => item.LabelingStatus == "0").Min(item => item.ID) - 1;
                    
                }
                catch
                {
                    MessageBox.Show("已接收数据中都已完成");
                    return;
                }
                count = int.Parse(list[index].PackageNum);
                Display();
                siemensTcpNet.Write(db, (short)0);
                BgwReadPlc.RunWorkerAsync();
            }
        }

        private void BgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            oc.HideOpaqueLayer();
        }

        private void w_UnnormalDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            BgwReadPlc.CancelAsync();
            FormS.IsOpen = false;
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            //int currentPackageNo = list.Where(item => item.LabelingStatus == "未完成").Min(item => item.PackageNo);
            int maxPackageNo = list.Select(x => x.PackageNo).Distinct().Count();
            w_DataPosition frm = new w_DataPosition(maxPackageNo);
            frm.ShowDialog();
            if (DataPosition.ID > 0)
            {
                index = DataPosition.ID - 1;
                SwichPackage();
                DataPosition.ID = 0;
                DataPosition.PackageNo = 0;
            }
        }
    }
}

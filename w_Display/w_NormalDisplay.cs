using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.Profinet.Siemens;

namespace w_Display
{
    public partial class w_NormalDisplay : Form
    {
        List<Model_Data> list;
        int index = 0;
        int count;
        decimal pno = 1;
        string imagePath = "";
        string plcIp = "";
        int l = 0;
        private SiemensS7Net siemensTcpNet = null;
        string db = "";
        float fontSize = 0;
        string deriction = "left";
        int readTime = 500;
        OpaqueCommand oc;
        public w_NormalDisplay()
        {
            InitializeComponent();

            plcIp = ConfigurationManager.AppSettings["PLCIp"].ToString();
            db = ConfigurationManager.AppSettings["DB"].ToString();
            imagePath = Application.StartupPath + @"\Resources";
            pno = Convert.ToDecimal(ConfigurationManager.AppSettings["PNo"]);
            readTime = Convert.ToInt32(ConfigurationManager.AppSettings["ReadTime"]);
            CheckForIllegalCrossThreadCalls = false;
            fontSize = Convert.ToInt32(ConfigurationManager.AppSettings["FontSize"]);
            oc = new OpaqueCommand();
            oc.ShowOpaqueLayer(this, 125, true);
            BgwLoad.RunWorkerAsync();
            X = this.Width;//获取窗体的宽度
            Y = this.Height;//获取窗体的高度
            SetTag(this);//调用方法 
        }


        #region
        private float X;//当前窗体的宽度

        private float Y;//当前窗体的高度

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
                if (con.Controls.Count > 0)
                {
                    SetControls(newx, newy, con);
                }
            }
        }

        private void w_Display_Resize(object sender, EventArgs e)
        {
            try
            {
                float newx = (this.Width) / X; //窗体宽度缩放比例
                float newy = (this.Height) / Y;//窗体高度缩放比例
                SetControls(newx, newy, this);//随窗体改变控件大小
            }
            catch
            {

            }
        }

        #endregion

        void Display()
        {
            l = 0;
            lblLineName.Text = "线路名称：" + list[index].LineName;
            lblLineTotal.Text = "线路总包数：" + list[index].LineTotalPackage;
            lblLineCusTotal.Text = "线路户数：" + list[index].LineCusCount;
            lblLineSeq.Text = "线路包序：" + list[index].LinePackageSeq;

            lblBillCode.Text = "订单号：" + list[index].BillCode;
            lblCusName.Text = "客户名称：" + list[index].CusName;
            lblPackagenum.Text = "该包数量：" + count;
            lblCus.Text = "客户总包数：" + list[index].CusTotalPackage;

            if (deriction == "left")
                AddPic();
            else
                AddPic2();
        }

        void AddPic()
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { AddPic(); }));
                return;
            }
            this.groupBox2.Controls.Clear();
            int c = count;
            int row = 5;
            int column = 0;
            if (c <= 5 && c > 0)
            {
                row = c;
                column = 1;
            }
            else
            {
                row = 5;
                column = (int)Math.Ceiling(c / 5.0);
            }
            int k = c % 5;
            int width = (this.groupBox2.Width - 60) / 5 - 6;
            int height = (this.groupBox2.Height - 72) / 6;
            for (int j = 0; j < column; j++)
            {
                if (j == column - 1 && k != 0)
                {
                    row = k;
                }
                for (int i = 0; i < row; i++)
                {
                    PictureBox box = new PictureBox();
                    box.Width = width;
                    box.Height = height - 5;
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

                        l++;
                    }
                    box.SizeMode = PictureBoxSizeMode.StretchImage;
                    box.Location = new Point((width + 5) * i + 35, (height) * (6 - 1 - j) + 75);
                    this.groupBox2.Controls.Add(box);
                    index++;
                }
            }
        }

        void AddPic2()
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate { AddPic2(); }));
                return;
            }
            this.groupBox2.Controls.Clear();
            int c = count;
            int row = 5;
            int column = 0;
            if (c <= 5 && c > 0)
            {
                row = c;
                column = 1;
            }
            else
            {
                row = 5;
                column = (int)Math.Ceiling(c / 5.0);
            }
            int k = c % 5;
            int width = (this.groupBox2.Width - 60) / 5 - 6;
            int height = (this.groupBox2.Height - 72) / 6;
            for (int j = 0; j < column; j++)
            {
                if (j == column - 1 && k != 0)
                {
                    row = k;
                }
                for (int i = 0; i < row; i++)
                {
                    PictureBox box = new PictureBox();
                    box.Width = width;
                    box.Height = height - 5;
                    try
                    {
                        box.Image = Image.FromFile(imagePath + @"\" + list[index].CigCode.Trim() + ".jpg");
                        box.BorderStyle = BorderStyle.FixedSingle;
                    }
                    catch
                    {
                        box.Paint += Box_Paint;
                        box.BorderStyle = BorderStyle.FixedSingle;
                        box.BackColor = Color.LightBlue;
                        l++;
                    }
                    box.SizeMode = PictureBoxSizeMode.StretchImage;
                    box.Location = new Point((width + 5) * (4 - i) + 35, (height) * (6 - 1 - j) + 75);
                    this.groupBox2.Controls.Add(box);
                    index++;
                }
            }
        }
        private void Box_Paint(object sender, PaintEventArgs e)
        {
            PictureBox box = sender as PictureBox;
            Graphics g = e.Graphics;
            g.DrawString(list[index - l].CigName, new Font("宋体", fontSize, FontStyle.Bold), new SolidBrush(Color.Red), 0, 32);
            l--;
        }
        private void BGReadPlc_DoWork(object sender, DoWorkEventArgs e)
        {
            // 读取short变量
            short result = siemensTcpNet.ReadInt16(db).Content;
            if (result == 1)
            {
                SwichPackage();
                siemensTcpNet.Write(db, short.Parse("0"));
            }
        }

        private void BGReadPlc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Thread.Sleep(readTime);
            BgwReadPlc.RunWorkerAsync();
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
            SetTag(this);//调用方法

            float newx = 1; //窗体宽度缩放比例
            float newy = 1;//窗体高度缩放比例
            SetControls(newx, newy, this);//随窗体改变控件大小
        }

        private void BgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            siemensTcpNet = new SiemensS7Net(SiemensPLCS.S1500)
            {
                IpAddress = plcIp,
                Rack = byte.Parse("0"),
                Slot = byte.Parse("0")
            };
            deriction = ConfigurationManager.AppSettings["Deriction"].ToString().ToLower();
            OperateResult result = siemensTcpNet.ConnectServer();
            if (!result.IsSuccess)
            {
                X = this.Width;//获取窗体的宽度
                Y = this.Height;//获取窗体的高度
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
                index = list.Where(item => item.LabelingStatus == "0").Min(item => item.ID) - 1;
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

        private void w_NormalDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            BgwReadPlc.CancelAsync();
            FormS.IsOpen = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwichPackage();
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
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

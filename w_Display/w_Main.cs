using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace w_Display
{
    public partial class w_Main : Form
    {
        public w_Main()
        {
            InitializeComponent();
            TTimer.Text = "     "+DateTime.Now.ToString("hh:mm:ss yyyy-MM-dd ") ;
        }

        private void 数据接收ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_DataReceive frm = new w_DataReceive();
            if (CheckExist(frm))
            {
                frm.Dispose();
                frm = null;
                return;
            }
            //frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            
            frm.Show();
        }


        /// <summary>
        /// 查找是否已经打开
        /// </summary>
        /// <param name="frm"></param>
        /// <returns></returns>
        private bool CheckExist(Form frm)
        {
            bool blResult = false;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().Name == frm.GetType().Name)
                {
                    Form tmpFrm = MdiChildren[i];
                    if (tmpFrm.Text == frm.Text)
                    {
                        blResult = true;
                        tmpFrm.Activate();
                    }
                    else if (frm.Text == "")
                    {
                        blResult = true;
                        tmpFrm.Activate();
                    }
                    else if (frm.GetType().Name.ToLower() == "w_export_new")
                    {
                        blResult = true;
                        tmpFrm.Activate();
                    }
                }
            }
            return blResult;
        }

        private void 大屏幕显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 正常烟大屏显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TTimer.Text = "     " + DateTime.Now.ToString("HH:mm:ss yyyy年MM月dd日 ");
        }

        private void w_Main_Load(object sender, EventArgs e)
        {
            OpaqueCommand oc = new OpaqueCommand();
            oc.ShowOpaqueLayer(this, 0, true);
        }
    }
}

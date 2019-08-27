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
    public partial class w_DataPosition : Form
    {
        int maxPackageNo;
        decimal pno = 1;
        public w_DataPosition(int maxPackageNo)
        {
            InitializeComponent();
            pno = Convert.ToDecimal(ConfigurationManager.AppSettings["PNo"]);
            this.maxPackageNo = maxPackageNo;
        }

        
        private void TxtPackageNo_TextChanged(object sender, EventArgs e)
        {
            int packageno = 0;
            if (!int.TryParse(TxtPackageNo.Text,out packageno))
            {
                TxtPackageNo.Text = "";
            }
            else
            {
                if (packageno > maxPackageNo)
                {
                    TxtPackageNo.Text = maxPackageNo.ToString();
                }
                else if (packageno == 0)
                    TxtPackageNo.Text = "";
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            int packageno = 0;
            try
            {
                packageno = int.Parse(TxtPackageNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            int id = 1;
            if (pno == 1)
            {
                if (BLL_Data.DataPosition(packageno, pno))
                {
                    id = BLL_Data.GetIDByPackageNo(packageno, Convert.ToInt32(pno));
                    MessageBox.Show("定位成功！");
                    this.Close();
                }
                else
                    MessageBox.Show("定位失败！");
            }
            else
            {
                if (BLL_Data.DataPosition(packageno, 0, pno))
                {
                    id = BLL_Data.GetIDByPackageNo(packageno, Convert.ToInt32(pno));
                    MessageBox.Show("定位成功！");
                    this.Close();
                }
                else
                    MessageBox.Show("定位失败！");
            }
            DataPosition.ID = id;
            DataPosition.PackageNo = packageno;
        }
    }
}

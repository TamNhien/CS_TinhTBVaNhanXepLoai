using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TinhTBVaNhanXepLoai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double toan, van, tb;
            toan = Convert.ToDouble(txtToan.Text);
            van = Convert.ToDouble(txtVan.Text);

            tb = (toan + van) / 2;
            txtTB.Text = tb.ToString();
            if (tb < 5)
            {
                txtXepLoai.Text = "Yếu";
            }
            else if (tb <= 6)
            {
                txtXepLoai.Text = "Khá";
            }
            else if (tb >= 8)
            {
                txtXepLoai.Text = "Giỏi";
            }
        }
    }
}

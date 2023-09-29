using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangBaTai_201200323
{
    public partial class HCN : Form
    {
        public HCN()
        {
            InitializeComponent();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            double a, b;
            bool k1 = double.TryParse(txtcd.Text, out a);
            bool k2 = double.TryParse(txtcr.Text, out b);
            if(k1==true && k2 == true)
            {
                txtkq.Text = "Diện tích là: " + (a * b).ToString();
            }
            else
            {
                MessageBox.Show("Nhập sai dữ liệu");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtcd.Text = " ";
            txtcr.Text = " ";
            txtkq.Text = " ";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

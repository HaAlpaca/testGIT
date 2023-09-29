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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hìnhTamGiácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính diện tích tam giác đang thực hiện ");
        }

        private void HCNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HCN h = new HCN();
            h.ShowDialog();
        }
    }
}

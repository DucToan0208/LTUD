using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhHongThai
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChucNang frm1 = new frmChucNang();
            frm1.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void traCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiem frm1 = new frmTimKiem();
            frm1.Show();
        }
    }
}

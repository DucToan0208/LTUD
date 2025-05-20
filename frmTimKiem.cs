using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinhHongThai
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=B202A-PC37\\SQLEXPRESS;Initial Catalog=KT2;Integrated Security=True");
        SqlCommand cmdHoaDon;
        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }
        //xây dựng hàm in danh sách hóa đơn theo mã hd
        private DataTable TimMaHD(string mahd)
        {
            SqlDataAdapter dsHD;
            DataTable hd = new DataTable();
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "TimMaHD";
                //tham so
                SqlParameter mahd1 = new SqlParameter("mahd", mahd);
                cmdHoaDon.Parameters.Add(mahd1);
               
                cmdHoaDon.CommandType = CommandType.StoredProcedure;
          

            
                dsHD = new SqlDataAdapter(cmdHoaDon);
                dsHD.Fill(hd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi: " + ex, "Thông báo");
            }
            finally
            {
                conn.Close();
            }
            return hd;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(rdoMaHD.Checked)
            {
                dgvDSHoaDon.DataSource = null;
                dgvDSHoaDon.DataSource = TimMaHD(txtTimKiem.Text);
                txtTimKiem.Clear();

            }
            if (rdoMaKH.Checked)
            {
                dgvDSHoaDon.DataSource = null;
                dgvDSHoaDon.DataSource = TimMaKH(txtTimKiem.Text);
                txtTimKiem.Clear();
            }
            txtTimKiem.Focus();
        }
        private DataTable TimMaKH(string makh)
        {
            SqlDataAdapter dsHD;
            DataTable hd = new DataTable();
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "TimMaKH";
                cmdHoaDon.CommandType = CommandType.StoredProcedure;
                //tham so
                SqlParameter makh1 = new SqlParameter("makh", makh);
                cmdHoaDon.Parameters.Add(makh1);
                dsHD = new SqlDataAdapter(cmdHoaDon);
                dsHD.Fill(hd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi: " + ex, "Thông báo");
            }
            finally
            {
                conn.Close();
            }
            return hd;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

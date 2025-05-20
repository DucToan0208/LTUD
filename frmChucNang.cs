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
    public partial class frmChucNang : Form
    {
        public frmChucNang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=B202A-PC37\\SQLEXPRESS;Initial Catalog=KT2;Integrated Security=True");
        SqlCommand cmdHoaDon;
        private void frmChucNang_Load(object sender, EventArgs e)
        {
            dgvDSHoaDon.DataSource = InDSHoaDon();
            cmbMaKH.DataSource = InDSKH();
            cmbMaKH.ValueMember = "MAKH";
            cmbMaKH.DisplayMember = "MAKH";
           
        }
        //xay dung hàm in danh sách hóa đơn
        private DataTable InDSHoaDon()
        {
            SqlDataAdapter dsHD;
            DataTable hd = new DataTable();
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "InDSHoaDon";
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
        //xây dựng hàm Sửa hóa đơn
        private void SuaHoaDon()
        {
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "SuaHoaDon";
                cmdHoaDon.CommandType = CommandType.StoredProcedure;
                //tham so
                SqlParameter mahd = new SqlParameter("mahd", txtMaHD.Text);
                cmdHoaDon.Parameters.Add(mahd);
                SqlParameter NgayLap = new SqlParameter("ngaylap", dtpkNgayLap.Value);
                cmdHoaDon.Parameters.Add(NgayLap);      
                cmdHoaDon.Parameters.Add("@soluong",SqlDbType.Int).Value = txtSoLuong.Text;
                cmdHoaDon.Parameters.Add("@dongia", SqlDbType.Float).Value = txtDonGia.Text;
                int thanhtien = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text);
                txtThanhTien.Text = thanhtien.ToString();
                cmdHoaDon.Parameters.Add("@thanhtien", SqlDbType.Float).Value = txtThanhTien.Text;
            
                SqlParameter makh = new SqlParameter("makhang", cmbMaKH.Text);
                cmdHoaDon.Parameters.Add(makh);
                //thuc thi cau lenh
                if (cmdHoaDon.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi: " + ex, "Thông báo");
            }
            finally
            {
                conn.Close();
                dgvDSHoaDon.DataSource = InDSHoaDon();
            }
        }
        //xây dựng hàm in danh sách kh
        private DataTable InDSKH()
        {
            SqlDataAdapter dsKH;
            DataTable KH = new DataTable();
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "InDSKH";
                cmdHoaDon.CommandType = CommandType.StoredProcedure;
                dsKH = new SqlDataAdapter(cmdHoaDon);
                dsKH.Fill(KH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi: " + ex, "Thông báo");
            }
            finally
            {
                conn.Close();
            }
            return KH;
        }

        //xây dừng hàm thêm hóa đơn
        private void ThemHD()
        {
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "ThemHoaDon";
                cmdHoaDon.CommandType = CommandType.StoredProcedure;
                //tham so
                SqlParameter mahd = new SqlParameter("mahd", txtMaHD.Text);
                cmdHoaDon.Parameters.Add(mahd);
                SqlParameter NgayLap = new SqlParameter("ngaylap", dtpkNgayLap.Value);
                cmdHoaDon.Parameters.Add(NgayLap);
                cmdHoaDon.Parameters.Add("@soluong", SqlDbType.Int).Value = txtSoLuong.Text;
                cmdHoaDon.Parameters.Add("@dongia", SqlDbType.Float).Value = txtDonGia.Text;
                int thanhtien = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text);
                txtThanhTien.Text = thanhtien.ToString();
                cmdHoaDon.Parameters.Add("@thanhtien", SqlDbType.Float).Value = txtThanhTien.Text;

                SqlParameter makh = new SqlParameter("makhang", cmbMaKH.Text);
                cmdHoaDon.Parameters.Add(makh);
                //thuc thi cau lenh
                if (cmdHoaDon.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi: " + ex, "Thông báo");
            }
            finally
            {
                conn.Close();
                dgvDSHoaDon.DataSource = InDSHoaDon();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check()) {
                ThemHD(); 
            }
        }

        private void cmbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
            int thanhtien = Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text);
            txtThanhTien.Text = thanhtien.ToString();
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
        }

        private void dgvDSHoaDon_Click(object sender, EventArgs e)
        {
            int dong = dgvDSHoaDon.CurrentCell.RowIndex;
            txtMaHD.Text = dgvDSHoaDon.Rows[dong].Cells[0].Value.ToString();
            dtpkNgayLap.Text = dgvDSHoaDon.Rows[dong].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvDSHoaDon.Rows[dong].Cells[2].Value.ToString();
            txtDonGia.Text = dgvDSHoaDon.Rows[dong].Cells[3].Value.ToString();
            txtThanhTien.Text = dgvDSHoaDon.Rows[dong].Cells[4].Value.ToString();
            cmbMaKH.Text = dgvDSHoaDon.Rows[dong].Cells[5].Value.ToString();
        }
        //hàm xóa đơn
        private void XoaHD()
        {
            try
            {
                conn.Open();
                cmdHoaDon = new SqlCommand();
                cmdHoaDon.Connection = conn;
                cmdHoaDon.CommandText = "XoaHD";
                cmdHoaDon.CommandType = CommandType.StoredProcedure;
                //tham so
                SqlParameter mahd = new SqlParameter("mahd", txtMaHD.Text);
                cmdHoaDon.Parameters.Add(mahd);
            
                //thuc thi cau lenh
                if (cmdHoaDon.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lõi: " + ex, "Thông báo");
            }
            finally
            {
                conn.Close();
                dgvDSHoaDon.DataSource = InDSHoaDon();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa hay không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn mã để xóa", "Thông báo");
                }
                else if(check()== true)
                {
                    XoaHD();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                this.Close();
            }
        }
        //xay dung ham kiem tra
        bool check()
        {
            if(txtMaHD.Text == "")
            {
                MessageBox.Show("Vui long nhap noi dung ma hoa don!!", "Thông báo");

                txtMaHD.Focus();
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Vui long nhap noi dung don gia!!", "Thông báo");
                txtDonGia.Focus();
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Vui long nhap noi dung so luong!!", "Thông báo");
                txtSoLuong.Focus();
                return false;
            }
            if (!char.IsDigit(txtDonGia.Text, txtDonGia.Text.Length - 1))
            {
                MessageBox.Show("Vui long nhập số ở control đơn giá!!", "Thông báo");
                txtDonGia.Focus();
                return false;
            }
            if (!char.IsDigit(txtSoLuong.Text, txtSoLuong.Text.Length - 1))
            {
                MessageBox.Show("Vui long nhập số ở control số lượng!!", "Thông báo");
                txtSoLuong.Focus();
                return false;
            }
            return true;
        }
    }

}

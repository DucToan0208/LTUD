namespace DinhHongThai
{
    partial class frmChucNang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cmbMaKH = new System.Windows.Forms.ComboBox();
            this.dtpkNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblNgaylap = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(0, 215);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.Size = new System.Drawing.Size(505, 150);
            this.dgvDSHoaDon.TabIndex = 33;
            this.dgvDSHoaDon.Click += new System.EventHandler(this.dgvDSHoaDon_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(390, 146);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 24);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(299, 146);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 24);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(208, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 24);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(117, 146);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 24);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKH.FormattingEnabled = true;
            this.cmbMaKH.Location = new System.Drawing.Point(368, 83);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(128, 21);
            this.cmbMaKH.TabIndex = 28;
            this.cmbMaKH.SelectedIndexChanged += new System.EventHandler(this.cmbMaKH_SelectedIndexChanged);
            // 
            // dtpkNgayLap
            // 
            this.dtpkNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayLap.Location = new System.Drawing.Point(368, 26);
            this.dtpkNgayLap.Name = "dtpkNgayLap";
            this.dtpkNgayLap.Size = new System.Drawing.Size(128, 20);
            this.dtpkNgayLap.TabIndex = 27;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(368, 55);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(128, 20);
            this.txtThanhTien.TabIndex = 26;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(117, 85);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(128, 20);
            this.txtDonGia.TabIndex = 25;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(117, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(128, 20);
            this.txtSoLuong.TabIndex = 24;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(117, 23);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(128, 20);
            this.txtMaHD.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã KH:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(293, 55);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(61, 13);
            this.lblThanhTien.TabIndex = 21;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // lblNgaylap
            // 
            this.lblNgaylap.AutoSize = true;
            this.lblNgaylap.Location = new System.Drawing.Point(293, 26);
            this.lblNgaylap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaylap.Name = "lblNgaylap";
            this.lblNgaylap.Size = new System.Drawing.Size(49, 13);
            this.lblNgaylap.TabIndex = 20;
            this.lblNgaylap.Text = "Ngày lập";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(35, 85);
            this.lblDonGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(47, 13);
            this.lblDonGia.TabIndex = 19;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(35, 55);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(56, 13);
            this.lblSoLuong.TabIndex = 18;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(35, 26);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 17;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // frmChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 365);
            this.Controls.Add(this.dgvDSHoaDon);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cmbMaKH);
            this.Controls.Add(this.dtpkNgayLap);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblNgaylap);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMaHD);
            this.Name = "frmChucNang";
            this.Text = "frmChucNang";
            this.Load += new System.EventHandler(this.frmChucNang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cmbMaKH;
        private System.Windows.Forms.DateTimePicker dtpkNgayLap;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblNgaylap;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaHD;
    }
}
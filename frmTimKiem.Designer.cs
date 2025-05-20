namespace DinhHongThai
{
    partial class frmTimKiem
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
            this.rdoMaHD = new System.Windows.Forms.RadioButton();
            this.rdoMaKH = new System.Windows.Forms.RadioButton();
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoMaHD
            // 
            this.rdoMaHD.AutoSize = true;
            this.rdoMaHD.Location = new System.Drawing.Point(93, 104);
            this.rdoMaHD.Name = "rdoMaHD";
            this.rdoMaHD.Size = new System.Drawing.Size(59, 17);
            this.rdoMaHD.TabIndex = 0;
            this.rdoMaHD.TabStop = true;
            this.rdoMaHD.Text = "Mã HD";
            this.rdoMaHD.UseVisualStyleBackColor = true;
            // 
            // rdoMaKH
            // 
            this.rdoMaKH.AutoSize = true;
            this.rdoMaKH.Location = new System.Drawing.Point(229, 104);
            this.rdoMaKH.Name = "rdoMaKH";
            this.rdoMaKH.Size = new System.Drawing.Size(103, 17);
            this.rdoMaKH.TabIndex = 1;
            this.rdoMaKH.TabStop = true;
            this.rdoMaKH.Text = "Mã Khách Hàng";
            this.rdoMaKH.UseVisualStyleBackColor = true;
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(0, 300);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.Size = new System.Drawing.Size(800, 150);
            this.dgvDSHoaDon.TabIndex = 34;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(72, 43);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(80, 13);
            this.lblTimKiem.TabIndex = 35;
            this.lblTimKiem.Text = "Nhập thông tin:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(165, 40);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(219, 20);
            this.txtTimKiem.TabIndex = 36;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(320, 266);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 31);
            this.btnTimKiem.TabIndex = 37;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(411, 266);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 31);
            this.btnThoat.TabIndex = 38;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.dgvDSHoaDon);
            this.Controls.Add(this.rdoMaKH);
            this.Controls.Add(this.rdoMaHD);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoMaHD;
        private System.Windows.Forms.RadioButton rdoMaKH;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}
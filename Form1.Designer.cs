namespace DinhHongThai
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.mnHoaDon = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // mnHoaDon
            // 
            this.mnHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.traCuuToolStripMenuItem});
            this.mnHoaDon.Location = new System.Drawing.Point(0, 0);
            this.mnHoaDon.Name = "mnHoaDon";
            this.mnHoaDon.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnHoaDon.Size = new System.Drawing.Size(1200, 25);
            this.mnHoaDon.TabIndex = 3;
            this.mnHoaDon.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            this.chứcNăngToolStripMenuItem.Click += new System.EventHandler(this.chứcNăngToolStripMenuItem_Click);
            // 
            // traCuuToolStripMenuItem
            // 
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            this.traCuuToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.traCuuToolStripMenuItem.Text = "Tra Cứu";
            this.traCuuToolStripMenuItem.Click += new System.EventHandler(this.traCuuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnHoaDon);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Quản lý Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.mnHoaDon.ResumeLayout(false);
            this.mnHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCuuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}


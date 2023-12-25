namespace QL_BanGiay
{
    partial class FrmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKho));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểuGiàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngHiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấtLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelKho = new System.Windows.Forms.Panel();
            this.mnu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSanPham,
            this.kiểuGiàyToolStripMenuItem,
            this.thươngHiệuToolStripMenuItem,
            this.chấtLiệuToolStripMenuItem});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(800, 31);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuSanPham
            // 
            this.mnuSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuSanPham.ForeColor = System.Drawing.Color.Red;
            this.mnuSanPham.Name = "mnuSanPham";
            this.mnuSanPham.Size = new System.Drawing.Size(95, 27);
            this.mnuSanPham.Text = "Sản Phẩm";
            this.mnuSanPham.Click += new System.EventHandler(this.mnuSanPham_Click);
            // 
            // kiểuGiàyToolStripMenuItem
            // 
            this.kiểuGiàyToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.kiểuGiàyToolStripMenuItem.Name = "kiểuGiàyToolStripMenuItem";
            this.kiểuGiàyToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.kiểuGiàyToolStripMenuItem.Text = "Kiểu Giày";
            this.kiểuGiàyToolStripMenuItem.Click += new System.EventHandler(this.kiểuGiàyToolStripMenuItem_Click);
            // 
            // thươngHiệuToolStripMenuItem
            // 
            this.thươngHiệuToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.thươngHiệuToolStripMenuItem.Name = "thươngHiệuToolStripMenuItem";
            this.thươngHiệuToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.thươngHiệuToolStripMenuItem.Text = "Thương Hiệu";
            this.thươngHiệuToolStripMenuItem.Click += new System.EventHandler(this.thươngHiệuToolStripMenuItem_Click);
            // 
            // chấtLiệuToolStripMenuItem
            // 
            this.chấtLiệuToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.chấtLiệuToolStripMenuItem.Name = "chấtLiệuToolStripMenuItem";
            this.chấtLiệuToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.chấtLiệuToolStripMenuItem.Text = "Chất Liệu";
            this.chấtLiệuToolStripMenuItem.Click += new System.EventHandler(this.chấtLiệuToolStripMenuItem_Click);
            // 
            // panelKho
            // 
            this.panelKho.AutoSize = true;
            this.panelKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKho.Location = new System.Drawing.Point(0, 31);
            this.panelKho.Name = "panelKho";
            this.panelKho.Size = new System.Drawing.Size(800, 419);
            this.panelKho.TabIndex = 1;
            // 
            // FrmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelKho);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "FrmKho";
            this.Text = "FrmKho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKho_Load);
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuSanPham;
        private System.Windows.Forms.ToolStripMenuItem kiểuGiàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thươngHiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấtLiệuToolStripMenuItem;
        private System.Windows.Forms.Panel panelKho;
    }
}
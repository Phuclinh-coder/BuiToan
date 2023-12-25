namespace QL_BanGiay
{
    partial class FrmChiTietHDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietHDN));
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.mahdn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.donGiaNhap = new System.Windows.Forms.TextBox();
            this.tenGiay = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.inHoaDon = new System.Windows.Forms.Button();
            this.slNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctDanhSachNhap = new System.Windows.Forms.DataGridView();
            this.luu = new System.Windows.Forms.Button();
            this.dGiaNhap = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maGiay = new System.Windows.Forms.ComboBox();
            this.m = new System.Windows.Forms.Label();
            this.maChatLieu = new System.Windows.Forms.TextBox();
            this.tenChatLieu = new System.Windows.Forms.TextBox();
            this.kichThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tongTien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctDanhSachNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.Yellow;
            this.thoat.Location = new System.Drawing.Point(963, 643);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(118, 48);
            this.thoat.TabIndex = 48;
            this.thoat.Text = "Đóng";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xoa.Location = new System.Drawing.Point(436, 643);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(118, 48);
            this.xoa.TabIndex = 45;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // mahdn
            // 
            this.mahdn.Enabled = false;
            this.mahdn.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahdn.Location = new System.Drawing.Point(137, 32);
            this.mahdn.Multiline = true;
            this.mahdn.Name = "mahdn";
            this.mahdn.Size = new System.Drawing.Size(181, 32);
            this.mahdn.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mã HDB";
            // 
            // donGiaNhap
            // 
            this.donGiaNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaNhap.Location = new System.Drawing.Point(905, 87);
            this.donGiaNhap.Multiline = true;
            this.donGiaNhap.Name = "donGiaNhap";
            this.donGiaNhap.ReadOnly = true;
            this.donGiaNhap.Size = new System.Drawing.Size(181, 38);
            this.donGiaNhap.TabIndex = 13;
            // 
            // tenGiay
            // 
            this.tenGiay.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenGiay.Location = new System.Drawing.Point(137, 150);
            this.tenGiay.Multiline = true;
            this.tenGiay.Name = "tenGiay";
            this.tenGiay.ReadOnly = true;
            this.tenGiay.Size = new System.Drawing.Size(181, 34);
            this.tenGiay.TabIndex = 12;
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.Chartreuse;
            this.them.Location = new System.Drawing.Point(53, 643);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(118, 48);
            this.them.TabIndex = 42;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // inHoaDon
            // 
            this.inHoaDon.BackColor = System.Drawing.Color.DarkOrange;
            this.inHoaDon.Location = new System.Drawing.Point(790, 643);
            this.inHoaDon.Name = "inHoaDon";
            this.inHoaDon.Size = new System.Drawing.Size(118, 48);
            this.inHoaDon.TabIndex = 47;
            this.inHoaDon.Text = "In hóa đơn";
            this.inHoaDon.UseVisualStyleBackColor = false;
            this.inHoaDon.Click += new System.EventHandler(this.inHoaDon_Click);
            // 
            // slNhap
            // 
            this.slNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slNhap.Location = new System.Drawing.Point(905, 31);
            this.slNhap.Multiline = true;
            this.slNhap.Name = "slNhap";
            this.slNhap.Size = new System.Drawing.Size(181, 45);
            this.slNhap.TabIndex = 10;
            this.slNhap.TextChanged += new System.EventHandler(this.slNhap_TextChanged);
            this.slNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.slNhap_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã giày";
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sua.Location = new System.Drawing.Point(257, 643);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(118, 48);
            this.sua.TabIndex = 46;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(867, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Tổng tiền: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên giày";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 76);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(338, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Tiết Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng nhập";
            // 
            // ctDanhSachNhap
            // 
            this.ctDanhSachNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctDanhSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctDanhSachNhap.Location = new System.Drawing.Point(12, 342);
            this.ctDanhSachNhap.Name = "ctDanhSachNhap";
            this.ctDanhSachNhap.RowHeadersWidth = 51;
            this.ctDanhSachNhap.RowTemplate.Height = 24;
            this.ctDanhSachNhap.Size = new System.Drawing.Size(1151, 212);
            this.ctDanhSachNhap.TabIndex = 40;
            this.ctDanhSachNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ctDanhSachNhap_CellContentClick);
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.Aqua;
            this.luu.Location = new System.Drawing.Point(621, 643);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(118, 48);
            this.luu.TabIndex = 49;
            this.luu.Text = "Làm lại";
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // dGiaNhap
            // 
            this.dGiaNhap.AutoSize = true;
            this.dGiaNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGiaNhap.Location = new System.Drawing.Point(774, 95);
            this.dGiaNhap.Name = "dGiaNhap";
            this.dGiaNhap.Size = new System.Drawing.Size(106, 20);
            this.dGiaNhap.TabIndex = 4;
            this.dGiaNhap.Text = "Đơn giá nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maGiay);
            this.groupBox2.Controls.Add(this.m);
            this.groupBox2.Controls.Add(this.maChatLieu);
            this.groupBox2.Controls.Add(this.tenChatLieu);
            this.groupBox2.Controls.Add(this.kichThuoc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mahdn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.donGiaNhap);
            this.groupBox2.Controls.Add(this.tenGiay);
            this.groupBox2.Controls.Add(this.slNhap);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dGiaNhap);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1151, 242);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhập";
            // 
            // maGiay
            // 
            this.maGiay.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maGiay.FormattingEnabled = true;
            this.maGiay.Location = new System.Drawing.Point(137, 101);
            this.maGiay.Name = "maGiay";
            this.maGiay.Size = new System.Drawing.Size(181, 28);
            this.maGiay.TabIndex = 31;
            this.maGiay.SelectedIndexChanged += new System.EventHandler(this.maGiay_SelectedIndexChanged);
            // 
            // m
            // 
            this.m.AutoSize = true;
            this.m.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.Location = new System.Drawing.Point(409, 30);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(99, 20);
            this.m.TabIndex = 30;
            this.m.Text = "Mã chất liệu";
            // 
            // maChatLieu
            // 
            this.maChatLieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maChatLieu.Location = new System.Drawing.Point(534, 30);
            this.maChatLieu.Multiline = true;
            this.maChatLieu.Name = "maChatLieu";
            this.maChatLieu.ReadOnly = true;
            this.maChatLieu.Size = new System.Drawing.Size(181, 34);
            this.maChatLieu.TabIndex = 28;
            // 
            // tenChatLieu
            // 
            this.tenChatLieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenChatLieu.Location = new System.Drawing.Point(535, 97);
            this.tenChatLieu.Multiline = true;
            this.tenChatLieu.Name = "tenChatLieu";
            this.tenChatLieu.ReadOnly = true;
            this.tenChatLieu.Size = new System.Drawing.Size(181, 34);
            this.tenChatLieu.TabIndex = 28;
            // 
            // kichThuoc
            // 
            this.kichThuoc.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kichThuoc.Location = new System.Drawing.Point(534, 158);
            this.kichThuoc.Multiline = true;
            this.kichThuoc.Name = "kichThuoc";
            this.kichThuoc.ReadOnly = true;
            this.kichThuoc.Size = new System.Drawing.Size(181, 34);
            this.kichThuoc.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên Chất liệu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kích thước";
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Location = new System.Drawing.Point(975, 577);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(69, 16);
            this.tongTien.TabIndex = 44;
            this.tongTien.Text = "Tổng tiền: ";
            // 
            // FrmChiTietHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1164, 708);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.inHoaDon);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctDanhSachNhap);
            this.Controls.Add(this.luu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tongTien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChiTietHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.chiTietHoaDonNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctDanhSachNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.TextBox mahdn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox donGiaNhap;
        private System.Windows.Forms.TextBox tenGiay;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button inHoaDon;
        private System.Windows.Forms.TextBox slNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ctDanhSachNhap;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Label dGiaNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kichThuoc;
        private System.Windows.Forms.Label m;
        private System.Windows.Forms.TextBox tenChatLieu;
        private System.Windows.Forms.ComboBox maGiay;
        private System.Windows.Forms.TextBox maChatLieu;
    }
}
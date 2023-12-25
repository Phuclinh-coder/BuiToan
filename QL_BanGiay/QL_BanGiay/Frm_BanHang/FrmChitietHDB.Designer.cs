namespace QL_BanGiay
{
    partial class FrmChitietHDB
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maHDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tongTien = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.Label();
            this.huy = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTenGiay = new System.Windows.Forms.TextBox();
            this.cboMaGiay = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.xoa = new System.Windows.Forms.Button();
            this.danhSachBan = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.inHoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maHDB);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tongTien);
            this.groupBox3.Controls.Add(this.tt);
            this.groupBox3.Controls.Add(this.huy);
            this.groupBox3.Controls.Add(this.txtThanhTien);
            this.groupBox3.Controls.Add(this.txtDonGia);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.txtGiamGia);
            this.groupBox3.Controls.Add(this.txtTenGiay);
            this.groupBox3.Controls.Add(this.cboMaGiay);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.xoa);
            this.groupBox3.Controls.Add(this.danhSachBan);
            this.groupBox3.Controls.Add(this.them);
            this.groupBox3.Controls.Add(this.sua);
            this.groupBox3.Controls.Add(this.thoat);
            this.groupBox3.Controls.Add(this.inHoaDon);
            this.groupBox3.Location = new System.Drawing.Point(12, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1125, 599);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin mặt hàng";
            // 
            // maHDB
            // 
            this.maHDB.Enabled = false;
            this.maHDB.Location = new System.Drawing.Point(110, 29);
            this.maHDB.Multiline = true;
            this.maHDB.Name = "maHDB";
            this.maHDB.Size = new System.Drawing.Size(249, 33);
            this.maHDB.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã HDB";
            // 
            // tongTien
            // 
            this.tongTien.AutoSize = true;
            this.tongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongTien.Location = new System.Drawing.Point(953, 469);
            this.tongTien.Name = "tongTien";
            this.tongTien.Size = new System.Drawing.Size(93, 20);
            this.tongTien.TabIndex = 49;
            this.tongTien.Text = "Tổng tiền:";
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.Location = new System.Drawing.Point(816, 465);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(131, 29);
            this.tt.TabIndex = 48;
            this.tt.Text = "Tổng tiền:";
            // 
            // huy
            // 
            this.huy.BackColor = System.Drawing.Color.Yellow;
            this.huy.Location = new System.Drawing.Point(553, 533);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(118, 48);
            this.huy.TabIndex = 47;
            this.huy.Text = "Làm lại";
            this.huy.UseVisualStyleBackColor = false;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(855, 125);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(243, 36);
            this.txtThanhTien.TabIndex = 42;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(855, 81);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(243, 26);
            this.txtDonGia.TabIndex = 43;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(110, 125);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(249, 33);
            this.txtSoLuong.TabIndex = 44;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(501, 125);
            this.txtGiamGia.Multiline = true;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(162, 33);
            this.txtGiamGia.TabIndex = 45;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // txtTenGiay
            // 
            this.txtTenGiay.Enabled = false;
            this.txtTenGiay.Location = new System.Drawing.Point(501, 81);
            this.txtTenGiay.Multiline = true;
            this.txtTenGiay.Name = "txtTenGiay";
            this.txtTenGiay.Size = new System.Drawing.Size(226, 24);
            this.txtTenGiay.TabIndex = 46;
            // 
            // cboMaGiay
            // 
            this.cboMaGiay.FormattingEnabled = true;
            this.cboMaGiay.Location = new System.Drawing.Point(110, 81);
            this.cboMaGiay.Name = "cboMaGiay";
            this.cboMaGiay.Size = new System.Drawing.Size(244, 24);
            this.cboMaGiay.TabIndex = 41;
            this.cboMaGiay.SelectedIndexChanged += new System.EventHandler(this.cboMaGiay_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(766, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 34;
            this.label14.Text = "Thành tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Giảm giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(766, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tên giày";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(669, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 16);
            this.label16.TabIndex = 39;
            this.label16.Text = "Số lượng";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 40;
            this.label17.Text = "Mã giày";
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.xoa.Location = new System.Drawing.Point(373, 533);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(118, 48);
            this.xoa.TabIndex = 33;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // danhSachBan
            // 
            this.danhSachBan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.danhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachBan.Location = new System.Drawing.Point(19, 195);
            this.danhSachBan.Name = "danhSachBan";
            this.danhSachBan.RowHeadersWidth = 51;
            this.danhSachBan.RowTemplate.Height = 24;
            this.danhSachBan.Size = new System.Drawing.Size(1069, 238);
            this.danhSachBan.TabIndex = 5;
            this.danhSachBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachBan_CellContentClick);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.Chartreuse;
            this.them.Location = new System.Drawing.Point(19, 533);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(118, 48);
            this.them.TabIndex = 16;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sua.Location = new System.Drawing.Point(188, 533);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(118, 48);
            this.sua.TabIndex = 18;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.Yellow;
            this.thoat.Location = new System.Drawing.Point(963, 533);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(118, 48);
            this.thoat.TabIndex = 20;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // inHoaDon
            // 
            this.inHoaDon.BackColor = System.Drawing.Color.DarkOrange;
            this.inHoaDon.Location = new System.Drawing.Point(740, 533);
            this.inHoaDon.Name = "inHoaDon";
            this.inHoaDon.Size = new System.Drawing.Size(118, 48);
            this.inHoaDon.TabIndex = 19;
            this.inHoaDon.Text = "Thanh toán";
            this.inHoaDon.UseVisualStyleBackColor = false;
            this.inHoaDon.Click += new System.EventHandler(this.inHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1126, 84);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(346, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi Tiết Hóa Đơn Bán";
            // 
            // chiTietHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1150, 726);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "chiTietHDB";
            this.Text = "chiTietHDB";
            this.Load += new System.EventHandler(this.chiTietHDB_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTenGiay;
        private System.Windows.Forms.ComboBox cboMaGiay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.DataGridView danhSachBan;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button inHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maHDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tongTien;
        private System.Windows.Forms.Label tt;
    }
}
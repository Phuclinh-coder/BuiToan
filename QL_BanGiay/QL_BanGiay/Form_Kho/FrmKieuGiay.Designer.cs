namespace QL_BanGiay
{
    partial class FrmKieuGiay
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
            this.components = new System.ComponentModel.Container();
            this.lbkieugiay = new System.Windows.Forms.Label();
            this.lbMakieugiay = new System.Windows.Forms.Label();
            this.lbTenkieugiay = new System.Windows.Forms.Label();
            this.txtMakieugiay = new System.Windows.Forms.TextBox();
            this.txtTenkieugiay = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errKieuGiay = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKieuGiay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errKieuGiay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKieuGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // lbkieugiay
            // 
            this.lbkieugiay.AutoSize = true;
            this.lbkieugiay.BackColor = System.Drawing.Color.LightSalmon;
            this.lbkieugiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkieugiay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbkieugiay.Location = new System.Drawing.Point(252, 7);
            this.lbkieugiay.Name = "lbkieugiay";
            this.lbkieugiay.Size = new System.Drawing.Size(239, 29);
            this.lbkieugiay.TabIndex = 0;
            this.lbkieugiay.Text = "Danh mục kiểu giầy";
            // 
            // lbMakieugiay
            // 
            this.lbMakieugiay.AutoSize = true;
            this.lbMakieugiay.BackColor = System.Drawing.Color.LightSalmon;
            this.lbMakieugiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakieugiay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbMakieugiay.Location = new System.Drawing.Point(29, 47);
            this.lbMakieugiay.Name = "lbMakieugiay";
            this.lbMakieugiay.Size = new System.Drawing.Size(107, 20);
            this.lbMakieugiay.TabIndex = 1;
            this.lbMakieugiay.Text = "Mã kiểu giầy:";
            // 
            // lbTenkieugiay
            // 
            this.lbTenkieugiay.AutoSize = true;
            this.lbTenkieugiay.BackColor = System.Drawing.Color.LightSalmon;
            this.lbTenkieugiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenkieugiay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTenkieugiay.Location = new System.Drawing.Point(29, 96);
            this.lbTenkieugiay.Name = "lbTenkieugiay";
            this.lbTenkieugiay.Size = new System.Drawing.Size(112, 20);
            this.lbTenkieugiay.TabIndex = 2;
            this.lbTenkieugiay.Text = "Tên kiểu giầy:";
            // 
            // txtMakieugiay
            // 
            this.txtMakieugiay.Location = new System.Drawing.Point(163, 47);
            this.txtMakieugiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMakieugiay.Name = "txtMakieugiay";
            this.txtMakieugiay.Size = new System.Drawing.Size(504, 22);
            this.txtMakieugiay.TabIndex = 3;
            // 
            // txtTenkieugiay
            // 
            this.txtTenkieugiay.Location = new System.Drawing.Point(163, 95);
            this.txtTenkieugiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenkieugiay.Name = "txtTenkieugiay";
            this.txtTenkieugiay.Size = new System.Drawing.Size(504, 22);
            this.txtTenkieugiay.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThem.Location = new System.Drawing.Point(30, 8);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(96, 45);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.Location = new System.Drawing.Point(150, 8);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 45);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSalmon;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.Location = new System.Drawing.Point(270, 8);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 45);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LightSalmon;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLuu.Location = new System.Drawing.Point(416, 8);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(96, 45);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBoqua.Location = new System.Drawing.Point(531, 8);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(96, 45);
            this.btnBoqua.TabIndex = 10;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightSalmon;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(650, 8);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 45);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errKieuGiay
            // 
            this.errKieuGiay.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.txtTenkieugiay);
            this.panel1.Controls.Add(this.txtMakieugiay);
            this.panel1.Controls.Add(this.lbTenkieugiay);
            this.panel1.Controls.Add(this.lbMakieugiay);
            this.panel1.Controls.Add(this.lbkieugiay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 119);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnBoqua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 55);
            this.panel2.TabIndex = 13;
            // 
            // dgvKieuGiay
            // 
            this.dgvKieuGiay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKieuGiay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKieuGiay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKieuGiay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKieuGiay.Location = new System.Drawing.Point(0, 119);
            this.dgvKieuGiay.Name = "dgvKieuGiay";
            this.dgvKieuGiay.RowHeadersWidth = 51;
            this.dgvKieuGiay.RowTemplate.Height = 24;
            this.dgvKieuGiay.Size = new System.Drawing.Size(757, 251);
            this.dgvKieuGiay.TabIndex = 14;
            this.dgvKieuGiay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKieuGiay_CellClick);
            // 
            // FrmKieuGiay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 425);
            this.Controls.Add(this.dgvKieuGiay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmKieuGiay";
            this.Text = "Kiểu giầy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKieuGiay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errKieuGiay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKieuGiay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkieugiay;
        private System.Windows.Forms.Label lbMakieugiay;
        private System.Windows.Forms.Label lbTenkieugiay;
        private System.Windows.Forms.TextBox txtMakieugiay;
        private System.Windows.Forms.TextBox txtTenkieugiay;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errKieuGiay;
        private System.Windows.Forms.DataGridView dgvKieuGiay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}
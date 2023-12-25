
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanGiay
{
    public partial class FrmChiTietSanPham : Form
    {
        AccessData data = new AccessData();
        public FrmChiTietSanPham()
        {
            InitializeComponent();
            btnLuu.Dock = DockStyle.Fill;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            txtAnh.Enabled = false;

            //
            string sql_thuonghieu = "select * from tthuonghieu";
            string sql_kieugiay = "select* from tTheLoai";
            string sql_chatlieu = "select* from tChatLieu";
            // fill combobox thương hiệu
            data.fillComboBox(sql_thuonghieu, cbThuonghieu, "MaThuongHieu", "TenThuongHieu");
            cbThuonghieu.SelectedIndex = -1;
            // fill combobox kiểu giầy
            data.fillComboBox(sql_kieugiay, cbKieugiay, "MaTheLoai", "TenTheLoai");
            cbKieugiay.SelectedIndex = -1;
            // fill combobox chất liệu
            data.fillComboBox(sql_chatlieu, cbChatLieu, "MaChatLieu", "TenChatLieu");
            cbChatLieu.SelectedIndex = -1;
        }
        private string masp;
        public FrmChiTietSanPham(string masp) : this()
        {
            //
            string sql_thuonghieu = "select * from tthuonghieu";
            string sql_kieugiay = "select* from tTheLoai";
            string sql_chatlieu = "select* from tChatLieu";
            // fill combobox thương hiệu
            data.fillComboBox(sql_thuonghieu, cbThuonghieu, "MaThuongHieu", "TenThuongHieu");

            // fill combobox kiểu giầy
            data.fillComboBox(sql_kieugiay, cbKieugiay, "MaTheLoai", "TenTheLoai");

            // fill combobox chất liệu
            data.fillComboBox(sql_chatlieu, cbChatLieu, "MaChatLieu", "TenChatLieu");
            this.masp = masp;
            string sql;
            txtMasp.Enabled = false;
            txtMasp.Text = masp;
            sql = "select TenGiay from Tgiay where MaGiay=N'" + masp + "'";
            txtTensp.Text = data.getFieldValue(sql);
            sql = "select DonGiaNhap from tGiay where MaGiay=N'" + masp + "'";
            txtDongianhap.Text = data.getFieldValue(sql);
            sql = "select DonGiaBan from tGiay where MaGiay=N'" + masp + "'";
            txtDongiaban.Text = data.getFieldValue(sql);
            sql = "select TenThuongHieu from tGiay join tThuongHieu on tGiay.MaThuongHieu=tThuongHieu.MaThuongHieu ";
            sql += "where MaGiay=N'" + masp + "'";
            cbThuonghieu.Text = data.getFieldValue(sql);
            sql = "select KichThuoc from tGiay where MaGiay=N'" + masp + "'";
            txtKichthuoc.Text = data.getFieldValue(sql);
            sql = "select GioiTinh from tGiay where MaGiay=N'" + masp + "'";
            cbGioitinh.Text = data.getFieldValue(sql);
            sql = "select MauSac from tGiay where MaGiay=N'" + masp + "'";
            txtMausac.Text = data.getFieldValue(sql);
            sql = "select TrongLuong from tGiay where MaGiay=N'" + masp + "'";
            txtTrongluong.Text = data.getFieldValue(sql);
            sql = "select TenChatLieu from tGiay join tChatLieu on tGiay.MaChatLieu=tChatLieu.MaChatLieu ";
            sql += "where MaGiay=N'" + masp + "'";
            cbChatLieu.Text = data.getFieldValue(sql);
            sql = "select TenTheLoai from tGiay join tTheLoai on tGiay.MaTheLoai= tTheLoai.MaTheLoai ";
            sql += "where MaGiay=N'" + masp + "'";

            cbKieugiay.Text = data.getFieldValue(sql);
            sql = "select Anh from tGiay where MaGiay=N'" + masp + "'";
            txtAnh.Text = data.getFieldValue(sql);
            
            
            
            ptbAnhsp.Image = Image.FromFile(txtAnh.Text);
            sql = "select SoLuong from tGiay where MaGiay=N'" + masp + "'";
            txtSoluong.Text = data.getFieldValue(sql);

            //
            btnLuu.Visible = false;
            btnLuu.Dock = DockStyle.Right;
            btnSua.Visible = true;
            btnXoa.Visible = true;
        }

        private void Chitietsp_Load(object sender, EventArgs e)
        {
            ptbAnhsp.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void ResetValue()
        {
            txtMasp.Text = "";
            txtTensp.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtMausac.Text = "";
            txtTrongluong.Text = "";
            cbChatLieu.SelectedIndex = -1;
            cbChatLieu.Text = "";
            txtAnh.Text = "";
            txtKichthuoc.Text = "";
            txtSoluong.Text = "";
            cbThuonghieu.SelectedIndex = -1;
            cbThuonghieu.Text = "";
            cbGioitinh.SelectedIndex = -1;
            cbGioitinh.Text = "";
            cbKieugiay.SelectedIndex = -1;
            cbKieugiay.Text = "";
            ptbAnhsp.Image = null;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMasp.Text.Trim() == "")
            {
                errSanpham.SetError(txtMasp, "Bạn chưa nhập mã sản phẩm");
                return;
            }
            else errSanpham.Clear();
            if (txtTensp.Text.Trim() == "")
            {
                errSanpham.SetError(txtTensp, "Bạn chưa nhập tên sản phẩm");
                return;
            }
            else errSanpham.Clear();
            if (txtDongiaban.Text.Trim() == "")
            {
                errSanpham.SetError(txtDongiaban, "Bạn chưa nhập đơn giá bán");
                return;
            }
            else errSanpham.Clear();
            if (txtDongianhap.Text.Trim() == "")
            {
                errSanpham.SetError(txtDongianhap, "Bạn chưa nhập đơn giá nhập");
                return;
            }
            else errSanpham.Clear();
            if (cbThuonghieu.Text == "")
            {
                errSanpham.SetError(cbThuonghieu, "Bạn chưa chọn thương hiệu");
                return;
            }
            else errSanpham.Clear();
            if (txtKichthuoc.Text.Trim() == "")
            {
                errSanpham.SetError(txtKichthuoc, "Bạn chưa nhập kích thước");
                return;
            }
            else errSanpham.Clear();
            if (cbGioitinh.Text == "")
            {
                errSanpham.SetError(cbGioitinh, "Bạn chưa chọn giới tính");
                return;
            }
            else errSanpham.Clear();
            if (cbThuonghieu.Text == "")
            {
                errSanpham.SetError(cbThuonghieu, "Bạn chưa chọn thương hiệu");
                return;
            }
            else errSanpham.Clear();
            if (txtMausac.Text.Trim() == "")
            {
                errSanpham.SetError(txtMausac, "Bạn chưa nhập màu sắc");
                return;
            }
            else errSanpham.Clear();
            if (txtTrongluong.Text.Trim() == "")
            {
                errSanpham.SetError(txtTrongluong, "Bạn chưa nhập trọng lượng");
                return;
            }
            else errSanpham.Clear();

            if (cbChatLieu.Text == "")
            {
                errSanpham.SetError(cbChatLieu, "Bạn chưa nhập chât liệu");
                return;
            }
            else errSanpham.Clear();
            //
            if (cbKieugiay.Text == "")
            {
                errSanpham.SetError(cbKieugiay, "Bạn chưa chọn kiểu giầy");
                return;
            }
            else errSanpham.Clear();
            if (txtSoluong.Text.Trim() == "")
            {
                errSanpham.SetError(txtSoluong, "Bạn chưa nhập số lượng");
                return;
            }
            else errSanpham.Clear();
            if (txtAnh.Text.Trim() == "")
            {
                errSanpham.SetError(txtAnh, "Bạn chưa chọn ảnh sản phẩm");
                return;
            }
            else errSanpham.Clear();
            sql = "select MaGiay from tGiay where maGiay=N'" + txtMasp.Text.Trim() + "'";
            if (data.checkKey(sql))
            {
                errSanpham.SetError(txtMasp, "Đã tồn tại sản phẩm có mã " + txtMasp.Text);
                return;
            }
            else errSanpham.Clear();
            sql = "INSERT INTO tGiay(MaGiay,TenGiay,MaTheLoai,MaThuongHieu,DonGiaNhap,DonGiaBan,SoLuong,KichThuoc,GioiTinh,MauSac,TrongLuong,Anh,MaChatLieu) values(";
            sql += "N'" + txtMasp.Text + "',";
            sql += "N'" + txtTensp.Text + "',";
            sql += "N'" + cbKieugiay.SelectedValue.ToString() + "',";
            sql += "N'" + cbThuonghieu.SelectedValue.ToString() + "',";
            sql += txtDongianhap.Text + ",";
            sql += txtDongiaban.Text + ",";
            sql += txtSoluong.Text + ",";
            sql += txtKichthuoc.Text + ",";
            sql += "N'" + cbGioitinh.Text + "',";
            sql += "N'" + txtMausac.Text + "',";
            sql += "N'" + txtTrongluong.Text + "',";
            sql += "N'" + txtAnh.Text + "',";
            sql += "N'" + cbChatLieu.SelectedValue.ToString() + "')";
            data.UpdateData(sql);
            ResetValue();
            MessageBox.Show("Thêm sản phẩm " + txtTensp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnMoanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgopen.FilterIndex = 2;
            dlgopen.Title = "Chọn ảnh minh họa cho sản phẩm";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {

                ptbAnhsp.Image = Image.FromFile(dlgopen.FileName);
                txtAnh.Text = dlgopen.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtTensp.Text.Trim() == "")
            {
                errSanpham.SetError(txtTensp, "Bạn chưa nhập tên sản phẩm");
                return;
            }
            else errSanpham.Clear();
            if (txtDongiaban.Text.Trim() == "")
            {
                errSanpham.SetError(txtDongiaban, "Bạn chưa nhập đơn giá bán");
                return;
            }
            else errSanpham.Clear();
            if (txtDongianhap.Text.Trim() == "")
            {
                errSanpham.SetError(txtDongianhap, "Bạn chưa nhập đơn giá nhập");
                return;
            }
            else errSanpham.Clear();
            if (cbThuonghieu.Text == "")
            {
                errSanpham.SetError(cbThuonghieu, "Bạn chưa chọn thương hiệu");
                return;
            }
            else errSanpham.Clear();
            if (txtKichthuoc.Text.Trim() == "")
            {
                errSanpham.SetError(txtKichthuoc, "Bạn chưa nhập kích thước");
                return;
            }
            else errSanpham.Clear();
            if (cbGioitinh.Text == "")
            {
                errSanpham.SetError(cbGioitinh, "Bạn chưa chọn giới tính");
                return;
            }
            else errSanpham.Clear();
            if (cbThuonghieu.Text == "")
            {
                errSanpham.SetError(cbThuonghieu, "Bạn chưa chọn thương hiệu");
                return;
            }
            else errSanpham.Clear();
            if (txtMausac.Text.Trim() == "")
            {
                errSanpham.SetError(txtMausac, "Bạn chưa nhập màu sắc");
                return;
            }
            else errSanpham.Clear();
            if (txtTrongluong.Text.Trim() == "")
            {
                errSanpham.SetError(txtTrongluong, "Bạn chưa nhập trọng lượng");
                return;
            }
            else errSanpham.Clear();

            if (cbChatLieu.Text == "")
            {
                errSanpham.SetError(cbChatLieu, "Bạn chưa nhập chât liệu");
                return;
            }
            else errSanpham.Clear();
            //
            if (cbKieugiay.Text == "")
            {
                errSanpham.SetError(cbKieugiay, "Bạn chưa chọn kiểu giầy");
                return;
            }
            else errSanpham.Clear();
            if (txtSoluong.Text.Trim() == "")
            {
                errSanpham.SetError(txtSoluong, "Bạn chưa nhập số lượng");
                return;
            }
            else errSanpham.Clear();
            if (txtAnh.Text.Trim() == "")
            {
                errSanpham.SetError(txtAnh, "Bạn chưa chọn ảnh sản phẩm");
                return;
            }
            else errSanpham.Clear();
            sql = "update tGiay set TenGiay=N'" + txtTensp.Text + "',";
            sql += "MaTheLoai=N'" + cbKieugiay.SelectedValue.ToString() + "',";
            sql += "MaThuongHieu=N'" + cbThuonghieu.SelectedValue.ToString() + "',";
            sql += "DonGiaNhap=" + txtDongianhap.Text + ",";
            sql += "DonGiaBan=" + txtDongiaban.Text + ",";
            sql += "SoLuong=" + txtSoluong.Text + ",";
            sql += "KichThuoc=" + txtKichthuoc.Text + ",";
            sql += "GioiTinh=N'" + cbGioitinh.Text + "',";
            sql += "MauSac=N'" + txtMausac.Text + "',";
            sql += "TrongLuong=N'" + txtTrongluong.Text + "',";
            sql += "MaChatLieu=N'" + cbChatLieu.SelectedValue.ToString() + "',";
            sql += "Anh=N'" + txtAnh.Text + "' ";
            sql += "where MaGiay=N'" + txtMasp.Text + "'";
            data.UpdateData(sql);
            MessageBox.Show("Sửa sản phẩm có mã " + txtMasp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm " + txtTensp.Text + "?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sql = "delete tGiay where MaGiay=N'" + txtMasp.Text + "'";
                data.UpdateData(sql);
                MessageBox.Show("Xóa sản phẩm có mã " + txtMasp.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDongianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Trường này phải là số!");
            }
        }
    }
}


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
    public partial class FrmKieuGiay : Form
    {
        public FrmKieuGiay()
        {
            InitializeComponent();
        }
        AccessData data = new AccessData();
        private void LoadDataGridView()
        {
            string sql = "select * from tTheLoai";
            dgvKieuGiay.DataSource = data.ReadData(sql);
            dgvKieuGiay.Columns[0].HeaderText = "Mã Thương Hiệu";
            dgvKieuGiay.Columns[1].HeaderText = "Tên Thương Hiệu";
            dgvKieuGiay.AllowUserToAddRows = false;
            dgvKieuGiay.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValue()
        {
            txtMakieugiay.Text = "";
            txtTenkieugiay.Text = "";
        }
        private void FrmKieuGiay_Load(object sender, EventArgs e)
        {
            txtMakieugiay.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }

        private void dgvKieuGiay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dgvKieuGiay.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu về kiểu giầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMakieugiay.Text = dgvKieuGiay.CurrentRow.Cells["MaTheLoai"].Value.ToString();
            txtTenkieugiay.Text = dgvKieuGiay.CurrentRow.Cells["TenTheLoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue();
            txtMakieugiay.Enabled = true;
            txtMakieugiay.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakieugiay.Text.Trim() == "")
            {
                errKieuGiay.SetError(txtMakieugiay, "Bạn chưa nhập mã kiểu giầy!");
                return;
            }
            else errKieuGiay.Clear();
            if (txtTenkieugiay.Text.Trim() == "")
            {
                errKieuGiay.SetError(txtTenkieugiay, "Bạn chưa nhập tên kiểu giầy!");
                return;
            }
            else errKieuGiay.Clear();
            sql = "select * from tTheLoai where MaTheLoai=N'" + txtMakieugiay.Text.Trim() + "'";
            if (data.checkKey(sql))
            {
                errKieuGiay.SetError(txtMakieugiay, "Đã tồn tại kiểu giầy có mã " + txtMakieugiay.Text);
                return;
            }
            else errKieuGiay.Clear();
            sql = "insert into tTheLoai(MaTheLoai,TenTheLoai) values(";
            sql += "N'" + txtMakieugiay.Text + "',";
            sql += "N'" + txtTenkieugiay.Text + "')";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMakieugiay.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvKieuGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakieugiay.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakieugiay.Focus();
                return;
            }
            if (txtTenkieugiay.Text.Trim() == "")
            {
                errKieuGiay.SetError(txtTenkieugiay, "Bạn chưa nhập tên kiểu giầy");
                return;
            }
            else errKieuGiay.Clear();
            sql = "update tTheLoai set ";
            sql += "TenTheLoai=N'" + txtTenkieugiay.Text + "' ";
            sql += "where MaTheLoai=N'" + txtMakieugiay.Text + "'";
            data.UpdateData(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (dgvKieuGiay.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMakieugiay.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn kiểu giầy nào nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa kiểu giầy " + txtTenkieugiay.Text + "? Hành động này sẽ xóa tất cả sản phẩm có kiểu giầy "+txtTenkieugiay.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                sql = "delete tTheLoai where MaTheLoai=N'" + txtMakieugiay.Text + "'";
                data.UpdateData(sql);
                LoadDataGridView();
                ResetValue();
                btnBoqua.Enabled = false;
            }
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakieugiay.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

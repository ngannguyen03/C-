using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadDataGridView();
        }

        // ================= RESET DỮ LIỆU =================
        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";

            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // ================= LOAD DATA GIẢ LẬP =================
        private void LoadDataGridView()
        {
            dgvSanPham.Rows.Clear();
            dgvSanPham.ReadOnly = true;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvSanPham.Rows.Add("SP001", "Áo thun Polo Nam", 100, 150000);
            dgvSanPham.Rows.Add("SP002", "Quần Jean Nữ Slimfit", 50, 350000);
            dgvSanPham.Rows.Add("SP003", "Áo Khoác Hoodie", 30, 450000);
        }

        // ================= XỬ LÝ NÚT THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;
            txtTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;

            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";

            txtMaSP.Focus();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        // ================= XỬ LÝ NÚT LƯU =================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text) || string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã và Tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSanPham.Rows.Add(txtMaSP.Text, txtTenSP.Text, txtSoLuong.Text, txtDonGia.Text);
            MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValues();
        }

        // ================= XỬ LÝ NÚT SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            txtTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;

            // Chế độ sửa: Cho phép lưu lại
            btnLuu.Enabled = true;
            btnThem.Enabled = false;

            // Logic cập nhật nhanh vào Grid (Trong thực tế sẽ gọi SQL Update)
            dgvSanPham.CurrentRow.Cells[1].Value = txtTenSP.Text;
            dgvSanPham.CurrentRow.Cells[2].Value = txtSoLuong.Text;
            dgvSanPham.CurrentRow.Cells[3].Value = txtDonGia.Text;
        }

        // ================= XỬ LÝ NÚT XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            string tenSP = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show($"Bạn có chắc muốn xóa: {tenSP}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvSanPham.Rows.RemoveAt(dgvSanPham.CurrentRow.Index);
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();

        private void btnDong_Click(object sender, EventArgs e) => this.Close();

        // ================= CLICK GRID =================
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenSP.Text = dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDonGia.Text = dgvSanPham.Rows[e.RowIndex].Cells[3].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;

            // Khóa mã khi xem/sửa
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
        }

        // ================= TÌM KIẾM =================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();
            if (key == "nhập tên sản phẩm...") return;

            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(key);
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tên sản phẩm...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập tên sản phẩm...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
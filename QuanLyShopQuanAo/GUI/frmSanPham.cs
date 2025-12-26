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
            // Ràng buộc chỉ nhập số
            txtSoLuong.KeyPress += NumericOnly_KeyPress;
            txtDonGia.KeyPress += NumericOnly_KeyPress;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadDataGridView();
        }

        // ================= RÀNG BUỘC CHỈ NHẬP SỐ =================
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ================= TỰ ĐỘNG TĂNG MÃ SP =================
        private string GetNewMaSP()
        {
            int maxId = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string ma = row.Cells[0].Value.ToString().Replace("SP", "");
                    if (int.TryParse(ma, out int id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            return "SP" + (maxId + 1).ToString("D2");
        }

        // ================= KIỂM TRA DỮ LIỆU ĐẦU VÀO =================
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || int.Parse(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) || double.Parse(txtDonGia.Text) <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private void ResetValues()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";

            txtTenSP.Enabled = false;
            txtSoLuong.Enabled = false;
            txtDonGia.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        private void LoadDataGridView()
        {
            dgvSanPham.Rows.Clear();
            dgvSanPham.Rows.Add("SP01", "Áo thun Polo Nam", 100, 150000);
            dgvSanPham.Rows.Add("SP02", "Quần Jean Nữ Slimfit", 50, 350000);
            dgvSanPham.Rows.Add("SP03", "Áo Khoác Hoodie", 30, 450000);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaSP.Text = GetNewMaSP(); // Mã tăng dần tự động
            txtTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtTenSP.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            // Nếu btnThem đang Disable nghĩa là đang ở chế độ Thêm mới
            if (btnThem.Enabled == false)
            {
                dgvSanPham.Rows.Add(txtMaSP.Text, txtTenSP.Text, txtSoLuong.Text, txtDonGia.Text);
                MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;
            if (!ValidateInput()) return;

            int i = dgvSanPham.CurrentRow.Index;
            dgvSanPham.Rows[i].Cells[1].Value = txtTenSP.Text;
            dgvSanPham.Rows[i].Cells[2].Value = txtSoLuong.Text;
            dgvSanPham.Rows[i].Cells[3].Value = txtDonGia.Text;

            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValues();
        }

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
            btnLuu.Enabled = false;
            btnThem.Enabled = true;

            txtTenSP.Enabled = true;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();
            if (key == "nhập tên sản phẩm...")
            {
                LoadDataGridView();
                return;
            }

            CurrencyManager cm = (CurrencyManager)BindingContext[dgvSanPham.DataSource];
            if (cm != null) cm.SuspendBinding();

            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(key);
                }
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

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();

        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            // Ràng buộc chỉ nhập số cho ô điện thoại
            txtDienThoai.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
        }

        // --- HÀM TỰ ĐỘNG TĂNG MÃ KHÁCH HÀNG ---
        private string GenerateNextMaKH()
        {
            int maxId = 0;
            foreach (DataGridViewRow row in dgvKhachHang.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string maStr = row.Cells[0].Value.ToString().Replace("KH", "");
                    if (int.TryParse(maStr, out int id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            return "KH" + (maxId + 1).ToString("D2"); // Ví dụ: KH01, KH02...
        }

        // --- KIỂM TRA RÀNG BUỘC (VALIDATION) ---
        private bool ValidateInput()
        {
            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKH.Focus(); return false;
            }

            // 2. Ràng buộc Số điện thoại chuẩn Việt Nam (10 số, đầu 03, 05, 07, 08, 09)
            if (!Regex.IsMatch(txtDienThoai.Text, @"^(03|05|07|08|09)[0-9]{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!\n(Phải đủ 10 chữ số và thuộc nhà mạng Việt Nam)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus(); return false;
            }

            return true;
        }

        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";

            txtTenKH.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
        }

        private void LoadData()
        {
            dgvKhachHang.Rows.Clear();
            dgvKhachHang.Rows.Add("KH01", "Nguyễn Thị Mai", "0905123456", "123 Lê Lợi, Đà Nẵng");
            dgvKhachHang.Rows.Add("KH02", "Trần Văn Hùng", "0914987654", "456 Nguyễn Huệ, TP.HCM");
            dgvKhachHang.Rows.Add("KH03", "Lê Hồng Hạnh", "0888222333", "789 Phan Chu Trinh, Hà Nội");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaKH.Text = GenerateNextMaKH(); // Mã tăng dần tự động
            txtTenKH.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            // Thêm mới vào lưới
            dgvKhachHang.Rows.Add(txtMaKH.Text, txtTenKH.Text, txtDienThoai.Text, txtDiaChi.Text);
            MessageBox.Show("Đã lưu thông tin khách hàng mới!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;
            if (!ValidateInput()) return;

            int i = dgvKhachHang.CurrentRow.Index;
            dgvKhachHang.Rows[i].Cells[1].Value = txtTenKH.Text;
            dgvKhachHang.Rows[i].Cells[2].Value = txtDienThoai.Text;
            dgvKhachHang.Rows[i].Cells[3].Value = txtDiaChi.Text;

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;
            string ten = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show($"Bạn có muốn xóa khách hàng: {ten}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgvKhachHang.Rows.RemoveAt(dgvKhachHang.CurrentRow.Index);
                ResetValues();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells[0].Value.ToString();
            txtTenKH.Text = row.Cells[1].Value.ToString();
            txtDienThoai.Text = row.Cells[2].Value.ToString();
            txtDiaChi.Text = row.Cells[3].Value.ToString();

            btnSua.Enabled = btnXoa.Enabled = btnBoQua.Enabled = true;
            txtTenKH.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            string detail = $"Mã KH: {row.Cells[0].Value}\nHọ tên: {row.Cells[1].Value}\nSĐT: {row.Cells[2].Value}";
            MessageBox.Show(detail, "Chi tiết khách hàng");
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
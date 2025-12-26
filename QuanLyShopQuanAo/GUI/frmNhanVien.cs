using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmNhanVien : Form
    {
        // Màu sắc Luxury Silver thống nhất với các Form khác
        private Color colorSilver = Color.FromArgb(192, 192, 192);
        private Color colorCharcoal = Color.FromArgb(45, 45, 48);

        public frmNhanVien()
        {
            InitializeComponent();
            ApplyLuxuryStyling();

            // Ràng buộc chỉ nhập số cho ô Số điện thoại
            txtSDT.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
        }

        // ================= THIẾT KẾ GIAO DIỆN =================
        private void ApplyLuxuryStyling()
        {
            this.BackColor = Color.FromArgb(245, 245, 247);
            grpThongTin.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, grpThongTin.ClientRectangle, colorSilver, 1, ButtonBorderStyle.Solid,
                    colorSilver, 1, ButtonBorderStyle.Solid, colorSilver, 1, ButtonBorderStyle.Solid, colorSilver, 1, ButtonBorderStyle.Solid);
            };
        }

        // ================= LOGIC TỰ ĐỘNG TĂNG MÃ =================
        private string GenerateNextMaNV()
        {
            int maxId = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    // Lấy phần số từ chuỗi NV01, NV02...
                    string maStr = row.Cells[0].Value.ToString().Replace("NV", "");
                    if (int.TryParse(maStr, out int id))
                    {
                        if (id > maxId) maxId = id;
                    }
                }
            }
            // Trả về định dạng NV + số tăng dần (độ dài 2 chữ số)
            return "NV" + (maxId + 1).ToString("D2");
        }

        // ================= KIỂM TRA RÀNG BUỘC (VALIDATION) =================
        private bool ValidateInput()
        {
            // 1. Kiểm tra họ tên
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên nhân viên!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNV.Focus(); return false;
            }

            // 2. Ràng buộc Số điện thoại Việt Nam (10 số, đầu số 03, 05, 07, 08, 09)
            if (!Regex.IsMatch(txtSDT.Text, @"^(03|05|07|08|09)[0-9]{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!\n(Phải đủ 10 chữ số và thuộc nhà mạng Việt Nam)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus(); return false;
            }

            // 3. Kiểm tra tài khoản
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                MessageBox.Show("Tài khoản không được để trống!", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus(); return false;
            }

            // 4. Ràng buộc mật khẩu (Phải có ít nhất 6 ký tự, gồm cả chữ, số và ký tự đặc biệt)
            string passPattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()_+]).{6,}$";
            if (!Regex.IsMatch(txtMatKhau.Text, passPattern))
            {
                MessageBox.Show("Mật khẩu không đủ mạnh!\n(Yêu cầu: Ít nhất 6 ký tự, bao gồm chữ cái, chữ số và ít nhất 1 ký tự đặc biệt)", "Bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus(); return false;
            }

            return true;
        }

        // ================= QUẢN LÝ DỮ LIỆU & TRẠNG THÁI =================
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            rdoNam.Checked = true;
            cboChucVu.SelectedIndex = 1; // Mặc định là 'Nhân viên'
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);

            // Khóa các trường nhập liệu
            txtTenNV.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled =
            dtpNgaySinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboChucVu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
        }

        private void LoadData()
        {
            dgvNhanVien.Rows.Clear();
            dgvNhanVien.Rows.Add("NV01", "Nguyễn Ngọc Bảo Ngân", "0912345678", "Quản lý", "Nữ", "admin", "03/12/2005");
            dgvNhanVien.Rows.Add("NV02", "Lê Thị Bình", "0388777666", "Nhân viên", "Nữ", "staff01", "10/10/1998");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaNV.Text = GenerateNextMaNV(); // Lấy mã tự động tăng

            // Mở khóa các trường
            txtTenNV.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled =
            dtpNgaySinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboChucVu.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtTenNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            dgvNhanVien.Rows.Add(txtMaNV.Text, txtTenNV.Text, txtSDT.Text, cboChucVu.Text,
                rdoNam.Checked ? "Nam" : "Nữ", txtTaiKhoan.Text, dtpNgaySinh.Value.ToShortDateString());

            MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            if (!ValidateInput()) return;

            int i = dgvNhanVien.CurrentRow.Index;
            dgvNhanVien.Rows[i].Cells[1].Value = txtTenNV.Text;
            dgvNhanVien.Rows[i].Cells[2].Value = txtSDT.Text;
            dgvNhanVien.Rows[i].Cells[3].Value = cboChucVu.Text;
            dgvNhanVien.Rows[i].Cells[4].Value = rdoNam.Checked ? "Nam" : "Nữ";
            dgvNhanVien.Rows[i].Cells[5].Value = txtTaiKhoan.Text;
            dgvNhanVien.Rows[i].Cells[6].Value = dtpNgaySinh.Value.ToShortDateString();

            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            string ten = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();

            if (MessageBox.Show($"Bạn có thực sự muốn xóa nhân viên: {ten}?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.CurrentRow.Index);
                ResetValues();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtSDT.Text = row.Cells[2].Value.ToString();
            cboChucVu.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value.ToString() == "Nam") rdoNam.Checked = true; else rdoNu.Checked = true;
            txtTaiKhoan.Text = row.Cells[5].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse(row.Cells[6].Value.ToString());

            // Cho phép sửa/xóa khi chọn dòng
            btnSua.Enabled = btnXoa.Enabled = btnBoQua.Enabled = true;
            txtTenNV.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled =
            dtpNgaySinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboChucVu.Enabled = true;
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            string detail = $"Mã NV: {row.Cells[0].Value}\nHọ tên: {row.Cells[1].Value}\nChức vụ: {row.Cells[3].Value}\nSĐT: {row.Cells[2].Value}";
            MessageBox.Show(detail, "Chi tiết nhân viên");
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
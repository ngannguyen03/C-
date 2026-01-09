using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmNhanVien : Form
    {
        NhanVienBLL bll = new NhanVienBLL();
        private Color colorSilver = Color.FromArgb(192, 192, 192);

        public frmNhanVien()
        {
            InitializeComponent();
            ApplyLuxuryStyling();

            // Ràng buộc chỉ nhập số cho ô SDT
            txtSDT.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            ResetValues();
            LoadDataGridView();
        }

        private void ApplyLuxuryStyling()
        {
            this.BackColor = Color.FromArgb(245, 245, 247);
            grpThongTin.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, grpThongTin.ClientRectangle, colorSilver, ButtonBorderStyle.Solid);
            };
        }

        private void LoadDataGridView()
        {
            dgvNhanVien.Rows.Clear();
            List<NhanVienDTO> list = bll.GetAll();
            foreach (var nv in list)
            {
                dgvNhanVien.Rows.Add(nv.MaNV, nv.TenNV, nv.SDT, nv.ChucVu, nv.GioiTinh, nv.TaiKhoan, nv.NgaySinh.ToString("dd/MM/yyyy"));
            }
        }

        private string GenerateNextMaNV()
        {
            int maxId = 0;
            foreach (DataGridViewRow row in dgvNhanVien.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string maStr = row.Cells[0].Value.ToString().Replace("NV", "");
                    if (int.TryParse(maStr, out int id)) if (id > maxId) maxId = id;
                }
            }
            return "NV" + (maxId + 1).ToString("D2");
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text)) { MessageBox.Show("Họ tên không được để trống!"); return false; }
            if (!Regex.IsMatch(txtSDT.Text, @"^(03|05|07|08|09)[0-9]{8}$")) { MessageBox.Show("SĐT không hợp lệ (10 số VN)!"); return false; }
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text)) { MessageBox.Show("Tài khoản không được để trống!"); return false; }

            // Ràng buộc mật khẩu 6 ký tự, 1 số, 1 ký tự đặc biệt
            string passPattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[!@#$%^&*()_+]).{6,}$";
            if (!Regex.IsMatch(txtMatKhau.Text, passPattern) && btnThem.Enabled == false)
            {
                MessageBox.Show("Mật khẩu yếu!"); return false;
            }
            return true;
        }

        private void ResetValues()
        {
            txtMaNV.Text = ""; txtTenNV.Text = ""; txtSDT.Text = "";
            txtTaiKhoan.Text = ""; txtMatKhau.Text = "";
            rdoNam.Checked = true; cboChucVu.SelectedIndex = 1;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-18);

            txtTenNV.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled =
            dtpNgaySinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboChucVu.Enabled = false;

            btnThem.Enabled = true; btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaNV.Text = GenerateNextMaNV();
            txtTenNV.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled =
            dtpNgaySinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboChucVu.Enabled = true;
            btnThem.Enabled = false; btnLuu.Enabled = btnBoQua.Enabled = true;
            txtTenNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            NhanVienDTO nv = new NhanVienDTO(txtMaNV.Text, txtTenNV.Text, txtSDT.Text, cboChucVu.Text,
                rdoNam.Checked ? "Nam" : "Nữ", txtTaiKhoan.Text, txtMatKhau.Text, dtpNgaySinh.Value);

            if (bll.Add(nv))
            {
                MessageBox.Show("Thêm mới thành công!");
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            NhanVienDTO nv = new NhanVienDTO(txtMaNV.Text, txtTenNV.Text, txtSDT.Text, cboChucVu.Text,
                rdoNam.Checked ? "Nam" : "Nữ", txtTaiKhoan.Text, txtMatKhau.Text, dtpNgaySinh.Value);

            if (bll.Edit(nv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Xóa nhân viên {txtTenNV.Text}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.Remove(txtMaNV.Text))
                {
                    LoadDataGridView();
                    ResetValues();
                }
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
            dtpNgaySinh.Value = DateTime.ParseExact(row.Cells[6].Value.ToString(), "dd/MM/yyyy", null);

            btnSua.Enabled = btnXoa.Enabled = btnBoQua.Enabled = true;
            txtTenNV.Enabled = txtSDT.Enabled = txtTaiKhoan.Enabled = txtMatKhau.Enabled =
            dtpNgaySinh.Enabled = rdoNam.Enabled = rdoNu.Enabled = cboChucVu.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();

        // Tránh lỗi Designer
        private void labelHeader_Click(object sender, EventArgs e) { }
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
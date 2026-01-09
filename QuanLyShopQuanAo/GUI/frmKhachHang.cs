using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmKhachHang : Form
    {
        KhachHangBLL bll = new KhachHangBLL();

        public frmKhachHang()
        {
            InitializeComponent();
            // Ràng buộc chỉ nhập số cho điện thoại
            txtDienThoai.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetValues();
        }

        private void LoadData()
        {
            dgvKhachHang.Rows.Clear();
            List<KhachHangDTO> ds = bll.GetAll();
            foreach (var item in ds)
            {
                dgvKhachHang.Rows.Add(item.MaKH, item.TenKH, item.DienThoai, item.DiaChi);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtTenKH.Focus(); return false;
            }
            if (!Regex.IsMatch(txtDienThoai.Text, @"^(03|05|07|08|09)[0-9]{8}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ (10 số VN)!");
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaKH.Text = "Tự động tăng"; // Vì DB dùng IDENTITY
            txtTenKH.Enabled = txtDienThoai.Enabled = txtDiaChi.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = btnBoQua.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            KhachHangDTO kh = new KhachHangDTO(0, txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);

            if (btnThem.Enabled == false) // Đang chế độ thêm
            {
                if (bll.Add(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    LoadData();
                    ResetValues();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            KhachHangDTO kh = new KhachHangDTO(int.Parse(txtMaKH.Text), txtTenKH.Text, txtDiaChi.Text, txtDienThoai.Text);

            if (bll.Edit(kh))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
                ResetValues();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text)) return;

            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.Remove(int.Parse(txtMaKH.Text)))
                {
                    LoadData();
                    ResetValues();
                }
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
            MessageBox.Show($"Khách hàng: {row.Cells[1].Value}\nSĐT: {row.Cells[2].Value}", "Chi tiết");
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
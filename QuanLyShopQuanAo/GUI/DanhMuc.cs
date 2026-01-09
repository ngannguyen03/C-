using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL; // Đảm bảo namespace này đúng với dự án của bạn
using QuanLyShopQuanAo.DTO; // Đảm bảo namespace này đúng với dự án của bạn

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmDanhMuc : Form
    {
        // Khai báo lớp nghiệp vụ
        DanhMucBLL bll = new DanhMucBLL();

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        // Sự kiện khi Load Form
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadDataGridView();
        }

        // Hàm load dữ liệu từ Database lên bảng
        private void LoadDataGridView()
        {
            dgvDanhMuc.Rows.Clear();
            try
            {
                List<DanhMucDTO> list = bll.GetAll();
                foreach (var item in list)
                {
                    dgvDanhMuc.Rows.Add(item.MaDM, item.TenDM);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // Hàm reset các ô nhập liệu về trạng thái ban đầu
        private void ResetValues()
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtTenDM.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // Sự kiện nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            // Tạo mã tự động dựa trên thời gian để tránh trùng lặp
            txtMaDM.Text = "DM" + DateTime.Now.ToString("ssmm");

            txtTenDM.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtTenDM.Focus();
        }

        // Sự kiện nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDM.Focus();
                return;
            }

            DanhMucDTO dm = new DanhMucDTO(txtMaDM.Text, txtTenDM.Text);

            if (btnThem.Enabled == false) // Đang ở chế độ thêm mới
            {
                if (bll.Add(dm))
                {
                    MessageBox.Show("Thêm mới thành công!");
                    LoadDataGridView();
                    ResetValues();
                }
                else
                {
                    MessageBox.Show("Thêm mới thất bại!");
                }
            }
        }

        // Sự kiện nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDM.Text))
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                return;
            }

            DanhMucDTO dm = new DanhMucDTO(txtMaDM.Text, txtTenDM.Text);
            if (bll.Edit(dm))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDataGridView();
                ResetValues();
            }
        }

        // Sự kiện nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDM.Text)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bll.Remove(txtMaDM.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDataGridView();
                    ResetValues();
                }
            }
        }

        // Sự kiện nút Bỏ qua (Hàm bạn bị thiếu)
        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        // Sự kiện nút Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện Click vào một dòng trên bảng
        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenDM.Text = dgvDanhMuc.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtTenDM.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
        }

        // ================= XỬ LÝ TÌM KIẾM (Các hàm bạn bị thiếu) =================

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();
            if (key == "nhập tên danh mục..." || string.IsNullOrEmpty(key))
            {
                LoadDataGridView();
                return;
            }

            // Lọc trực tiếp trên DataGridView
            foreach (DataGridViewRow row in dgvDanhMuc.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    string tenDM = row.Cells[1].Value.ToString().ToLower();
                    row.Visible = tenDM.Contains(key);
                }
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập tên danh mục...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Nhập tên danh mục...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
    }
}
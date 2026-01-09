using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;
using Microsoft.VisualBasic; // Dùng cho Interaction.InputBox

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmSanPham : Form
    {
        SanPhamBLL bll = new SanPhamBLL();

        // Biến tạm để quản lý danh sách ảnh
        List<string> dsAnhTam = new List<string>();
        int indexAnhHienTai = 0;

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

        // ================= XỬ LÝ HIỂN THỊ ẢNH =================
        private void ShowImage()
        {
            if (dsAnhTam.Count > 0)
            {
                try
                {
                    string path = dsAnhTam[indexAnhHienTai];
                    if (path.StartsWith("http")) // Nếu là Link web
                    {
                        picSanPham.Load(path);
                    }
                    else if (File.Exists(path)) // Nếu là file máy tính
                    {
                        picSanPham.Image = Image.FromFile(path);
                    }

                    lblIndexAnh.Text = $"{indexAnhHienTai + 1}/{dsAnhTam.Count}";
                    if (indexAnhHienTai == 0) lblIndexAnh.Text += " (Đại diện)";
                }
                catch
                {
                    picSanPham.Image = null;
                }
            }
            else
            {
                picSanPham.Image = null;
                lblIndexAnh.Text = "0/0";
            }
        }

        // Chọn ảnh từ máy tính
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Multiselect = true, Filter = "Image Files|*.jpg;*.png;*.jpeg" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames) dsAnhTam.Add(file);
                indexAnhHienTai = dsAnhTam.Count - 1;
                ShowImage();
                new frmAlert().showAlert("Đã thêm ảnh từ máy!", frmAlert.enmType.Info);
            }
        }

        // Thêm link ảnh từ upanhlaylink
        private void btnAddLink_Click(object sender, EventArgs e)
        {
            string link = Interaction.InputBox("Dán link ảnh vào đây:", "Thêm ảnh từ Link (URL)", "");
            if (!string.IsNullOrEmpty(link))
            {
                dsAnhTam.Add(link);
                indexAnhHienTai = dsAnhTam.Count - 1;
                ShowImage();
                new frmAlert().showAlert("Đã thêm ảnh từ Link!", frmAlert.enmType.Info);
            }
        }

        private void btnNextAnh_Click(object sender, EventArgs e)
        {
            if (indexAnhHienTai < dsAnhTam.Count - 1) { indexAnhHienTai++; ShowImage(); }
        }

        private void btnPrevAnh_Click(object sender, EventArgs e)
        {
            if (indexAnhHienTai > 0) { indexAnhHienTai--; ShowImage(); }
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            if (dsAnhTam.Count > 0)
            {
                dsAnhTam.RemoveAt(indexAnhHienTai);
                if (indexAnhHienTai > 0) indexAnhHienTai--;
                ShowImage();
                new frmAlert().showAlert("Đã xóa ảnh chọn!", frmAlert.enmType.Warning);
            }
        }

        // ================= XỬ LÝ EXCEL =================
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bll.ExportToExcel(sfd.FileName);
                    new frmAlert().showAlert("Xuất Excel thành công!", frmAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Excel Workbook|*.xlsx" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int count = bll.ImportFromExcel(ofd.FileName);
                    new frmAlert().showAlert($"Đã nhập {count} sản phẩm!", frmAlert.enmType.Success);
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi dữ liệu Excel: " + ex.Message);
                }
            }
        }

        // ================= LOGIC CRUD CƠ BẢN (NÂNG CẤP) =================
        private void LoadDataGridView()
        {
            dgvSanPham.Rows.Clear();
            List<SanPhamDTO> list = bll.GetAll();
            foreach (var sp in list)
            {
                dgvSanPham.Rows.Add(sp.MaSP, sp.TenSP, sp.SoLuong, sp.DonGia);
            }
        }

        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private string GetNewMaSP()
        {
            int maxId = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string ma = row.Cells[0].Value.ToString().Replace("SP", "");
                    if (int.TryParse(ma, out int id)) if (id > maxId) maxId = id;
                }
            }
            return "SP" + (maxId + 1).ToString("D2");
        }

        private void ResetValues()
        {
            txtMaSP.Text = ""; txtTenSP.Text = ""; txtSoLuong.Text = ""; txtDonGia.Text = "";
            dsAnhTam.Clear(); indexAnhHienTai = 0; ShowImage();

            txtTenSP.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = false;
            btnThem.Enabled = true; btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnBoQua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaSP.Text = GetNewMaSP();
            txtTenSP.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = true;
            btnThem.Enabled = false; btnLuu.Enabled = btnBoQua.Enabled = true;
            txtTenSP.Focus();
        }

private void btnLuu_Click(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(txtTenSP.Text)) return;

    // Tạo đối tượng DTO
    SanPhamDTO sp = new SanPhamDTO();
    sp.MaSP = txtMaSP.Text;
    sp.TenSP = txtTenSP.Text;
    sp.SoLuong = int.Parse(txtSoLuong.Text);
    sp.DonGia = decimal.Parse(txtDonGia.Text);
    
    // GÁN DANH SÁCH ẢNH TỪ GIAO DIỆN VÀO DTO ĐỂ LƯU
    sp.DanhSachAnh = dsAnhTam; 

    if (btnThem.Enabled == false) // Đang chế độ Thêm mới
    {
        if (bll.AddSanPham(sp))
        {
            new frmAlert().showAlert("Thêm sản phẩm và ảnh thành công!", frmAlert.enmType.Success);
            LoadDataGridView();
            ResetValues();
        }
    }
    else // Đang chế độ Sửa
    {
        if (bll.EditSanPham(sp))
        {
            new frmAlert().showAlert("Cập nhật thành công!", frmAlert.enmType.Success);
            LoadDataGridView();
            ResetValues();
        }
    }
}
        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO(txtMaSP.Text, txtTenSP.Text, int.Parse(txtSoLuong.Text), decimal.Parse(txtDonGia.Text));
            sp.DanhSachAnh = dsAnhTam;

            if (bll.EditSanPham(sp))
            {
                new frmAlert().showAlert("Cập nhật thành công!", frmAlert.enmType.Success);
                LoadDataGridView(); ResetValues();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.DeleteSanPham(txtMaSP.Text))
                {
                    new frmAlert().showAlert("Đã xóa sản phẩm!", frmAlert.enmType.Success);
                    LoadDataGridView(); ResetValues();
                }
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
            txtMaSP.Text = row.Cells[0].Value.ToString();
            txtTenSP.Text = row.Cells[1].Value.ToString();
            txtSoLuong.Text = row.Cells[2].Value.ToString();
            txtDonGia.Text = row.Cells[3].Value.ToString();

            // Load ảnh của sản phẩm được chọn từ DB thông qua BLL
            dsAnhTam = bll.GetImagesByMaSP(txtMaSP.Text);
            indexAnhHienTai = 0;
            ShowImage();

            btnSua.Enabled = btnXoa.Enabled = btnBoQua.Enabled = true;
            btnLuu.Enabled = false; btnThem.Enabled = true;
            txtTenSP.Enabled = txtSoLuong.Enabled = txtDonGia.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.ToLower();
            if (key == "nhập tên sản phẩm..." || string.IsNullOrEmpty(key)) { LoadDataGridView(); return; }
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells[1].Value != null) row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(key);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();

        // Placeholder cho Tim Kiem
        private void txtTimKiem_Enter(object sender, EventArgs e) { if (txtTimKiem.Text == "Nhập tên sản phẩm...") { txtTimKiem.Text = ""; txtTimKiem.ForeColor = Color.Black; } }
        private void txtTimKiem_Leave(object sender, EventArgs e) { if (string.IsNullOrWhiteSpace(txtTimKiem.Text)) { txtTimKiem.Text = "Nhập tên sản phẩm..."; txtTimKiem.ForeColor = Color.Gray; } }
    }
}
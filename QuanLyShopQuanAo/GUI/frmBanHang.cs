using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmBanHang : Form
    {
        // Khai báo các lớp nghiệp vụ cần thiết
        BanHangBLL banHangBLL = new BanHangBLL();
        SanPhamBLL spBLL = new SanPhamBLL();
        NhanVienBLL nvBLL = new NhanVienBLL();
        KhachHangBLL khBLL = new KhachHangBLL();

        public frmBanHang()
        {
            InitializeComponent();
            txtSoLuong.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadComboboxData();
            ResetHoaDon();
        }

        private void LoadComboboxData()
        {
            // Nạp Nhân viên thật từ DB
            cboNhanVien.DataSource = nvBLL.GetAll();
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";

            // Nạp Khách hàng thật từ DB
            cboKhachHang.DataSource = khBLL.GetAll();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";

            // Nạp Sản phẩm thật từ DB
            cboMaSP.DataSource = spBLL.GetAll();
            cboMaSP.DisplayMember = "TenSP";
            cboMaSP.ValueMember = "MaSP";
            cboMaSP.SelectedIndex = -1;
        }

        private void ResetHoaDon()
        {
            txtMaHDBan.Text = "Hệ thống tự tạo"; // Vì DB dùng INT IDENTITY
            dtpNgayBan.Value = DateTime.Now;
            txtSoLuong.Text = "1";
            txtTenSP.Text = "";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            lblTongTien.Text = "0 VNĐ";
            dgvHDBanHang.Rows.Clear();
            cboMaSP.SelectedIndex = -1;
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSP.SelectedItem is SanPhamDTO sp)
            {
                txtTenSP.Text = sp.TenSP;
                txtDonGia.Text = sp.DonGia.ToString();
                TinhThanhTien();
            }
        }

        private void TxtSoLuong_TextChanged(object sender, EventArgs e) => TinhThanhTien();

        private void TinhThanhTien()
        {
            if (decimal.TryParse(txtSoLuong.Text, out decimal sl) && decimal.TryParse(txtDonGia.Text, out decimal dg))
                txtThanhTien.Text = (sl * dg).ToString("N0");
            else
                txtThanhTien.Text = "0";
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cboMaSP.SelectedItem is SanPhamDTO sp)
            {
                int sl = int.Parse(txtSoLuong.Text);
                decimal dg = sp.DonGia;
                decimal tt = sl * dg;

                // Thêm vào lưới (MaSP, TenSP, SL, DG, TT, TT_Raw để tính toán)
                dgvHDBanHang.Rows.Add(sp.MaSP, sp.TenSP, sl, dg.ToString("N0"), tt.ToString("N0"), tt);
                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
                tong += Convert.ToDecimal(row.Cells["colTT_Raw"].Value);
            lblTongTien.Text = string.Format("{0:N0} VNĐ", tong);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvHDBanHang.Rows.Count == 0) return;

            // 1. Tạo đối tượng Hóa đơn tổng
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
                tongTien += Convert.ToDecimal(row.Cells["colTT_Raw"].Value);

            HoaDonDTO hd = new HoaDonDTO(
                cboNhanVien.SelectedValue.ToString(),
                (int)cboKhachHang.SelectedValue,
                dtpNgayBan.Value,
                tongTien
            );

            // 2. Tạo danh sách Chi tiết từ GridView
            List<ChiTietHoaDonDTO> dsChiTiet = new List<ChiTietHoaDonDTO>();
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                dsChiTiet.Add(new ChiTietHoaDonDTO
                {
                    MaSP = row.Cells["colMa"].Value.ToString(),
                    SoLuong = int.Parse(row.Cells["colSL"].Value.ToString()),
                    DonGia = decimal.Parse(row.Cells["colDG"].Value.ToString().Replace(",", "").Replace(".", "")),
                    ThanhTien = Convert.ToDecimal(row.Cells["colTT_Raw"].Value)
                });
            }

            // 3. Gọi BLL lưu vào Database
            if (banHangBLL.LuuHoaDon(hd, dsChiTiet))
            {
                MessageBox.Show("Thanh toán thành công!");
                ResetHoaDon();
            }
            else MessageBox.Show("Lỗi khi lưu hóa đơn!");
        }

        private void btnXoa_Click(object sender, EventArgs e) => ResetHoaDon();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();

        private void btnInHoaDon_Click(object sender, EventArgs e) => MessageBox.Show("Đang kết nối máy in...");
        private void btnThemMoi_Click(object sender, EventArgs e) => ResetHoaDon();
    }
}
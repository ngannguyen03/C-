using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmBanHang : Form
    {
        // Tạo cấu trúc dữ liệu mẫu để chọn
        struct SanPham
        {
            public string MaSP;
            public string TenSP;
            public double DonGia;
            public override string ToString() => MaSP + " - " + TenSP;
        }

        List<SanPham> danhSachSP = new List<SanPham>();

        public frmBanHang()
        {
            InitializeComponent();
            // Chỉ cho nhập số vào ô số lượng
            txtSoLuong.KeyPress += (s, e) => {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
            };
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDataDemo();
            ResetHoaDon();
        }

        private void LoadDataDemo()
        {
            // 1. Dữ liệu Nhân viên
            cboNhanVien.Items.AddRange(new string[] { "NV01 - Bảo Ngân", "NV02 - Hoàng Gia", "NV03 - Lê Bình" });

            // 2. Dữ liệu Khách hàng
            cboKhachHang.Items.AddRange(new string[] { "KH00 - Khách vãng lai", "KH01 - Nguyễn Văn A", "KH02 - Trần Thị B" });

            // 3. Dữ liệu Sản phẩm (Dùng List để truy xuất giá nhanh)
            danhSachSP.Add(new SanPham { MaSP = "SP01", TenSP = "Áo thun Polo Nam", DonGia = 150000 });
            danhSachSP.Add(new SanPham { MaSP = "SP02", TenSP = "Quần Jean Slimfit", DonGia = 350000 });
            danhSachSP.Add(new SanPham { MaSP = "SP03", TenSP = "Áo khoác Hoodie", DonGia = 450000 });
            danhSachSP.Add(new SanPham { MaSP = "SP04", TenSP = "Sơ mi trắng Oxford", DonGia = 280000 });

            cboMaSP.Items.Clear();
            foreach (var sp in danhSachSP)
            {
                cboMaSP.Items.Add(sp);
            }
        }

        private void ResetHoaDon()
        {
            txtMaHDBan.Text = "HDB" + DateTime.Now.ToString("ddMMyyHHmm");
            dtpNgayBan.Value = DateTime.Now;
            txtSoLuong.Text = "1";
            txtTenSP.Text = "";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            lblTongTien.Text = "0 VNĐ";
            dgvHDBanHang.Rows.Clear();
            cboNhanVien.SelectedIndex = 0;
            cboKhachHang.SelectedIndex = 0;
            cboMaSP.SelectedIndex = -1;
        }

        // Khi chọn sản phẩm -> Tự nhảy tên và đơn giá
        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaSP.SelectedIndex != -1)
            {
                SanPham spChon = (SanPham)cboMaSP.SelectedItem;
                txtTenSP.Text = spChon.TenSP;
                txtDonGia.Text = spChon.DonGia.ToString();
                TinhThanhTien();
            }
        }

        private void TxtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            if (double.TryParse(txtSoLuong.Text, out double sl) && double.TryParse(txtDonGia.Text, out double dg))
            {
                txtThanhTien.Text = (sl * dg).ToString("N0");
            }
            else
            {
                txtThanhTien.Text = "0";
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (cboMaSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtSoLuong.Text) || int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SanPham sp = (SanPham)cboMaSP.SelectedItem;
            int sl = int.Parse(txtSoLuong.Text);
            double tt = sl * sp.DonGia;

            // Thêm vào lưới
            dgvHDBanHang.Rows.Add(sp.MaSP, sp.TenSP, sl, sp.DonGia.ToString("N0"), tt.ToString("N0"), tt);

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                tong += Convert.ToDouble(row.Cells[5].Value); // Cột ẩn chứa giá trị số
            }
            lblTongTien.Text = string.Format("{0:N0} VNĐ", tong);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy hóa đơn?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ResetHoaDon();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvHDBanHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã lưu hóa đơn " + txtMaHDBan.Text + " vào hệ thống!", "Thành công");
            ResetHoaDon();
        }

        private void btnDong_Click(object sender, EventArgs e) => this.Close();

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang xuất hóa đơn ra máy in...", "Print");
        }

        private void btnThemMoi_Click(object sender, EventArgs e) => ResetHoaDon();
    }
}
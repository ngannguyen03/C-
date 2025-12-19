using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            ResetHoaDon();
            LoadDataDemo();
        }

        private void LoadDataDemo()
        {
            // Thêm dữ liệu giả lập cho ComboBox
            cboNhanVien.Items.AddRange(new string[] { "NV01 - Nguyễn Văn A", "NV02 - Trần Thị B" });
            cboKhachHang.Items.AddRange(new string[] { "KH01 - Khách lẻ", "KH02 - Nguyễn Văn C" });
            cboMaSP.Items.AddRange(new string[] { "SP01 - Áo thun Polo", "SP02 - Quần Jean", "SP03 - Áo khoác" });

            cboNhanVien.SelectedIndex = 0;
            cboKhachHang.SelectedIndex = 0;
        }

        private void ResetHoaDon()
        {
            txtMaHDBan.Text = "HDB" + DateTime.Now.ToString("ddMMyyHHmm");
            dtpNgayBan.Value = DateTime.Now;
            txtSoLuong.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "0";
            txtThanhTien.Text = "0";
            lblTongTien.Text = "0 VNĐ";
            dgvHDBanHang.Rows.Clear();
        }

        // ================= TỰ ĐỘNG TÍNH TOÁN =================
        private void TxtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void cboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Giả lập lấy giá sản phẩm khi chọn
            if (cboMaSP.SelectedIndex == 0) { txtTenSP.Text = "Áo thun Polo"; txtDonGia.Text = "150000"; }
            if (cboMaSP.SelectedIndex == 1) { txtTenSP.Text = "Quần Jean"; txtDonGia.Text = "350000"; }
            if (cboMaSP.SelectedIndex == 2) { txtTenSP.Text = "Áo khoác"; txtDonGia.Text = "500000"; }
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            try
            {
                double sl = string.IsNullOrEmpty(txtSoLuong.Text) ? 0 : double.Parse(txtSoLuong.Text);
                double dg = string.IsNullOrEmpty(txtDonGia.Text) ? 0 : double.Parse(txtDonGia.Text);
                txtThanhTien.Text = (sl * dg).ToString();
            }
            catch { txtThanhTien.Text = "0"; }
        }

        private void TinhTongTien()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dgvHDBanHang.Rows)
            {
                tong += Convert.ToDouble(row.Cells[4].Value);
            }
            lblTongTien.Text = string.Format("{0:N0} VNĐ", tong);
        }

        // ================= THÊM SẢN PHẨM VÀO GIỎ =================
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuong.Text) || cboMaSP.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maSP = cboMaSP.Text.Split('-')[0].Trim();
            dgvHDBanHang.Rows.Add(maSP, txtTenSP.Text, txtSoLuong.Text, txtDonGia.Text, txtThanhTien.Text);
            TinhTongTien();
        }

        // ================= XỬ LÝ HỦY HÓA ĐƠN (XÁC NHẬN XÓA) =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy toàn bộ hóa đơn này không?",
                "⚠️ XÁC NHẬN HỦY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ResetHoaDon();
            }
        }

        // ================= POPUP CHI TIẾT DÒNG HÀNG =================
        private void dgvHDBanHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvHDBanHang.Rows[e.RowIndex];
            string info = $"📦 Sản phẩm: {row.Cells[1].Value}\n" +
                          $"🔢 Số lượng: {row.Cells[2].Value}\n" +
                          $"💰 Đơn giá: {row.Cells[3].Value}\n" +
                          $"💵 Thành tiền: {row.Cells[4].Value}";
            MessageBox.Show(info, "CHI TIẾT MẶT HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvHDBanHang.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào trong hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã lưu hóa đơn thành công vào hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetHoaDon();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang kết nối máy in...", "In hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemMoi_Click(object sender, EventArgs e) => ResetHoaDon();
    }
}
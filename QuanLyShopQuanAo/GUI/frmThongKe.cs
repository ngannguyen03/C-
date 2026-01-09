using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmThongKe : Form
    {
        ThongKeBLL bll = new ThongKeBLL();

        public frmThongKe()
        {
            InitializeComponent();
            StylingInterface();
        }

        private void StylingInterface()
        {
            dgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe.AllowUserToAddRows = false;
            dgvThongKe.ReadOnly = true;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            // Mặc định xem thống kê từ đầu tháng đến hiện tại
            DateTime now = DateTime.Now;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = now;

            LoadDataReal();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDataReal();
        }

        private void LoadDataReal()
        {
            dgvThongKe.Columns.Clear();
            dgvThongKe.Rows.Clear();

            // Khởi tạo cột
            dgvThongKe.Columns.Add("Ngay", "📅 Ngày bán");
            dgvThongKe.Columns.Add("SoDon", "🛒 Số hóa đơn");
            dgvThongKe.Columns.Add("SoLuong", "👕 Số lượng SP");
            dgvThongKe.Columns.Add("DoanhThu", "💰 Doanh thu");
            dgvThongKe.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";

            // Lấy dữ liệu từ BLL
            List<ThongKeDTO> list = bll.LayThongKe(dtpTuNgay.Value, dtpDenNgay.Value);

            decimal tongDoanhThu = 0;
            int tongDonHang = 0;
            int tongSanPham = 0;

            foreach (var item in list)
            {
                dgvThongKe.Rows.Add(
                    item.Ngay.ToString("dd/MM/yyyy"),
                    item.SoDonHang,
                    item.SoLuongSanPham,
                    item.DoanhThu.ToString("N0")
                );

                tongDoanhThu += item.DoanhThu;
                tongDonHang += item.SoDonHang;
                tongSanPham += item.SoLuongSanPham;
            }

            // Hiển thị lên các Card tổng hợp
            lblDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";
            lblDonHang.Text = tongDonHang.ToString() + " đơn";
            lblSoLuong.Text = tongSanPham.ToString() + " cái";
        }

        private void DgvThongKe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ngayChon = dgvThongKe.Rows[e.RowIndex].Cells[0].Value.ToString();
                // frmChiTietThongKe là form xem danh sách các hóa đơn của ngày đó
                frmChiTietThongKe popup = new frmChiTietThongKe(ngayChon);
                popup.ShowDialog();
            }
        }
    }
}
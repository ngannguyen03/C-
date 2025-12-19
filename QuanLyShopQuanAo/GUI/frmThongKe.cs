using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            StylingInterface(); // Gọi hàm trang trí giao diện
        }

        // 1. Hàm trang trí giao diện
        private void StylingInterface()
        {
            // Trang trí nút
            btnThongKe.Text = "🔍 Xem Thống Kê";
            btnThongKe.BackColor = Color.MediumSlateBlue;
            btnThongKe.ForeColor = Color.White;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.Cursor = Cursors.Hand;

            // Trang trí bảng
            dgvThongKe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThongKe.AllowUserToAddRows = false; // Không cho user tự thêm dòng
            dgvThongKe.ReadOnly = true; // Chỉ xem

            // Map sự kiện Click đúp vào bảng (Nếu Designer chưa map)
            dgvThongKe.CellDoubleClick += DgvThongKe_CellDoubleClick;
        }

        // 2. Sự kiện Load Form
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dtpTuNgay.Value = new DateTime(now.Year, now.Month, 1);
            dtpDenNgay.Value = now;

            // Tự động load dữ liệu mẫu khi mở form
            LoadDummyData();
        }

        // 3. Sự kiện Click nút Xem Thống Kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDummyData(); // Quan trọng: Phải gọi hàm này
        }

        // 4. Hàm tạo dữ liệu giả
        private void LoadDummyData()
        {
            // Xóa cột cũ để tránh trùng lặp nếu ấn nhiều lần
            dgvThongKe.Columns.Clear();
            dgvThongKe.Rows.Clear();

            // Tạo cột
            dgvThongKe.Columns.Add("Ngay", "📅 Ngày bán");
            dgvThongKe.Columns.Add("SoDon", "🛒 Số hóa đơn");
            dgvThongKe.Columns.Add("SoLuong", "👕 Số lượng SP");
            dgvThongKe.Columns.Add("DoanhThu", "💰 Doanh thu");

            // Định dạng
            dgvThongKe.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
            dgvThongKe.Columns["DoanhThu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thêm dữ liệu giả
            dgvThongKe.Rows.Add("15/12/2025", "10", "25", "5,500,000");
            dgvThongKe.Rows.Add("16/12/2025", "15", "40", "8,200,000");
            dgvThongKe.Rows.Add("17/12/2025", "8", "12", "2,800,000");
            dgvThongKe.Rows.Add("18/12/2025", "20", "55", "12,150,000");
            dgvThongKe.Rows.Add("19/12/2025", "12", "30", "6,000,000");

            // Tính tổng
            CalculateTotals();
        }

        // 5. Hàm tính tổng hiển thị lên các ô màu
        private void CalculateTotals()
        {
            decimal tongTien = 0;
            int tongDon = 0;
            int tongSP = 0;

            foreach (DataGridViewRow row in dgvThongKe.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    tongDon += int.Parse(row.Cells[1].Value.ToString());
                    tongSP += int.Parse(row.Cells[2].Value.ToString());
                    tongTien += decimal.Parse(row.Cells[3].Value.ToString().Replace(",", ""));
                }
            }

            lblDoanhThu.Text = tongTien.ToString("N0") + " đ";
            lblDonHang.Text = tongDon.ToString() + " đơn";
            lblSoLuong.Text = tongSP.ToString() + " cái";
        }

        // 6. Sự kiện mở Popup chi tiết
        private void DgvThongKe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string ngayChon = dgvThongKe.Rows[e.RowIndex].Cells[0].Value.ToString();

                // Mở Form chi tiết
                frmChiTietThongKe popup = new frmChiTietThongKe(ngayChon);
                popup.ShowDialog();
            }
        }
    }
}
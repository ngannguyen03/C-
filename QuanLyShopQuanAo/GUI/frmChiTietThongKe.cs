using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmChiTietThongKe : Form
    {
        private string _ngayXem;

        // Constructor nhận tham số ngày từ form cha truyền sang
        public frmChiTietThongKe(string ngay)
        {
            InitializeComponent();
            _ngayXem = ngay;

            // Gán sự kiện cho các nút (nếu Designer chưa gán)
            this.Load += FrmChiTietThongKe_Load;
            this.btnClose.Click += BtnClose_Click;
        }

        private void FrmChiTietThongKe_Load(object sender, EventArgs e)
        {
            // Cập nhật tiêu đề
            lblTitle.Text = "CHI TIẾT BÁN HÀNG NGÀY: " + _ngayXem;

            // Trang trí bảng
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChiTiet.EnableHeadersVisualStyles = false;

            LoadDetailData();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDetailData()
        {
            // 1. Tạo cột
            dgvChiTiet.Columns.Clear();
            dgvChiTiet.Columns.Add("MaHD", "🧾 Mã HĐ");
            dgvChiTiet.Columns.Add("TenSP", "📦 Tên Sản Phẩm");
            dgvChiTiet.Columns.Add("SoLuong", "🔢 SL");
            dgvChiTiet.Columns.Add("DonGia", "💲 Đơn giá");
            dgvChiTiet.Columns.Add("ThanhTien", "💰 Thành tiền");

            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            // 2. Dữ liệu giả lập (Tùy ngày mà hiển thị khác nhau cho sinh động)
            if (_ngayXem.StartsWith("15"))
            {
                dgvChiTiet.Rows.Add("HDB001", "Áo Thun Basic Trắng", "5", "150,000", "750,000");
                dgvChiTiet.Rows.Add("HDB001", "Quần Jean Rách", "2", "350,000", "700,000");
                dgvChiTiet.Rows.Add("HDB002", "Váy Hoa Nhí", "10", "280,000", "2,800,000");
            }
            else if (_ngayXem.StartsWith("16"))
            {
                dgvChiTiet.Rows.Add("HDB003", "Áo Khoác Gió", "5", "450,000", "2,250,000");
                dgvChiTiet.Rows.Add("HDB004", "Tất Cổ Cao", "20", "20,000", "400,000");
            }
            else
            {
                dgvChiTiet.Rows.Add("HDB005", "Sơ Mi Công Sở", "3", "300,000", "900,000");
                dgvChiTiet.Rows.Add("HDB005", "Quần Tây Đen", "3", "400,000", "1,200,000");
            }
        }
    }
}
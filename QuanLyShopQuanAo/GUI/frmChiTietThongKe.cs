using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmChiTietThongKe : Form
    {
        private string _ngayXem;
        ThongKeBLL bll = new ThongKeBLL();

        // Constructor nhận tham số ngày từ form cha truyền sang
        public frmChiTietThongKe(string ngay)
        {
            InitializeComponent();
            _ngayXem = ngay;

            // Gán sự kiện
            this.Load += FrmChiTietThongKe_Load;
            this.btnClose.Click += BtnClose_Click;
        }

        private void FrmChiTietThongKe_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "CHI TIẾT BÁN HÀNG NGÀY: " + _ngayXem;

            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.ReadOnly = true;

            // Thiết kế màu sắc Navy đồng bộ với App
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvChiTiet.EnableHeadersVisualStyles = false;

            LoadDetailData();
        }

        private void LoadDetailData()
        {
            dgvChiTiet.Columns.Clear();
            dgvChiTiet.Rows.Clear();

            // Tạo cột hiển thị
            dgvChiTiet.Columns.Add("MaHD", "🧾 Mã HĐ");
            dgvChiTiet.Columns.Add("TenSP", "📦 Tên Sản Phẩm");
            dgvChiTiet.Columns.Add("SoLuong", "🔢 SL");
            dgvChiTiet.Columns.Add("DonGia", "💲 Đơn giá");
            dgvChiTiet.Columns.Add("ThanhTien", "💰 Thành tiền");

            // Cấu hình định dạng số
            dgvChiTiet.Columns["DonGia"].DefaultCellStyle.Format = "N0";
            dgvChiTiet.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Lấy dữ liệu thật từ tầng BLL
            try
            {
                List<ChiTietThongKeDTO> list = bll.LayChiTietTheoNgay(_ngayXem);
                foreach (var item in list)
                {
                    dgvChiTiet.Rows.Add(
                        "HDB" + item.MaHD.ToString("D3"), // Format mã HD ví dụ HDB001
                        item.TenSP,
                        item.SoLuong,
                        item.DonGia,
                        item.ThanhTien
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết: " + ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
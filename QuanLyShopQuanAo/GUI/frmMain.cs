using System;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định khi mở form (nếu cần)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cập nhật giờ hệ thống
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // === HÀM HỖ TRỢ MỞ FORM CON (Tránh mở nhiều form giống nhau) ===
        private void OpenChildForm(Form childForm)
        {
            // Kiểm tra xem form đó đã mở chưa
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == childForm.Name)
                {
                    f.Activate(); // Nếu mở rồi thì focus vào nó
                    return;
                }
            }
            // Nếu chưa mở thì thiết lập và hiển thị
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        // --- CÁC SỰ KIỆN CLICK TRÊN SIDEBAR ---

        // 1. Quản lý Sản Phẩm
        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            // Lưu ý: Tên hàm này đang khớp với sự kiện trong Designer (btnSanPham)
            OpenChildForm(new frmSanPham());
        }

        // 2. Quản lý Nhân Viên
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
        }

        // 3. Quản lý Khách Hàng
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());
        }

        // 4. Bán Hàng
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBanHang());
        }

        // 5. Thống kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        // 6. Đăng xuất / Đổi Mật Khẩu
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất quay về màn hình đăng nhập?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Chỉ cần Close form Main, code bên frmLogin sẽ tự động Show lại form Login
                this.Close();
            }
        }

        // 7. Thoát chương trình
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            // Lưu ý: Tên hàm này đang khớp với sự kiện trong Designer (btnThoat)
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi hệ thống?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
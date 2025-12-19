using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL; // Gọi lớp Nghiệp vụ
using QuanLyShopQuanAo.DTO; // Gọi lớp Dữ liệu


namespace QuanLyShopQuanAo.GUI
{
    public partial class frmLogin : Form
    {
        // Khởi tạo lớp BLL
        NhanVienBLL bll = new NhanVienBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        // Xử lý nút ĐĂNG NHẬP
        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.TaiKhoan = txtTaiKhoan.Text;
            nv.MatKhau = txtMatKhau.Text;

            string ketQua = bll.CheckLogin(nv);

            if (ketQua == "Kém tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
            else if (ketQua == "Kém mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
            else if (ketQua != null)
            {
                MessageBox.Show("Đăng nhập thành công! Xin chào: " + ketQua, "Thông báo");

                this.Hide(); // Ẩn form Login

                frmMain f = new frmMain();
                f.ShowDialog(); // Chờ thao tác bên form Main

                // --- SỬA ĐOẠN NÀY ---
                // Kiểm tra: Nếu Form chưa bị hủy (tức là chỉ Đăng xuất chứ không phải Thoát app) thì mới hiện lại
                if (this.IsDisposed == false)
                {
                    this.Show();
                    txtMatKhau.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý nút THOÁT
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using QuanLyShopQuanAo.BLL; // Lớp xử lý nghiệp vụ
using QuanLyShopQuanAo.DTO; // Đối tượng dữ liệu nhân viên

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmLogin : Form
    {
        NhanVienBLL bll = new NhanVienBLL();

        // KỸ THUẬT: Tạo bóng đổ cho Form không viền
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // CS_DROPSHADOW
                return cp;
            }
        }

        // KỸ THUẬT: Gọi Windows API để cho phép kéo Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmLogin()
        {
            InitializeComponent();
            SetPlaceholder(); // Thiết lập chữ mờ ban đầu
        }

        // Thiết lập trạng thái chữ mờ (Placeholder)
        private void SetPlaceholder()
        {
            txtTaiKhoan.Text = "Tên đăng nhập...";
            txtTaiKhoan.ForeColor = Color.Silver;
            txtMatKhau.Text = "Mật khẩu...";
            txtMatKhau.ForeColor = Color.Silver;
            txtMatKhau.UseSystemPasswordChar = false;
        }

        // ================= LOGIC XEM MẬT KHẨU KHI DI CHUỘT (Hover) =================

        private void lblShowPass_MouseEnter(object sender, EventArgs e)
        {
            // Nếu không phải đang hiển thị placeholder thì cho hiện mật khẩu
            if (txtMatKhau.Text != "Mật khẩu...")
            {
                txtMatKhau.UseSystemPasswordChar = false;
                lblShowPass.ForeColor = Color.SteelBlue; // Đổi màu icon cho đẹp
            }
        }

        private void lblShowPass_MouseLeave(object sender, EventArgs e)
        {
            // Khi rời chuột ra, ẩn lại mật khẩu ngay lập tức
            if (txtMatKhau.Text != "Mật khẩu...")
            {
                txtMatKhau.UseSystemPasswordChar = true;
                lblShowPass.ForeColor = Color.Silver;
            }
        }

        // ================= LOGIC XỬ LÝ ĐĂNG NHẬP (KHÔI PHỤC frmAlert) =================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Xử lý giá trị nhập (nếu còn placeholder thì coi như rỗng)
            string tk = txtTaiKhoan.Text == "Tên đăng nhập..." ? "" : txtTaiKhoan.Text;
            string mk = txtMatKhau.Text == "Mật khẩu..." ? "" : txtMatKhau.Text;

            // 1. Kiểm tra trống - Sử dụng frmAlert Warning
            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                new frmAlert().showAlert("Vui lòng nhập đủ thông tin!", frmAlert.enmType.Warning);
                return;
            }

            NhanVienDTO nv = new NhanVienDTO { TaiKhoan = tk, MatKhau = mk };
            string ketQua = bll.CheckLogin(nv);

            // 2. Kiểm tra đăng nhập thành công - Sử dụng frmAlert Success
            if (ketQua != null && ketQua != "Sai tài khoản" && ketQua != "Sai mật khẩu")
            {
                new frmAlert().showAlert("Đăng nhập thành công!", frmAlert.enmType.Success);

                this.DialogResult = DialogResult.OK; // Gửi tín hiệu thành công về Program.cs
                this.Close(); // Đóng form Login
            }
            else
            {
                // 3. Sai thông tin - Sử dụng frmAlert Error
                new frmAlert().showAlert("Tài khoản hoặc mật khẩu sai!", frmAlert.enmType.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        // Sự kiện kéo Form
        private void pnlLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // ================= LOGIC PLACEHOLDER (CHỮ MỜ) =================

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Tên đăng nhập...") { txtTaiKhoan.Text = ""; txtTaiKhoan.ForeColor = Color.Black; }
            pnlLine1.BackColor = Color.SteelBlue;
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaiKhoan.Text)) { txtTaiKhoan.Text = "Tên đăng nhập..."; txtTaiKhoan.ForeColor = Color.Silver; }
            pnlLine1.BackColor = Color.Silver;
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu...")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true;
            }
            pnlLine2.BackColor = Color.SteelBlue;
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Mật khẩu...";
                txtMatKhau.ForeColor = Color.Silver;
                txtMatKhau.UseSystemPasswordChar = false;
            }
            pnlLine2.BackColor = Color.Silver;
        }
    }
}
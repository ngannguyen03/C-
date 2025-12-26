namespace QuanLyShopQuanAo.GUI
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        // Giải phóng tài nguyên
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLeft = new Panel();
            lblBrand = new Label();
            lblTitle = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            pnlLine1 = new Panel();
            pnlLine2 = new Panel();
            lblUserIcon = new Label();
            lblPassIcon = new Label();
            lblShowPass = new Label();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panel bên trái (Màu xanh đậm thương hiệu)
            // 
            pnlLeft.BackColor = Color.MidnightBlue;
            pnlLeft.Controls.Add(lblBrand);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(280, 420);
            pnlLeft.TabIndex = 9;
            pnlLeft.MouseDown += pnlLeft_MouseDown; // Cho phép kéo form khi nhấn vào vùng này
            // 
            // lblBrand: Chữ thương hiệu lớn
            // 
            lblBrand.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(0, 150);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(277, 157);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "NGAN\nSHOP";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle: Tiêu đề Welcome
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(380, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(198, 50);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "WELCOME";
            // 
            // txtTaiKhoan: Ô nhập tên tài khoản (Không viền)
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.Location = new Point(365, 150);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(230, 27);
            txtTaiKhoan.TabIndex = 3;
            txtTaiKhoan.Enter += txtTaiKhoan_Enter;
            txtTaiKhoan.Leave += txtTaiKhoan_Leave;
            // 
            // txtMatKhau: Ô nhập mật khẩu (Không viền)
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(365, 230);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(200, 27); // Ngắn hơn một chút để chừa chỗ cho icon con mắt
            txtMatKhau.TabIndex = 2;
            txtMatKhau.Enter += txtMatKhau_Enter;
            txtMatKhau.Leave += txtMatKhau_Leave;
            // 
            // btnLogin: Nút đăng nhập
            // 
            btnLogin.BackColor = Color.DarkBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(330, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(270, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit: Nút đóng Form (X)
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.Silver;
            btnExit.Location = new Point(661, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 0;
            btnExit.Text = "✕";
            btnExit.Click += btnExit_Click;
            // 
            // pnlLine1 & 2: Đường gạch chân dưới TextBox
            // 
            pnlLine1.BackColor = Color.Silver;
            pnlLine1.Location = new Point(330, 175);
            pnlLine1.Name = "pnlLine1";
            pnlLine1.Size = new Size(270, 2);
            pnlLine1.TabIndex = 4;
            // 
            // pnlLine2
            // 
            pnlLine2.BackColor = Color.Silver;
            pnlLine2.Location = new Point(330, 255);
            pnlLine2.Name = "pnlLine2";
            pnlLine2.Size = new Size(270, 2);
            pnlLine2.TabIndex = 5;
            // 
            // Biểu tượng Người dùng & Khóa
            // 
            lblUserIcon.ForeColor = Color.DarkBlue;
            lblUserIcon.Location = new Point(330, 150);
            lblUserIcon.Name = "lblUserIcon";
            lblUserIcon.Size = new Size(30, 23);
            lblUserIcon.TabIndex = 6;
            lblUserIcon.Text = "👤";
            // 
            // lblPassIcon
            // 
            lblPassIcon.ForeColor = Color.DarkBlue;
            lblPassIcon.Location = new Point(330, 230);
            lblPassIcon.Name = "lblPassIcon";
            lblPassIcon.Size = new Size(30, 23);
            lblPassIcon.TabIndex = 7;
            lblPassIcon.Text = "🔒";
            // 
            // lblShowPass: Biểu tượng con mắt để xem MK
            // 
            lblShowPass.AutoSize = true;
            lblShowPass.Cursor = Cursors.Hand;
            lblShowPass.Font = new Font("Segoe UI", 11F);
            lblShowPass.ForeColor = Color.Silver;
            lblShowPass.Location = new Point(570, 227);
            lblShowPass.Name = "lblShowPass";
            lblShowPass.Size = new Size(32, 25);
            lblShowPass.TabIndex = 10;
            lblShowPass.Text = "👁";
            lblShowPass.MouseEnter += lblShowPass_MouseEnter; // Hiện khi di chuột vào
            lblShowPass.MouseLeave += lblShowPass_MouseLeave; // Ẩn khi rời chuột đi
            // 
            // frmLogin: Thiết lập Form chính
            // 
            AcceptButton = btnLogin; // Nhấn Enter để Đăng nhập
            BackColor = Color.White;
            ClientSize = new Size(714, 420);
            Controls.Add(lblShowPass);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(pnlLine1);
            Controls.Add(pnlLine2);
            Controls.Add(lblUserIcon);
            Controls.Add(lblPassIcon);
            Controls.Add(lblTitle);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.None; // Xóa viền Windows cũ
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlLeft, pnlLine1, pnlLine2;
        private Label lblBrand, lblTitle, lblUserIcon, lblPassIcon, lblShowPass;
        private TextBox txtTaiKhoan, txtMatKhau;
        private Button btnLogin, btnExit;
    }
}
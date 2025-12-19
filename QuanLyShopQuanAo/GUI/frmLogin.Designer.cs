namespace QuanLyShopQuanAo.GUI
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblBrand = new Label();
            lblTitle = new Label();
            lblTaiKhoan = new Label();
            txtTaiKhoan = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            panelTop = new Panel();
            panelLine1 = new Panel();
            panelLine2 = new Panel();
            panelBorder = new Panel();
            panelTop.SuspendLayout();
            panelBorder.SuspendLayout();
            SuspendLayout();
            // 
            // lblBrand
            // 
            lblBrand.BackColor = Color.SteelBlue;
            lblBrand.Dock = DockStyle.Fill;
            lblBrand.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(0, 0);
            lblBrand.Margin = new Padding(4, 0, 4, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(598, 154);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "NganShop";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 0, 192);
            lblTitle.Location = new Point(0, 185);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "LOGIN ADMIN";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTaiKhoan
            // 
            lblTaiKhoan.AutoSize = true;
            lblTaiKhoan.Font = new Font("Segoe UI", 10F);
            lblTaiKhoan.ForeColor = Color.DimGray;
            lblTaiKhoan.Location = new Point(67, 277);
            lblTaiKhoan.Margin = new Padding(4, 0, 4, 0);
            lblTaiKhoan.Name = "lblTaiKhoan";
            lblTaiKhoan.Size = new Size(82, 23);
            lblTaiKhoan.TabIndex = 2;
            lblTaiKhoan.Text = "Tài khoản";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BorderStyle = BorderStyle.None;
            txtTaiKhoan.Font = new Font("Segoe UI", 12F);
            txtTaiKhoan.ForeColor = Color.FromArgb(51, 51, 51);
            txtTaiKhoan.Location = new Point(72, 315);
            txtTaiKhoan.Margin = new Padding(4, 5, 4, 5);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(453, 27);
            txtTaiKhoan.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.ForeColor = Color.DimGray;
            lblMatKhau.Location = new Point(67, 400);
            lblMatKhau.Margin = new Padding(4, 0, 4, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(82, 23);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BorderStyle = BorderStyle.None;
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.ForeColor = Color.FromArgb(51, 51, 51);
            txtMatKhau.Location = new Point(72, 438);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(453, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 100, 200);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(72, 554);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(453, 69);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(30, 144, 255);
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(30, 144, 255);
            btnExit.Location = new Point(72, 646);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(453, 69);
            btnExit.TabIndex = 3;
            btnExit.Text = "THOÁT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(30, 144, 255);
            panelTop.Controls.Add(lblBrand);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(598, 154);
            panelTop.TabIndex = 8;
            // 
            // panelLine1
            // 
            panelLine1.BackColor = Color.FromArgb(30, 144, 255);
            panelLine1.Location = new Point(72, 354);
            panelLine1.Margin = new Padding(4, 5, 4, 5);
            panelLine1.Name = "panelLine1";
            panelLine1.Size = new Size(453, 3);
            panelLine1.TabIndex = 9;
            // 
            // panelLine2
            // 
            panelLine2.BackColor = Color.FromArgb(30, 144, 255);
            panelLine2.Location = new Point(72, 477);
            panelLine2.Margin = new Padding(4, 5, 4, 5);
            panelLine2.Name = "panelLine2";
            panelLine2.Size = new Size(453, 3);
            panelLine2.TabIndex = 10;
            // 
            // panelBorder
            // 
            panelBorder.BackColor = Color.AliceBlue;
            panelBorder.BorderStyle = BorderStyle.FixedSingle;
            panelBorder.Controls.Add(panelLine2);
            panelBorder.Controls.Add(panelTop);
            panelBorder.Controls.Add(panelLine1);
            panelBorder.Controls.Add(btnExit);
            panelBorder.Controls.Add(lblTitle);
            panelBorder.Controls.Add(btnLogin);
            panelBorder.Controls.Add(lblTaiKhoan);
            panelBorder.Controls.Add(txtMatKhau);
            panelBorder.Controls.Add(txtTaiKhoan);
            panelBorder.Controls.Add(lblMatKhau);
            panelBorder.Dock = DockStyle.Fill;
            panelBorder.Location = new Point(0, 0);
            panelBorder.Margin = new Padding(4, 5, 4, 5);
            panelBorder.Name = "panelBorder";
            panelBorder.Size = new Size(600, 769);
            panelBorder.TabIndex = 11;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 769);
            Controls.Add(panelBorder);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập hệ thống";
            panelTop.ResumeLayout(false);
            panelBorder.ResumeLayout(false);
            panelBorder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.Panel panelBorder;
    }
}
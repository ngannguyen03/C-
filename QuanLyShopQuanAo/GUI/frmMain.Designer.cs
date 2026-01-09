namespace QuanLyShopQuanAo.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSidebar = new Panel();
            btnThoat = new Button();
            line5 = new Panel();
            btnDangXuat = new Button();
            line4 = new Panel();
            btnThongKe = new Button();
            line3 = new Panel();
            btnBanHang = new Button();
            line2 = new Panel();
            btnKhachHang = new Button();
            line1 = new Panel();
            btnNhanVien = new Button();
            lineDM = new Panel(); // Đường kẻ mới
            btnDanhMuc = new Button(); // Nút mới
            line0 = new Panel();
            btnSanPham = new Button();
            pnlLogo = new Panel();
            lblLogoText = new Label();
            panelHeader = new Panel();
            lblTime = new Label();
            lblTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblUserStatus = new ToolStripStatusLabel();
            panelSidebar.SuspendLayout();
            pnlLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.MidnightBlue;
            panelSidebar.Controls.Add(line5);
            panelSidebar.Controls.Add(btnDangXuat);
            panelSidebar.Controls.Add(line4);
            panelSidebar.Controls.Add(btnThongKe);
            panelSidebar.Controls.Add(line3);
            panelSidebar.Controls.Add(btnBanHang);
            panelSidebar.Controls.Add(line2);
            panelSidebar.Controls.Add(btnKhachHang);
            panelSidebar.Controls.Add(line1);
            panelSidebar.Controls.Add(btnNhanVien);
            panelSidebar.Controls.Add(lineDM); // Thêm vào danh sách điều khiển
            panelSidebar.Controls.Add(btnDanhMuc); // Thêm vào danh sách điều khiển
            panelSidebar.Controls.Add(line0);
            panelSidebar.Controls.Add(btnSanPham);
            panelSidebar.Controls.Add(btnThoat);
            panelSidebar.Controls.Add(pnlLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(260, 800);
            panelSidebar.TabIndex = 0;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.MidnightBlue;
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.Location = new Point(0, 80);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(15, 0, 0, 0);
            btnSanPham.Size = new Size(260, 65);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "  📦  Quản lý Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // line0
            // 
            line0.BackColor = Color.SlateBlue;
            line0.Dock = DockStyle.Top;
            line0.Location = new Point(0, 145);
            line0.Name = "line0";
            line0.Size = new Size(260, 2);
            //
            // btnDanhMuc (Nút mới chèn vào đây)
            //
            btnDanhMuc.BackColor = Color.MidnightBlue;
            btnDanhMuc.Dock = DockStyle.Top;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnDanhMuc.ForeColor = Color.White;
            btnDanhMuc.Location = new Point(0, 147);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(15, 0, 0, 0);
            btnDanhMuc.Size = new Size(260, 65);
            btnDanhMuc.TabIndex = 8;
            btnDanhMuc.Text = "  📂  Quản lý Danh mục";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            //
            // lineDM (Đường kẻ mới)
            //
            lineDM.BackColor = Color.SlateBlue;
            lineDM.Dock = DockStyle.Top;
            lineDM.Location = new Point(0, 212);
            lineDM.Name = "lineDM";
            lineDM.Size = new Size(260, 2);
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.MidnightBlue;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(0, 214);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(15, 0, 0, 0);
            btnNhanVien.Size = new Size(260, 65);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "  👥  Quản lý Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // line1
            // 
            line1.BackColor = Color.SlateBlue;
            line1.Dock = DockStyle.Top;
            line1.Location = new Point(0, 279);
            line1.Name = "line1";
            line1.Size = new Size(260, 2);
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.MidnightBlue;
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Location = new Point(0, 281);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(15, 0, 0, 0);
            btnKhachHang.Size = new Size(260, 65);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "  👤  Quản lý Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // line2
            // 
            line2.BackColor = Color.SlateBlue;
            line2.Dock = DockStyle.Top;
            line2.Location = new Point(0, 346);
            line2.Name = "line2";
            line2.Size = new Size(260, 2);
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.MidnightBlue;
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBanHang.ForeColor = Color.White;
            btnBanHang.Location = new Point(0, 348);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(15, 0, 0, 0);
            btnBanHang.Size = new Size(260, 65);
            btnBanHang.TabIndex = 4;
            btnBanHang.Text = "  🛒  Bán hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // line3
            // 
            line3.BackColor = Color.SlateBlue;
            line3.Dock = DockStyle.Top;
            line3.Location = new Point(0, 413);
            line3.Name = "line3";
            line3.Size = new Size(260, 2);
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.MidnightBlue;
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(0, 415);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(15, 0, 0, 0);
            btnThongKe.Size = new Size(260, 65);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "  📊  Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // line4
            // 
            line4.BackColor = Color.SlateBlue;
            line4.Dock = DockStyle.Top;
            line4.Location = new Point(0, 480);
            line4.Name = "line4";
            line4.Size = new Size(260, 2);
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.MidnightBlue;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnDangXuat.ForeColor = Color.Orange;
            btnDangXuat.Location = new Point(0, 482);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(15, 0, 0, 0);
            btnDangXuat.Size = new Size(260, 65);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "  🔑  Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // line5
            // 
            line5.BackColor = Color.SlateBlue;
            line5.Dock = DockStyle.Top;
            line5.Location = new Point(0, 547);
            line5.Name = "line5";
            line5.Size = new Size(260, 2);
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(192, 0, 0);
            btnThoat.Dock = DockStyle.Bottom;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(0, 740);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(15, 0, 0, 0);
            btnThoat.Size = new Size(260, 60);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "  ❌  Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(20, 20, 60);
            pnlLogo.Controls.Add(lblLogoText);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(260, 80);
            pnlLogo.TabIndex = 0;
            // 
            // lblLogoText
            // 
            lblLogoText.Dock = DockStyle.Fill;
            lblLogoText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblLogoText.ForeColor = Color.White;
            lblLogoText.Location = new Point(0, 0);
            lblLogoText.Name = "lblLogoText";
            lblLogoText.Size = new Size(260, 80);
            lblLogoText.TabIndex = 0;
            lblLogoText.Text = "NGAN SHOP";
            lblLogoText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTime);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(260, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(940, 80);
            panelHeader.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 11F);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(780, 30);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(63, 20);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(20, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(158, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DASHBOARD";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUserStatus });
            statusStrip1.Location = new Point(260, 778);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(940, 22);
            statusStrip1.TabIndex = 3;
            // 
            // lblUserStatus
            // 
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(111, 17);
            lblUserStatus.Text = "Trạng thái: Sẵn sàng";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(statusStrip1);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NganShop Management System";
            WindowState = FormWindowState.Maximized;
            panelSidebar.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelSidebar, panelHeader, pnlLogo, line0, line1, line2, line3, line4, line5, lineDM;
        private Label lblLogoText, lblTitle, lblTime;
        private Button btnSanPham, btnNhanVien, btnKhachHang, btnBanHang, btnThongKe, btnDangXuat, btnThoat, btnDanhMuc;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblUserStatus;
    }
}
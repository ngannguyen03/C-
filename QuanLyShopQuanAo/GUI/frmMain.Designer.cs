namespace QuanLyShopQuanAo.GUI
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSidebar = new Panel();
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
            line0 = new Panel();
            btnSanPham = new Button();
            btnThoat = new Button();
            panelHeader = new Panel();
            lblTime = new Label();
            lblTitle = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            lblUserStatus = new ToolStripStatusLabel();
            panelSidebar.SuspendLayout();
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
            panelSidebar.Controls.Add(line0);
            panelSidebar.Controls.Add(btnSanPham);
            panelSidebar.Controls.Add(btnThoat);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(333, 1055);
            panelSidebar.TabIndex = 0;
            // 
            // line5
            // 
            line5.BackColor = Color.SlateBlue;
            line5.Dock = DockStyle.Top;
            line5.Location = new Point(0, 562);
            line5.Margin = new Padding(4, 5, 4, 5);
            line5.Name = "line5";
            line5.Size = new Size(333, 2);
            line5.TabIndex = 13;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.MidnightBlue;
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            btnDangXuat.ForeColor = Color.OrangeRed;
            btnDangXuat.Location = new Point(0, 470);
            btnDangXuat.Margin = new Padding(4, 5, 4, 5);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(27, 0, 0, 0);
            btnDangXuat.Size = new Size(333, 92);
            btnDangXuat.TabIndex = 6;
            btnDangXuat.Text = "Đăng xuất / Đổi MK";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // line4
            // 
            line4.BackColor = Color.SlateBlue;
            line4.Dock = DockStyle.Top;
            line4.Location = new Point(0, 468);
            line4.Margin = new Padding(4, 5, 4, 5);
            line4.Name = "line4";
            line4.Size = new Size(333, 2);
            line4.TabIndex = 12;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.MidnightBlue;
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(0, 376);
            btnThongKe.Margin = new Padding(4, 5, 4, 5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(27, 0, 0, 0);
            btnThongKe.Size = new Size(333, 92);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống kê doanh thu";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // line3
            // 
            line3.BackColor = Color.SlateBlue;
            line3.Dock = DockStyle.Top;
            line3.Location = new Point(0, 374);
            line3.Margin = new Padding(4, 5, 4, 5);
            line3.Name = "line3";
            line3.Size = new Size(333, 2);
            line3.TabIndex = 11;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.MidnightBlue;
            btnBanHang.Cursor = Cursors.Hand;
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBanHang.ForeColor = Color.Transparent;
            btnBanHang.Location = new Point(0, 282);
            btnBanHang.Margin = new Padding(4, 5, 4, 5);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(27, 0, 0, 0);
            btnBanHang.Size = new Size(333, 92);
            btnBanHang.TabIndex = 4;
            btnBanHang.Text = "Quản lý bán hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // line2
            // 
            line2.BackColor = Color.SlateBlue;
            line2.Dock = DockStyle.Top;
            line2.Location = new Point(0, 280);
            line2.Margin = new Padding(4, 5, 4, 5);
            line2.Name = "line2";
            line2.Size = new Size(333, 2);
            line2.TabIndex = 10;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.MidnightBlue;
            btnKhachHang.Cursor = Cursors.Hand;
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Location = new Point(0, 188);
            btnKhachHang.Margin = new Padding(4, 5, 4, 5);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(27, 0, 0, 0);
            btnKhachHang.Size = new Size(333, 92);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "Quản lý Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // line1
            // 
            line1.BackColor = Color.SlateBlue;
            line1.Dock = DockStyle.Top;
            line1.Location = new Point(0, 186);
            line1.Margin = new Padding(4, 5, 4, 5);
            line1.Name = "line1";
            line1.Size = new Size(333, 2);
            line1.TabIndex = 9;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.MidnightBlue;
            btnNhanVien.Cursor = Cursors.Hand;
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(0, 94);
            btnNhanVien.Margin = new Padding(4, 5, 4, 5);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(27, 0, 0, 0);
            btnNhanVien.Size = new Size(333, 92);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "Quản lý Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // line0
            // 
            line0.BackColor = Color.SlateBlue;
            line0.Dock = DockStyle.Top;
            line0.Location = new Point(0, 92);
            line0.Margin = new Padding(4, 5, 4, 5);
            line0.Name = "line0";
            line0.Size = new Size(333, 2);
            line0.TabIndex = 8;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.MidnightBlue;
            btnSanPham.Cursor = Cursors.Hand;
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.Location = new Point(0, 0);
            btnSanPham.Margin = new Padding(4, 5, 4, 5);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(27, 0, 0, 0);
            btnSanPham.Size = new Size(333, 92);
            btnSanPham.TabIndex = 1;
            btnSanPham.Text = "Quản lý Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += mnuSanPham_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.MidnightBlue;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Dock = DockStyle.Bottom;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseDownBackColor = Color.Red;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(0, 963);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(27, 0, 0, 0);
            btnThoat.Size = new Size(333, 92);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát chương trình";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += mnuThoat_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblTime);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(333, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1200, 92);
            panelHeader.TabIndex = 1;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.ForeColor = Color.Gray;
            lblTime.Location = new Point(1000, 31);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.TabIndex = 1;
            lblTime.Text = "00:00:00";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(27, 28);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "DASHBOARD HỆ THỐNG";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUserStatus });
            statusStrip1.Location = new Point(333, 1029);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 19, 0);
            statusStrip1.Size = new Size(1200, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUserStatus
            // 
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(126, 20);
            lblUserStatus.Text = "Nhân viên: Admin";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1533, 1055);
            Controls.Add(statusStrip1);
            Controls.Add(panelHeader);
            Controls.Add(panelSidebar);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý NganShop";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            panelSidebar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserStatus;

        // Các nút bấm
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThoat;

        // Các đường kẻ ngăn cách (Panel)
        private System.Windows.Forms.Panel line0;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Panel line4;
        private System.Windows.Forms.Panel line5;
    }
}
namespace QuanLyShopQuanAo.GUI
{
    partial class frmNhanVien
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
            panelTop = new Panel();
            labelHeader = new Label();
            grpThongTin = new GroupBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            txtMatKhau = new TextBox();
            label4 = new Label();
            txtTaiKhoan = new TextBox();
            label3 = new Label();
            txtTenNV = new TextBox();
            label2 = new Label();
            txtMaNV = new TextBox();
            label1 = new Label();
            panelButtons = new Panel();
            btnDong = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvNhanVien = new DataGridView();
            colMaNV = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colTaiKhoan = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            grpThongTin.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(41, 128, 185);
            panelTop.Controls.Add(labelHeader);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1184, 80);
            panelTop.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1184, 80);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "👥 QUẢN LÝ NHÂN VIÊN";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(rdoNu);
            grpThongTin.Controls.Add(rdoNam);
            grpThongTin.Controls.Add(label6);
            grpThongTin.Controls.Add(label5);
            grpThongTin.Controls.Add(txtMatKhau);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(txtTaiKhoan);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(txtTenNV);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(txtMaNV);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Dock = DockStyle.Top;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(0, 80);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1184, 210);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin chi tiết";
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = Color.FromArgb(236, 240, 241);
            txtMaNV.Location = new Point(170, 40);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(250, 30);
            txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(170, 95);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(250, 30);
            txtTenNV.TabIndex = 3;
            // 
            // rdoNam
            // 
            rdoNam.Location = new Point(170, 155);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(70, 27);
            rdoNam.TabIndex = 10;
            rdoNam.Text = "Nam";
            // 
            // rdoNu
            // 
            rdoNu.Location = new Point(260, 155);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(70, 27);
            rdoNu.TabIndex = 11;
            rdoNu.Text = "Nữ";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(650, 40);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(250, 30);
            txtTaiKhoan.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(650, 95);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(250, 30);
            txtMatKhau.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(650, 155);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 30);
            dtpNgaySinh.TabIndex = 12;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            panelButtons.Controls.Add(btnDong);
            panelButtons.Controls.Add(btnBoQua);
            panelButtons.Controls.Add(btnLuu);
            panelButtons.Controls.Add(btnXoa);
            panelButtons.Controls.Add(btnSua);
            panelButtons.Controls.Add(btnThem);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 711);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1184, 100);
            panelButtons.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(41, 128, 185);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(30, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(130, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(243, 156, 18);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(180, 25);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(130, 50);
            btnSua.TabIndex = 1;
            btnSua.Text = "📝 Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 57, 43);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(330, 25);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(130, 50);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(39, 174, 96);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(550, 25);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(130, 50);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "💾 Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.BackColor = Color.FromArgb(127, 140, 141);
            btnBoQua.FlatAppearance.BorderSize = 0;
            btnBoQua.FlatStyle = FlatStyle.Flat;
            btnBoQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBoQua.ForeColor = Color.White;
            btnBoQua.Location = new Point(700, 25);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(130, 50);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "🔄 Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = false;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(44, 62, 80);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(1020, 25);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(130, 50);
            btnDong.TabIndex = 5;
            btnDong.Text = "❌ Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaNV, colTenNV, colGioiTinh, colTaiKhoan, colNgaySinh });
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 290);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1184, 421);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellDoubleClick += dgvNhanVien_CellDoubleClick;
            // 
            // colMaNV
            // 
            colMaNV.HeaderText = "Mã NV";
            colMaNV.Name = "colMaNV";
            // 
            // colTenNV
            // 
            colTenNV.HeaderText = "Họ Tên";
            colTenNV.Name = "colTenNV";
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.Name = "colGioiTinh";
            // 
            // colTaiKhoan
            // 
            colTaiKhoan.HeaderText = "Tài Khoản";
            colTaiKhoan.Name = "colTaiKhoan";
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.Name = "colNgaySinh";
            // 
            // label1-6 (Khai báo Label giao diện)
            label1.Text = "Mã nhân viên"; label1.Location = new Point(40, 45); label1.Font = new Font("Segoe UI", 10F);
            label2.Text = "Tên nhân viên"; label2.Location = new Point(40, 100); label2.Font = new Font("Segoe UI", 10F);
            label3.Text = "Tài khoản"; label3.Location = new Point(530, 45); label3.Font = new Font("Segoe UI", 10F);
            label4.Text = "Mật khẩu"; label4.Location = new Point(530, 100); label4.Font = new Font("Segoe UI", 10F);
            label5.Text = "Giới tính"; label5.Location = new Point(40, 155); label5.Font = new Font("Segoe UI", 10F);
            label6.Text = "Ngày sinh"; label6.Location = new Point(530, 155); label6.Font = new Font("Segoe UI", 10F);
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 811);
            Controls.Add(dgvNhanVien);
            Controls.Add(panelButtons);
            Controls.Add(grpThongTin);
            Controls.Add(panelTop);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += frmNhanVien_Load;
            panelTop.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelHeader;
        private GroupBox grpThongTin;
        private Panel panelButtons;
        private DataGridView dgvNhanVien;
        private TextBox txtMaNV;
        private Label label1;
        private TextBox txtTenNV;
        private Label label2;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label5;
        private TextBox txtMatKhau;
        private Label label4;
        private TextBox txtTaiKhoan;
        private Label label3;
        private DateTimePicker dtpNgaySinh;
        private Label label6;
        private Button btnDong;
        private Button btnBoQua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn colMaNV;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colTaiKhoan;
        private DataGridViewTextBoxColumn colNgaySinh;
    }
}
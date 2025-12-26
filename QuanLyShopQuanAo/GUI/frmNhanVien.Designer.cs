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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            labelHeader = new Label();
            grpThongTin = new GroupBox();
            cboChucVu = new ComboBox();
            labelChucVu = new Label();
            txtSDT = new TextBox();
            labelSDT = new Label();
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
            colSDT = new DataGridViewTextBoxColumn();
            colChucVu = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colTaiKhoan = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            grpThongTin.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(45, 45, 48);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.BackColor = Color.MidnightBlue;
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelHeader.ForeColor = Color.Gainsboro;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1184, 80);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "QUẢN LÝ NHÂN VIÊN";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            labelHeader.Click += labelHeader_Click;
            // 
            // grpThongTin
            // 
            grpThongTin.BackColor = Color.White;
            grpThongTin.Controls.Add(cboChucVu);
            grpThongTin.Controls.Add(labelChucVu);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(labelSDT);
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
            grpThongTin.Size = new Size(1184, 215);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin chi tiết";
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboChucVu.Location = new Point(945, 42);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(180, 31);
            cboChucVu.TabIndex = 20;
            // 
            // labelChucVu
            // 
            labelChucVu.Font = new Font("Segoe UI", 10F);
            labelChucVu.Location = new Point(855, 45);
            labelChucVu.Name = "labelChucVu";
            labelChucVu.Size = new Size(80, 23);
            labelChucVu.TabIndex = 21;
            labelChucVu.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(170, 150);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(250, 30);
            txtSDT.TabIndex = 3;
            // 
            // labelSDT
            // 
            labelSDT.Font = new Font("Segoe UI", 10F);
            labelSDT.Location = new Point(40, 155);
            labelSDT.Name = "labelSDT";
            labelSDT.Size = new Size(120, 23);
            labelSDT.TabIndex = 19;
            labelSDT.Text = "Số điện thoại";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(580, 150);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(230, 30);
            dtpNgaySinh.TabIndex = 6;
            // 
            // rdoNu
            // 
            rdoNu.Location = new Point(1020, 100);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(70, 27);
            rdoNu.TabIndex = 8;
            rdoNu.Text = "Nữ";
            // 
            // rdoNam
            // 
            rdoNam.Location = new Point(945, 100);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(70, 27);
            rdoNam.TabIndex = 7;
            rdoNam.Text = "Nam";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(470, 155);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 13;
            label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(855, 103);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 14;
            label5.Text = "Giới tính";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(580, 95);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '●';
            txtMatKhau.Size = new Size(230, 30);
            txtMatKhau.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(470, 100);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 15;
            label4.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(580, 40);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(230, 30);
            txtTaiKhoan.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(470, 45);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 16;
            label3.Text = "Tài khoản";
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(170, 95);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(250, 30);
            txtTenNV.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 100);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 17;
            label2.Text = "Tên nhân viên";
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(40, 45);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 18;
            label1.Text = "Mã nhân viên";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(240, 240, 242);
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
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(45, 45, 48);
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
            // btnBoQua
            // 
            btnBoQua.BackColor = Color.FromArgb(127, 140, 141);
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
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(39, 174, 96);
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
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 57, 43);
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
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(243, 156, 18);
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
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(45, 45, 48);
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
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 40;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaNV, colTenNV, colSDT, colChucVu, colGioiTinh, colTaiKhoan, colNgaySinh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(0, 295);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1184, 416);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            dgvNhanVien.CellDoubleClick += dgvNhanVien_CellDoubleClick;
            // 
            // colMaNV
            // 
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            // 
            // colTenNV
            // 
            colTenNV.HeaderText = "Họ Tên";
            colTenNV.MinimumWidth = 6;
            colTenNV.Name = "colTenNV";
            colTenNV.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.HeaderText = "Số điện thoại";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colChucVu
            // 
            colChucVu.HeaderText = "Chức vụ";
            colChucVu.MinimumWidth = 6;
            colChucVu.Name = "colChucVu";
            colChucVu.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colTaiKhoan
            // 
            colTaiKhoan.HeaderText = "Tài khoản";
            colTaiKhoan.MinimumWidth = 6;
            colTaiKhoan.Name = "colTaiKhoan";
            colTaiKhoan.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 811);
            Controls.Add(dgvNhanVien);
            Controls.Add(panelButtons);
            Controls.Add(grpThongTin);
            Controls.Add(panelHeader);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += frmNhanVien_Load;
            panelHeader.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label labelChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
    }
}
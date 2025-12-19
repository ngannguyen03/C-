namespace QuanLyShopQuanAo.GUI
{
    partial class frmKhachHang
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
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtDienThoai = new TextBox();
            label3 = new Label();
            txtTenKH = new TextBox();
            label2 = new Label();
            txtMaKH = new TextBox();
            label1 = new Label();
            panelButtons = new Panel();
            btnDong = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvKhachHang = new DataGridView();
            colMaKH = new DataGridViewTextBoxColumn();
            colTenKH = new DataGridViewTextBoxColumn();
            colDienThoai = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            grpThongTin.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(41, 128, 185);
            panelTop.Controls.Add(labelHeader);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1179, 80);
            panelTop.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1179, 80);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "🤝 QUẢN LÝ KHÁCH HÀNG";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtDiaChi);
            grpThongTin.Controls.Add(label4);
            grpThongTin.Controls.Add(txtDienThoai);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(txtTenKH);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(txtMaKH);
            grpThongTin.Controls.Add(label1);
            grpThongTin.Dock = DockStyle.Top;
            grpThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpThongTin.Location = new Point(0, 80);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(1179, 180);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(693, 108);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(332, 30);
            txtDiaChi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(573, 112);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 6;
            label4.Text = "Địa chỉ";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 10F);
            txtDienThoai.Location = new Point(693, 46);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(332, 30);
            txtDienThoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(573, 51);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 4;
            label3.Text = "Điện thoại";
            // 
            // txtTenKH
            // 
            txtTenKH.Font = new Font("Segoe UI", 10F);
            txtTenKH.Location = new Point(173, 108);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(265, 30);
            txtTenKH.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 112);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên KH";
            // 
            // txtMaKH
            // 
            txtMaKH.BackColor = Color.FromArgb(236, 240, 241);
            txtMaKH.Font = new Font("Segoe UI", 10F);
            txtMaKH.Location = new Point(173, 46);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.ReadOnly = true;
            txtMaKH.Size = new Size(265, 30);
            txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(40, 51);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã KH";
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
            panelButtons.Location = new Point(0, 740);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1179, 123);
            panelButtons.TabIndex = 2;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(44, 62, 80);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(1000, 38);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(133, 46);
            btnDong.TabIndex = 5;
            btnDong.Text = "❌ Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.BackColor = Color.FromArgb(127, 140, 141);
            btnBoQua.FlatAppearance.BorderSize = 0;
            btnBoQua.FlatStyle = FlatStyle.Flat;
            btnBoQua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBoQua.ForeColor = Color.White;
            btnBoQua.Location = new Point(800, 38);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(133, 46);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "🔄 Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = false;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(39, 174, 96);
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(600, 38);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(133, 46);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "💾 Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 57, 43);
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(400, 38);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 46);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(243, 156, 18);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(200, 38);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 46);
            btnSua.TabIndex = 1;
            btnSua.Text = "📝 Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(41, 128, 185);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(27, 38);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 46);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = Color.White;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colMaKH, colTenKH, colDienThoai, colDiaChi });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 260);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1179, 480);
            dgvKhachHang.TabIndex = 3;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
            // 
            // colMaKH
            // 
            colMaKH.HeaderText = "Mã KH";
            colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            colTenKH.HeaderText = "Họ Tên";
            colTenKH.Name = "colTenKH";
            // 
            // colDienThoai
            // 
            colDienThoai.HeaderText = "Điện Thoại";
            colDienThoai.Name = "colDienThoai";
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.Name = "colDiaChi";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1179, 863);
            Controls.Add(dgvKhachHang);
            Controls.Add(panelButtons);
            Controls.Add(grpThongTin);
            Controls.Add(panelTop);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý khách hàng";
            Load += frmKhachHang_Load;
            panelTop.ResumeLayout(false);
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}
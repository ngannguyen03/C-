namespace QuanLyShopQuanAo.GUI
{
    partial class frmSanPham
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtSoLuong = new TextBox();
            label5 = new Label();
            txtDonGia = new TextBox();
            label4 = new Label();
            txtTenSP = new TextBox();
            label3 = new Label();
            txtMaSP = new TextBox();
            label2 = new Label();
            panelButton = new Panel();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnDong = new Button();
            btnBoQua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dgvSanPham = new DataGridView();
            colMaSP = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            groupBox1.SuspendLayout();
            panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(41, 128, 185);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4, 5, 4, 5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1179, 77);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1179, 77);
            label1.TabIndex = 0;
            label1.Text = "📦 QUẢN LÝ DANH MỤC SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenSP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaSP);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 77);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1179, 167);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 10F);
            txtSoLuong.Location = new Point(733, 108);
            txtSoLuong.Margin = new Padding(4, 5, 4, 5);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(265, 30);
            txtSoLuong.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(613, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 6;
            label5.Text = "Số lượng";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 10F);
            txtDonGia.Location = new Point(733, 46);
            txtDonGia.Margin = new Padding(4, 5, 4, 5);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(265, 30);
            txtDonGia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(613, 51);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 4;
            label4.Text = "Đơn giá";
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Segoe UI", 10F);
            txtTenSP.Location = new Point(173, 108);
            txtTenSP.Margin = new Padding(4, 5, 4, 5);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(265, 30);
            txtTenSP.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(40, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Segoe UI", 10F);
            txtMaSP.Location = new Point(173, 46);
            txtMaSP.Margin = new Padding(4, 5, 4, 5);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(265, 30);
            txtMaSP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã sản phẩm";
            // 
            // panelButton
            // 
            panelButton.BackColor = Color.FromArgb(236, 240, 241);
            panelButton.Controls.Add(txtTimKiem);
            panelButton.Controls.Add(btnTimKiem);
            panelButton.Controls.Add(btnDong);
            panelButton.Controls.Add(btnBoQua);
            panelButton.Controls.Add(btnLuu);
            panelButton.Controls.Add(btnXoa);
            panelButton.Controls.Add(btnSua);
            panelButton.Controls.Add(btnThem);
            panelButton.Dock = DockStyle.Bottom;
            panelButton.Location = new Point(0, 709);
            panelButton.Margin = new Padding(4, 5, 4, 5);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(1179, 154);
            panelButton.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(45, 23);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(265, 30);
            txtTimKiem.TabIndex = 7;
            txtTimKiem.Text = "Nhập tên sản phẩm...";
            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(22, 160, 133);
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(320, 20);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 36);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "🔍 Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(44, 62, 80);
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(1000, 77);
            btnDong.Margin = new Padding(4, 5, 4, 5);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(133, 54);
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
            btnBoQua.Location = new Point(840, 77);
            btnBoQua.Margin = new Padding(4, 5, 4, 5);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(133, 54);
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
            btnLuu.Location = new Point(680, 77);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(133, 54);
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
            btnXoa.Location = new Point(360, 77);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 54);
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
            btnSua.Location = new Point(200, 77);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 54);
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
            btnThem.Location = new Point(40, 77);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 54);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colMaSP, colTenSP, colSoLuong, colDonGia });
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 244);
            dgvSanPham.Margin = new Padding(4, 5, 4, 5);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(1179, 465);
            dgvSanPham.TabIndex = 3;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // colMaSP
            // 
            colMaSP.HeaderText = "Mã SP";
            colMaSP.MinimumWidth = 6;
            colMaSP.Name = "colMaSP";
            // 
            // colTenSP
            // 
            colTenSP.HeaderText = "Tên Sản Phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            // 
            // colSoLuong
            // 
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            colDonGia.HeaderText = "Đơn Giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1179, 863);
            Controls.Add(dgvSanPham);
            Controls.Add(panelButton);
            Controls.Add(groupBox1);
            Controls.Add(panelTop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý sản phẩm";
            Load += frmSanPham_Load;
            panelTop.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelButton.ResumeLayout(false);
            panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
    }
}
namespace QuanLyShopQuanAo.GUI
{
    partial class frmDanhMuc
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
            panelTop = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTenDM = new TextBox();
            label3 = new Label();
            txtMaDM = new TextBox();
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
            dgvDanhMuc = new DataGridView();
            colMaDM = new DataGridViewTextBoxColumn();
            colTenDM = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            groupBox1.SuspendLayout();
            panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.MidnightBlue;
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1179, 77);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1179, 77);
            label1.TabIndex = 0;
            label1.Text = "📂 QUẢN LÝ DANH MỤC SẢN PHẨM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTenDM);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaDM);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1179, 130);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtTenDM
            // 
            txtTenDM.Font = new Font("Segoe UI", 10F);
            txtTenDM.Location = new Point(173, 85);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(400, 30);
            txtTenDM.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(40, 89);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên danh mục";
            // 
            // txtMaDM
            // 
            txtMaDM.BackColor = Color.FromArgb(236, 240, 241);
            txtMaDM.Font = new Font("Segoe UI", 10F);
            txtMaDM.Location = new Point(173, 40);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.ReadOnly = true;
            txtMaDM.Size = new Size(265, 30);
            txtMaDM.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(40, 45);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã danh mục";
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
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(1179, 154);
            panelButton.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Location = new Point(45, 23);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(265, 30);
            txtTimKiem.TabIndex = 10;
            txtTimKiem.Text = "Nhập tên danh mục...";
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
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 36);
            btnTimKiem.TabIndex = 11;
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
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(133, 54);
            btnDong.TabIndex = 9;
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
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(133, 54);
            btnBoQua.TabIndex = 8;
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
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(133, 54);
            btnLuu.TabIndex = 7;
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
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(133, 54);
            btnXoa.TabIndex = 6;
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
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(133, 54);
            btnSua.TabIndex = 5;
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
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(133, 54);
            btnThem.TabIndex = 4;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.BackgroundColor = Color.White;
            dgvDanhMuc.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhMuc.ColumnHeadersHeight = 40;
            dgvDanhMuc.Columns.AddRange(new DataGridViewColumn[] { colMaDM, colTenDM });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhMuc.Dock = DockStyle.Fill;
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.Location = new Point(0, 207);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersVisible = false;
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.Size = new Size(1179, 502);
            dgvDanhMuc.TabIndex = 3;
            dgvDanhMuc.CellClick += dgvDanhMuc_CellClick;
            // 
            // colMaDM
            // 
            colMaDM.HeaderText = "Mã Danh Mục";
            colMaDM.MinimumWidth = 6;
            colMaDM.Name = "colMaDM";
            // 
            // colTenDM
            // 
            colTenDM.HeaderText = "Tên Danh Mục";
            colTenDM.MinimumWidth = 6;
            colTenDM.Name = "colTenDM";
            // 
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1179, 863);
            Controls.Add(dgvDanhMuc);
            Controls.Add(panelButton);
            Controls.Add(groupBox1);
            Controls.Add(panelTop);
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống quản lý danh mục";
            Load += frmDanhMuc_Load;
            panelTop.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelButton.ResumeLayout(false);
            panelButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDM;
    }
}
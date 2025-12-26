namespace QuanLyShopQuanAo.GUI
{
    partial class frmBanHang
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
            panelTop = new Panel();
            labelHeader = new Label();
            groupBox1 = new GroupBox();
            cboKhachHang = new ComboBox();
            label5 = new Label();
            cboNhanVien = new ComboBox();
            label4 = new Label();
            dtpNgayBan = new DateTimePicker();
            label3 = new Label();
            txtMaHDBan = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvHDBanHang = new DataGridView();
            colMa = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colSL = new DataGridViewTextBoxColumn();
            colDG = new DataGridViewTextBoxColumn();
            colTT = new DataGridViewTextBoxColumn();
            colTT_Raw = new DataGridViewTextBoxColumn();
            panelTotal = new Panel();
            lblTongTien = new Label();
            label10 = new Label();
            panelMatHang = new Panel();
            btnThemSP = new Button();
            txtThanhTien = new TextBox();
            label9 = new Label();
            txtDonGia = new TextBox();
            label8 = new Label();
            txtTenSP = new TextBox();
            label7 = new Label();
            txtSoLuong = new TextBox();
            label6 = new Label();
            cboMaSP = new ComboBox();
            label1 = new Label();
            panelButtons = new Panel();
            btnDong = new Button();
            btnInHoaDon = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnThemMoi = new Button();
            panelTop.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).BeginInit();
            panelTotal.SuspendLayout();
            panelMatHang.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Navy;
            panelTop.Controls.Add(labelHeader);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1282, 70);
            panelTop.TabIndex = 0;
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Fill;
            labelHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(0, 0);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(1282, 70);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "HÓA ĐƠN BÁN HÀNG";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpNgayBan);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMaHDBan);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1282, 140);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Location = new Point(590, 82);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(250, 31);
            cboKhachHang.TabIndex = 2;
            // 
            // label5
            // 
            label5.Location = new Point(480, 85);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 0;
            label5.Text = "Khách hàng:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.Location = new Point(590, 37);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(250, 31);
            cboNhanVien.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(480, 40);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 0;
            label4.Text = "Nhân viên:";
            // 
            // dtpNgayBan
            // 
            dtpNgayBan.Format = DateTimePickerFormat.Short;
            dtpNgayBan.Location = new Point(140, 82);
            dtpNgayBan.Name = "dtpNgayBan";
            dtpNgayBan.Size = new Size(250, 30);
            dtpNgayBan.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(30, 85);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 0;
            label3.Text = "Ngày bán:";
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.BackColor = Color.FromArgb(236, 240, 241);
            txtMaHDBan.Location = new Point(140, 37);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.ReadOnly = true;
            txtMaHDBan.Size = new Size(250, 30);
            txtMaHDBan.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(30, 40);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDBanHang);
            groupBox2.Controls.Add(panelTotal);
            groupBox2.Controls.Add(panelMatHang);
            groupBox2.Controls.Add(panelButtons);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(0, 210);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1282, 543);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHDBanHang.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHDBanHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHDBanHang.ColumnHeadersHeight = 35;
            dgvHDBanHang.Columns.AddRange(new DataGridViewColumn[] { colMa, colTen, colSL, colDG, colTT, colTT_Raw });
            dgvHDBanHang.Dock = DockStyle.Fill;
            dgvHDBanHang.EnableHeadersVisualStyles = false;
            dgvHDBanHang.Location = new Point(3, 136);
            dgvHDBanHang.Name = "dgvHDBanHang";
            dgvHDBanHang.ReadOnly = true;
            dgvHDBanHang.RowHeadersVisible = false;
            dgvHDBanHang.RowHeadersWidth = 51;
            dgvHDBanHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHDBanHang.Size = new Size(1276, 263);
            dgvHDBanHang.TabIndex = 0;
            // 
            // colMa
            // 
            colMa.HeaderText = "Mã sản phẩm";
            colMa.MinimumWidth = 6;
            colMa.Name = "colMa";
            colMa.ReadOnly = true;
            // 
            // colTen
            // 
            colTen.HeaderText = "Tên sản phẩm";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            colTen.ReadOnly = true;
            // 
            // colSL
            // 
            colSL.HeaderText = "Số lượng";
            colSL.MinimumWidth = 6;
            colSL.Name = "colSL";
            colSL.ReadOnly = true;
            // 
            // colDG
            // 
            colDG.HeaderText = "Đơn giá";
            colDG.MinimumWidth = 6;
            colDG.Name = "colDG";
            colDG.ReadOnly = true;
            // 
            // colTT
            // 
            colTT.HeaderText = "Thành tiền";
            colTT.MinimumWidth = 6;
            colTT.Name = "colTT";
            colTT.ReadOnly = true;
            // 
            // colTT_Raw
            // 
            colTT_Raw.HeaderText = "TT_Raw";
            colTT_Raw.MinimumWidth = 6;
            colTT_Raw.Name = "colTT_Raw";
            colTT_Raw.ReadOnly = true;
            colTT_Raw.Visible = false;
            // 
            // panelTotal
            // 
            panelTotal.BackColor = Color.FromArgb(236, 240, 241);
            panelTotal.Controls.Add(lblTongTien);
            panelTotal.Controls.Add(label10);
            panelTotal.Dock = DockStyle.Bottom;
            panelTotal.Location = new Point(3, 399);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(1276, 60);
            panelTotal.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(160, 10);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(109, 41);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "0 VNĐ";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(20, 18);
            label10.Name = "label10";
            label10.Size = new Size(130, 23);
            label10.TabIndex = 0;
            label10.Text = "TỔNG CỘNG:";
            // 
            // panelMatHang
            // 
            panelMatHang.BackColor = Color.White;
            panelMatHang.Controls.Add(btnThemSP);
            panelMatHang.Controls.Add(txtThanhTien);
            panelMatHang.Controls.Add(label9);
            panelMatHang.Controls.Add(txtDonGia);
            panelMatHang.Controls.Add(label8);
            panelMatHang.Controls.Add(txtTenSP);
            panelMatHang.Controls.Add(label7);
            panelMatHang.Controls.Add(txtSoLuong);
            panelMatHang.Controls.Add(label6);
            panelMatHang.Controls.Add(cboMaSP);
            panelMatHang.Controls.Add(label1);
            panelMatHang.Dock = DockStyle.Top;
            panelMatHang.Location = new Point(3, 26);
            panelMatHang.Name = "panelMatHang";
            panelMatHang.Size = new Size(1276, 110);
            panelMatHang.TabIndex = 0;
            // 
            // btnThemSP
            // 
            btnThemSP.BackColor = Color.FromArgb(41, 128, 185);
            btnThemSP.FlatStyle = FlatStyle.Flat;
            btnThemSP.ForeColor = Color.White;
            btnThemSP.Location = new Point(1080, 35);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(160, 50);
            btnThemSP.TabIndex = 4;
            btnThemSP.Text = "\U0001f6d2 Thêm hàng";
            btnThemSP.UseVisualStyleBackColor = false;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.FromArgb(236, 240, 241);
            txtThanhTien.Location = new Point(880, 62);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(150, 30);
            txtThanhTien.TabIndex = 0;
            // 
            // label9
            // 
            label9.Location = new Point(780, 65);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 0;
            label9.Text = "Thành tiền:";
            // 
            // txtDonGia
            // 
            txtDonGia.BackColor = Color.FromArgb(236, 240, 241);
            txtDonGia.Location = new Point(580, 62);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(150, 30);
            txtDonGia.TabIndex = 0;
            // 
            // label8
            // 
            label8.Location = new Point(480, 65);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            label8.Text = "Đơn giá:";
            // 
            // txtTenSP
            // 
            txtTenSP.BackColor = Color.FromArgb(236, 240, 241);
            txtTenSP.Location = new Point(580, 12);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.ReadOnly = true;
            txtTenSP.Size = new Size(250, 30);
            txtTenSP.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(480, 15);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            label7.Text = "Tên hàng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(140, 62);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(100, 30);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.TextChanged += TxtSoLuong_TextChanged;
            // 
            // label6
            // 
            label6.Location = new Point(20, 65);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            label6.Text = "Số lượng:";
            // 
            // cboMaSP
            // 
            cboMaSP.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaSP.Location = new Point(140, 12);
            cboMaSP.Name = "cboMaSP";
            cboMaSP.Size = new Size(300, 31);
            cboMaSP.TabIndex = 0;
            cboMaSP.SelectedIndexChanged += cboMaSP_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 0;
            label1.Text = "Chọn sản phẩm:";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.White;
            panelButtons.Controls.Add(btnDong);
            panelButtons.Controls.Add(btnInHoaDon);
            panelButtons.Controls.Add(btnLuu);
            panelButtons.Controls.Add(btnXoa);
            panelButtons.Controls.Add(btnThemMoi);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(3, 459);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1276, 81);
            panelButtons.TabIndex = 3;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.FromArgb(44, 62, 80);
            btnDong.FlatStyle = FlatStyle.Flat;
            btnDong.ForeColor = Color.White;
            btnDong.Location = new Point(1110, 15);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(140, 50);
            btnDong.TabIndex = 4;
            btnDong.Text = "❌ Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.FromArgb(243, 156, 18);
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.ForeColor = Color.White;
            btnInHoaDon.Location = new Point(500, 15);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(150, 50);
            btnInHoaDon.TabIndex = 3;
            btnInHoaDon.Text = "🖨️ In ";
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(39, 174, 96);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(340, 15);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 50);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "💾 Lưu ";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 57, 43);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(180, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 50);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "🗑️ Hủy ";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.FromArgb(41, 128, 185);
            btnThemMoi.FlatStyle = FlatStyle.Flat;
            btnThemMoi.ForeColor = Color.White;
            btnThemMoi.Location = new Point(20, 15);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(150, 50);
            btnThemMoi.TabIndex = 0;
            btnThemMoi.Text = "➕ New";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panelTop);
            Name = "frmBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Bán hàng";
            Load += frmBanHang_Load;
            panelTop.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).EndInit();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelMatHang.ResumeLayout(false);
            panelMatHang.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panelMatHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboMaSP;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDong, btnInHoaDon, btnLuu, btnXoa, btnThemMoi;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTT_Raw;
    }
}
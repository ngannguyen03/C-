namespace QuanLyShopQuanAo.GUI
{
    partial class frmThongKe
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
            panelHeader = new Panel();
            label1 = new Label();
            panelFilter = new Panel();
            btnThongKe = new Button();
            dtpDenNgay = new DateTimePicker();
            label3 = new Label();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            panelCards = new Panel();
            panelCard3 = new Panel();
            lblSoLuong = new Label();
            label8 = new Label();
            panelCard2 = new Panel();
            lblDonHang = new Label();
            label6 = new Label();
            panelCard1 = new Panel();
            lblDoanhThu = new Label();
            label4 = new Label();
            dgvThongKe = new DataGridView();
            panelHeader.SuspendLayout();
            panelFilter.SuspendLayout();
            panelCards.SuspendLayout();
            panelCard3.SuspendLayout();
            panelCard2.SuspendLayout();
            panelCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.DodgerBlue;
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(4, 5, 4, 5);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1189, 77);
            panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Dock = DockStyle.Fill;
            label1.Enabled = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1189, 77);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ DOANH THU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.Controls.Add(btnThongKe);
            panelFilter.Controls.Add(dtpDenNgay);
            panelFilter.Controls.Add(label3);
            panelFilter.Controls.Add(dtpTuNgay);
            panelFilter.Controls.Add(label2);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 77);
            panelFilter.Margin = new Padding(4, 5, 4, 5);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(1189, 82);
            panelFilter.TabIndex = 1;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.DodgerBlue;
            btnThongKe.Cursor = Cursors.Hand;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(733, 23);
            btnThongKe.Margin = new Padding(4, 5, 4, 5);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(177, 49);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Xem Thống Kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(507, 29);
            dtpDenNgay.Margin = new Padding(4, 5, 4, 5);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(159, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(400, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 2;
            label3.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(200, 29);
            dtpTuNgay.Margin = new Padding(4, 5, 4, 5);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(159, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(93, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 0;
            label2.Text = "Từ ngày";
            // 
            // panelCards
            // 
            panelCards.BackColor = Color.WhiteSmoke;
            panelCards.Controls.Add(panelCard3);
            panelCards.Controls.Add(panelCard2);
            panelCards.Controls.Add(panelCard1);
            panelCards.Dock = DockStyle.Top;
            panelCards.Location = new Point(0, 159);
            panelCards.Margin = new Padding(4, 5, 4, 5);
            panelCards.Name = "panelCards";
            panelCards.Padding = new Padding(27, 31, 27, 31);
            panelCards.Size = new Size(1189, 237);
            panelCards.TabIndex = 2;
            // 
            // panelCard3
            // 
            panelCard3.BackColor = Color.MediumPurple;
            panelCard3.Controls.Add(lblSoLuong);
            panelCard3.Controls.Add(label8);
            panelCard3.Location = new Point(827, 31);
            panelCard3.Margin = new Padding(4, 5, 4, 5);
            panelCard3.Name = "panelCard3";
            panelCard3.Size = new Size(333, 154);
            panelCard3.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            lblSoLuong.BackColor = Color.Crimson;
            lblSoLuong.Dock = DockStyle.Fill;
            lblSoLuong.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSoLuong.ForeColor = Color.White;
            lblSoLuong.Location = new Point(0, 46);
            lblSoLuong.Margin = new Padding(4, 0, 4, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(333, 108);
            lblSoLuong.TabIndex = 1;
            lblSoLuong.Text = "0";
            lblSoLuong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.Crimson;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(0, 0);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(333, 46);
            label8.TabIndex = 0;
            label8.Text = "Số Sản Phẩm Bán";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCard2
            // 
            panelCard2.BackColor = Color.DarkOrange;
            panelCard2.Controls.Add(lblDonHang);
            panelCard2.Controls.Add(label6);
            panelCard2.Location = new Point(433, 31);
            panelCard2.Margin = new Padding(4, 5, 4, 5);
            panelCard2.Name = "panelCard2";
            panelCard2.Size = new Size(333, 154);
            panelCard2.TabIndex = 1;
            // 
            // lblDonHang
            // 
            lblDonHang.Dock = DockStyle.Fill;
            lblDonHang.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDonHang.ForeColor = Color.White;
            lblDonHang.Location = new Point(0, 46);
            lblDonHang.Margin = new Padding(4, 0, 4, 0);
            lblDonHang.Name = "lblDonHang";
            lblDonHang.Size = new Size(333, 108);
            lblDonHang.TabIndex = 1;
            lblDonHang.Text = "0";
            lblDonHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(333, 46);
            label6.TabIndex = 0;
            label6.Text = "Số Đơn Hàng";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCard1
            // 
            panelCard1.BackColor = Color.SeaGreen;
            panelCard1.Controls.Add(lblDoanhThu);
            panelCard1.Controls.Add(label4);
            panelCard1.Location = new Point(40, 31);
            panelCard1.Margin = new Padding(4, 5, 4, 5);
            panelCard1.Name = "panelCard1";
            panelCard1.Size = new Size(333, 154);
            panelCard1.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.Dock = DockStyle.Fill;
            lblDoanhThu.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblDoanhThu.ForeColor = Color.White;
            lblDoanhThu.Location = new Point(0, 46);
            lblDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(333, 108);
            lblDoanhThu.TabIndex = 1;
            lblDoanhThu.Text = "0 đ";
            lblDoanhThu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(333, 46);
            label4.TabIndex = 0;
            label4.Text = "Tổng Doanh Thu";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvThongKe
            // 
            dgvThongKe.BackgroundColor = Color.White;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvThongKe.DefaultCellStyle = dataGridViewCellStyle1;
            dgvThongKe.Dock = DockStyle.Fill;
            dgvThongKe.Location = new Point(0, 396);
            dgvThongKe.Margin = new Padding(4, 5, 4, 5);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 51;
            dgvThongKe.Size = new Size(1189, 467);
            dgvThongKe.TabIndex = 3;
            // 
            // frmThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1189, 863);
            Controls.Add(dgvThongKe);
            Controls.Add(panelCards);
            Controls.Add(panelFilter);
            Controls.Add(panelHeader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmThongKe";
            Text = "Thống kê";
            Load += frmThongKe_Load;
            panelHeader.ResumeLayout(false);
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            panelCards.ResumeLayout(false);
            panelCard3.ResumeLayout(false);
            panelCard2.ResumeLayout(false);
            panelCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblDonHang;
        private System.Windows.Forms.Label label6;
    }
}
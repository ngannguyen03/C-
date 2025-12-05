using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Article06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện Click nút Cộng (+)
        private void btCong_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x + y;

                // Thêm kết quả vào Multiline Textbox với format đẹp
                string historyEntry = $"{x} + {y} = {kq}";
                AddToHistory(historyEntry);
            }
        }

        // Sự kiện Click nút Nhân (×)
        private void btNhan_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x * y;

                string historyEntry = $"{x} × {y} = {kq}";
                AddToHistory(historyEntry);
            }
        }

        // Sự kiện Click nút Trừ (-)
        private void btTru_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);
                int kq = x - y;

                string historyEntry = $"{x} - {y} = {kq}";
                AddToHistory(historyEntry);
            }
        }

        // Sự kiện Click nút Chia (/)
        private void btChia_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int x = int.Parse(tbSoX.Text);
                int y = int.Parse(tbSoY.Text);

                if (y == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double kq = (double)x / y;
                string historyEntry = $"{x} ÷ {y} = {kq:F2}"; // Làm tròn 2 số thập phân
                AddToHistory(historyEntry);
            }
        }

        // Sự kiện Click nút Lưu
        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text Files|*.txt|All Files|*.*";
                saveDialog.Title = "Lưu lịch sử tính toán";
                saveDialog.FileName = "Calculator_History.txt";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveDialog.FileName, tbKetQua.Text);
                    MessageBox.Show("Đã lưu lịch sử tính toán!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu file: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện Click nút Xóa
        private void btXoa_Click(object sender, EventArgs e)
        {
            tbSoX.Clear();
            tbSoY.Clear();
            tbKetQua.Clear();
            tbSoX.Focus(); // Đặt focus về ô nhập đầu tiên
        }

        // Sự kiện Click nút Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===== CÁC PHƯƠNG THỨC HỖ TRỢ =====

        // Kiểm tra input hợp lệ
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(tbSoX.Text) || string.IsNullOrEmpty(tbSoY.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ 2 số!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(tbSoX.Text, out _) || !int.TryParse(tbSoY.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Thêm kết quả vào history (Multiline Textbox)
        private void AddToHistory(string entry)
        {
            // Thêm timestamp
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            string formattedEntry = $"[{timestamp}] {entry}";

            // Thêm vào đầu hoặc cuối tùy chọn
            if (tbKetQua.Text.Length == 0)
                tbKetQua.Text = formattedEntry;
            else
                tbKetQua.AppendText(Environment.NewLine + formattedEntry);

            // Tự động scroll xuống cuối
            tbKetQua.SelectionStart = tbKetQua.Text.Length;
            tbKetQua.ScrollToCaret();
        }

        // Sự kiện KeyPress cho Textbox (chỉ cho phép số)
        private void tbSoX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu trừ ở đầu
            if (e.KeyChar == '-' && ((TextBox)sender).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void tbSoY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && ((TextBox)sender).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }
    }
}
using System;
using System.Windows.Forms;

namespace Article04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện KeyPress: Chỉ cho phép nhập số và phím điều khiển
        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép: số, phím điều khiển (Backspace = 8, Delete = 127)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho nhập ký tự này
            }
        }

        // Sự kiện Validating: Kiểm tra giá trị năm (KHÔNG ĐƯỢC LỚN HƠN 2025)
        private void tbYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbYear.Text))
            {
                try
                {
                    int year = int.Parse(tbYear.Text);
                    int currentYear = DateTime.Now.Year; // Lấy năm hiện tại

                    if (year > currentYear)
                    {
                        MessageBox.Show($"Năm sinh không được lớn hơn năm hiện tại ({currentYear})",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true; // Giữ focus tại textbox này
                        tbYear.SelectAll(); // Chọn toàn bộ text để sửa
                    }
                    else if (year < 1900) // Thêm kiểm tra năm quá cũ
                    {
                        MessageBox.Show("Năm sinh không hợp lệ (phải từ 1900 trở lên)",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                        tbYear.SelectAll();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Sự kiện Click nút Kiểm tra (CÓ THỂ THÊM KIỂM TRA TUỔI)
        private void btCheck_Click(object sender, EventArgs e)
        {
            string message = "";

            if (string.IsNullOrEmpty(tbName.Text))
                message += "Chưa nhập tên\n";
            if (string.IsNullOrEmpty(tbYear.Text))
                message += "Chưa nhập năm sinh\n";
            if (string.IsNullOrEmpty(tbPhone.Text))
                message += "Chưa nhập số điện thoại\n";

            if (string.IsNullOrEmpty(message))
            {
                // Tính tuổi từ năm sinh
                int birthYear = int.Parse(tbYear.Text);
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birthYear;

                MessageBox.Show($"THÔNG TIN HỢP LỆ!\n\n" +
                               $"Tên: {tbName.Text}\n" +
                               $"Năm sinh: {tbYear.Text}\n" +
                               $"Tuổi: {age} tuổi\n" +
                               $"Điện thoại: {tbPhone.Text}",
                               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Sự kiện Click nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
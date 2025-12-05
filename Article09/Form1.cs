using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện Load form: Khởi tạo ComboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập SelectedIndex mặc định
            cbFaculty.SelectedIndex = 2; // Chọn item thứ 3 (index 2)

            // Cập nhật hiển thị
            UpdateDisplay();
        }

        // Sự kiện khi thay đổi lựa chọn trong ComboBox
        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        // Sự kiện click nút OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbFaculty.SelectedItem != null)
            {
                string faculty = cbFaculty.SelectedItem.ToString();
                MessageBox.Show($"Bạn đã chọn khoa: {faculty}",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        // Sự kiện click nút Xóa
        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFaculty.SelectedIndex = -1; // Bỏ chọn
            tbDisplay.Clear();
        }

        // Sự kiện click nút Thêm khoa
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newFaculty = txtNewFaculty.Text.Trim();

            if (!string.IsNullOrEmpty(newFaculty))
            {
                // Kiểm tra xem khoa đã tồn tại chưa
                bool exists = false;
                foreach (var item in cbFaculty.Items)
                {
                    if (item.ToString().Equals(newFaculty, StringComparison.OrdinalIgnoreCase))
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    cbFaculty.Items.Add(newFaculty);
                    cbFaculty.SelectedItem = newFaculty;
                    txtNewFaculty.Clear();
                    MessageBox.Show($"Đã thêm khoa mới: {newFaculty}",
                                    "Thành công",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Khoa '{newFaculty}' đã tồn tại!",
                                    "Cảnh báo",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khoa mới!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        // Sự kiện click nút Xóa khoa được chọn
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cbFaculty.SelectedIndex >= 0)
            {
                string faculty = cbFaculty.SelectedItem.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khoa '{faculty}'?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int currentIndex = cbFaculty.SelectedIndex;
                    cbFaculty.Items.RemoveAt(currentIndex);

                    // Chọn item tiếp theo hoặc item cuối cùng
                    if (cbFaculty.Items.Count > 0)
                    {
                        if (currentIndex < cbFaculty.Items.Count)
                            cbFaculty.SelectedIndex = currentIndex;
                        else
                            cbFaculty.SelectedIndex = cbFaculty.Items.Count - 1;
                    }
                    else
                    {
                        cbFaculty.SelectedIndex = -1;
                    }

                    UpdateDisplay();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khoa để xóa!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        // Sự kiện click nút Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Phương thức cập nhật hiển thị
        private void UpdateDisplay()
        {
            if (cbFaculty.SelectedIndex >= 0)
            {
                int index = cbFaculty.SelectedIndex;
                string faculty = cbFaculty.SelectedItem.ToString();

                tbDisplay.Text = $"Thông tin lựa chọn:\r\n" +
                                $"------------------------\r\n" +
                                $"Chỉ số (Index): {index}\r\n" +
                                $"Khoa: {faculty}\r\n" +
                                $"Tổng số khoa: {cbFaculty.Items.Count}";
            }
            else
            {
                tbDisplay.Text = "Chưa có khoa nào được chọn.\r\n" +
                                "Vui lòng chọn một khoa từ danh sách.";
            }
        }

        // Sự kiện KeyPress cho TextBox thêm khoa mới
        private void txtNewFaculty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép Enter để thêm khoa
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdd.PerformClick();
                e.Handled = true;
            }
        }
    }
}
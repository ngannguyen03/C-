using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article13
{
    public partial class Form1 : Form
    {
        // Biến đếm số thứ tự sinh viên
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi Form load lên
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập mặc định
            rbMale.Checked = true; // Mặc định chọn Nam

            // Chọn item đầu tiên của ComboBox nếu có
            if (cbFaculty.Items.Count > 0)
                cbFaculty.SelectedIndex = 0;
        }

        // Sự kiện click nút Thêm (Add)
        private void btAdd_Click(object sender, EventArgs e)
        {
            // 1. Tăng biến đếm
            count++;

            // 2. Lấy thông tin Họ tên
            string name = tbName.Text;

            // 3. Lấy thông tin Giới tính
            string gender = "Nam";
            if (rbFemale.Checked)
            {
                gender = "Nữ";
            }

            // 4. Lấy thông tin Ngày sinh
            // Định dạng chuỗi ngày tháng theo kiểu dd/MM/yyyy
            string dob = dtpDob.Value.ToString("dd/MM/yyyy");

            // 5. Lấy thông tin Khoa
            string faculty = "";
            if (cbFaculty.SelectedItem != null)
            {
                faculty = cbFaculty.SelectedItem.ToString();
            }

            // 6. Tạo chuỗi kết quả để hiển thị (Mô phỏng giống hình trang 110)
            string result = count + ". " + name + "\n" +
                            "   -Giới tính: " + gender + "\n" +
                            "   -Ngày Sinh: " + dob + "\n" +
                            "   -Khoa: " + faculty + "\n\n"; // Thêm dòng trống cho đẹp

            // 7. Thêm vào RichTextBox (Trạng thái)
            rtbStatus.Text += result;

            // Cuộn xuống dưới cùng
            rtbStatus.SelectionStart = rtbStatus.Text.Length;
            rtbStatus.ScrollToCaret();
        }

        // Sự kiện click nút Thoát (Exit)
        private void btExit_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
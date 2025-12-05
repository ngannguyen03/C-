using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi bấm nút Tính tiền (Trang 104)
        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;

            // Kiểm tra RadioButton
            if (rbMale.Checked == true)
                msg = "Ông ";
            if (rbFemale.Checked == true)
                msg = "Bà ";

            // Kiểm tra CheckBox
            if (ckDiscount.Checked == true)
            {
                // Theo code trong ảnh trang 104 là: disc = 5;
                // Tuy nhiên thực tế nên lấy từ TextBox tbDiscount nếu có nhập:
                // Int32.TryParse(tbDiscount.Text, out disc);

                disc = 5; // Giữ nguyên theo tài liệu hướng dẫn
            }

            // Hiển thị kết quả
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        // Sự kiện khi thay đổi trạng thái CheckBox (Trang 104)
        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        // Sự kiện nút Thoát (Bổ sung cho đủ giao diện trang 103)
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
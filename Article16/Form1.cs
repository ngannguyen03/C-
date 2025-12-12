using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Article16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi bấm nút "Chọn ảnh..." (Trang 127)
        private void btFile_Click(object sender, EventArgs e)
        {
            // Chế độ hiển thị ảnh: Co dãn ảnh cho vừa khung PictureBox
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // Khởi tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            // Chỉ lọc các file có đuôi .jpg
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";

            // Nếu người dùng bấm OK trong hộp thoại
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán đường dẫn file ảnh vào PictureBox
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}
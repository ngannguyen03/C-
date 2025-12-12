using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article20
{
    public partial class Form1 : Form
    {
        // Khai báo PictureBox và tọa độ ban đầu
        PictureBox pb = new PictureBox();
        int x = 10; // Sửa mặc định khác 0 một chút để dễ nhìn
        int y = 10;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện nút File (Trang 151)
        private void btFile_Click(object sender, EventArgs e)
        {
            // Cấu hình PictureBox
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(100, 100);
            pb.Location = new Point(x, y);

            // Thêm PictureBox vào Form (quan trọng)
            this.Controls.Add(pb);

            // Cách 1: Gán cứng như tài liệu (Máy bạn phải có file này thì mới chạy được)
            // pb.ImageLocation = @"d:\abc.jpg";

            // Cách 2: Dùng hộp thoại chọn ảnh (Khuyên dùng)
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = dlg.FileName;
            }
        }

        // Sự kiện nút sang Trái (Trang 152)
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10; // Giảm tọa độ X
            pb.Location = new Point(x, y);
        }

        // Sự kiện nút sang Phải (Trang 152)
        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10; // Tăng tọa độ X
            pb.Location = new Point(x, y);
        }
    }
}
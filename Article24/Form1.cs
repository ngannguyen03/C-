using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article24
{
    public partial class Form1 : Form
    {
        // Khai báo đối tượng PictureBox cho cái giỏ
        PictureBox pbBasket = new PictureBox();

        // Tọa độ và tốc độ di chuyển của giỏ
        int xBasket = 300;
        int yBasket = 500; // Vị trí thấp xuống dưới đáy form
        int xDelta = 30;   // Mỗi lần bấm phím sẽ dịch chuyển 30 đơn vị

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình hiển thị cho cái giỏ
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100); // Kích thước giỏ
            pbBasket.Location = new Point(xBasket, yBasket); // Vị trí ban đầu
            pbBasket.BackColor = Color.Transparent; // Nền trong suốt

            // QUAN TRỌNG: Đường dẫn ảnh. 
            // Dấu .. nghĩa là lùi ra thư mục cha. Code đang chạy trong bin/Debug
            // ../../Images/basket.png nghĩa là tìm thư mục Images nằm ở thư mục project
            try
            {
                pbBasket.Image = Image.FromFile(
    Path.Combine(Application.StartupPath, "Images", "basket.png")
);

            }
            catch
            {
                // Nếu không tìm thấy ảnh thì gán màu đỏ để test code chạy được
                pbBasket.BackColor = Color.Red;
                MessageBox.Show("Chưa thấy file ảnh basket.png trong thư mục Images!");
            }

            // Thêm cái giỏ vào Form
            this.Controls.Add(pbBasket);
        }

        // Sự kiện khi nhấn phím (Trang 172)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím Mũi tên Phải (Right Arrow) - KeyValue 39
            // Điều kiện: Giỏ chưa chạm mép phải
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
            {
                xBasket += xDelta; // Tăng tọa độ X
            }

            // Kiểm tra phím Mũi tên Trái (Left Arrow) - KeyValue 37
            // Điều kiện: Giỏ chưa chạm mép trái (x > 0)
            if (e.KeyValue == 37 && xBasket > 0)
            {
                xBasket -= xDelta; // Giảm tọa độ X
            }

            // Cập nhật lại vị trí mới cho cái giỏ
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}
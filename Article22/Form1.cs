using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article22
{
    public partial class Form1 : Form
    {
        // Khai báo các control bằng code
        PictureBox pb = new PictureBox();

        // SỬA LỖI Ở ĐÂY: Chỉ định rõ dùng Timer của Windows Forms
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();

        // Tọa độ ban đầu
        int xBall = 0;
        int yBall = 0;

        // Bước nhảy (tốc độ di chuyển)
        int xDelta = 5;
        int yDelta = 5;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình Timer
            tmGame.Interval = 10;
            tmGame.Tick += new EventHandler(tmGame_Tick);
            tmGame.Start();

            // Cấu hình PictureBox (Quả bóng)
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(50, 50);
            pb.Location = new Point(xBall, yBall);
            pb.BackColor = Color.Transparent;

            // Thêm bóng vào Form
            this.Controls.Add(pb);

            // Load ảnh
            try
            {
                pb.Image = Image.FromFile(@"D:\ball.png");
            }
            catch
            {
                // Nếu không tìm thấy ảnh thì đổ màu đỏ để test
                pb.BackColor = Color.Red;
            }
        }

        // Sự kiện Timer Tick
        void tmGame_Tick(object sender, EventArgs e)
        {
            // Thay đổi tọa độ
            xBall += xDelta;
            yBall += yDelta;

            // Kiểm tra va chạm biên Ngang
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
            {
                xDelta = -xDelta;
            }

            // Kiểm tra va chạm biên Dọc
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
            {
                yDelta = -yDelta;
            }

            // Cập nhật vị trí mới cho PictureBox
            pb.Location = new Point(xBall, yBall);
        }
    }
}
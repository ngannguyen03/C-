using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article23
{
    public partial class Form1 : Form
    {
        // Khai báo PictureBox và Timer bằng code
        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        // Tọa độ và tốc độ rơi của trứng
        int xEgg = 300;
        int yEgg = 0;
        int xDelta = 3;
        int yDelta = 3;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load (Trang 166)
        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình Timer
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            // Cấu hình PictureBox quả trứng
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50); // Kích thước trứng
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;

            this.Controls.Add(pbEgg);

            // Load ảnh trứng nguyên vẹn
            try
            {
                // Bạn hãy sửa đường dẫn này đúng với nơi bạn lưu file ảnh
                pbEgg.Image = Image.FromFile(
    Path.Combine(Application.StartupPath, "Images", "egg_gold.png")
);

            }
            catch
            {
                pbEgg.BackColor = Color.Yellow; // Màu vàng nếu không tìm thấy ảnh
            }
        }

        // Sự kiện Timer Tick để trứng rơi (Trang 167)
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDelta; // Tăng Y để rơi xuống

            // Kiểm tra chạm đáy hoặc chạm nóc (theo logic tài liệu)
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                try
                {
                    // Đổi sang ảnh trứng vỡ
                    pbEgg.Image = Image.FromFile(
     Path.Combine(Application.StartupPath, "Images", "egg_gold_broken.png")
 );

                }
                catch
                {
                    pbEgg.BackColor = Color.Red; // Màu đỏ nếu vỡ (fallback)
                }

                // (Mở rộng: Thường ở đây sẽ dừng game hoặc reset trứng lên trên)
                // Nhưng theo Article 26 thì code dừng ở việc đổi ảnh.
            }

            // Cập nhật vị trí
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}
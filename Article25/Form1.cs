using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article25
{
    public partial class Form1 : Form
    {
        // 1. KHAI BÁO ĐỐI TƯỢNG (Trang 176)
        PictureBox pbBasket = new PictureBox(); // Cái giỏ
        PictureBox pbEgg = new PictureBox();    // Quả trứng
        PictureBox pbChicken = new PictureBox();// Con gà

        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmChicken = new System.Windows.Forms.Timer();
        // 2. KHAI BÁO BIẾN TỌA ĐỘ VÀ TỐC ĐỘ (Trang 176)
        // --- Giỏ ---
        int xBasket = 300;
        int yBasket = 500;
        int xDeltaBasket = 30;

        // --- Gà ---
        int xChicken = 300;
        int yChicken = 10;
        int xDeltaChicken = 5; // Tốc độ gà chạy ngang

        // --- Trứng ---
        int xEgg = 300;
        int yEgg = 10;
        int yDeltaEgg = 5;     // Tốc độ trứng rơi dọc

        public Form1()
        {
            InitializeComponent();
        }

        // 3. SỰ KIỆN LOAD FORM (Trang 177, 178)
        private void Form1_Load(object sender, EventArgs e)
        {
            // --- Cấu hình Timer ---
            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            tmChicken.Interval = 10;
            tmChicken.Tick += tmChicken_Tick;
            tmChicken.Start();

            // --- Cấu hình Cái Giỏ (Basket) ---
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);

            // --- Cấu hình Con Gà (Chicken) ---
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(100, 100);
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.BackColor = Color.Transparent;
            this.Controls.Add(pbChicken);

            // --- Cấu hình Quả Trứng (Egg) ---
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            // --- Load Hình Ảnh ---
            try
            {
                pbBasket.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "Images", "basket.png")
                );

                pbChicken.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "Images", "chicken.png")
                );

                pbEgg.Image = Image.FromFile(
                    Path.Combine(Application.StartupPath, "Images", "egg_gold.png")
                );
            }
            catch

            {
                // Nếu lỗi ảnh thì hiển thị màu để test
                pbBasket.BackColor = Color.Red;
                pbChicken.BackColor = Color.Blue;
                pbEgg.BackColor = Color.Yellow;
            }
        }

        // 4. SỰ KIỆN TRỨNG RƠI (Trang 179)
        void tmEgg_Tick(object sender, EventArgs e)
        {
            yEgg += yDeltaEgg; // Trứng rơi xuống

            // Nếu trứng chạm đáy (hoặc rơi quá tầm nhìn)
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                // Reset trứng về vị trí TRÊN CAO (y = 30)
                yEgg = 30;
                // QUAN TRỌNG: Trứng xuất hiện tại vị trí CON GÀ đang đứng
                xEgg = pbChicken.Location.X + (pbChicken.Width / 2) - (pbEgg.Width / 2);
            }

            // Cập nhật vị trí trứng
            pbEgg.Location = new Point(xEgg, yEgg);
        }

        // 5. SỰ KIỆN GÀ DI CHUYỂN (Trang 179)
        void tmChicken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken; // Gà chạy ngang

            // Nếu gà chạm mép phải HOẶC chạm mép trái màn hình
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
            {
                xDeltaChicken = -xDeltaChicken; // Đảo chiều di chuyển
            }

            // Cập nhật vị trí gà
            pbChicken.Location = new Point(xChicken, yChicken);
        }

        // 6. SỰ KIỆN DI CHUYỂN GIỎ BẰNG PHÍM (Trang 180)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím Mũi tên Phải (Right)
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
                xBasket += xDeltaBasket;

            // Phím Mũi tên Trái (Left)
            if (e.KeyValue == 37 && xBasket > 0)
                xBasket -= xDeltaBasket;

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}
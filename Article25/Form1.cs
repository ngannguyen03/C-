using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Article25
{
    public partial class Form1 : Form
    {
        // ================= OBJECT =================
        PictureBox pbBasket = new PictureBox();

        PictureBox pbChicken1 = new PictureBox();
        PictureBox pbChicken2 = new PictureBox();

        PictureBox pbEgg1 = new PictureBox();
        PictureBox pbEgg2 = new PictureBox();

        PictureBox pbBrokenEgg = new PictureBox();

        Button btnStart = new Button();
        Button btnRestart = new Button();

        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer tmBrokenEgg = new System.Windows.Forms.Timer();

        // ================= VARIABLE =================
        int xBasket = 300;
        int yBasket = 520; // 🔴 nâng giỏ cao hơn
        int speedBasket = 20;

        int xChicken1 = 200, xChicken2 = 500;
        int yChicken = 10;
        int dxChicken1 = 5, dxChicken2 = -6;

        int xEgg1, xEgg2;
        int yEgg1 = 0, yEgg2 = 0;
        int dyEgg = 5;

        int score = 0;
        int level = 1;
        int life = 3;

        bool gameRunning = false;
        bool gameOver = false;

        bool dragging = false;
        Point mouseOffset;

        Label lblScore = new Label();
        Label lblLevel = new Label();
        Label lblLife = new Label();

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        // ================= LOAD =================
        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            // TIMER (CHƯA START)
            tmGame.Interval = 15;
            tmGame.Tick += GameLoop;

            // ---------------- GIỎ ----------------
            pbBasket.Size = new Size(100, 100);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.MouseDown += BasketDown;
            pbBasket.MouseMove += BasketMove;
            pbBasket.MouseUp += BasketUp;
            this.Controls.Add(pbBasket);
            pbBasket.BringToFront(); // 🔴 QUAN TRỌNG

            // ---------------- GÀ ----------------
            SetupChicken(pbChicken1, xChicken1);
            SetupChicken(pbChicken2, xChicken2);
            pbChicken2.Visible = false;

            // ---------------- TRỨNG ----------------
            SetupEgg(pbEgg1);
            SetupEgg(pbEgg2);
            pbEgg2.Visible = false;

            // ---------------- TRỨNG VỠ ----------------
            pbBrokenEgg.Size = new Size(50, 50);
            pbBrokenEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBrokenEgg.Visible = false;
            this.Controls.Add(pbBrokenEgg);
            pbBrokenEgg.BringToFront();

            tmBrokenEgg.Interval = 300;
            tmBrokenEgg.Tick += (s, ev) =>
            {
                pbBrokenEgg.Visible = false;
                tmBrokenEgg.Stop();
            };

            // ---------------- LABEL ----------------
            SetupLabel(lblScore, "Score: 0", 10, 10);
            SetupLabel(lblLevel, "Level: 1", 10, 40);
            SetupLabel(lblLife, "Life: 3", 10, 70);

            // ---------------- BUTTON START ----------------
            btnStart.Text = "Bắt đầu";
            btnStart.Size = new Size(120, 40);
            btnStart.Location = new Point(
                this.ClientSize.Width / 2 - 60,
                this.ClientSize.Height / 2 - 50);
            btnStart.Click += (s, ev) => StartGame();
            this.Controls.Add(btnStart);

            // ---------------- BUTTON RESTART ----------------
            btnRestart.Text = "Chơi lại";
            btnRestart.Size = new Size(120, 40);
            btnRestart.Location = new Point(
                this.ClientSize.Width / 2 - 60,
                this.ClientSize.Height / 2 + 10);
            btnRestart.Visible = false;
            btnRestart.Click += (s, ev) => RestartGame();
            this.Controls.Add(btnRestart);

            // ---------------- LOAD IMAGE ----------------
            pbBasket.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "basket.png"));
            pbChicken1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "chicken.png"));
            pbChicken2.Image = pbChicken1.Image;
            pbEgg1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "egg_gold.png"));
            pbEgg2.Image = pbEgg1.Image;
            pbBrokenEgg.Image = Image.FromFile(
                Path.Combine(Application.StartupPath, "Images", "egg_gold_broken.png"));
        }

        // ================= START GAME =================
        void StartGame()
        {
            btnStart.Visible = false;
            gameRunning = true;
            gameOver = false;

            ResetEgg(pbChicken1, pbEgg1, ref yEgg1, ref xEgg1);
            ResetEgg(pbChicken2, pbEgg2, ref yEgg2, ref xEgg2);

            tmGame.Start();
        }

        // ================= GAME LOOP =================
        void GameLoop(object sender, EventArgs e)
        {
            if (!gameRunning || gameOver) return;

            MoveChicken();

            DropEgg(pbEgg1, pbChicken1, ref yEgg1, ref xEgg1);

            if (level >= 3)
                DropEgg(pbEgg2, pbChicken2, ref yEgg2, ref xEgg2);
        }

        // ================= DROP EGG =================
        void DropEgg(PictureBox egg, PictureBox chicken, ref int yEgg, ref int xEgg)
        {
            egg.Visible = true;
            yEgg += dyEgg;
            egg.Location = new Point(xEgg, yEgg);

            // ✅ VA CHẠM CHẮC CHẮN
            if (egg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score++;
                lblScore.Text = "Score: " + score;
                CheckLevel();
                ResetEgg(chicken, egg, ref yEgg, ref xEgg);
            }
            else if (yEgg > this.ClientSize.Height - egg.Height)
            {
                life--;
                lblLife.Text = "Life: " + life;

                pbBrokenEgg.Location = new Point(xEgg,
                    this.ClientSize.Height - egg.Height);
                pbBrokenEgg.Visible = true;
                tmBrokenEgg.Start();

                if (life <= 0)
                    GameOver();
                else
                    ResetEgg(chicken, egg, ref yEgg, ref xEgg);
            }
        }

        // ================= LEVEL =================
        void CheckLevel()
        {
            if (score >= 80 && level == 2)
            {
                level = 3;
                lblLevel.Text = "Level: 3";
                pbChicken2.Visible = true;
                pbEgg2.Visible = true;
                dyEgg = 10;
            }
            else if (score >= 30 && level == 1)
            {
                level = 2;
                lblLevel.Text = "Level: 2";
                dyEgg = 8;
                dxChicken1 = 7;
            }
        }

        // ================= GAME OVER =================
        void GameOver()
        {
            gameOver = true;
            tmGame.Stop();
            btnRestart.Visible = true;
            MessageBox.Show("GAME OVER!", "Thông báo");
        }

        // ================= RESTART =================
        void RestartGame()
        {
            score = 0;
            level = 1;
            life = 3;
            dyEgg = 5;
            dxChicken1 = 5;

            lblScore.Text = "Score: 0";
            lblLevel.Text = "Level: 1";
            lblLife.Text = "Life: 3";

            pbChicken2.Visible = false;
            pbEgg2.Visible = false;
            btnRestart.Visible = false;
            gameOver = false;
            gameRunning = true;

            ResetEgg(pbChicken1, pbEgg1, ref yEgg1, ref xEgg1);
            ResetEgg(pbChicken2, pbEgg2, ref yEgg2, ref xEgg2);

            tmGame.Start();
        }

        // ================= SUPPORT =================
        void ResetEgg(PictureBox chicken, PictureBox egg, ref int yEgg, ref int xEgg)
        {
            yEgg = chicken.Bottom;
            xEgg = chicken.Left + chicken.Width / 2 - egg.Width / 2;
        }

        void MoveChicken()
        {
            xChicken1 += dxChicken1;
            if (xChicken1 <= 0 || xChicken1 >= this.ClientSize.Width - pbChicken1.Width)
                dxChicken1 = -dxChicken1;
            pbChicken1.Location = new Point(xChicken1, yChicken);

            if (level >= 3)
            {
                xChicken2 += dxChicken2;
                if (xChicken2 <= 0 || xChicken2 >= this.ClientSize.Width - pbChicken2.Width)
                    dxChicken2 = -dxChicken2;
                pbChicken2.Location = new Point(xChicken2, yChicken);
            }
        }

        // ================= INPUT =================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && xBasket > 0)
                xBasket -= speedBasket;
            if (e.KeyCode == Keys.Right && xBasket < this.ClientSize.Width - pbBasket.Width)
                xBasket += speedBasket;

            pbBasket.Location = new Point(xBasket, yBasket);
        }

        void BasketDown(object s, MouseEventArgs e)
        {
            dragging = true;
            mouseOffset = e.Location;
        }

        void BasketMove(object s, MouseEventArgs e)
        {
            if (!dragging) return;
            int newX = pbBasket.Left + e.X - mouseOffset.X;
            newX = Math.Max(0, Math.Min(newX, this.ClientSize.Width - pbBasket.Width));
            xBasket = newX;
            pbBasket.Location = new Point(xBasket, yBasket);
        }

        void BasketUp(object s, MouseEventArgs e)
        {
            dragging = false;
        }

        // ================= SETUP =================
        void SetupChicken(PictureBox pb, int x)
        {
            pb.Size = new Size(100, 100);
            pb.Location = new Point(x, yChicken);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pb);
        }

        void SetupEgg(PictureBox pb)
        {
            pb.Size = new Size(50, 50);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pb);
        }

        void SetupLabel(Label lbl, string text, int x, int y)
        {
            lbl.Text = text;
            lbl.Location = new Point(x, y);
            lbl.Font = new Font("Arial", 14, FontStyle.Bold);
            lbl.AutoSize = true;
            this.Controls.Add(lbl);
        }
    }
}

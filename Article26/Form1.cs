using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article26
{
    public partial class Form1 : Form
    {
        // 1. Khai báo 3 màn hình
        Login l = new Login();
        Question q = new Question();
        Finish f = new Finish();

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            // Thiết lập kích thước Form
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Text = "Chương trình thi trắc nghiệm (Article 29)";
        }

        // 2. Sự kiện Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt vị trí trùng nhau
            l.Location = new Point(0, 0);
            q.Location = new Point(0, 0);
            f.Location = new Point(0, 0);

            // Thêm Login vào đầu tiên
            this.Controls.Add(l);

            // 3. Gắn sự kiện cho các nút bấm trong UserControl
            // Nút ở màn hình Login
            l.btStart.Click += new EventHandler(btLogin_Click);

            // Nút ở màn hình Question
            q.btPrev.Click += new EventHandler(bt_Prev_Click);
            q.btFinish.Click += new EventHandler(btFinish_Click);

            // Nút ở màn hình Finish
            f.btExit.Click += new EventHandler(btExit_Click);
        }

        // --- CÁC HÀM XỬ LÝ CHUYỂN MÀN HÌNH ---

        // Từ Login -> Question
        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(l);
            this.Controls.Add(q);
        }

        // Từ Question -> Login
        private void bt_Prev_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q);
            this.Controls.Add(l);
        }

        // Từ Question -> Finish
        private void btFinish_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(q);
            this.Controls.Add(f);
        }

        // Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
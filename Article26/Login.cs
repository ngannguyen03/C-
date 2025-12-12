using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article26
{
    public partial class Login : UserControl
    {
        // Khai báo public để Form1 có thể truy cập được nút bấm này
        public Button btStart;

        public Login()
        {
            InitializeComponent(); // Hàm mặc định của VS
            InitCustomUI();        // Hàm giao diện tự viết
        }

        private void InitCustomUI()
        {
            System.Windows.Forms.Label lblName = new System.Windows.Forms.Label();
            System.Windows.Forms.TextBox tbName = new System.Windows.Forms.TextBox();
            btStart = new System.Windows.Forms.Button();

            // Cấu hình UserControl
            this.Size = new System.Drawing.Size(600, 400);
            this.BackColor = Color.WhiteSmoke;

            // Label
            lblName.Text = "Họ và tên thí sinh:";
            lblName.Location = new System.Drawing.Point(50, 50);
            lblName.AutoSize = true;

            // TextBox
            tbName.Location = new System.Drawing.Point(160, 47);
            tbName.Size = new System.Drawing.Size(200, 20);

            // Button
            btStart.Text = "Tiếp tục";
            btStart.Location = new System.Drawing.Point(160, 100);
            btStart.Size = new System.Drawing.Size(100, 30);

            // Thêm vào giao diện
            this.Controls.Add(lblName);
            this.Controls.Add(tbName);
            this.Controls.Add(btStart);
        }
    }
}
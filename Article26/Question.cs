using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article26
{
    public partial class Question : UserControl
    {
        public Button btPrev;
        public Button btFinish;

        public Question()
        {
            InitializeComponent();
            InitCustomUI();
        }

        private void InitCustomUI()
        {
            System.Windows.Forms.Label lblQ = new System.Windows.Forms.Label();
            System.Windows.Forms.RadioButton rb1 = new System.Windows.Forms.RadioButton();
            System.Windows.Forms.RadioButton rb2 = new System.Windows.Forms.RadioButton();
            btPrev = new System.Windows.Forms.Button();
            btFinish = new System.Windows.Forms.Button();

            this.Size = new System.Drawing.Size(600, 400);
            this.BackColor = Color.WhiteSmoke;

            lblQ.Text = "Câu hỏi: 1 + 1 bằng mấy?";
            lblQ.Location = new System.Drawing.Point(50, 50);
            lblQ.AutoSize = true;

            rb1.Text = "Hai";
            rb1.Location = new System.Drawing.Point(50, 80);

            rb2.Text = "Ba";
            rb2.Location = new System.Drawing.Point(50, 110);

            btPrev.Text = "Quay lại";
            btPrev.Location = new System.Drawing.Point(50, 200);

            btFinish.Text = "Nộp bài";
            btFinish.Location = new System.Drawing.Point(150, 200);

            this.Controls.Add(lblQ);
            this.Controls.Add(rb1);
            this.Controls.Add(rb2);
            this.Controls.Add(btPrev);
            this.Controls.Add(btFinish);
        }
    }
}
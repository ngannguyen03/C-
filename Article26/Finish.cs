using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article26
{
    public partial class Finish : UserControl
    {
        public Button btExit;

        public Finish()
        {
            InitializeComponent();
            InitCustomUI();
        }

        private void InitCustomUI()
        {
            System.Windows.Forms.Label lblResult = new System.Windows.Forms.Label();
            btExit = new System.Windows.Forms.Button();

            this.Size = new System.Drawing.Size(600, 400);
            this.BackColor = Color.WhiteSmoke;

            lblResult.Text = "Kết quả thi: \nSố câu đúng: 10/10\nĐiểm: 10";
            lblResult.Location = new System.Drawing.Point(50, 50);
            lblResult.AutoSize = true;

            btExit.Text = "Kết thúc";
            btExit.Location = new System.Drawing.Point(50, 150);

            this.Controls.Add(lblResult);
            this.Controls.Add(btExit);
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmAlert : Form
    {
        public frmAlert()
        {
            InitializeComponent();
        }

        public enum enmAction { wait, start, close }
        public enum enmType { Success, Warning, Error, Info }
        private frmAlert.enmAction action;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 3000; // Hiển thị trong 3 giây
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.Opacity == 1.0) action = enmAction.wait;
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    if (this.Opacity == 0.0) this.Close();
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            // Tìm vị trí hiển thị (Góc trên bên phải)
            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                frmAlert frm = (frmAlert)Application.OpenForms[fname];
                if (frm == null)
                {
                    this.Name = fname;
                    int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
                    int y = (this.Height + 5) * i; // Xếp chồng từ trên xuống
                    this.Location = new Point(x, y);
                    break;
                }
            }

            // Thiết lập màu sắc theo loại
            switch (type)
            {
                case enmType.Success: this.BackColor = Color.FromArgb(46, 204, 113); lblIcon.Text = "✔"; break;
                case enmType.Error: this.BackColor = Color.FromArgb(231, 76, 60); lblIcon.Text = "✘"; break;
                case enmType.Warning: this.BackColor = Color.FromArgb(243, 156, 18); lblIcon.Text = "⚠"; break;
                case enmType.Info: this.BackColor = Color.SteelBlue; lblIcon.Text = "ℹ"; break;
            }

            this.lblMsg.Text = msg;
            this.Show();
            this.action = enmAction.start;
            this.timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.action = enmAction.close;
    }
}
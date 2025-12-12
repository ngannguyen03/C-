using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article21
{
    public partial class Form1 : Form
    {
        // Biến đếm giây
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện nút Start (Trang 157)
        private void btStart_Click(object sender, EventArgs e)
        {
            // Thiết lập timer chạy mỗi 1000ms (1 giây)
            tmStopwatch.Interval = 1000;
            tmStopwatch.Start();
        }

        // Sự kiện nút Stop (Trang 157)
        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();
        }

        // Sự kiện Tick của Timer (Chạy định kỳ theo Interval) (Trang 157)
        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++;
            lblDisplay.Text = second.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Article12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi bấm nút OK (Trang 108)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Hiển thị ngày dạng dài lên tiêu đề Form
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // Sự kiện khi giá trị ngày tháng thay đổi (Trang 108)
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Hiển thị ngày dạng ngắn lên tiêu đề Form
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}
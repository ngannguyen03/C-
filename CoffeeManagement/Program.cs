using System;
using System.Windows.Forms;
using CoffeeManagement.GUI; // Gọi GUI để thấy frmLogin

namespace CoffeeManagement
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chạy frmLogin nằm trong thư mục GUI đầu tiên
            Application.Run(new frmLogin());
        }
    }
}
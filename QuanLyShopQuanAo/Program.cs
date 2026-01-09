using System;
using System.Windows.Forms;
using QuanLyShopQuanAo.GUI;

namespace QuanLyShopQuanAo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Khởi tạo các cấu hình mặc định của WinForms
            ApplicationConfiguration.Initialize();

            // 1. Khởi tạo form Login
            // Dùng khối using để tự động giải phóng bộ nhớ sau khi dùng xong
            using (frmLogin login = new frmLogin())
            {
                // 2. Hiện Login dưới dạng Dialog
                // Khi đăng nhập thành công, bên trong frmLogin sẽ gán DialogResult = OK
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // 3. Nếu đăng nhập thành công, mới chạy Form Main
                    // Application.Run sẽ giữ cho ứng dụng chạy cho đến khi frmMain đóng
                    Application.Run(new frmMain());
                }
                else
                {
                    // Nếu bấm nút Exit (X) hoặc đăng nhập thất bại mà đóng Form
                    // Ứng dụng sẽ kết thúc tại đây
                    Application.Exit();
                }
            }
        }
    }
}
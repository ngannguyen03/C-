using QuanLyShopQuanAo.GUI;

namespace QuanLyShopQuanAo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Khởi tạo form Login
            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain());
            }

            // 2. Hiện Login dưới dạng Dialog
            // Khi đăng nhập thành công, ta sẽ gán DialogResult = OK bên trong frmLogin
            if (login.ShowDialog() == DialogResult.OK)
            {
                // 3. Nếu OK thì mới chạy Main
                Application.Run(new frmMain());
            }
            else
            {
                // Nếu bấm thoát ở Login thì thoát hẳn app
                Application.Exit();
            }
        }
    }
}
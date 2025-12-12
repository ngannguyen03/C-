using System;
using System.Windows.Forms;
using CoffeeManagement.BLL; // Gọi BLL

namespace CoffeeManagement.GUI
{
    public partial class frmLogin : Form
    {
        UserBLL bll = new UserBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (bll.IsValidUser(txtUser.Text, txtPass.Text))
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Mở form Quản lý
                frmProduct f = new frmProduct();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient) ctrl.BackColor = Color.WhiteSmoke;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy | HH:mm:ss");
        }

        private void OpenChildForm(Form childForm, string title)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == childForm.Name)
                {
                    f.Activate();
                    lblTitle.Text = title.ToUpper();
                    return;
                }
                f.Close();
            }
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            lblTitle.Text = title.ToUpper();
            childForm.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e) => OpenChildForm(new frmSanPham(), "Sản phẩm");
        private void btnNhanVien_Click(object sender, EventArgs e) => OpenChildForm(new frmNhanVien(), "Nhân viên");
        private void btnKhachHang_Click(object sender, EventArgs e) => OpenChildForm(new frmKhachHang(), "Khách hàng");
        private void btnBanHang_Click(object sender, EventArgs e) => OpenChildForm(new frmBanHang(), "Bán hàng");
        private void btnThongKe_Click(object sender, EventArgs e) => OpenChildForm(new frmThongKe(), "Thống kê");

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Restart();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
        }
    }
}
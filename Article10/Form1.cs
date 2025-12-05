using System;
using System.Collections; // Cần thêm dòng này để dùng ArrayList
using System.Windows.Forms;

namespace Article10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hàm tạo dữ liệu giả lập (Trang 98)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; // Mình sửa thành K03 để khác K02 bên trên cho logic đúng hơn
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // Sự kiện khi Form Load (Trang 99)
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            cb_Faculty.DataSource = lst;
            cb_Faculty.DisplayMember = "Name"; // Hiển thị tên khoa lên ComboBox
        }

        // Sự kiện khi thay đổi giá trị chọn trong ComboBox (Trang 99)
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Faculty.SelectedValue != null)
            {
                // Khi chọn đổi item, set ValueMember là Id để lấy mã khoa
                cb_Faculty.ValueMember = "Id";
                string id = cb_Faculty.SelectedValue.ToString();
                tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
            }
        }

        // Sự kiện khi click nút OK (Trang 99)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Khi bấm nút, set ValueMember là Name để lấy tên khoa
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
        }
    }
}
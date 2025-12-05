using System;
using System.Collections; // Cần dòng này để dùng ArrayList
using System.Windows.Forms;

namespace Article14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu giả lập (Trang 121)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        // Sự kiện Form Load (Trang 122)
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            // Gán nguồn dữ liệu là danh sách các đối tượng
            lbSong.DataSource = lst;
            // Chỉ hiển thị thuộc tính "Name" của đối tượng lên giao diện
            lbSong.DisplayMember = "Name";
        }

        // Sự kiện bấm nút chuyển sang phải (Trang 122)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Ép kiểu item đang chọn về đối tượng Song
            Song song = (Song)lbSong.SelectedItem;

            // Lấy thông tin chi tiết từ đối tượng
            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;

            // Ghép chuỗi và thêm vào danh sách yêu thích
            lbFavorite.Items.Add(id + " - " + name + " - " + author);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                // Thư viện để ghi file
using System.Xml.Serialization; // Thư viện để chuyển đổi sang XML

namespace Article01 // Đã cập nhật theo tên bạn đặt
{
    public partial class Form1 : Form
    {
        // Đường dẫn file lưu trữ (theo trang 28 PDF)
        // Lưu ý: Nếu máy bạn không có ổ D, hãy đổi thành @"C:\form.xml" hoặc @"D:\Data\form.xml"
        string path = @"F:\form.xml";

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm ghi dữ liệu ra file XML (Trang 28)
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                StreamWriter file = new StreamWriter(path);
                writer.Serialize(file, iw);
                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // Hàm đọc dữ liệu từ file XML (Trang 33)
        public InfoWindows Read()
        {
            // Kiểm tra xem file có tồn tại không để tránh lỗi
            if (!File.Exists(path))
            {
                return null;
            }

            try
            {
                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                StreamReader file = new StreamReader(path);
                InfoWindows iw = (InfoWindows)reader.Deserialize(file);
                file.Close();
                return iw;
            }
            catch { return null; }
        }

        private void UpdateInfoToTitle()
        {
            this.Text = string.Format("Size: {0}x{1} | Location: X={2}, Y={3}",
                                      this.Width, this.Height, this.Location.X, this.Location.Y);
        }

        // Sự kiện Form1_ResizeEnd (Trang 29 - Code sự kiện này)
        // Code này chạy khi bạn thả chuột sau khi co giãn form
        //private void Form1_ResizeEnd(object sender, EventArgs e)
        //{
        //    InfoWindows iw = new InfoWindows();
        //    iw.Width = this.Size.Width;
        //    iw.Height = this.Size.Height;

        //    // Hiển thị kích thước lên tiêu đề form
        //    this.Text = iw.Width.ToString() + " - " + iw.Height.ToString();
        //    // Khi kéo thả xong thì LƯU lại kích thước mới
        //    Write(iw);
        //}

        // Sự kiện Form1_Load (Trang 29 - Code sự kiện này)
        // Code này chạy khi form bắt đầu hiện lên
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    InfoWindows iw = new InfoWindows();
        //    iw.Width = this.Size.Width;
        //    iw.Height = this.Size.Height;

        //    this.Text = iw.Width.ToString() + " - " + iw.Height.ToString();

        //    Write(iw);
        //}

        // Cập nhật sự kiện Load (Trang 34)
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    InfoWindows iw = Read();

        //    // Nếu đọc được dữ liệu cũ thì gán lại kích thước cho Form
        //    if (iw != null)
        //    {
        //        this.Width = iw.Width;
        //        this.Height = iw.Height;

        //        // Cập nhật tiêu đề để biết là đã load thành công
        //        this.Text = iw.Width.ToString() + " - " + iw.Height.ToString();
        //    }
        //}


        // --- Cập nhật sự kiện LOAD (Trang 39) ---
        // 1. Khi Form bắt đầu chạy

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = Read();
            if (iw != null)
            {
                this.Width = iw.Width;
                this.Height = iw.Height;
                this.Location = iw.Location; // <-- Khôi phục vị trí cũ

                // Cập nhật tiêu đề để kiểm tra
                this.Text = "Kích thước: " + iw.Width + "x" + iw.Height + " | Vị trí: " + iw.Location.ToString();
            }

            // Cập nhật tiêu đề ngay khi load xong
            UpdateInfoToTitle();
        }




        // 2. Khi Form đang thay đổi kích thước (Kéo to/nhỏ) -> Cập nhật tiêu đề liên tục
        private void Form1_Resize(object sender, EventArgs e)
        {
            UpdateInfoToTitle();
        }

        // 3. Khi Form đang di chuyển vị trí -> Cập nhật tiêu đề liên tục
        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            UpdateInfoToTitle();
        }

        // 4. Khi tắt Form -> Mới thực sự GHI xuống file
        // --- Thêm sự kiện FORM CLOSING (Trang 39) ---
        // Sự kiện này chạy khi bạn bấm dấu X để tắt chương trình
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location; // <-- Lưu vị trí hiện tại

            Write(iw); // Ghi tất cả xuống file
        }





    }
}
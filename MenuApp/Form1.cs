using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; // Thư viện để chạy file .exe
using System.IO;          // Thư viện để xử lý đường dẫn file

namespace MenuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Text = "Menu Bài Tập (Article Launcher)";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Danh sách các bài tập bạn đã làm (bạn có thể thêm bớt vào đây)
            // Lưu ý: Tên trong danh sách này phải KHỚP với Tên Project bạn đã đặt
            string[] projects = new string[]
            {
                "Article01", "Article02", "Article03", "Article04", "Article05",
                "Article06", "Article07", "Article08", "Article09", "Article10",
                "Article11", "Article12",
                "Article13",
                "Article14", "Article15", "Article16", "Article17", "Article18",
                "Article19", "Article20", "Article21", "Article22", "Article23",
                "Article24", // Game hứng trứng (bài 27, 28)
                "Article25", // Bóng nảy
                "Article26"  // Trắc nghiệm (bài 29)
            };

            foreach (string projName in projects)
            {
                CreateButton(projName);
            }
        }

        private void CreateButton(string projectName)
        {
            Button btn = new Button();
            btn.Text = projectName;
            btn.Size = new Size(120, 60);
            btn.BackColor = Color.LightSkyBlue;
            btn.Font = new Font("Arial", 10, FontStyle.Bold);
            btn.Margin = new Padding(10); // Khoảng cách giữa các nút

            // Lưu tên project vào thuộc tính Tag để dùng sau này
            btn.Tag = projectName;

            // Gắn sự kiện Click
            btn.Click += Btn_Click;

            // Thêm nút vào FlowLayoutPanel (nhớ đặt tên FlowLayoutPanel là flpMenu ở bước Design)
            // Nếu bạn chưa đặt tên, hãy đổi dòng dưới thành: this.Controls.Add(btn); (nhưng sẽ bị chồng lên nhau)
            if (this.Controls.ContainsKey("flpMenu"))
            {
                ((FlowLayoutPanel)this.Controls["flpMenu"]).Controls.Add(btn);
            }
            else
            {
                // Nếu lỡ quên tạo FlowLayoutPanel thì add tạm vào form
                // (Khuyến khích làm Bước 3 cho đẹp)
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Name = "flpMenu";
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                this.Controls.Add(flp);
                flp.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string projectName = btn.Tag.ToString();

            // 1. TÌM THƯ MỤC GỐC (Logic cũ vẫn đúng)
            DirectoryInfo currentFolder = new DirectoryInfo(Application.StartupPath);
            string rootFolder = "";

            while (currentFolder != null)
            {
                string potentialPath = Path.Combine(currentFolder.FullName, projectName);
                if (Directory.Exists(potentialPath) && currentFolder.Name != "MenuApp")
                {
                    rootFolder = currentFolder.FullName;
                    break;
                }
                currentFolder = currentFolder.Parent;
            }

            if (string.IsNullOrEmpty(rootFolder))
            {
                MessageBox.Show($"Không tìm thấy thư mục project '{projectName}'.", "Lỗi");
                return;
            }

            // 2. TÌM FILE .EXE (LOGIC MỚI - QUAN TRỌNG)
            // Thay vì chỉ đường dẫn cứng, ta sẽ tìm trong folder bin\Debug xem file exe nằm ở đâu
            string baseDebugPath = Path.Combine(rootFolder, projectName, "bin", "Debug");
            string finalPath = "";

            if (Directory.Exists(baseDebugPath))
            {
                // Tìm file .exe trong tất cả thư mục con của bin\Debug (bao gồm cả net8.0-windows)
                string[] files = Directory.GetFiles(baseDebugPath, projectName + ".exe", SearchOption.AllDirectories);

                if (files.Length > 0)
                {
                    // Lấy file đầu tiên tìm thấy (thường là file đúng nhất)
                    finalPath = files[0];
                }
            }

            // 3. KIỂM TRA VÀ CHẠY
            if (!string.IsNullOrEmpty(finalPath) && File.Exists(finalPath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = finalPath,
                        WorkingDirectory = Path.GetDirectoryName(finalPath)
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chạy: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy file '{projectName}.exe' trong thư mục bin\\Debug.\n\n" +
                                $"Đã tìm tại: {baseDebugPath}\n\n" +
                                "Hãy chắc chắn bạn đã chuột phải vào project đó và chọn 'Build' hoặc 'Rebuild'.",
                                "Lỗi chưa Build");
            }
        }
    }
}
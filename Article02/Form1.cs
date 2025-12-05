using System;
using System.IO;
using System.Windows.Forms;

namespace Article02
{
    public partial class Form1 : Form
    {
        private string logFilePath = @"F:\C_NguyenNgocBaoNgan\Ngan_2123110503\Key_Logger.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string directory = Path.GetDirectoryName(logFilePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                StreamWriter sw = new StreamWriter(logFilePath, true);
                sw.Write(e.KeyCode + " ");
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK button clicked!", "Article02");
        }
    }
}
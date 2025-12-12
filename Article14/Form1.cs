using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Article14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Chuyển 1 bài hát được chọn từ Trái sang Phải (Button >)
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        // 2. Chuyển tất cả bài hát từ Trái sang Phải (Button >>)
        // Lưu ý: Phải dùng vòng lặp ngược (i--) như hướng dẫn trang 117
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        // 3. Chuyển 1 bài hát từ Phải về Trái (Button <) - Logic tự suy luận tương tự
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // 4. Chuyển tất cả từ Phải về Trái (Button <<) - Logic tự suy luận tương tự
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                string song = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        // 5. Double click vào ListBox Trái để chuyển sang Phải (Trang 117)
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbSong.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        // 6. Double click vào ListBox Phải để chuyển về Trái (Tương tự)
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFavorite.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}
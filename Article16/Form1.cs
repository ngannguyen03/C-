using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Article16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện nút Thêm (Trang 134)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // Thêm một dòng mới vào DataGridView với các giá trị từ control nhập liệu
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        // Sự kiện nút Xóa (Trang 135)
        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có ô nào đang được chọn không để tránh lỗi
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                // Không xóa dòng "New Row" (dòng trắng cuối cùng)
                if (idx < dgvEmployee.Rows.Count - 1 || (dgvEmployee.AllowUserToAddRows == false))
                {
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        // Sự kiện khi người dùng chọn (click) vào một dòng (Trang 135)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;

            // Kiểm tra để tránh lỗi khi click vào dòng tiêu đề hoặc dòng mới chưa có dữ liệu
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                // Lấy dữ liệu từ các ô (Cell) gán ngược lại cho TextBox/CheckBox
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();

                // Cần ép kiểu hoặc parse chuỗi sang bool cho CheckBox
                string genderValue = dgvEmployee.Rows[idx].Cells[3].Value.ToString();
                ckGender.Checked = bool.Parse(genderValue);
            }
        }

        // Nút thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
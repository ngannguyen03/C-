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

namespace Article17
{
    public partial class Form1 : Form
    {
        // Khai báo danh sách nhân viên
        List<Employee> lst;

        public Form1()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu giả lập (Trang 139)
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            em.Gender = true; // Nam
            lst.Add(em);

            em = new Employee();
            em.Id = "53416";
            em.Name = "Nguyễn Cường";
            em.Age = 25;
            em.Gender = false;
            lst.Add(em);

            em = new Employee();
            em.Id = "53417";
            em.Name = "Nguyễn Hào";
            em.Age = 23;
            em.Gender = true;
            lst.Add(em);

            return lst;
        }

        // Sự kiện Form Load (Trang 140)
        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();
            // Duyệt danh sách và đưa từng nhân viên lên Grid
            foreach (Employee em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        // Sự kiện nút Thêm (Trang 141)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            // 1. Tạo đối tượng và thêm vào List
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;
            em.Age = int.Parse(tbAge.Text);
            em.Gender = ckGender.Checked;
            lst.Add(em);

            // 2. Thêm hiển thị lên Grid
            dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
        }

        // Sự kiện nút Xóa (Trang 142)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                if (idx < dgvEmployee.Rows.Count - 1 || (dgvEmployee.AllowUserToAddRows == false))
                {
                    // 1. Xóa trong List
                    lst.RemoveAt(idx);
                    // 2. Xóa trên Grid
                    dgvEmployee.Rows.RemoveAt(idx);
                }
            }
        }

        // Sự kiện click vào dòng (Trang 142)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && idx < dgvEmployee.Rows.Count - 1)
            {
                tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value.ToString();
                tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value.ToString();
                string genderValue = dgvEmployee.Rows[idx].Cells[3].Value.ToString();
                ckGender.Checked = bool.Parse(genderValue);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
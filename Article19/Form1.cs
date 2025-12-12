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

namespace Article19
{
    public partial class Form1 : Form
    {
        // Khai báo danh sách và BindingSource
        List<Employee> lst;
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu giả lập (Trang 147)
        public List<Employee> GetData()
        {
            List<Employee> lst = new List<Employee>();

            Employee em = new Employee();
            em.Id = "53418";
            em.Name = "Trần Tiến";
            em.Age = 20;
            em.Gender = true;
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

        // Sự kiện Form Load (Trang 147)
        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();

            // Gán dữ liệu vào BindingSource
            bs.DataSource = lst;

            // Gán BindingSource vào DataGridView
            dgvEmployee.DataSource = bs;
        }

        // Sự kiện nút Thêm (Trang 147)
        private void btAddNew_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Id = tbId.Text;
            em.Name = tbName.Text;

            // Kiểm tra lỗi nhập liệu cho tuổi
            int age = 0;
            int.TryParse(tbAge.Text, out age);
            em.Age = age;

            em.Gender = ckGender.Checked;

            // Thêm vào BindingSource (nó sẽ tự thêm vào List và Grid)
            bs.Add(em);
        }

        // Sự kiện nút Xóa (Trang 148)
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell != null)
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                // Xóa thông qua BindingSource
                bs.RemoveAt(idx);
            }
        }

        // Sự kiện click vào dòng (Trang 148)
        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            // Kiểm tra index hợp lệ
            if (idx >= 0 && idx < dgvEmployee.Rows.Count)
            {
                // Lấy giá trị hiển thị lên TextBox
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
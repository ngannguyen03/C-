using System;
using System.Windows.Forms;
using CoffeeManagement.DAL; // Tạm gọi DAL vì chưa có ProductBLL
using CoffeeManagement.DTO;

namespace CoffeeManagement.GUI
{
    public partial class frmProduct : Form
    {
        ProductDAL prodDAL = new ProductDAL();

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = prodDAL.GetAllProducts();
        }
    }
}
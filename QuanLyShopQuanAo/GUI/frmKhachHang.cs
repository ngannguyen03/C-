using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadData();
        }

        // ================= TRẠNG THÁI BAN ĐẦU =================
        private void ResetValues()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";

            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDienThoai.Enabled = false;
            txtDiaChi.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // ================= DỮ LIỆU MẪU =================
        private void LoadData()
        {
            dgvKhachHang.Rows.Clear();
            dgvKhachHang.Rows.Add("KH01", "Nguyễn Thị Mai", "0905123456", "123 Lê Lợi, Đà Nẵng");
            dgvKhachHang.Rows.Add("KH02", "Trần Văn Hùng", "0914987654", "456 Nguyễn Huệ, TP.HCM");
            dgvKhachHang.Rows.Add("KH03", "Lê Hồng Hạnh", "0888222333", "789 Phan Chu Trinh, Hà Nội");
        }

        // ================= POPUP CHI TIẾT (DOUBLE CLICK) =================
        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            string detail = $"🆔 Mã khách hàng: {row.Cells[0].Value}\n" +
                            $"👤 Tên khách hàng: {row.Cells[1].Value}\n" +
                            $"📞 Điện thoại: {row.Cells[2].Value}\n" +
                            $"🏠 Địa chỉ: {row.Cells[3].Value}";

            MessageBox.Show(detail, "THÔNG TIN CHI TIẾT KHÁCH HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ================= XỬ LÝ XÓA (CÓ XÁC NHẬN) =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;

            string tenKH = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa khách hàng: {tenKH}?",
                "⚠️ XÁC NHẬN XÓA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                dgvKhachHang.Rows.RemoveAt(dgvKhachHang.CurrentRow.Index);
                MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo");
                ResetValues();
            }
        }

        // ================= CÁC CHỨC NĂNG CRUD =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaKH.Text = "KH" + DateTime.Now.ToString("ssmm"); // Sinh mã giả định
            txtTenKH.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtTenKH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text) || string.IsNullOrWhiteSpace(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvKhachHang.Rows.Add(txtMaKH.Text, txtTenKH.Text, txtDienThoai.Text, txtDiaChi.Text);
            MessageBox.Show("Đã lưu thông tin khách hàng!", "Thành công");
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;

            int i = dgvKhachHang.CurrentRow.Index;
            dgvKhachHang.Rows[i].Cells[1].Value = txtTenKH.Text;
            dgvKhachHang.Rows[i].Cells[2].Value = txtDienThoai.Text;
            dgvKhachHang.Rows[i].Cells[3].Value = txtDiaChi.Text;

            MessageBox.Show("Cập nhật thành công!", "Thông báo");
            ResetValues();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = row.Cells[0].Value?.ToString();
            txtTenKH.Text = row.Cells[1].Value?.ToString();
            txtDienThoai.Text = row.Cells[2].Value?.ToString();
            txtDiaChi.Text = row.Cells[3].Value?.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;

            txtTenKH.Enabled = true;
            txtDienThoai.Enabled = true;
            txtDiaChi.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
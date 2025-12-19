using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            ResetValues();
            LoadData();
        }

        // ================= THIẾT LẬP TRẠNG THÁI BAN ĐẦU =================
        private void ResetValues()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            rdoNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);

            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            dtpNgaySinh.Enabled = false;
            rdoNam.Enabled = false;
            rdoNu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
        }

        // ================= DỮ LIỆU MẪU =================
        private void LoadData()
        {
            dgvNhanVien.Rows.Clear();
            dgvNhanVien.Rows.Add("NV01", "Nguyễn Ngọc Bảo Ngân", "Nữ", "admin", "03/12/2005");
            dgvNhanVien.Rows.Add("NV02", "Lê Thị Bình", "Nữ", "nv02", "15/10/1998");
            dgvNhanVien.Rows.Add("NV03", "Phạm Hoàng Gia", "Nam", "nv03", "20/02/1992");
        }

        // ================= POPUP CHI TIẾT (DOUBLE CLICK) =================
        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            string info = $"🆔 Mã nhân viên: {row.Cells[0].Value}\n" +
                          $"👤 Họ và tên: {row.Cells[1].Value}\n" +
                          $"⚧ Giới tính: {row.Cells[2].Value}\n" +
                          $"🔐 Tài khoản: {row.Cells[3].Value}\n" +
                          $"📅 Ngày sinh: {row.Cells[4].Value}";

            MessageBox.Show(info, "THÔNG TIN CHI TIẾT NHÂN VIÊN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ================= XÁC NHẬN XÓA (CÓ POPUP) =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            string ten = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa nhân viên: {ten}?\nThao tác này không thể phục hồi!",
                "⚠️ CẢNH BÁO XÓA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.CurrentRow.Index);
                MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValues();
            }
        }

        // ================= CÁC NÚT CHỨC NĂNG KHÁC =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaNV.Text = "NV" + DateTime.Now.ToString("ssmm"); // Mã tự sinh giả định
            txtTenNV.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            txtTenNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvNhanVien.Rows.Add(txtMaNV.Text, txtTenNV.Text, rdoNam.Checked ? "Nam" : "Nữ", txtTaiKhoan.Text, dtpNgaySinh.Value.ToShortDateString());
            MessageBox.Show("Đã lưu dữ liệu!", "Thành công");
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            int i = dgvNhanVien.CurrentRow.Index;
            dgvNhanVien.Rows[i].Cells[1].Value = txtTenNV.Text;
            dgvNhanVien.Rows[i].Cells[2].Value = rdoNam.Checked ? "Nam" : "Nữ";
            dgvNhanVien.Rows[i].Cells[3].Value = txtTaiKhoan.Text;
            dgvNhanVien.Rows[i].Cells[4].Value = dtpNgaySinh.Value.ToShortDateString();

            MessageBox.Show("Cập nhật hoàn tất!", "Thông báo");
            ResetValues();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
            txtMaNV.Text = row.Cells[0].Value?.ToString();
            txtTenNV.Text = row.Cells[1].Value?.ToString();
            if (row.Cells[2].Value?.ToString() == "Nam") rdoNam.Checked = true; else rdoNu.Checked = true;
            txtTaiKhoan.Text = row.Cells[3].Value?.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            txtTenNV.Enabled = true;
            txtTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rdoNam.Enabled = true;
            rdoNu.Enabled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e) => ResetValues();
        private void btnDong_Click(object sender, EventArgs e) => this.Close();
    }
}
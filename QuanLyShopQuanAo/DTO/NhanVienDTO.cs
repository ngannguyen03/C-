using System;

namespace QuanLyShopQuanAo.DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }
        public string GioiTinh { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(string ma, string ten, string sdt, string chucvu, string gioitinh, string taikhoan, string matkhau, DateTime ngaysinh)
        {
            this.MaNV = ma;
            this.TenNV = ten;
            this.SDT = sdt;
            this.ChucVu = chucvu;
            this.GioiTinh = gioitinh;
            this.TaiKhoan = taikhoan;
            this.MatKhau = matkhau;
            this.NgaySinh = ngaysinh;
        }
    }
}
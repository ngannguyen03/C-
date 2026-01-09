using System;

namespace QuanLyShopQuanAo.DTO
{
    public class ThongKeDTO
    {
        public DateTime Ngay { get; set; }
        public int SoDonHang { get; set; }
        public int SoLuongSanPham { get; set; }
        public decimal DoanhThu { get; set; }

        public ThongKeDTO() { }
        public ThongKeDTO(DateTime ngay, int soDon, int soLuong, decimal doanhThu)
        {
            this.Ngay = ngay;
            this.SoDonHang = soDon;
            this.SoLuongSanPham = soLuong;
            this.DoanhThu = doanhThu;
        }
    }
}
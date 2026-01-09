using System;

namespace QuanLyShopQuanAo.DTO
{
    public class HoaDonDTO
    {
        public int MaHDBan { get; set; }
        public string MaNV { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal TongTien { get; set; }

        public HoaDonDTO() { }
        public HoaDonDTO(string maNV, int maKH, DateTime ngayBan, decimal tongTien)
        {
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.NgayBan = ngayBan;
            this.TongTien = tongTien;
        }
    }
}
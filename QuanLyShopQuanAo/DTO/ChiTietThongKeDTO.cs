namespace QuanLyShopQuanAo.DTO
{
    public class ChiTietThongKeDTO
    {
        public int MaHD { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public ChiTietThongKeDTO() { }
        public ChiTietThongKeDTO(int ma, string ten, int sl, decimal dg, decimal tt)
        {
            this.MaHD = ma;
            this.TenSP = ten;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.ThanhTien = tt;
        }
    }
}
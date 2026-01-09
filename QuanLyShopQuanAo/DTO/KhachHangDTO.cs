namespace QuanLyShopQuanAo.DTO
{
    public class KhachHangDTO
    {
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public KhachHangDTO() { }

        public KhachHangDTO(int ma, string ten, string diaChi, string dienThoai)
        {
            this.MaKH = ma;
            this.TenKH = ten;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }
    }
}
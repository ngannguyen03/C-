using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    public class SanPhamDTO
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; } // Dùng decimal cho tiền tệ để chính xác hơn

        public string MaDM { get; set; }

        //danh sach cac duong dan anh
        public List<string> DanhSachAnh { get; set; } = new List<string>();
        public SanPhamDTO() { }

        public SanPhamDTO(string ma, string ten, int soLuong, decimal donGia)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }
    }
}
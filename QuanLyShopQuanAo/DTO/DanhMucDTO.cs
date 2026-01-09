using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
    public class DanhMucDTO
    {
        // Khai báo các thuộc tính tương ứng với cột trong SQL
        public string MaDM { get; set; }
        public string TenDM { get; set; }

        // Constructor không tham số
        public DanhMucDTO() { }

        // Constructor có tham số để gán nhanh dữ liệu
        public DanhMucDTO(string ma, string ten)
        {
            this.MaDM = ma;
            this.TenDM = ten;
        }
    }
}
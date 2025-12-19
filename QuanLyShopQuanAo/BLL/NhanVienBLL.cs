using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();

        public string CheckLogin(NhanVienDTO nv)
        {
            if (string.IsNullOrEmpty(nv.TaiKhoan)) return "Sai tài khoản";
            if (string.IsNullOrEmpty(nv.MatKhau)) return "Sai mật khẩu";

            return dal.CheckLogin(nv);
        }
    }
}

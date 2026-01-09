using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class NhanVienBLL
    {
        NhanVienDAL dal = new NhanVienDAL();

        // --- HÀM KIỂM TRA ĐĂNG NHẬP (THEO ĐÚNG Ý BẠN) ---
        public string CheckLogin(NhanVienDTO nv)
        {
            if (string.IsNullOrEmpty(nv.TaiKhoan)) return "Sai tài khoản";
            if (string.IsNullOrEmpty(nv.MatKhau)) return "Sai mật khẩu";

            return dal.CheckLogin(nv);
        }

        // --- CÁC HÀM QUẢN LÝ ---
        public List<NhanVienDTO> GetAll() => dal.GetAll();
        public bool Add(NhanVienDTO nv) => dal.Insert(nv);
        public bool Edit(NhanVienDTO nv) => dal.Update(nv);
        public bool Remove(string ma) => dal.Delete(ma);
    }
}
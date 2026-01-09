using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class KhachHangBLL
    {
        KhachHangDAL dal = new KhachHangDAL();

        public List<KhachHangDTO> GetAll() => dal.GetAll();
        public bool Add(KhachHangDTO kh) => dal.Insert(kh);
        public bool Edit(KhachHangDTO kh) => dal.Update(kh);
        public bool Remove(int ma) => dal.Delete(ma);
    }
}
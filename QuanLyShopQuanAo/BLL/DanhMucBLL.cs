using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class DanhMucBLL
    {
        DanhMucDAL dal = new DanhMucDAL();

        public List<DanhMucDTO> GetAll() => dal.GetAll();

        public bool Add(DanhMucDTO dm) => dal.Insert(dm);

        public bool Edit(DanhMucDTO dm) => dal.Update(dm);

        public bool Remove(string maDM) => dal.Delete(maDM);
    }
}
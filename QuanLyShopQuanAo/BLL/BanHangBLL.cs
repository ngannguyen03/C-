using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class BanHangBLL
    {
        BanHangDAL dal = new BanHangDAL();

        public bool LuuHoaDon(HoaDonDTO hd, List<ChiTietHoaDonDTO> dsChiTiet)
        {
            try
            {
                // Bước 1: Lưu hóa đơn tổng, lấy mã ID
                int maHDMoi = dal.InsertHoaDon(hd);

                // Bước 2: Lưu từng dòng chi tiết
                foreach (var item in dsChiTiet)
                {
                    item.MaHDBan = maHDMoi; // Gán mã HD vừa tạo cho chi tiết
                    dal.InsertChiTiet(item);

                    // Bước 3: Trừ tồn kho
                    dal.UpdateGiamSoLuongSP(item.MaSP, item.SoLuong);
                }
                return true;
            }
            catch { return false; }
        }
    }
}
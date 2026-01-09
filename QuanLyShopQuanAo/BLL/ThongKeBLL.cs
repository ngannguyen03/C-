using System;
using System.Collections.Generic;
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class ThongKeBLL
    {
        ThongKeDAL dal = new ThongKeDAL();

        public List<ThongKeDTO> LayThongKe(DateTime tu, DateTime den)
        {
            // Có thể thêm logic kiểm tra ngày bắt đầu không được lớn hơn ngày kết thúc
            if (tu > den) return new List<ThongKeDTO>();
            return dal.GetThongKe(tu, den);
        }
        // chi tiet theo ngay
        public List<ChiTietThongKeDTO> LayChiTietTheoNgay(string ngayStr)
        {
            // Chuyển chuỗi dd/MM/yyyy từ GUI thành DateTime để DAL xử lý
            DateTime ngay = DateTime.ParseExact(ngayStr, "dd/MM/yyyy", null);
            return dal.GetChiTietTheoNgay(ngay);
        }
    }
}
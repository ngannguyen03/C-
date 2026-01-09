using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class ThongKeDAL
    {
        public List<ThongKeDTO> GetThongKe(DateTime tuNgay, DateTime denNgay)
        {
            List<ThongKeDTO> list = new List<ThongKeDTO>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                // Câu lệnh SQL: Gộp theo ngày, đếm số hóa đơn, tổng số lượng sản phẩm và tổng doanh thu
                string sql = @"
                    SELECT 
                        CAST(NgayBan AS DATE) as Ngay,
                        COUNT(DISTINCT HoaDon.MaHDBan) as SoDon,
                        SUM(ChiTietHoaDon.SoLuong) as TongSL,
                        SUM(DISTINCT HoaDon.TongTien) as DoanhThu
                    FROM HoaDon
                    LEFT JOIN ChiTietHoaDon ON HoaDon.MaHDBan = ChiTietHoaDon.MaHDBan
                    WHERE NgayBan >= @tuNgay AND NgayBan <= @denNgay
                    GROUP BY CAST(NgayBan AS DATE)
                    ORDER BY Ngay DESC";

                SqlCommand cmd = new SqlCommand(sql, conn);
                // Lưu ý: denNgay cần cộng thêm 1 ngày hoặc đặt là 23:59:59 để lấy hết dữ liệu trong ngày đó
                cmd.Parameters.AddWithValue("@tuNgay", tuNgay.Date);
                cmd.Parameters.AddWithValue("@denNgay", denNgay.Date.AddDays(1).AddSeconds(-1));

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new ThongKeDTO(
                        Convert.ToDateTime(rdr["Ngay"]),
                        Convert.ToInt32(rdr["SoDon"]),
                        rdr["TongSL"] != DBNull.Value ? Convert.ToInt32(rdr["TongSL"]) : 0,
                        Convert.ToDecimal(rdr["DoanhThu"])
                    ));
                }
            }
            return list;
        }

        //chi tiet  theo ngay
        public List<ChiTietThongKeDTO> GetChiTietTheoNgay(DateTime ngay)
        {
            List<ChiTietThongKeDTO> list = new List<ChiTietThongKeDTO>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = @"
            SELECT ct.MaHDBan, sp.TenSP, ct.SoLuong, ct.DonGia, ct.ThanhTien 
            FROM ChiTietHoaDon ct
            JOIN HoaDon hd ON ct.MaHDBan = hd.MaHDBan
            JOIN SanPham sp ON ct.MaSP = sp.MaSP
            WHERE CAST(hd.NgayBan AS DATE) = @ngay";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ngay", ngay.Date);

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new ChiTietThongKeDTO(
                        Convert.ToInt32(rdr["MaHDBan"]),
                        rdr["TenSP"].ToString(),
                        Convert.ToInt32(rdr["SoLuong"]),
                        Convert.ToDecimal(rdr["DonGia"]),
                        Convert.ToDecimal(rdr["ThanhTien"])
                    ));
                }
            }
            return list;
        }
    }
}
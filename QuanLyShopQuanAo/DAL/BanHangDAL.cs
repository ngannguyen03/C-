using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class BanHangDAL
    {
        // 1. Lưu hóa đơn chính và trả về ID tự tăng (MaHDBan)
        public int InsertHoaDon(HoaDonDTO hd)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                // Câu lệnh SQL thêm và lấy ngay mã vừa tạo (SCOPE_IDENTITY)
                string sql = "INSERT INTO HoaDon (MaNV, MaKH, NgayBan, TongTien) " +
                             "VALUES (@maNV, @maKH, @ngay, @tong); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maNV", hd.MaNV);
                cmd.Parameters.AddWithValue("@maKH", hd.MaKH);
                cmd.Parameters.AddWithValue("@ngay", hd.NgayBan);
                cmd.Parameters.AddWithValue("@tong", hd.TongTien);

                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // 2. Lưu chi tiết từng món hàng
        public bool InsertChiTiet(ChiTietHoaDonDTO ct)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "INSERT INTO ChiTietHoaDon (MaHDBan, MaSP, SoLuong, DonGia, ThanhTien) " +
                             "VALUES (@maHD, @maSP, @sl, @dg, @tt)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maHD", ct.MaHDBan);
                cmd.Parameters.AddWithValue("@maSP", ct.MaSP);
                cmd.Parameters.AddWithValue("@sl", ct.SoLuong);
                cmd.Parameters.AddWithValue("@dg", ct.DonGia);
                cmd.Parameters.AddWithValue("@tt", ct.ThanhTien);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 3. Cập nhật giảm số lượng tồn kho của sản phẩm sau khi bán
        public void UpdateGiamSoLuongSP(string maSP, int slBan)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "UPDATE SanPham SET SoLuong = SoLuong - @sl WHERE MaSP = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sl", slBan);
                cmd.Parameters.AddWithValue("@ma", maSP);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
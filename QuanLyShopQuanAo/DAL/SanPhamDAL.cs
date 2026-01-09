using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "SELECT * FROM SanPham";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new SanPhamDTO(
                        rdr["MaSP"].ToString(), rdr["TenSP"].ToString(),
                        Convert.ToInt32(rdr["SoLuong"]), Convert.ToDecimal(rdr["DonGia"])
                    ));
                }
            }
            return list;
        }

        public List<string> GetImagesByMaSP(string maSP)
        {
            List<string> list = new List<string>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "SELECT DuongDan FROM SanPhamAnh WHERE MaSP = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maSP);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) list.Add(rdr["DuongDan"].ToString());
            }
            return list;
        }

        // Thêm ảnh vào SP mới
        public bool Insert(SanPhamDTO sp)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction(); // Bắt đầu giao dịch
                try
                {
                    // 1. Lưu thông tin sản phẩm vào bảng SanPham
                    // Lưu ý: Kiểm tra số lượng cột trong bảng SanPham của bạn (MaSP, TenSP, SoLuong, DonGia, MaDM, GhiChu, Anh)
                    string sqlSP = "INSERT INTO SanPham (MaSP, TenSP, SoLuong, DonGia) VALUES (@ma, @ten, @sl, @gia)";
                    SqlCommand cmd = new SqlCommand(sqlSP, conn, trans);
                    cmd.Parameters.AddWithValue("@ma", sp.MaSP);
                    cmd.Parameters.AddWithValue("@ten", sp.TenSP);
                    cmd.Parameters.AddWithValue("@sl", sp.SoLuong);
                    cmd.Parameters.AddWithValue("@gia", sp.DonGia);
                    cmd.ExecuteNonQuery();

                    // 2. Lưu danh sách ảnh vào bảng SanPhamAnh
                    foreach (string path in sp.DanhSachAnh)
                    {
                        string sqlImg = "INSERT INTO SanPhamAnh (MaSP, DuongDan) VALUES (@maSP, @path)";
                        SqlCommand cmdImg = new SqlCommand(sqlImg, conn, trans);
                        cmdImg.Parameters.AddWithValue("@maSP", sp.MaSP);
                        cmdImg.Parameters.AddWithValue("@path", path);
                        cmdImg.ExecuteNonQuery();
                    }

                    trans.Commit(); // Hoàn tất lưu mọi thứ
                    return true;
                }
                catch (Exception)
                {
                    trans.Rollback(); // Nếu lỗi thì hủy hết
                    return false;
                }
            }
        }

        // Cập nhật SP và thay đổi ảnh
        public bool Update(SanPhamDTO sp)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật bảng SanPham
                    string sqlSP = "UPDATE SanPham SET TenSP=@ten, SoLuong=@sl, DonGia=@gia WHERE MaSP=@ma";
                    SqlCommand cmd = new SqlCommand(sqlSP, conn, trans);
                    cmd.Parameters.AddWithValue("@ma", sp.MaSP);
                    cmd.Parameters.AddWithValue("@ten", sp.TenSP);
                    cmd.Parameters.AddWithValue("@sl", sp.SoLuong);
                    cmd.Parameters.AddWithValue("@gia", sp.DonGia);
                    cmd.ExecuteNonQuery();

                    // 2. Xóa hết ảnh cũ của sản phẩm này trong DB
                    SqlCommand delImg = new SqlCommand("DELETE FROM SanPhamAnh WHERE MaSP=@ma", conn, trans);
                    delImg.Parameters.AddWithValue("@ma", sp.MaSP);
                    delImg.ExecuteNonQuery();

                    // 3. Lưu lại danh sách ảnh mới từ danh sách tạm
                    foreach (string path in sp.DanhSachAnh)
                    {
                        SqlCommand cmdImg = new SqlCommand("INSERT INTO SanPhamAnh (MaSP, DuongDan) VALUES (@maSP, @path)", conn, trans);
                        cmdImg.Parameters.AddWithValue("@maSP", sp.MaSP);
                        cmdImg.Parameters.AddWithValue("@path", path);
                        cmdImg.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception)
                {
                    trans.Rollback();
                    return false;
                }
            }
        }
        public bool Delete(string maSP)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "DELETE FROM SanPham WHERE MaSP = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maSP);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
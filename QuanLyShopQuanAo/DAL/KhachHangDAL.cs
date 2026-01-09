using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> GetAll()
        {
            List<KhachHangDTO> list = new List<KhachHangDTO>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "SELECT * FROM KhachHang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new KhachHangDTO(
                        Convert.ToInt32(rdr["MaKH"]),
                        rdr["TenKH"].ToString(),
                        rdr["DiaChi"].ToString(),
                        rdr["DienThoai"].ToString()
                    ));
                }
            }
            return list;
        }

        public bool Insert(KhachHangDTO kh)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                // Không chèn MaKH vì là IDENTITY
                string sql = "INSERT INTO KhachHang (TenKH, DiaChi, DienThoai) VALUES (@ten, @dc, @dt)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ten", kh.TenKH);
                cmd.Parameters.AddWithValue("@dc", kh.DiaChi);
                cmd.Parameters.AddWithValue("@dt", kh.DienThoai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(KhachHangDTO kh)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "UPDATE KhachHang SET TenKH=@ten, DiaChi=@dc, DienThoai=@dt WHERE MaKH=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", kh.MaKH);
                cmd.Parameters.AddWithValue("@ten", kh.TenKH);
                cmd.Parameters.AddWithValue("@dc", kh.DiaChi);
                cmd.Parameters.AddWithValue("@dt", kh.DienThoai);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maKH)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "DELETE FROM KhachHang WHERE MaKH=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maKH);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
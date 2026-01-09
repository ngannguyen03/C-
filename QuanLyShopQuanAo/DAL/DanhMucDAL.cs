using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient; // Dùng thư viện giống file DatabaseConnect của bạn
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class DanhMucDAL
    {
        // 1. Hàm lấy danh sách danh mục (Read)
        public List<DanhMucDTO> GetAll()
        {
            List<DanhMucDTO> list = new List<DanhMucDTO>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "SELECT * FROM DanhMuc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new DanhMucDTO(rdr["MaDM"].ToString(), rdr["TenDM"].ToString()));
                }
            }
            return list;
        }

        // 2. Hàm thêm mới (Insert)
        public bool Insert(DanhMucDTO dm)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "INSERT INTO DanhMuc (MaDM, TenDM) VALUES (@ma, @ten)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", dm.MaDM);
                cmd.Parameters.AddWithValue("@ten", dm.TenDM);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 3. Hàm sửa (Update)
        public bool Update(DanhMucDTO dm)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "UPDATE DanhMuc SET TenDM = @ten WHERE MaDM = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", dm.MaDM);
                cmd.Parameters.AddWithValue("@ten", dm.TenDM);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 4. Hàm xóa (Delete)
        public bool Delete(string maDM)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "DELETE FROM DanhMuc WHERE MaDM = @ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maDM);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient; // Thư viện kết nối SQL
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class NhanVienDAL
    {
        // --- HÀM KIỂM TRA ĐĂNG NHẬP (MỚI KHÔI PHỤC) ---
        public string CheckLogin(NhanVienDTO nv)
        {
            string chucvu = null;
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                // Truy vấn lấy Chức vụ nếu Tài khoản và Mật khẩu khớp
                string sql = "SELECT ChucVu FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tk", nv.TaiKhoan);
                cmd.Parameters.AddWithValue("@mk", nv.MatKhau);

                conn.Open();
                object result = cmd.ExecuteScalar(); // Lấy giá trị đầu tiên (Chức vụ)
                if (result != null)
                {
                    chucvu = result.ToString();
                }
            }
            return chucvu; // Trả về "Quản lý", "Nhân viên" hoặc null nếu sai
        }

        // --- CÁC HÀM QUẢN LÝ NHÂN VIÊN ---
        public List<NhanVienDTO> GetAll()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "SELECT * FROM NhanVien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new NhanVienDTO(
                        rdr["MaNV"].ToString(), rdr["TenNV"].ToString(), rdr["SDT"].ToString(),
                        rdr["ChucVu"].ToString(), rdr["GioiTinh"].ToString(), rdr["TaiKhoan"].ToString(),
                        rdr["MatKhau"].ToString(), Convert.ToDateTime(rdr["NgaySinh"])));
                }
            }
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "INSERT INTO NhanVien VALUES (@ma, @ten, @sdt, @cv, @gt, @tk, @mk, @ns)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", nv.MaNV);
                cmd.Parameters.AddWithValue("@ten", nv.TenNV);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@cv", nv.ChucVu);
                cmd.Parameters.AddWithValue("@gt", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@tk", nv.TaiKhoan);
                cmd.Parameters.AddWithValue("@mk", nv.MatKhau);
                cmd.Parameters.AddWithValue("@ns", nv.NgaySinh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "UPDATE NhanVien SET TenNV=@ten, SDT=@sdt, ChucVu=@cv, GioiTinh=@gt, TaiKhoan=@tk, MatKhau=@mk, NgaySinh=@ns WHERE MaNV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", nv.MaNV);
                cmd.Parameters.AddWithValue("@ten", nv.TenNV);
                cmd.Parameters.AddWithValue("@sdt", nv.SDT);
                cmd.Parameters.AddWithValue("@cv", nv.ChucVu);
                cmd.Parameters.AddWithValue("@gt", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@tk", nv.TaiKhoan);
                cmd.Parameters.AddWithValue("@mk", nv.MatKhau);
                cmd.Parameters.AddWithValue("@ns", nv.NgaySinh);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maNV)
        {
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                string sql = "DELETE FROM NhanVien WHERE MaNV=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", maNV);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
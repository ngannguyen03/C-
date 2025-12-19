using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.DAL
{
    public class NhanVienDAL
    {
        public string CheckLogin(NhanVienDTO nv)
        {
            string user = null;
            using (SqlConnection conn = DatabaseConnect.Connect())
            {
                conn.Open();
                // Câu lệnh SQL kiểm tra đăng nhập
                string query = "SELECT ChucVu FROM NhanVien WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", nv.TaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", nv.MatKhau);

                    var result = cmd.ExecuteScalar();
                    if (result != null) user = result.ToString();
                }
            }
            return user;
        }
    }
}

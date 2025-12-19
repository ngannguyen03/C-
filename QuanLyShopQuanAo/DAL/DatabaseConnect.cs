using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyShopQuanAo.DAL
{
    public class DatabaseConnect
    {
        static string strConnect = @"Data Source=BAONGAN0312\SQLEXPRESS;Initial Catalog=QuanLyShopQuanAo;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection Connect()
        {
            return new SqlConnection(strConnect);
        }
    }
}
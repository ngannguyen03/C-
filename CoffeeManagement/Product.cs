using System;
using System.Collections.Generic;

namespace CoffeeManagement
{
    // Lớp đối tượng Đồ uống
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; } // Đường dẫn ảnh
    }

    // Lớp tĩnh để lưu dữ liệu dùng chung cho toàn bộ ứng dụng
    public static class DataStore
    {
        public static List<Product> ListProduct = new List<Product>()
        {
            // Tạo sẵn vài dữ liệu mẫu
            new Product() { ID = "CF01", Name = "Cà phê Đen", Category = "Cà phê", Price = 20000 },
            new Product() { ID = "CF02", Name = "Cà phê Sữa", Category = "Cà phê", Price = 25000 },
            new Product() { ID = "ST01", Name = "Sinh tố Bơ", Category = "Sinh tố", Price = 35000 },
            new Product() { ID = "NE01", Name = "Nước ép Cam", Category = "Nước ép", Price = 30000 }
        };
    }
}
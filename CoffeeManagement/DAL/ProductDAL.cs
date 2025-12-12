using System.Collections.Generic;
using CoffeeManagement.DTO;

namespace CoffeeManagement.DAL
{
    public class ProductDAL
    {
        // Danh sách món mẫu
        private static List<Product> listProduct = new List<Product>()
        {
            new Product() { ID = "01", Name = "Cafe Đen", Category = "Cafe", Price = 20000 },
            new Product() { ID = "02", Name = "Cafe Sữa", Category = "Cafe", Price = 25000 },
            new Product() { ID = "03", Name = "Sinh tố Bơ", Category = "Sinh Tố", Price = 35000 }
        };

        // Lấy tất cả món
        public List<Product> GetAllProducts()
        {
            return listProduct;
        }

        // Thêm món mới
        public void AddProduct(Product p)
        {
            listProduct.Add(p);
        }

        // Xóa món
        public void RemoveProduct(string id)
        {
            Product p = listProduct.Find(x => x.ID == id);
            if (p != null)
            {
                listProduct.Remove(p);
            }
        }
    }
}
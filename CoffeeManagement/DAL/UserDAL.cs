using System.Collections.Generic;
using CoffeeManagement.DTO; // Gọi thư mục DTO

namespace CoffeeManagement.DAL
{
    public class UserDAL
    {
        // Danh sách tài khoản mẫu
        private static List<User> listUser = new List<User>()
        {
            new User() { Username = "admin", Password = "123", FullName = "Quản Trị Viên" },
            new User() { Username = "staff", Password = "1", FullName = "Nhân Viên A" }
        };

        public bool CheckLogin(string user, string pass)
        {
            foreach (var item in listUser)
            {
                if (item.Username == user && item.Password == pass)
                    return true;
            }
            return false;
        }
    }
}
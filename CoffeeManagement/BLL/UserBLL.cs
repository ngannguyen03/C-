using CoffeeManagement.DAL; // Gọi DAL

namespace CoffeeManagement.BLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();

        public bool IsValidUser(string user, string pass)
        {
            // Nghiệp vụ: Không được để trống
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                return false;

            return dal.CheckLogin(user, pass);
        }
    }
}
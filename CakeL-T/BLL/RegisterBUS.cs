using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class RegisterBUS
    {
        public string Register(string username, string password, string address, string fullname, string phone)
        {
            try
            {
                LoginDAL login = new LoginDAL();
            var tbAccount = login.GetAccounts();
            foreach (var account in tbAccount)
            {
                if (account.TenTK == username)
                {
                    return "Username already exists";
                }
                else if (account.SoDienThoai == phone)
                {
                    return "Phone number already exists";
                }
            }
           
                RegisterDAL register = new RegisterDAL();
                if (register.Register(username, password, address, fullname, phone) == "success")
                {
                    return "success";
                }
            }
            catch (Exception)
            {
                return "error";
            }
            return "success";
        }
    }
}

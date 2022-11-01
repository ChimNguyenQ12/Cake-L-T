using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdminBUS
    {
        public List<TaiKhoan> GetAccounts()
        {
            List<TaiKhoan> listAccount = new List<TaiKhoan>();
            AdminDAL adminDAL = new AdminDAL();
            listAccount = adminDAL.GetAccounts().ToList();
            return listAccount;
        }

        public List<TaiKhoan> GetAccountById(int id)
        {
            try
            {
                List<TaiKhoan> accountById = new List<TaiKhoan>();
                AdminDAL adminDAL = new AdminDAL();
                accountById = adminDAL.GetAccountById(id);
                return accountById;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void UpdateAccountById(int id, string fullname, string username, string password, string address, string phone)
        {
            try
            {
                AdminDAL adminDAL = new AdminDAL();
                adminDAL.UpdateAccountById(id, fullname, username, password, address, phone);
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public void DeleteAccountById(int id)
        {
            try
            {
                AdminDAL adminDAL = new AdminDAL();
                adminDAL.DeleteAccountById(id);
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }
    }
}

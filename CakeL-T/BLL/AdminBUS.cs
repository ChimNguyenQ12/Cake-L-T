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

        public void UpdateAccountById(int id, string fullname, string username, string password, string address, string phone, string image, bool status)
        {
            try
            {
                AdminDAL adminDAL = new AdminDAL();
                adminDAL.UpdateAccountById(id, fullname, username, password, address, phone, image, status);
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

        public List<TaiKhoan> SearchAccount(string key)
        {
            try
            {
                List<TaiKhoan> accountSearch = new List<TaiKhoan>();
                AdminDAL adminDAL = new AdminDAL();
                accountSearch = adminDAL.SearchAccount(key);
                return accountSearch;
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }

        public List<TaiKhoan> SearchAccountMulti(string name, string phone, bool status)
        {
            try
            {
                List<TaiKhoan> accountSearch = new List<TaiKhoan>();
                AdminDAL adminDAL = new AdminDAL();
                accountSearch = adminDAL.SearchAccountMulti(name,phone, status);
                return accountSearch;
            }
            catch (Exception)
            {
                throw new Exception("error");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class LoginBUS
    {
        public string checkLogin(string username, string password)
        {
            try
            {
                List<TaiKhoan> list = new List<TaiKhoan>();
                LoginDAL login = new LoginDAL();
                list = login.GetAccounts();
                foreach (var account in list)
                {
                    if (account.TenTK == username && account.MatKhau == password && account.TrangThaiXoa == false && account.LoaiTK == false && account.TrangThai == false)
                        return "lock";
                    if (account.TenTK == username && account.MatKhau == password && account.TrangThaiXoa == false && account.LoaiTK == true)
                        return "admin";
                    else if (account.TenTK == username && account.MatKhau == password && account.TrangThaiXoa == false && account.LoaiTK == false)
                        return "staff";
                }
            }
            catch (Exception)
            {
                return "error";
            }
            return "success";
        }

        public List<TaiKhoan> GetAccountByUsername(string username)
        {
            try
            {
                List<TaiKhoan> accountByUsername= new List<TaiKhoan>();
                LoginDAL loginDAL = new LoginDAL();
                accountByUsername = loginDAL.GetAccountByUsername(username);
                return accountByUsername;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<TaiKhoan> GetAccountById(int id)
        {
            try
            {
                List<TaiKhoan> accountById = new List<TaiKhoan>();
                LoginDAL loginDAL = new LoginDAL();
                accountById = loginDAL.GetAccountById(id);
                return accountById;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ChangePassword(int idTk, string currentPass, string newPass, string repeatPass)
        {
            try
            {
               
                LoginDAL loginDAL = new LoginDAL();
                loginDAL.ChangePassword(idTk,currentPass, newPass,repeatPass);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

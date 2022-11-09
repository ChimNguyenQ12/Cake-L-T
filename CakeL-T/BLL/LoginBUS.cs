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
    }
}

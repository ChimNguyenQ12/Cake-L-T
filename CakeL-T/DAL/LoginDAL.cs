using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
      public List<TaiKhoan> GetAccounts()
        {
            List<TaiKhoan> listAccount = new List<TaiKhoan>();
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var tbAccount = cakeEntities.TaiKhoans.ToList();
                foreach(var i in tbAccount)
                {
                    TaiKhoan account = new TaiKhoan();
                    account.Id = i.Id;
                    account.TenTK = i.TenTK;
                    account.HoTen = i.HoTen;
                    account.MatKhau = i.MatKhau;
                    account.DiaChi = i.DiaChi;
                    account.LoaiTK = i.LoaiTK;
                    account.SoDienThoai = i.SoDienThoai;
                    account.TrangThai = i.TrangThai;

                    listAccount.Add(account);
                }
            }
            return listAccount;
        }

        public List<TaiKhoan> GetAccountByUsername(string username)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var accountByUsername = cakeEntities.TaiKhoans.Where(x => x.TenTK == username).ToList();
                return accountByUsername;
            }
        }

        public List<TaiKhoan> GetAccountById(int id)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var accountById = cakeEntities.TaiKhoans.Where(x => x.Id == id).ToList();
                return accountById;
            }
        }

        public void ChangePassword(int idTk,string currentPass, string newPass, string repeatPass)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var accountCurrent = cakeEntities.TaiKhoans.Where(x => x.Id == idTk).FirstOrDefault();
          
                    accountCurrent.MatKhau = newPass;
                    cakeEntities.SaveChanges();
                
            }
        }

    }
}

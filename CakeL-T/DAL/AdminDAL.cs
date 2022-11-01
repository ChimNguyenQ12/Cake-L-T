using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDAL
    {
        public List<TaiKhoan> GetAccounts()
        {
            List<TaiKhoan> listAccount = new List<TaiKhoan>();
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var tbAccount = cakeEntities.TaiKhoans.Where(x => x.TrangThai == true).ToList();
                foreach (var i in tbAccount)
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

        public List<TaiKhoan> GetAccountById(int id)
        {
            List<TaiKhoan> account = new List<TaiKhoan>();
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                account = cakeEntities.TaiKhoans.Where(x => x.Id == id).ToList();
            }
            return account;

        }

        public void UpdateAccountById(int id, string fullname, string username, string password, string address, string phone)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var accountCurrent = cakeEntities.TaiKhoans.Where(x => x.Id == id).FirstOrDefault();
                accountCurrent.HoTen = fullname;
                accountCurrent.MatKhau = password;
                accountCurrent.DiaChi = address;
                accountCurrent.SoDienThoai = phone;
                accountCurrent.TenTK = username;

                cakeEntities.SaveChanges();
            }

        }

        public void DeleteAccountById(int id)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var accountCurrent = cakeEntities.TaiKhoans.Where(x => x.Id == id).FirstOrDefault();
                accountCurrent.TrangThai = false;
                cakeEntities.SaveChanges();
            }

        }
    }
}

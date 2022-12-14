using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdminDAL
    {
        CakeEntities cakeEntities = new CakeEntities();
        public List<TaiKhoan> GetAccounts()
        {
            List<TaiKhoan> listAccount = new List<TaiKhoan>();
                var tbAccount = cakeEntities.TaiKhoans.Where(x => x.TrangThaiXoa == false).ToList();
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
                    account.TrangThaiXoa = i.TrangThaiXoa;
                    account.TenLoaiTrangThai = i.TenLoaiTrangThai;
                    account.HinhAnh = i.HinhAnh;
                    listAccount.Add(account);
                }
            return listAccount;
        }

        public List<TaiKhoan> GetAccountById(int id)
        {
            List<TaiKhoan> account = new List<TaiKhoan>();
                account = cakeEntities.TaiKhoans.Where(x => x.Id == id).ToList();
            return account;

        }

        public void UpdateAccountById(int id, string fullname, string username, string password, string address, string phone, byte[] image, bool status)
        {
                var accountCurrent = cakeEntities.TaiKhoans.Where(x => x.Id == id).FirstOrDefault();
                accountCurrent.HoTen = fullname;
                accountCurrent.MatKhau = password;
                accountCurrent.DiaChi = address;
                accountCurrent.SoDienThoai = phone;
                accountCurrent.TenTK = username;
                accountCurrent.HinhAnh = image;
                accountCurrent.TrangThai = status;
                if(status == true)
                {
                accountCurrent.TenLoaiTrangThai = "Hoạt động";
                }
                else if(status == false)
                {
                accountCurrent.TenLoaiTrangThai = "Khóa";
                }
                cakeEntities.SaveChanges();
        }

        public void DeleteAccountById(int id)
        {
                var accountCurrent = cakeEntities.TaiKhoans.Where(x => x.Id == id).FirstOrDefault();
                accountCurrent.TrangThaiXoa = true;
                cakeEntities.SaveChanges();
        }

        public List<TaiKhoan> SearchAccount(string key)
        {
            List<TaiKhoan> accountSearch = new List<TaiKhoan>();
            accountSearch = cakeEntities.TaiKhoans.Where(x => x.TenTK.Contains(key) && x.TrangThaiXoa == false || x.DiaChi.Contains(key) && x.TrangThaiXoa == false || x.SoDienThoai.Contains(key) && x.TrangThaiXoa == false)
                                                .ToList();
            return accountSearch;
        }

        public List<TaiKhoan> SearchAccountMulti(string name,string phone, bool status)
        {
            List<TaiKhoan> accountSearch = new List<TaiKhoan>();
            accountSearch = cakeEntities.TaiKhoans.Where(x => x.TenTK.Contains(name) && x.TrangThaiXoa == false)
                                                  .Where(x => x.SoDienThoai.Contains(phone) && x.TrangThaiXoa == false)
                                                  .Where(x => x.TrangThai == status && x.TrangThaiXoa == false)
                                                .ToList();
            return accountSearch;
        }

        private string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        public void ResetPass(int id)
        {
            var accountCurrent = cakeEntities.TaiKhoans.Where(x => x.Id == id).FirstOrDefault();
            accountCurrent.MatKhau = Encrypt("1");
            cakeEntities.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegisterDAL
    {
        public string Register(string username, string password, string address, string fullname, string phone)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                cakeEntities.TaiKhoans.Add(new TaiKhoan()
                {
                    TenTK = username,
                    MatKhau = password,
                    DiaChi = address,
                    HoTen = fullname,
                    SoDienThoai = phone,
                    TrangThai = true,
                    LoaiTK = false,
                    TrangThaiXoa = false,
                });
                cakeEntities.SaveChanges();
            }
            return "success";
        }
    }
}

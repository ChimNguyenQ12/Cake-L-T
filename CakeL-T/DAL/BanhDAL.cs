using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanhDAL
    {
        public List<Banh> GetCakes()
        {
            List<Banh> listCake = new List<Banh>();
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var tbCake = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false).ToList();
                foreach (var i in tbCake)
                {
                    Banh cake = new Banh();
                    cake.LoaiBanh = i.LoaiBanh;
                    cake.MaBanh = i.MaBanh;
                    cake.TenBanh = i.TenBanh;
                    cake.SoLuong = i.SoLuong;
                    cake.DonGia = i.DonGia;
                    cake.NgaySanXuat = i.NgaySanXuat;
                    cake.NgayHetHan = i.NgayHetHan;
                    cake.HinhAnh = i.HinhAnh;
                    cake.TrangThaiXoa = i.TrangThaiXoa;

                    listCake.Add(cake);
                }
            }
            return listCake;
        }

        public List<Banh> GetCakeById(int code)
        {
            List<Banh> cake = new List<Banh>();
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                cake = cakeEntities.Banhs.Where(x => x.MaBanh == code).ToList();
            }
            return cake;

        }

        public void UpdateCakeById(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
                cakeCurrent.LoaiBanh = category;
                cakeCurrent.TenBanh = name;
                cakeCurrent.SoLuong = quanity;
                cakeCurrent.DonGia = price;
                cakeCurrent.NgaySanXuat = dateManu;
                cakeCurrent.NgayHetHan = dateExpire;
                cakeCurrent.HinhAnh = image;

                cakeEntities.SaveChanges();
            }

        }

        public void DeleteCakeById(int code)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
                cakeCurrent.TrangThaiXoa = true;
                cakeEntities.SaveChanges();
            }

        }

        public string AddCake(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
        {
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                cakeEntities.Banhs.Add(new Banh()
                {
                    MaBanh = code,
                    TenBanh = name,
                    LoaiBanh = category,
                    SoLuong = quanity,
                    DonGia = price,
                    NgayHetHan = dateExpire,
                    NgaySanXuat = dateManu,
                    TrangThaiXoa = false,
                    HinhAnh = image
                });
                cakeEntities.SaveChanges();
            }
            return "success";
        }
    }
}

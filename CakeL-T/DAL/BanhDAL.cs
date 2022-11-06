using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanhDAL
    {
        CakeEntities cakeEntities = new CakeEntities();
        public List<Banh> GetCakes()
        {
            List<Banh> listCake = new List<Banh>();
           
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
            var results = (from c in cakeEntities.LoaiBanhs
                           join p in cakeEntities.Banhs on c.MaLoai equals p.LoaiBanh
                           select new { category = c, product = p })
                         .GroupBy(x => x.category.MaLoai)
                         .ToList();
            return listCake;
        }

        public List<Banh> GetCakeById(int code)
        {
                List<Banh> cake = new List<Banh>();
                cake = cakeEntities.Banhs.Where(x => x.MaBanh == code).ToList();
                return cake;

        }

        public void UpdateCakeById(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
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

        public void DeleteCakeById(int code)
        {
                var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
                cakeCurrent.TrangThaiXoa = true;
                cakeEntities.SaveChanges();
        }

        public string AddCake(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
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
            return "success";
        }

        public List<Banh> SearchCake(string key)
        {
            List<Banh> accountBanh = new List<Banh>();
            accountBanh = cakeEntities.Banhs.Where(x => x.TenBanh.Contains(key) && x.TrangThaiXoa == false)
                                                .ToList();
            return accountBanh;
        }

        public List<Banh> SearchCakeMulti(int price, int codeCategory, DateTime dateManu, DateTime dateExpire)
        {
            List<Banh> accountBanh = new List<Banh>();
            if (price == 0 && codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.NgaySanXuat == dateManu && x.NgayHetHan == dateExpire && x.TrangThaiXoa == false)
                                                .ToList();
            }
            else if(price == 50000) { 
            accountBanh = cakeEntities.Banhs.Where(x => x.DonGia < 50000 && x.TrangThaiXoa == false)
                                            .Where(x => x.LoaiBanh == codeCategory && x.TrangThaiXoa == false)
                                            .Where(x => x.NgaySanXuat == dateManu && x.NgayHetHan == dateExpire && x.TrangThaiXoa == false)
                                                .ToList();
            } 
            else if(price == 75000)
            {
            accountBanh = cakeEntities.Banhs.Where(x => x.DonGia > 50000 && x.DonGia < 100000 && x.TrangThaiXoa == false)
                                                .ToList();
            }
            else if (price == 150000)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.DonGia > 100000 && x.DonGia < 200000 && x.TrangThaiXoa == false)
                                                    .ToList();
            }
            else if (price == 200000)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.DonGia > 200000 && x.TrangThaiXoa == false)
                                                    .ToList();
            }
            return accountBanh;
        }
    }
}

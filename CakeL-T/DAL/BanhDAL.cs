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
                cake.TrangThaiBanh = i.TrangThaiBanh;
                cake.DonGia = i.DonGia;
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
        public List<Banh> GetCakeByName(string nameCake)
        {
            List<Banh> cake = new List<Banh>();
            cake = cakeEntities.Banhs.Where(x => x.TenBanh == nameCake).ToList();
            return cake;

        }
        public void UpdateCakeById(int code, int category, string name, bool status, int price, string image)
        {
            var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
            cakeCurrent.LoaiBanh = category;
            cakeCurrent.TenBanh = name;
            cakeCurrent.TrangThaiBanh = status;
            cakeCurrent.DonGia = price;
            cakeCurrent.HinhAnh = image;

            cakeEntities.SaveChanges();
        }

        public void DeleteCakeById(int code, int category, string name, int price, string image)
        {
            var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
            cakeEntities.Banhs.Remove(cakeCurrent);
            cakeEntities.Banhs.Add(new Banh()
            {
                MaBanh = int.Parse(DateTime.Now.ToString("MMddHHmmss")),
                TenBanh = name,
                LoaiBanh = category,
                TrangThaiBanh = true,
                DonGia = price,
                TrangThaiXoa = true,
                HinhAnh = image
            });
            cakeEntities.SaveChanges();
        }

        public string AddCake(int code, int category, string name, int price, string image)
        {
            cakeEntities.Banhs.Add(new Banh()
            {
                MaBanh = code,
                TenBanh = name,
                LoaiBanh = category,
                TrangThaiBanh = true,
                DonGia = price,
                TrangThaiXoa = false,
                HinhAnh = image
            });
            cakeEntities.SaveChanges();
            return "success";
        }

        public List<Banh> SearchCake(string key)
        {
            List<Banh> accountBanh = new List<Banh>();
            if (key == "0")
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false)
                                                .ToList();
            }
            else
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.MaBanh.ToString().Contains(key) && x.TrangThaiXoa == false)
                                                .ToList();
            }
            return accountBanh;
        }

        public List<Banh> SearchCakeStaff(string key)
        {
            List<Banh> accountBanh = new List<Banh>();
            accountBanh = cakeEntities.Banhs.Where(x => x.TenBanh.Contains(key) && x.TrangThaiXoa == false)
                                                .ToList();
            return accountBanh;
        }

        public List<Banh> SearchCakeStatus(bool status)
        {
            List<Banh> accountBanh = new List<Banh>();
            accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .ToList();
            return accountBanh;
        }

        public List<Banh> SearchCakeName(string name)
        {
            List<Banh> accountBanh = new List<Banh>();
            if (name == null)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false)
                                                .ToList();
            }
            accountBanh = cakeEntities.Banhs.Where(x => x.TenBanh.Contains(name) && x.TrangThaiXoa == false)
                                                .ToList();
            return accountBanh;
        }

        public List<Banh> SearchCakeMulti(int minPrice, int maxPrice, int price, int codeCategory, bool status)
        {
            List<Banh> accountBanh = new List<Banh>();
            if (price == 0 && codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false && x.TrangThaiBanh == status)
                                                .ToList();
            }
            else if (price == 0 && codeCategory != 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            else if (minPrice == 1 && maxPrice == 1 && codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .ToList();
            }
            else if (minPrice == 1 && maxPrice == 1 && codeCategory != 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            else if (minPrice == 200000)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status)
                                                .Where(x => x.DonGia > 200000 && x.TrangThaiBanh == false)
                                                .ToList();
            }
            else if (price != 1)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .Where(x => x.DonGia == price && x.TrangThaiXoa == false)
                                                .ToList();
            }
            else if (codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.DonGia > minPrice && x.DonGia < maxPrice && x.TrangThaiXoa == false)
                                               .Where(x => x.TrangThaiBanh == status)
                                               .ToList();
            }
            else
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.DonGia > minPrice && x.DonGia < maxPrice && x.TrangThaiXoa == false)
                                               .Where(x => x.TrangThaiBanh == status)
                                               .Where(x => x.LoaiBanh == codeCategory)
                                               .ToList();
            }
            return accountBanh;
        }
    }
}

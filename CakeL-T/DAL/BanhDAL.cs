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
                cake.TenLoaiBanh = i.TenLoaiBanh;
                cake.TenTrangThaiBanh = i.TenTrangThaiBanh;

                listCake.Add(cake);
            }
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
            var CateCakeName = cakeEntities.LoaiBanhs.Where(x => x.MaLoai == category).FirstOrDefault();
            var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
            cakeCurrent.LoaiBanh = category;
            cakeCurrent.TenBanh = name;
            cakeCurrent.TrangThaiBanh = status;
            cakeCurrent.DonGia = price;
            cakeCurrent.HinhAnh = image;
            if(status == true)
            {
                cakeCurrent.TenTrangThaiBanh = "Còn hàng";
            }
            else if(status == false)
            {
                cakeCurrent.TenTrangThaiBanh = "Hết hàng";
            }
            cakeCurrent.TenLoaiBanh = CateCakeName.TenLoai;
            cakeEntities.SaveChanges();
        }

        public void DeleteCakeById(int code)
        {
            var cakeCurrent = cakeEntities.Banhs.Where(x => x.MaBanh == code).FirstOrDefault();
            cakeCurrent.TrangThaiXoa = true;
            cakeEntities.SaveChanges();
        }

        public string AddCake(int category, string name, int price, string image)
        {
            var cakeCateName = cakeEntities.LoaiBanhs.Where(x => x.MaLoai.ToString() == category.ToString()).FirstOrDefault();
            cakeEntities.Banhs.Add(new Banh()
            {
                TenBanh = name,
                LoaiBanh = category,
                TrangThaiBanh = true,
                DonGia = price,
                TrangThaiXoa = false,
                HinhAnh = image,
                TenTrangThaiBanh="Còn hàng",
                TenLoaiBanh = cakeCateName.TenLoai
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

        public List<Banh> SearchCakeMulti(int minPrice, int maxPrice, int codeCategory, bool status)
        {
            List<Banh> accountBanh = new List<Banh>();
            // Trường hợp không chọn loại nhưng chọn tất cả giá
            if (codeCategory == 0 && maxPrice == 1 && minPrice ==1)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false && x.TrangThaiBanh == status)
                                                .ToList();
            }
            // Trường hợp không chọn loại nhưng chọn giá > 200000
            else if (minPrice == 200000 && codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status)
                                                .Where(x => x.DonGia >= 200000)
                                                .ToList();
            }
            // Trường hợp có chọn loại nhưng chọn giá > 200000
            else if (minPrice == 200000 && codeCategory != 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status)
                                                .Where(x => x.DonGia >= 200000)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            // Trường hợp không chọn loại nhưng chọn giá
            else if (codeCategory == 0 && maxPrice != 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false && x.TrangThaiBanh == status)
                                                .Where(x => x.DonGia >= minPrice && x.DonGia <= maxPrice)
                                                .ToList();
            }
            // Trường hợp không chọn loại và không chọn giá
            else if (codeCategory == 0 && minPrice ==0 && maxPrice ==0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiXoa == false && x.TrangThaiBanh == status)
                                                .ToList();
            }
            // Có chọn loại nhưng không chọn giá
            else if (codeCategory != 0 && minPrice == 0 && maxPrice == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            // Có chọn loại và có chọn giá
            else if (codeCategory != 0 && maxPrice != 0 && maxPrice != 1)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .Where(x => x.DonGia >= minPrice && x.DonGia <= maxPrice)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            // Có chọn loại và chọn tất cả giá
            else if (codeCategory != 0 && maxPrice == 1 && minPrice == 1)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            // Trường hợp chọn tất cả ở cbb giá và không chọn loại
            else if (minPrice == 1 && maxPrice == 1 && codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .ToList();
            }

            // Chọn tất cả nhưng lại chọn loại
            else if (minPrice == 1 && maxPrice == 1 && codeCategory != 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
                                                .Where(x => x.LoaiBanh == codeCategory)
                                                .ToList();
            }
            else if (codeCategory == 0)
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.DonGia >= minPrice && x.DonGia <= maxPrice && x.TrangThaiXoa == false)
                                               .Where(x => x.TrangThaiBanh == status)
                                               .ToList();
            }
            else
            {
                accountBanh = cakeEntities.Banhs.Where(x => x.DonGia >= minPrice && x.DonGia <= maxPrice && x.TrangThaiXoa == false)
                                               .Where(x => x.TrangThaiBanh == status)
                                               .Where(x => x.LoaiBanh == codeCategory)
                                               .ToList();
            }
            return accountBanh;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiBanhDAL
    {
        CakeEntities cakeEntities = new CakeEntities();
        public List<LoaiBanh> GetCateCakes()
        {
            List<LoaiBanh> listCateCake = new List<LoaiBanh>();
           
                var tbCateCake = cakeEntities.LoaiBanhs.Where(x => x.TrangThaiXoa == false).ToList();
                foreach (var i in tbCateCake)
                {
                    LoaiBanh cake = new LoaiBanh();
                    cake.TenLoai = i.TenLoai;
                    cake.MaLoai = i.MaLoai;
                    cake.TrangThaiXoa = i.TrangThaiXoa;

                    listCateCake.Add(cake);
            }
            return listCateCake;
        }

        public List<LoaiBanh> GetCakeById(int code)
        {
                List<LoaiBanh> cake = new List<LoaiBanh>();
                cake = cakeEntities.LoaiBanhs.Where(x => x.MaLoai == code).ToList();
                return cake;
        }

        public void UpdateCateCakeById(int code, string name)
        {
                var cakeCateCurrent = cakeEntities.LoaiBanhs.Where(x => x.MaLoai == code).FirstOrDefault();
                    cakeCateCurrent.TenLoai = name;
               
                cakeEntities.SaveChanges();
        }

        public void DeleteCateCakeById(int code)
        {
                var cakeCateCurrent = cakeEntities.LoaiBanhs.Where(x => x.MaLoai == code).FirstOrDefault();
                    cakeCateCurrent.TrangThaiXoa = true;
                cakeEntities.SaveChanges();
        }

        public string AddCateCake(string name)
        {
                cakeEntities.LoaiBanhs.Add(new LoaiBanh()
                {
                    TenLoai = name,
                    TrangThaiXoa=false
                });
                cakeEntities.SaveChanges();
            return "success";
        }

        public List<LoaiBanh> SearchCateCake(string key)
        {
            List<LoaiBanh> accountLoaiBanh = new List<LoaiBanh>();
            if (key == "0")
            {
                accountLoaiBanh = cakeEntities.LoaiBanhs.Where(x => x.TrangThaiXoa == false)
                                                .ToList();
            }
            else
            {
                accountLoaiBanh = cakeEntities.LoaiBanhs.Where(x => x.MaLoai.ToString().Contains(key) && x.TrangThaiXoa == false)
                                                    .ToList();
            }
            return accountLoaiBanh;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL
    {
        CakeEntities cakeEntities = new CakeEntities();
        public List<HoaDon> GetHoaDon()
        {
            List<HoaDon> listHoadon = new List<HoaDon>();
            using (CakeEntities cakeEntities = new CakeEntities())
            {
                var tbHoaDon = cakeEntities.HoaDons.ToList();
                foreach (var i in tbHoaDon)
                {
                    HoaDon hoadon = new HoaDon();
                    hoadon.MaHoaDon = i.MaHoaDon;
                    hoadon.IdTaiKhoan = i.IdTaiKhoan;
                    hoadon.NgayMua=i.NgayMua;
                    hoadon.TongTien=i.TongTien;
                    hoadon.TrangThai=i.TrangThai;
                    listHoadon.Add(hoadon);
                }
            }
            return listHoadon;
        }
        public string HoaDon(int MaHD, int IDTK, int TongTien, bool trangthai)
        {
            try
            {
                using (CakeEntities cakeEntities = new CakeEntities())
                {
                    cakeEntities.HoaDons.Add(new HoaDon()
                    {
                        MaHoaDon =MaHD,
                        IdTaiKhoan =IDTK,
                        NgayMua =DateTime.Now,
                        TongTien =TongTien,   
                        TrangThai=trangthai                               
                    });
                    cakeEntities.SaveChanges();
                }
            }
            catch (Exception ex) { return "error"; }
            return "success";
        }
        public void DeleteCateHDById(int maHD)
        {
            var cakeCateCurrent = cakeEntities.HoaDons.Where(x => x.MaHoaDon == maHD).FirstOrDefault();
            cakeEntities.HoaDons.Remove(cakeCateCurrent);
            cakeEntities.HoaDons.Add(new HoaDon()
            {
                TrangThai = false
            });
            cakeEntities.SaveChanges();
        }

    }
}

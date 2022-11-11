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
                    listHoadon.Add(hoadon);
                }
            }
            return listHoadon;
        }
        public string HoaDon(int MaHD, string IDTK, int TongTien)
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
                        TongTien =TongTien                       
                    });
                    cakeEntities.SaveChanges();
                }
            }
            catch (Exception ex) { return "error"; }
            return "success";
        }
    }
}

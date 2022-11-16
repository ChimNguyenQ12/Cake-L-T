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
                        hoadon.NgayMua = i.NgayMua;
                        hoadon.TongTien = i.TongTien;
                        hoadon.TrangThai = i.TrangThai;
                        listHoadon.Add(hoadon);
                    
                }
            }
            return listHoadon;
        }
        public string ThemHoaDon(int IDTK, int TongTien, bool trangthai)
        {
            try
            {
                using (CakeEntities cakeEntities = new CakeEntities())
                {
                    cakeEntities.HoaDons.Add(new HoaDon()
                    {
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
        public List<HoaDon> GetHoaDonByMaHD(int maHD)
        {
            List<HoaDon> hoaDon = new List<HoaDon>();
            if (maHD == 0)
            {
                hoaDon = cakeEntities.HoaDons.Where(x => x.TrangThai == true)
                                                .ToList();
            }
            else
            {
                hoaDon = cakeEntities.HoaDons.Where(x => x.MaHoaDon == maHD && x.TrangThai == true)
                                                .ToList();
            }
            return hoaDon;

        }
        public List<HoaDon> GetHoaDonByMaNV(int maNV)
        {
            List<HoaDon> hoaDon = new List<HoaDon>();
            if (maNV == 0)
            {
                hoaDon = cakeEntities.HoaDons.Where(x => x.TrangThai == true)
                                                .ToList();
            }
            else
            {
                hoaDon = cakeEntities.HoaDons.Where(x => x.IdTaiKhoan == maNV && x.TrangThai == true)
                                                .ToList();
            }
            return hoaDon;

        }
        public void DeleteHoaDonById(int maHD)
        {
            var hoaDon = cakeEntities.HoaDons.Where(x => x.MaHoaDon == maHD).FirstOrDefault();
            hoaDon.TrangThai = false;
            cakeEntities.SaveChanges();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTHoaDonDAL
    {
        CakeEntities cakeEntities = new CakeEntities();
        public List<ChiTietHD> GetCTHoaDon()
        {
            List<ChiTietHD> listCTHoaDon = new List<ChiTietHD>();

            var tbCTHoaDon = cakeEntities.ChiTietHDs.ToList();
            foreach (var i in tbCTHoaDon)
            {
                ChiTietHD ct = new ChiTietHD();
                ct.MaCTHoaDon = i.MaCTHoaDon;
                ct.MaBanh=i.MaBanh;
                ct.MaHoaDon = i.MaHoaDon;
                ct.SoLuong=i.SoLuong;
                ct.GiaTien=i.GiaTien;
                listCTHoaDon.Add(ct);
            }
            return listCTHoaDon;
        }
        public string CTHoaDon(int MaCTHD, int maBanh,int MaHD,int soLuong, int giaTien)
        {
            try
            {
                using (CakeEntities cakeEntities = new CakeEntities())
                {
                    cakeEntities.ChiTietHDs.Add(new ChiTietHD()
                    {
                        MaCTHoaDon = MaCTHD,
                        MaBanh = maBanh,
                        MaHoaDon= MaHD, 
                        SoLuong= soLuong,
                        GiaTien= giaTien

                    });
                    cakeEntities.SaveChanges();
                }
            }
            catch (Exception ex) { return "error"; }
            return "success";
        }
    }
}

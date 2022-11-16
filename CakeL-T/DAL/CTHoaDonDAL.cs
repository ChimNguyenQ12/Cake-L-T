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

        public List<ChiTietHD> GetAllCTHD()
        {
            List<ChiTietHD> listCTHDs = new List<ChiTietHD>();

            var tbCTHD = cakeEntities.ChiTietHDs.Where(x => x.TrangThai != false).ToList();
            foreach (var i in tbCTHD)
            {
                ChiTietHD chiTietHD = new ChiTietHD();
                chiTietHD.TrangThai = i.TrangThai;
                chiTietHD.MaBanh = i.MaBanh;
                chiTietHD.MaHoaDon = i.MaHoaDon;
                chiTietHD.SoLuong = i.SoLuong;
                chiTietHD.GiaTien = i.GiaTien;
                chiTietHD.MaCTHoaDon = i.MaCTHoaDon;

                listCTHDs.Add(chiTietHD);
            }
           
            return listCTHDs;
        }

        public List<ChiTietHD> GetCTHoaDon()
        {
            List<ChiTietHD> listCTHoaDon = new List<ChiTietHD>();

            var tbCTHoaDon = cakeEntities.ChiTietHDs.ToList();
            foreach (var i in tbCTHoaDon)
            {
                ChiTietHD ct = new ChiTietHD();
                
                    ct.MaCTHoaDon = i.MaCTHoaDon;
                    ct.MaBanh = i.MaBanh;
                    ct.MaHoaDon = i.MaHoaDon;
                    ct.SoLuong = i.SoLuong;
                    ct.GiaTien = i.GiaTien;
                    ct.TrangThai = i.TrangThai;
                    listCTHoaDon.Add(ct);
                
            }
            return listCTHoaDon;
        }
        public string ThemCTHoaDon(int maBanh,int soLuong, int giaTien, bool trangthai)
        {
            try
            {
                using (CakeEntities cakeEntities = new CakeEntities())
                {
                   int maHd =  cakeEntities.HoaDons.Max(x => x.MaHoaDon);
                    cakeEntities.ChiTietHDs.Add(new ChiTietHD()
                    {
                        MaBanh = maBanh,
                        MaHoaDon= maHd, 
                        SoLuong= soLuong,
                        GiaTien= giaTien,
                        TrangThai=trangthai

                    });
                    cakeEntities.SaveChanges();
                }
            }
            catch (Exception ex) { return "error"; }
            return "success";
        }
        public List<ChiTietHD> GetctHoaDonByMaHD(int maHD)
        {
            List<ChiTietHD> ctHoaDon = new List<ChiTietHD>();
            if (maHD == 0)
            {
                ctHoaDon = cakeEntities.ChiTietHDs.Where(x => x.TrangThai == true)
                                                .ToList();
            }
            else
            {
                ctHoaDon = cakeEntities.ChiTietHDs.Where(x => x.MaHoaDon == maHD && x.TrangThai == true)
                                                .ToList();
            }
            return ctHoaDon;

        }

        public void DeleteCTHoaDonById(int maHD)
        {
            var ctHoaDon = cakeEntities.ChiTietHDs.Where(x => x.MaHoaDon == maHD).ToList();
            foreach(var item in ctHoaDon)
            {
                if(item.TrangThai == true)
                {
                    item.TrangThai = false;
                }
            }
            cakeEntities.SaveChanges();
        }
    }
}

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
                ct.TrangThai = i.TrangThai;
                listCTHoaDon.Add(ct);
            }
            return listCTHoaDon;
        }
        public string CTHoaDon(int MaCTHD, int maBanh,int MaHD,int soLuong, int giaTien, bool trangthai)
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
                        GiaTien= giaTien,
                        TrangThai=trangthai

                    });
                    cakeEntities.SaveChanges();
                }
            }
            catch (Exception ex) { return "error"; }
            return "success";
        }
        public List<ChiTietHD> GetCTHD(int maHD)
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
        public void DeleteCatectHDById(int maHD)
        {
            var cakeCateCurrent = cakeEntities.ChiTietHDs.Where(x => x.MaHoaDon == maHD).FirstOrDefault();
            cakeEntities.ChiTietHDs.Remove(cakeCateCurrent);
            cakeEntities.ChiTietHDs.Add(new ChiTietHD()
            {
                TrangThai = false
            });
            cakeEntities.SaveChanges();
        }
    }
}

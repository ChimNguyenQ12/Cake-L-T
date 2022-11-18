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
            return cakeEntities.ChiTietHDs
                .Where(x => x.TrangThai != false)
                .ToList();
        }

        public List<ChiTietHD> GetCTHoaDon()
        {
            List<ChiTietHD> listCTHoaDon = new List<ChiTietHD>();

            return cakeEntities.ChiTietHDs.ToList();
        }

        public string ThemCTHoaDon(int maBanh, int soLuong, int giaTien, bool trangthai)
        {
            try
            {
                using (CakeEntities cakeEntities = new CakeEntities())
                {
                    int maHd = cakeEntities.HoaDons.Max(x => x.MaHoaDon);
                    cakeEntities.ChiTietHDs.Add(new ChiTietHD()
                    {
                        MaBanh = maBanh,
                        MaHoaDon = maHd,
                        SoLuong = soLuong,
                        GiaTien = giaTien,
                        TrangThai = trangthai

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
            foreach (var item in ctHoaDon)
            {
                if (item.TrangThai == true)
                {
                    item.TrangThai = false;
                }
            }
            cakeEntities.SaveChanges();
        }
    }
}

using DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace BLL
{
    public class CTHoaDonBUS
    {
        public string CTHoaDon(int MaCTHD, int maBanh, int MaHD, int soLuong, int giaTien, bool trangthai)
        {
            try
            {
                CTHoaDonDAL ctHoaDon = new CTHoaDonDAL();
                var tbCTHoaDon = ctHoaDon.GetCTHoaDon();
                foreach (var ct in tbCTHoaDon)
                {
                    if (ct.MaCTHoaDon == MaCTHD)
                    {
                        return "Mã đã tồn tại";
                    }
                }
                if (ctHoaDon.CTHoaDon(MaCTHD,maBanh,MaHD,soLuong,giaTien,trangthai) == "success")
                {
                    return "success";
                }

            }
            catch (Exception)
            {

            }
            return "success";
        }
        public List<ChiTietHD> GetHDByMaHD(int maHD)
        {
            try
            {
                List<ChiTietHD> accountById = new List<ChiTietHD>();
                CTHoaDonDAL ctHoaDonDAL = new CTHoaDonDAL();
                accountById = ctHoaDonDAL.GetCTHD(maHD);
                return accountById;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void DeleteCatectHDById(int maHD)
        {
            try
            {
                CTHoaDonDAL cthoaDonDAL = new CTHoaDonDAL();
                var tbCateCake = cthoaDonDAL.GetCTHoaDon();
                cthoaDonDAL.DeleteCatectHDById(maHD);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

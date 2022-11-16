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
        public List<ChiTietHD> GetAllCTHD()
        {
            try
            {
                List<ChiTietHD> chiTietHDs = new List<ChiTietHD>();
                CTHoaDonDAL ctHoaDonDAL = new CTHoaDonDAL();
                chiTietHDs = ctHoaDonDAL.GetAllCTHD();
                return chiTietHDs;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string ThemCTHoaDon(int maBanh, int soLuong, int giaTien, bool trangthai)
        {
            try
            {
                CTHoaDonDAL ctHoaDon = new CTHoaDonDAL();
                if (ctHoaDon.ThemCTHoaDon(maBanh,soLuong,giaTien,trangthai) == "success")
                {
                    return "success";
                }

            }
            catch (Exception)
            {

            }
            return "success";
        }
        public List<ChiTietHD> GetCTHDByMaHD(int maHD)
        {
            try
            {
                List<ChiTietHD> accountById = new List<ChiTietHD>();
                CTHoaDonDAL ctHoaDonDAL = new CTHoaDonDAL();
                accountById = ctHoaDonDAL.GetctHoaDonByMaHD(maHD);
                return accountById;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void DeletectHoaDonById(int maHD)
        {
            try
            {
                CTHoaDonDAL cthoaDonDAL = new CTHoaDonDAL();
                var tbCateCake = cthoaDonDAL.GetCTHoaDon();
                cthoaDonDAL.DeleteCTHoaDonById(maHD);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

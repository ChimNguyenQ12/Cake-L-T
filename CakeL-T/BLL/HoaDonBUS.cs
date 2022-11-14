using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class HoaDonBUS
    {
        public List<HoaDon> GetHD()
        {
            List<HoaDon> listHD = new List<HoaDon>();
            HoaDonDAL hoadonDAL = new HoaDonDAL();
            listHD = hoadonDAL.GetHoaDon().ToList();
            return listHD;
        }
        public string ThemHoaDon(int MaHD, int IDTK, int TongTien, bool trangthai)
        {
            try
            {
                
                HoaDonDAL hoadon = new HoaDonDAL();
                var tbHoaDon = hoadon.GetHoaDon();
                foreach(var hoaDon in tbHoaDon)
                {
                    if(hoaDon.MaHoaDon == MaHD)
                    {
                        return "Ma hoa don da ton tai";
                    }
                }
                if(hoadon.ThemHoaDon(MaHD,IDTK,TongTien,trangthai) == "success")
                {
                    return "success";
                }
            }catch(Exception ex) { return "error"; }
            return "success";
        }
        public void DeleteHoaDonById(int maHD)
        {
            try
            {
                HoaDonDAL hoaDonDAL = new HoaDonDAL();
                var tbCateCake = hoaDonDAL.GetHoaDon();
                hoaDonDAL.DeleteHoaDonById(maHD);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<HoaDon> GetHDByMaHD(int maHD)
        {
            try
            {
                List<HoaDon> hoadon = new List<HoaDon>();
                HoaDonDAL hoaDonDAL = new HoaDonDAL();
                var seachHD = hoaDonDAL.GetHoaDonByMaHD(maHD);
                return seachHD;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<HoaDon> GetHDByMaNV(int maNV)
        {
            try
            {
                List<HoaDon> hoadon = new List<HoaDon>();
                HoaDonDAL hoaDonDAL = new HoaDonDAL();
                var seachHD = hoaDonDAL.GetHoaDonByMaNV(maNV);
                return seachHD;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}

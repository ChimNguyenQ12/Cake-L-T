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
        public string HoaDon(int MaHD, string IDTK, int TongTien)
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
                if(hoadon.HoaDon(MaHD,IDTK,TongTien) == "success")
                {
                    return "success";
                }
            }catch(Exception ex) { return "error"; }
            return "success";
        }
    }
}

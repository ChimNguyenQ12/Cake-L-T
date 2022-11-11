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
        public string CTHoaDon(int MaCTHD, int maBanh, int MaHD, int soLuong, int giaTien)
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
                if (ctHoaDon.CTHoaDon(MaCTHD,maBanh,MaHD,soLuong,giaTien) == "success")
                {
                    return "success";
                }

            }
            catch (Exception)
            {

            }
            return "success";
        }
    }
}

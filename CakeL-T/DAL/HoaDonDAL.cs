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
                    hoadon.NgayMua=i.NgayMua;
                    hoadon.TongTien=i.TongTien;
                    listHoadon.Add(hoadon);
                }
            }
            return listHoadon;
        }
        public string HoaDon(int MaHD, int IDTK, int TongTien)
        {
            try
            {
                using (CakeEntities cakeEntities = new CakeEntities())
                {
                    cakeEntities.HoaDons.Add(new HoaDon()
                    {
                        MaHoaDon =MaHD,
                        IdTaiKhoan =IDTK,
                        NgayMua =DateTime.Now,
                        TongTien =TongTien                       
                    });
                    cakeEntities.SaveChanges();
                }
            }
            catch (Exception ex) { return "error"; }
            return "success";
        }
        public List<HoaDon> SearchHDMulti(int tien, int tongtien)
        {
            List<HoaDon> accountHD = new List<HoaDon>();
            //if (tien == 0 && tongtien == 0)
            //{
            //    accountHD = cakeEntities.HoaDons.Where(x => x.TrangThaiXoa == false && x.TrangThaiBanh == status)
            //                                    .ToList();
            //}
            //else if (tien == 1)
            //{
            //    accountHD = cakeEntities.HoaDons.Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
            //                                    .Where(x => x.LoaiBanh == tongtien && x.TrangThaiXoa == false)
            //                                    .ToList();

            //}
            //else if (tien == 50000)
            //{
            //    accountHD = cakeEntities.HoaDons.Where(x => x.DonGia < 50000 && x.TrangThaiXoa == false)
            //                                    .Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
            //                                    .Where(x => x.LoaiBanh == codeCategory && x.TrangThaiXoa == false)
            //                                    .ToList();
            //}
            //else if (tien == 75000)
            //{
            //    accountHD = cakeEntities.HoaDons.Where(x => x.DonGia > 50000 && x.DonGia < 100000 && x.TrangThaiXoa == false)
            //                                        .Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
            //                                        .Where(x => x.LoaiBanh == codeCategory && x.TrangThaiXoa == false)
            //                                        .ToList();
            //}
            //else if (tien == 150000)
            //{
            //    accountHD = cakeEntities.HoaDons.Where(x => x.DonGia > 100000 && x.DonGia < 200000 && x.TrangThaiXoa == false)
            //                                        .Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
            //                                        .Where(x => x.LoaiBanh == codeCategory && x.TrangThaiXoa == false)
            //                                        .ToList();
            //}
            //else if (tien == 200000)
            //{
            //    accountHD = cakeEntities.HoaDons.Where(x => x.DonGia > 200000 && x.TrangThaiXoa == false)
            //                                        .Where(x => x.TrangThaiBanh == status && x.TrangThaiXoa == false)
            //                                        .Where(x => x.LoaiBanh == codeCategory && x.TrangThaiXoa == false)
            //                                        .ToList();
            //}
            return accountHD;
        }
    }
}

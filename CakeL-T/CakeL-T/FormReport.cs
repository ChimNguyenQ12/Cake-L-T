using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeL_T
{
    public partial class FormReport : Form
    {
        AdminBUS adminBus = new AdminBUS();
        LoaiBanhBUS loaiBanhBus = new LoaiBanhBUS();
        BanhBUS banhBus = new BanhBUS();
        HoaDonBUS hoaDonBus = new HoaDonBUS();
        CTHoaDonBUS cTHoaDonBUS = new CTHoaDonBUS();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            reportViewerNhanVien.Visible = false;
            reportViewerNgay.Visible = false;
            reportViewerSanPham.Visible = false;
            reportViewerLoaiSanPham.Visible = false;
            reportViewerTongTien.Visible = false;
            // Category
            var cate = loaiBanhBus.GetCateCakes();
            cbbLoaiSP.DataSource = cate;
            cbbLoaiSP.DisplayMember = "TenLoai";
            cbbLoaiSP.ValueMember = "MaLoai";

            // Cake
            var cake = banhBus.GetCakes();
            cbbSanPham.DataSource = cake;
            cbbSanPham.DisplayMember = "TenBanh";
            cbbSanPham.ValueMember = "MaBanh";

            // Account
            var account = adminBus.GetAccounts();
            cbbNV.DataSource = account;
            cbbNV.DisplayMember = "TenTK";
            cbbNV.ValueMember = "Id";
            this.reportViewerLoaiSanPham.RefreshReport();
            this.reportViewerTongTien.RefreshReport();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Report theo nhân viên
            if (rdbNV.Checked == true)
            {
                reportViewerNgay.Visible = false;
                reportViewerSanPham.Visible = false;
                reportViewerLoaiSanPham.Visible = false;
                reportViewerTongTien.Visible = false;
                if (reportViewerNhanVien.Visible == true)
                {
                    reportViewerNhanVien.Visible = false;
                }
                else
                {
                    reportViewerNhanVien.Visible = true;
                }
                var id = Convert.ToInt32(cbbNV.SelectedValue.ToString());
                AdminBUS adminBUS = new AdminBUS();
                var accountCreateReport = adminBUS.GetAccounts().Where(x => x.Id == id).FirstOrDefault();
                var listInvoices = hoaDonBus.GetHD().Where(x => x.IdTaiKhoan == id).ToList();
                reportViewerNhanVien.LocalReport.ReportPath = "ReportByAccount.rdlc";
                var source = new ReportDataSource("DataSetHoaDon", listInvoices);
                reportViewerNhanVien.LocalReport.DataSources.Clear();
                //Add param
                var total = listInvoices.Sum(x => x.TongTien);
                ReportParameter[] parameter = new ReportParameter[3];
                parameter[0] = new ReportParameter("rpName", accountCreateReport.HoTen);
                parameter[1] = new ReportParameter("rpDate", DateTime.Now.ToString());
                parameter[2] = new ReportParameter("Total", total.ToString() + " VND");
                this.reportViewerNhanVien.LocalReport.SetParameters(parameter);

                reportViewerNhanVien.LocalReport.DataSources.Add(source);
                this.reportViewerNhanVien.RefreshReport();
            }

            // Report theo ngày
            if (rdbNgay.Checked == true)
            {
                reportViewerNhanVien.Visible = false;
                reportViewerSanPham.Visible = false;
                reportViewerLoaiSanPham.Visible = false;
                reportViewerTongTien.Visible = false;

                if (reportViewerNgay.Visible == true)
                {
                    reportViewerNgay.Visible = false;
                }
                else
                {
                    reportViewerNgay.Visible = true;
                }
                string Datein = dtp_HD.Value.ToShortDateString();
                DateTime theDate = this.dtp_HD.Value.Date;
                AdminBUS adminBUS = new AdminBUS();
                var listInvoices = hoaDonBus.GetHD().Where(x => x.NgayMua.Value.Date == theDate).ToList();
                reportViewerNgay.LocalReport.ReportPath = "ReportByDate.rdlc";
                var source = new ReportDataSource("DataSetHoaDon", listInvoices);
                reportViewerNgay.LocalReport.DataSources.Clear();
                //Add param
                var total = listInvoices.Sum(x => x.TongTien);
                ReportParameter[] parameter = new ReportParameter[3];
                parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
                parameter[1] = new ReportParameter("rpDatein", Datein.ToString());
                parameter[2] = new ReportParameter("Total", total.ToString() + " VND");
                this.reportViewerNgay.LocalReport.SetParameters(parameter);

                reportViewerNgay.LocalReport.DataSources.Add(source);
                this.reportViewerNgay.RefreshReport();
            }

            // Report theo sản phẩm
            if (rdbSP.Checked == true)
            {
                reportViewerNhanVien.Visible = false;
                reportViewerNgay.Visible = false;
                reportViewerTongTien.Visible = false;
                reportViewerLoaiSanPham.Visible = false;
                if (reportViewerSanPham.Visible == true)
                {
                    reportViewerSanPham.Visible = false;
                }
                else
                {
                    reportViewerSanPham.Visible = true;
                }
                var id = Convert.ToInt32(cbbSanPham.SelectedValue.ToString());
                var cakeName = banhBus.GetCakeById(id).FirstOrDefault();
                var listInvoiceDetails = cTHoaDonBUS.GetAllCTHD().Where(x => x.MaBanh == id).ToList();
                List<HoaDon> listHD = new List<HoaDon>();
                foreach (var item in listInvoiceDetails)
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHoaDon = Convert.ToInt32(item.MaHoaDon);
                    var listInvoices = hoaDonBus.GetHD().Where(x => x.MaHoaDon == hoaDon.MaHoaDon);
                    foreach (var itemHD in listInvoices)
                    {
                        hoaDon.TongTien = itemHD.TongTien;
                        hoaDon.NgayMua = itemHD.NgayMua;
                    }
                    listHD.Add(hoaDon);
                }
                var total = listHD.Sum(x => x.TongTien);
                reportViewerSanPham.LocalReport.ReportPath = "ReportByCake.rdlc";
                var source = new ReportDataSource("DataSetHoaDon", listHD);
                reportViewerSanPham.LocalReport.DataSources.Clear();
                //Add param
                ReportParameter[] parameter = new ReportParameter[3];
                parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
                parameter[1] = new ReportParameter("rpName", cakeName.TenBanh);
                parameter[2] = new ReportParameter("Total", total.ToString() + " VND");
                this.reportViewerSanPham.LocalReport.SetParameters(parameter);
                reportViewerSanPham.LocalReport.DataSources.Add(source);
                this.reportViewerSanPham.RefreshReport();
            }

            // Report theo loại sản phẩm
            if (rdbLoaiSP.Checked == true)
            {
                reportViewerNhanVien.Visible = false;
                reportViewerNgay.Visible = false;
                reportViewerTongTien.Visible = false;
                reportViewerSanPham.Visible = false;
                if (reportViewerLoaiSanPham.Visible == true)
                {
                    reportViewerLoaiSanPham.Visible = false;
                }
                else
                {
                    reportViewerLoaiSanPham.Visible = true;
                }
                var id = Convert.ToInt32(cbbLoaiSP.SelectedValue.ToString());
                var cakeCateName = loaiBanhBus.GetCateCakeById(id).FirstOrDefault();
                var listCakeByCate = banhBus.GetCakes().Where(x => x.LoaiBanh == cakeCateName.MaLoai).ToList();

                var Ids = listCakeByCate.Select(x => x.MaBanh);

                var listInvoiceDetails = cTHoaDonBUS
                    .GetAllCTHD()
                    .Where(x => Ids.Contains(x.MaBanh.GetValueOrDefault()))
                    .ToList();

                var listUnit = listInvoiceDetails.Select(x => x.MaHoaDon).Distinct().ToList();
                // Cách 2
                //var listUnit = listInvoiceDetails
                //    .GroupBy(x => x.MaHoaDon)
                //    .Select(x => new { MaHoaDon = x.Key, HoaDonItem = x.First() })
                //    .Select(x => x.HoaDonItem)
                //    .ToList();
                List<HoaDon> listHD = new List<HoaDon>();
                  foreach (var item in listUnit)
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHoaDon = item.Value;
                    var listInvoices = hoaDonBus.GetHD().Where(x => x.MaHoaDon == hoaDon.MaHoaDon);
                    foreach (var itemHD in listInvoices)
                    {
                        hoaDon.TongTien = itemHD.TongTien;
                        hoaDon.NgayMua = itemHD.NgayMua;
                    }
                    listHD.Add(hoaDon);
                }
                var total = listHD.Sum(x => x.TongTien);
                reportViewerLoaiSanPham.LocalReport.ReportPath = "ReportByCakeCate.rdlc";
                var source = new ReportDataSource("DataSetHoaDon", listHD);
                reportViewerLoaiSanPham.LocalReport.DataSources.Clear();
                //Add param
                ReportParameter[] parameter = new ReportParameter[3];
                parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
                parameter[1] = new ReportParameter("rpName", cakeCateName.TenLoai);
                parameter[2] = new ReportParameter("Total", total.ToString() + " VND");
                this.reportViewerLoaiSanPham.LocalReport.SetParameters(parameter);
                reportViewerLoaiSanPham.LocalReport.DataSources.Add(source);
                this.reportViewerLoaiSanPham.RefreshReport();
            }

            // Report theo tổng tiền
            if (rdbTongTien.Checked == true)
            {
                reportViewerNhanVien.Visible = false;
                reportViewerNgay.Visible = false;
                reportViewerSanPham.Visible = false;
                reportViewerLoaiSanPham.Visible = false;
                if (reportViewerTongTien.Visible == true)
                {
                    reportViewerTongTien.Visible = false;
                }
                else
                {
                    reportViewerTongTien.Visible = true;
                }
                
                List<HoaDon> listInvoices = new List<HoaDon>();
                string totalFrom = "", totalTo = "";
                int total = 0;
                if (cbbTotal.SelectedItem == null)
                {
                    totalFrom = "!";
                    totalTo = "!";
                    listInvoices = hoaDonBus.GetHD().ToList();
                }
                else
                {

                var price = cbbTotal.SelectedItem.ToString();
                if (price == "< 500.000đ")
                {
                    totalFrom = "0đ";
                    totalTo = "500.000đ";
                     listInvoices = hoaDonBus.GetHD().Where(x => x.TongTien <= 500000).ToList();    
                     total = Convert.ToInt32(listInvoices.Sum(x => x.TongTien));
                }
                else if(price == "500.000đ - 1.000.000đ")
                {
                    totalFrom = "500.000đ";
                    totalTo = "1.000.000đ";
                    listInvoices = hoaDonBus.GetHD().Where(x => x.TongTien >= 500000 && x.TongTien <= 1000000).ToList();
                    total = Convert.ToInt32(listInvoices.Sum(x => x.TongTien));
                }
                else if(price == "1.000.000đ - 5.000.000đ")
                {
                    totalFrom = "1.000.000đ";
                    totalTo = "5.000.000đ";
                    listInvoices = hoaDonBus.GetHD().Where(x => x.TongTien >= 1000000 && x.TongTien <= 5000000).ToList();
                    total = Convert.ToInt32(listInvoices.Sum(x => x.TongTien));
                }
                else if(price == "> 5.000.000đ")
                {
                    totalFrom = ">5.000.000đ";
                    totalTo = "!";
                    listInvoices = hoaDonBus.GetHD().Where(x => x.TongTien >= 5000000).ToList();
                    total = Convert.ToInt32(listInvoices.Sum(x => x.TongTien));
                }
                }
                reportViewerTongTien.LocalReport.ReportPath = "ReportByTotal.rdlc";
                var source = new ReportDataSource("DataSetHoaDon", listInvoices);
                reportViewerTongTien.LocalReport.DataSources.Clear();
                //Add param
                ReportParameter[] parameter = new ReportParameter[4];
                parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
                parameter[1] = new ReportParameter("rpTotalFrom", totalFrom);
                parameter[2] = new ReportParameter("rpTotalTo", totalTo);
                parameter[3] = new ReportParameter("Total", total.ToString() + " VND");
                this.reportViewerTongTien.LocalReport.SetParameters(parameter);
                reportViewerTongTien.LocalReport.DataSources.Add(source);
                this.reportViewerTongTien.RefreshReport();
            }
        }
    }
}

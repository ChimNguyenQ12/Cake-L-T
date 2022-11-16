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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (rdbNV.Checked == true)
            {
                 reportViewerNgay.Visible = false;
                 reportViewerSanPham.Visible = false;
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

            if(rdbNgay.Checked == true)
            {
                reportViewerNhanVien.Visible = false;
                reportViewerSanPham.Visible = false;
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

            if (rdbSP.Checked == true)
            {
                reportViewerNhanVien.Visible = false;
                reportViewerNgay.Visible = false;
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
                var listInvoiceDetails = cTHoaDonBUS.GetAllCTHD().Where(x => x.MaBanh == id);
                var listCTHD = new List<ChiTietHD>();
                foreach (var item in listInvoiceDetails)
                {
                    var listInvoices = hoaDonBus.GetHDByMaHD(Convert.ToInt32(item.MaHoaDon));
                    var total = listInvoices.Sum(x => x.TongTien);
                    reportViewerSanPham.LocalReport.ReportPath = "ReportByCake.rdlc";
                    var source = new ReportDataSource("DataSetHoaDon", listInvoices);
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
            }
        }
    }
}

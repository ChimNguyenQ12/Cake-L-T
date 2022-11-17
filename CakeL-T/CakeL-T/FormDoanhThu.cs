using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;

namespace CakeL_T
{
    public partial class FormDoanhThu : Form
    {
        int tong = 0;
        HoaDonBUS hoadonBUS = new HoaDonBUS();
        AdminBUS adminBUS = new AdminBUS();
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            dgv_DTNgay.DataSource = hoadonBUS.GetHD();
            reportViewerDoanhThu.Visible = false;

            for (int i = 0; i < dgv_DTNgay.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgv_DTNgay.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgv_DTNgay.Rows[i].Cells["TenTaiKhoan"].Value = item.TenTK.ToString();
                    }
                }
            }

            dgv_DTNgay.Columns["TrangThai"].Visible = false;
            dgv_DTNgay.Columns["ChiTietHDs"].Visible = false;
            dgv_DTNgay.Columns["TaiKhoan"].Visible = false;
            dgv_DTNgay.Columns["IdTaiKhoan"].Visible = false;
            // Tính tổng doanh thu
            for ( int i =0;i<dgv_DTNgay.Rows.Count;i++ )
            {
                tong =  tong + int.Parse(dgv_DTNgay.Rows[i].Cells[3].Value.ToString()); 
            }
            txt_TongDtNgay.Text = tong.ToString() + "VNĐ";
            this.reportViewerDoanhThu.RefreshReport();
        }

        private void btn_ThongKeDTNgay_Click(object sender, EventArgs e)
        {
            tong = 0;
            DateTime dateFrom = dtpTu.Value.Date;
            DateTime dateTo = dtpDen.Value.Date;
            dgv_DTNgay.DataSource = hoadonBUS.GetHD().Where(x => x.NgayMua.Value.Date >= dateFrom && x.NgayMua.Value.Date <= dateTo).ToList();
            // Tính tổng doanh thu
            for (int i = 0; i < dgv_DTNgay.Rows.Count; i++)
            {
                tong = tong + int.Parse(dgv_DTNgay.Rows[i].Cells[3].Value.ToString());
            }
            txt_TongDtNgay.Text = tong.ToString() + "VNĐ";
            for (int i = 0; i < dgv_DTNgay.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgv_DTNgay.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgv_DTNgay.Rows[i].Cells["TenTaiKhoan"].Value = item.TenTK.ToString();
                    }
                }
            }
        }

        private void btn_ReportNgay_Click(object sender, EventArgs e)
        {
            if (reportViewerDoanhThu.Visible == true)
            {
                reportViewerDoanhThu.Visible = false;
            }
            else
            {
                reportViewerDoanhThu.Visible = true;
            }
            string DateIn = dtpTu.Value.ToShortDateString();
            string DateOut = dtpDen.Value.ToShortDateString();
            DateTime dateFrom = dtpTu.Value.Date;
            DateTime dateTo = dtpDen.Value.Date;
            AdminBUS adminBUS = new AdminBUS();
            var listInvoices = hoadonBUS.GetHD().Where(x => x.NgayMua.Value.Date >= dateFrom && x.NgayMua.Value.Date <= dateTo).ToList();
            reportViewerDoanhThu.LocalReport.ReportPath = "ReportDoanhThu.rdlc";
            var source = new ReportDataSource("DataSetHoaDon", listInvoices);
            reportViewerDoanhThu.LocalReport.DataSources.Clear();
            //Add param
            var total = listInvoices.Sum(x => x.TongTien);
            ReportParameter[] parameter = new ReportParameter[4];
            parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
            parameter[1] = new ReportParameter("rpDateFrom", DateIn.ToString());
            parameter[2] = new ReportParameter("rpDateTo", DateOut.ToString());
            parameter[3] = new ReportParameter("Total", total.ToString() + " VND");
            this.reportViewerDoanhThu.LocalReport.SetParameters(parameter);

            reportViewerDoanhThu.LocalReport.DataSources.Add(source);
            this.reportViewerDoanhThu.RefreshReport();
        }
    }
}

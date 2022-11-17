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
using System.Diagnostics;
using DAL;
using ServiceStack;
using Microsoft.Reporting.WinForms;

namespace CakeL_T
{

    public partial class USHoaDonAdmin : UserControl
    {
        AdminBUS  adminBUS = new AdminBUS();
        int maHD = 0;
        private static USHoaDonAdmin instance;
        public static HoaDonBUS hoadonBUS = new HoaDonBUS();
        public static CTHoaDonBUS ctHoaDonBUS = new CTHoaDonBUS();
        public static USHoaDonAdmin
            Instance
        {
            get
            {
                if (instance == null)
                    instance = new USHoaDonAdmin();
                return instance;
            }
        }
        public USHoaDonAdmin()
        {
            InitializeComponent();
        }

        private void USHoaDonAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            reportViewerHoaDon.Visible = false;
            reportViewerCTHD.Visible = false;
            dgv_HoaDon.DataSource = hoadonBUS.GetHD();

            for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgv_HoaDon.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgv_HoaDon.Rows[i].Cells["TenTaiKhoan"].Value = item.TenTK.ToString();
                    }
                }
            }

            dgv_HoaDon.Columns["TrangThai"].Visible = false;
            dgv_HoaDon.Columns["ChiTietHDs"].Visible = false;
            dgv_HoaDon.Columns["TaiKhoan"].Visible = false;
            dgv_HoaDon.Columns["IdTaiKhoan"].Visible = false;
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_HoaDon.CurrentCell.RowIndex;
            maHD = int.Parse(dgv_HoaDon.Rows[index].Cells[0].Value.ToString());
            dgv_ctHoaDon.DataSource = ctHoaDonBUS.GetCTHDByMaHD(maHD);
            dgv_ctHoaDon.Columns["TrangThai"].Visible = false;
            dgv_ctHoaDon.Columns["Banh"].Visible = false;
            dgv_ctHoaDon.Columns["HoaDon"].Visible = false;
        }

        private void btn_TimHD_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_maHD.Text != null)
                {
                   dgv_HoaDon.DataSource = hoadonBUS.GetHDByMaHD(int.Parse(txt_maHD.Text));

                }
                else if (txt_maNV.Text != null)
                {
                    dgv_HoaDon.DataSource = hoadonBUS.GetHDByMaHD(int.Parse(txt_maNV.Text));
                }
            }
            catch { };
        }
        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            hoadonBUS.DeleteHoaDonById(maHD);            
            ctHoaDonBUS.DeletectHoaDonById(maHD);
            LoadData();
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_maNV.Text = "";
            txt_maHD.Text = "";
            LoadData();
        }

        private void btn_ReportHD_Click(object sender, EventArgs e)
        {
            if (reportViewerHoaDon.Visible == true)
            {
                reportViewerHoaDon.Visible = false;
            }
            else
            {
                reportViewerHoaDon.Visible = true;
            }
            AdminBUS adminBUS = new AdminBUS();
            var accountCreateReport = adminBUS.GetAccounts().Where(x => x.LoaiTK == true).FirstOrDefault();
            var listInvoice = hoadonBUS.GetHD().ToList();
            reportViewerHoaDon.LocalReport.ReportPath = "ReportHoaDon.rdlc";
            var source = new ReportDataSource("DataSetHoaDon", listInvoice);
            reportViewerHoaDon.LocalReport.DataSources.Clear();
            //Add param
            ReportParameter[] parameter = new ReportParameter[2];
            parameter[0] = new ReportParameter("rpName", accountCreateReport.HoTen);
            parameter[1] = new ReportParameter("rpDate", DateTime.Now.ToString());
            this.reportViewerHoaDon.LocalReport.SetParameters(parameter);

            reportViewerHoaDon.LocalReport.DataSources.Add(source);
            this.reportViewerHoaDon.RefreshReport();
        }

        private void btnReportCTHD_Click(object sender, EventArgs e)
        {
            if (reportViewerCTHD.Visible == true)
            {
                reportViewerCTHD.Visible = false;
            }
            else
            {
                reportViewerCTHD.Visible = true;
            }
            AdminBUS adminBUS = new AdminBUS();
            var accountCreateReport = adminBUS.GetAccounts().Where(x => x.LoaiTK == true).FirstOrDefault();
            var listInvoice = ctHoaDonBUS.GetAllCTHD().ToList();
            reportViewerCTHD.LocalReport.ReportPath = "ReportCTHD.rdlc";
            var source = new ReportDataSource("DataSetCTHD", listInvoice);
            reportViewerCTHD.LocalReport.DataSources.Clear();
            //Add param
            ReportParameter[] parameter = new ReportParameter[2];
            parameter[0] = new ReportParameter("rpName", accountCreateReport.HoTen);
            parameter[1] = new ReportParameter("rpDate", DateTime.Now.ToString());
            this.reportViewerCTHD.LocalReport.SetParameters(parameter);

            reportViewerCTHD.LocalReport.DataSources.Add(source);
            this.reportViewerCTHD.RefreshReport();
        }
    }
}

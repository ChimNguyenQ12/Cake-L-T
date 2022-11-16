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
            dgv_HoaDon.DataSource = hoadonBUS.GetHD();
            reportViewerHoaDon.Visible = false;
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_HoaDon.CurrentCell.RowIndex;
            maHD = int.Parse(dgv_HoaDon.Rows[index].Cells[0].Value.ToString());
            
            dgv_ctHoaDon.DataSource = ctHoaDonBUS.GetCTHDByMaHD(maHD);
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
    }
}

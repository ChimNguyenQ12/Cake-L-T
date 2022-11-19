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
            reportViewerNgay.Visible = false;
            reportViewerThang.Visible = false;
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
            dgvThang.DataSource = hoadonBUS.GetHD();
            for (int i = 0; i < dgvThang.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgvThang.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgvThang.Rows[i].Cells["TenTK"].Value = item.TenTK.ToString();
                    }
                }
            }
            dgv_DTNgay.Columns["TrangThai"].Visible = false;
            dgv_DTNgay.Columns["ChiTietHDs"].Visible = false;
            dgv_DTNgay.Columns["TaiKhoan"].Visible = false;
            dgv_DTNgay.Columns["IdTaiKhoan"].Visible = false;

            dgvThang.Columns["TrangThai"].Visible = false;
            dgvThang.Columns["ChiTietHDs"].Visible = false;
            dgvThang.Columns["TaiKhoan"].Visible = false;
            dgvThang.Columns["IdTaiKhoan"].Visible = false;
            // Tính tổng doanh thu
            for ( int i =0;i<dgv_DTNgay.Rows.Count;i++ )
            {
                tong =  tong + int.Parse(dgv_DTNgay.Rows[i].Cells[3].Value.ToString()); 
            }
            txt_TongDtNgay.Text = tong.ToString() + "VNĐ";

            for (int i = 0; i < dgvThang.Rows.Count; i++)
            {
                tong = tong + int.Parse(dgvThang.Rows[i].Cells[3].Value.ToString());
            }
            txtTotalMonth.Text = tong.ToString() + "VNĐ";
            this.reportViewerThang.RefreshReport();
        }

        private void btn_ThongKeDTNgay_Click(object sender, EventArgs e)
        {
            tong = 0;
            DateTime dateFrom = dtpTu.Value.Date;
            DateTime dateTo = dtpDen.Value.Date;
            if (dateTo < dateFrom)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
            }
            else
            {
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
        }

        private void btn_ReportNgay_Click(object sender, EventArgs e)
        {
            if (reportViewerNgay.Visible == true)
            {
                reportViewerNgay.Visible = false;
            }
            else
            {
                reportViewerNgay.Visible = true;
            }
            string DateIn = dtpTu.Value.ToShortDateString();
            string DateOut = dtpDen.Value.ToShortDateString();
            DateTime dateFrom = dtpTu.Value.Date;
            DateTime dateTo = dtpDen.Value.Date;
            AdminBUS adminBUS = new AdminBUS();
            var listInvoices = hoadonBUS.GetHD().Where(x => x.NgayMua.Value.Date >= dateFrom && x.NgayMua.Value.Date <= dateTo).ToList();
            reportViewerNgay.LocalReport.ReportPath = "ReportDoanhThu.rdlc";
            var source = new ReportDataSource("DataSetHoaDon", listInvoices);
            reportViewerNgay.LocalReport.DataSources.Clear();
            //Add param
            var total = listInvoices.Sum(x => x.TongTien);
            ReportParameter[] parameter = new ReportParameter[4];
            parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
            parameter[1] = new ReportParameter("rpDateFrom", DateIn.ToString());
            parameter[2] = new ReportParameter("rpDateTo", DateOut.ToString());
            parameter[3] = new ReportParameter("Total", total.ToString() + " VND");
            this.reportViewerNgay.LocalReport.SetParameters(parameter);

            reportViewerNgay.LocalReport.DataSources.Add(source);
            this.reportViewerNgay.RefreshReport();
        }

        private void btn_ThongKeDTThang_Click(object sender, EventArgs e)
        {
            tong = 0;
            string month = txt_Thang.Text;
            if(month == "")
            {
                dgvThang.DataSource = hoadonBUS.GetHD().ToList();
                for (int i = 0; i < dgvThang.Rows.Count; i++)
                {
                    foreach (var item in adminBUS.GetAccounts())
                    {
                        if (dgvThang.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                        {
                            dgvThang.Rows[i].Cells["TenTK"].Value = item.TenTK.ToString();
                        }
                    }
                }
            }
            else if(int.Parse(month) < 1 || int.Parse(month) > 12)
            {
                MessageBox.Show("Tháng không hợp lệ");
                return;
            }
            else
            {
            dgvThang.DataSource = hoadonBUS.GetHD().Where(x => x.NgayMua.Value.Month == int.Parse(month)).ToList();
            // Tính tổng doanh thu
            for (int i = 0; i < dgvThang.Rows.Count; i++)
            {
                tong = tong + int.Parse(dgvThang.Rows[i].Cells[3].Value.ToString());
            }
            txtTotalMonth.Text = tong.ToString() + "VNĐ";
            for (int i = 0; i < dgvThang.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgvThang.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgvThang.Rows[i].Cells["TenTK"].Value = item.TenTK.ToString();
                    }
                }
            }
            }
        }

        private void btn_ReportDtThang_Click(object sender, EventArgs e)
        {
            if (reportViewerThang.Visible == true)
            {
                reportViewerThang.Visible = false;
            }
            else
            {
                reportViewerThang.Visible = true;
            }
            string month = txt_Thang.Text;
            DateTime dateFrom = dtpTu.Value.Date;
            DateTime dateTo = dtpDen.Value.Date;
            AdminBUS adminBUS = new AdminBUS();
            var listInvoices = hoadonBUS.GetHD().Where(x => x.NgayMua.Value.Month == int.Parse(month)).ToList();
            reportViewerThang.LocalReport.ReportPath = "ReportDoanhThuThang.rdlc";
            var source = new ReportDataSource("DataSetHoaDon", listInvoices);
            reportViewerThang.LocalReport.DataSources.Clear();
            //Add param
            var total = listInvoices.Sum(x => x.TongTien);
            ReportParameter[] parameter = new ReportParameter[3];
            parameter[0] = new ReportParameter("rpDate", DateTime.Now.ToString());
            parameter[1] = new ReportParameter("rpMonth", month.ToString());
            parameter[2] = new ReportParameter("Total", total.ToString() + " VND");
            this.reportViewerThang.LocalReport.SetParameters(parameter);

            reportViewerThang.LocalReport.DataSources.Add(source);
            this.reportViewerThang.RefreshReport();
        }

        private void txt_Thang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txt_Thang.Text.Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgv_DTNgay.DataSource = hoadonBUS.GetHD();
            for (int i = 0; i < dgv_DTNgay.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgv_DTNgay.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgv_DTNgay.Rows[i].Cells["TenTK"].Value = item.TenTK.ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvThang.DataSource = hoadonBUS.GetHD();
            for (int i = 0; i < dgvThang.Rows.Count; i++)
            {
                foreach (var item in adminBUS.GetAccounts())
                {
                    if (dgvThang.Rows[i].Cells["IdTaiKhoan"].Value.ToString() == item.Id.ToString())
                    {
                        dgvThang.Rows[i].Cells["TenTK"].Value = item.TenTK.ToString();
                    }
                }
            }
        }
    }
}

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

namespace CakeL_T
{
    public partial class FormHomeAdmin : Form
    {
        string fileName;
        public FormHomeAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            AdminBUS adminBUS = new AdminBUS();
            dgv_TaiKhoan.DataSource = adminBUS.GetAccounts();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhThuVaReprot formDoanhThuVaReprot = new FormDoanhThuVaReprot();
            formDoanhThuVaReprot.ShowDialog();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            //panel_HoaDon.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_TaiKhoan.Visible = false;
            //panel_TrangChu.Visible = false;
            //panel_Banh.Visible = false;
            if (!panel_chinh.Controls.Contains(USHoaDonAdmin.Instance))
            {
                panel_chinh.Controls.Add(USHoaDonAdmin.Instance);
                USHoaDonAdmin.Instance.Dock = DockStyle.Fill;
                USHoaDonAdmin.Instance.BringToFront();
            }
            else
                USBanhAdmin.Instance.BringToFront();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = false;
            //panel_Banh.Visible = false;
            if (!panel_chinh.Controls.Contains(USTaiKhoanAdmin.Instance))
            {
                panel_chinh.Controls.Add(USTaiKhoanAdmin.Instance);
                USTaiKhoanAdmin.Instance.Dock = DockStyle.Fill;
                USTaiKhoanAdmin.Instance.BringToFront();
            }
            else
                USTaiKhoanAdmin.Instance.BringToFront();
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            FormRegister frm =new FormRegister();
            frm.ShowDialog();
            LoadData();
        }

        private void FormHomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cake L&T", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = true;
            //panel_Banh.Visible = false;
            if (!panel_chinh.Controls.Contains(USTrangChu.Instance))
            {
                panel_chinh.Controls.Add(USTrangChu.Instance);
                USTrangChu.Instance.Dock = DockStyle.Fill;
                USTrangChu.Instance.BringToFront();
            }
            else
                USTrangChu.Instance.BringToFront();
        }

        private void btn_Banh_Click(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = true;
            //panel_Banh.Visible = true;
            if (!panel_chinh.Controls.Contains(USBanhAdmin.Instance))
            {
                panel_chinh.Controls.Add(USBanhAdmin.Instance);
                USBanhAdmin.Instance.Dock = DockStyle.Fill;
                USBanhAdmin.Instance.BringToFront();
            }
            else
                USBanhAdmin.Instance.BringToFront();
        }

        private void FormHomeAdmin_Load(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = true;
            //panel_Banh.Visible = true;
            if (!panel_chinh.Controls.Contains(USTrangChu.Instance))
            {
                panel_chinh.Controls.Add(USTrangChu.Instance);
                USTrangChu.Instance.Dock = DockStyle.Fill;
                USTrangChu.Instance.BringToFront();
            }
            else
                USBanhAdmin.Instance.BringToFront();
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            FormCaiDat formCaiDat = new FormCaiDat();
            formCaiDat.ShowDialog();
        }

    }
}

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
        public FormHomeAdmin()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            panel_DoanhThu.Visible = true;
            panel_TaiKhoan.Visible = false;
            panel_HoaDon.Visible = false;
            panel_TrangChu.Visible = false;
            panel_Banh.Visible = false;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            panel_HoaDon.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_TaiKhoan.Visible = false;
            panel_TrangChu.Visible = false;
            panel_Banh.Visible = false;

        }



        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            panel_TaiKhoan.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_HoaDon.Visible = true;
            panel_TrangChu.Visible = false;
            panel_Banh.Visible = false;
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            FormRegister frm =new FormRegister();
            frm.ShowDialog();
        }

        private void panel_TaiKhoan_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormHomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cake L&T", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            panel_TaiKhoan.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_HoaDon.Visible = true;
            panel_TrangChu.Visible = true;
            panel_Banh.Visible = false;
        }

        private void btn_Banh_Click(object sender, EventArgs e)
        {
            panel_TaiKhoan.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_HoaDon.Visible = true;
            panel_TrangChu.Visible = true;
            panel_Banh.Visible = true;
        }

        private void FormHomeAdmin_Load(object sender, EventArgs e)
        {
            panel_TaiKhoan.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_HoaDon.Visible = true;
            panel_TrangChu.Visible = true;
            panel_Banh.Visible = false;
        }
    }
}

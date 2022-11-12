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

namespace CakeL_T
{

    public partial class USHoaDonAdmin : UserControl
    {
        private static USHoaDonAdmin instance;
        public static HoaDonBUS hoadonBUS = new HoaDonBUS();
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

        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgv_HoaDon.Rows[e.RowIndex];
            txt_MaHD.Text = row.Cells["MaHoaDon"].Value.ToString();
            txt_MaNV.Text = row.Cells["IdTaiKhoan"].Value.ToString();
            txt_NgayBan.Text = row.Cells["NgayMua"].Value.ToString();
            txt_Tongtien.Text = row.Cells["TongTien"].Value.ToString();
        }

        private void btn_TimHD_Click(object sender, EventArgs e)
        {
            var tongtien = 1;
            var tien = Convert.ToInt32(cbb_TongTien.SelectedValue);
            if (cbb_TongTien.SelectedItem == null || cbb_TongTien == null)
            {
                tongtien = 0;
                tien = 0;
            }
            else if (cbb_TongTien.SelectedItem.ToString() == "Tất cả")
            {
                tongtien = 1;
            }
            else if (cbb_TongTien.SelectedItem.ToString() == "< 50.000đ")
            {
                tongtien = 50000;
            }
            else if (cbb_TongTien.SelectedItem.ToString() == "50.000đ -> 100.000đ")
            {
                tongtien = 75000;
            }
            else if (cbb_TongTien.SelectedItem.ToString() == "100.000đ -> 200.000đ")
            {
                tongtien = 150000;
            }
            else if (cbb_TongTien.SelectedItem.ToString() == "> 200.000đ")
            {
                tongtien = 200000;
            }
        }
    }
}

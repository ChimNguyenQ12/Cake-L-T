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
    }
}

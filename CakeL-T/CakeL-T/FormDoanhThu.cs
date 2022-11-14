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
    public partial class FormDoanhThu : Form
    {
        int tong = 0;
        HoaDonBUS hoadonBUS = new HoaDonBUS();
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            dgv_DTNgay.DataSource = hoadonBUS.GetHD();
            // Tính tổng doanh thu
            for( int i =0;i<dgv_DTNgay.Rows.Count;i++ )
            {
                tong =  tong + int.Parse(dgv_DTNgay.Rows[i].Cells[3].Value.ToString()); 
            }
            txt_TongDtNgay.Text= tong.ToString();
        }
    }
}

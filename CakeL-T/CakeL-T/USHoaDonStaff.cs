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
    public partial class USHoaDonStaff : UserControl
    {
        DataTable dt = new DataTable();
        public static string tenbanh, soluong, dongia;
        public static int tong = 0;
        BanhBUS banhBUS = new BanhBUS();
        private static USHoaDonStaff instance;
        public static USHoaDonStaff Instance
        {
            get
            {
                if (instance == null)
                    instance = new USHoaDonStaff();
                return instance;
            }
        }
        public USHoaDonStaff()
        {
            InitializeComponent();
        }

        private void USHoaDonStaff_Load(object sender, EventArgs e)
        {
            LoadData();
            dt.Columns.Add("Tên Bánh");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Đơn Giá");
            dt.Columns.Add("Thành Tiền");
            dgv_HoaDon.DataSource = dt;
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(num_DemBanh.Value.ToString()) * int.Parse(dongia);
            tong = tong + thanhtien;
            if(int.Parse(soluong)<num_DemBanh.Value)
            {
                MessageBox.Show("không đủ số lượng");
            }
            dt.Rows.Add(tenbanh, num_DemBanh.Value.ToString(), dongia, thanhtien);
            txt_TongTien.Text = tong.ToString();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            string tam;
            MessageBox.Show("tổng tiền cần thanh toán là: " + tong + "VND");
            tong = 0;
        }


        private void LoadData()
        {
            dgv_Banh.DataSource = banhBUS.GetCakes();
            dgv_Banh.Columns["HinhAnhs"].Visible = false;
            dgv_Banh.Columns["LoaiBanh1"].Visible = false;
            DataGridViewRow row = this.dgv_Banh.Rows[0];
        }
        private void dgv_Banh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_Banh.Rows[e.RowIndex];
            dongia = row.Cells["DonGia"].Value.ToString();
            soluong = row.Cells["SoLuong"].Value.ToString();
            tenbanh = row.Cells["TenBanh"].Value.ToString();
        }
    }
}

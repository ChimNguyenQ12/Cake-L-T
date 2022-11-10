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
        public static string tenbanh, tinhtrang, dongia, idTk;
        public static int tong = 0;
        public static string ID
        {
            set { idTk = value; }
        }
        BanhBUS banhBUS = new BanhBUS();
        LoaiBanhBUS loaiBanhBUS = new LoaiBanhBUS();
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
            label2.Text = idTk;
            LoadData();
            dt.Columns.Add("Tên Bánh");
            dt.Columns.Add("Tình Trạng");
            dt.Columns.Add("Đơn Giá");
            dt.Columns.Add("Thành Tiền");
            dgv_HoaDon.DataSource = dt;
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            int thanhtien = 0;
            thanhtien = int.Parse(num_DemBanh.Value.ToString()) * int.Parse(dongia);
            if (tinhtrang == "False")
            {
                MessageBox.Show("Bánh này đã hết hàng");
            }
            else
            {
                tong = tong + thanhtien;
                dt.Rows.Add(tenbanh, num_DemBanh.Value.ToString(), dongia, thanhtien);
                txt_TongTien.Text = tong.ToString();
            }
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            string tam;
            MessageBox.Show("tổng tiền cần thanh toán là: " + tong + "VND");
            tong = 0;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            var price = 1;
            var codeCategory = 1;
            bool status;
            if (rbn_Conhang.Checked)
            {
                status = true;
                dgv_Banh.DataSource = banhBUS.SearchCakeMulti(price, codeCategory, status);
            }
            else if (rbn_HetHang.Checked)
            {
                status = false;
                dgv_Banh.DataSource = banhBUS.SearchCakeMulti(price, codeCategory, status);
            }
        }

        private void txt_TenBanh_TextChanged(object sender, EventArgs e)
        {
            dgv_Banh.DataSource = banhBUS.SearchCakeStaff(txt_TenBanh.Text);
            for (int i = 0; i < dgv_Banh.Rows.Count; i++)
            {
                foreach (var item in loaiBanhBUS.GetCateCakes())
                {
                    if (dgv_Banh.Rows[i].Cells["LoaiBanh"].Value.ToString() == item.MaLoai.ToString())
                    {
                        dgv_Banh.Rows[i].Cells["TenLoaiBanh"].Value = item.TenLoai.ToString();
                    }
                }
                if (dgv_Banh.Rows[i].Cells["TrangThaiBanh"].Value.ToString() == "True")
                {
                    dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Còn hàng";
                }
                else
                {
                    dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Hết hàng";
                }
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            dgv_Banh.DataSource = banhBUS.GetCakes();
            for (int i = 0; i < dgv_Banh.Rows.Count; i++)
            {
                foreach (var item in loaiBanhBUS.GetCateCakes())
                {
                    if (dgv_Banh.Rows[i].Cells["LoaiBanh"].Value.ToString() == item.MaLoai.ToString())
                    {
                        dgv_Banh.Rows[i].Cells["TenLoaiBanh"].Value = item.TenLoai.ToString();
                    }
                }
                if (dgv_Banh.Rows[i].Cells["TrangThaiBanh"].Value.ToString() == "True")
                {
                    dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Còn hàng";
                }
                else
                {
                    dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Hết hàng";
                }
            }
            dgv_Banh.Columns["LoaiBanh"].Visible = false;
            dgv_Banh.Columns["MaBanh"].Visible = false;
            dgv_Banh.Columns["HinhAnh"].Visible = false;
            dgv_Banh.Columns["LoaiBanh"].Visible = false;
            dgv_Banh.Columns["HinhAnhs"].Visible = false;
            dgv_Banh.Columns["LoaiBanh1"].Visible = false;
            dgv_Banh.Columns["TrangThaiXoa"].Visible = false;
            dgv_Banh.Columns["TrangThaiBanh"].Visible = false;
        }
        private void dgv_Banh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_Banh.Rows[e.RowIndex];
            dongia = row.Cells["DonGia"].Value.ToString();
            tinhtrang = row.Cells["TrangThaiBanh"].Value.ToString();
            tenbanh = row.Cells["TenBanh"].Value.ToString();
        }
    }
}

using BLL;
using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace CakeL_T
{
    public partial class USHoaDonStaff : UserControl
    {
       
        DataTable dt ;
        public static string tenbanh, tinhtrang, dongia, tam, tensosanh;
        public static int tong = 0, maHD = 0, maCTHD, _idTk;
        public static int ID
        {
            set { _idTk = value; }
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
            
            LoadData();
            dt=new DataTable();
            dt.Columns.Add("Tên Bánh");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Đơn Giá");
            dt.Columns.Add("Thành Tiền");
            dgv_HoaDon.DataSource = dt;
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            int tontai = 0, vitri =0;
            
            try
            {
                for (int i = 0; i < dgv_HoaDon.Rows.Count; i++)
                {
                    if (dgv_HoaDon.Rows[i].Cells["Tên Bánh"].Value != null)
                    {
                        if (tensosanh == dgv_HoaDon.Rows[i].Cells["Tên Bánh"].Value.ToString())
                        {
                            tontai = 1;
                            vitri = i;
                            break;
                        }
                        else
                        {
                            tontai = 0;
                        }
                    }
                    else
                    {
                        tontai = 0;
                        break;
                    }
                }
                if (tontai == 0)
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
                else
                {
                    int soluongmoi = 0;
                    soluongmoi = int.Parse(dgv_HoaDon.Rows[vitri].Cells[1].Value.ToString()) + int.Parse(num_DemBanh.Value.ToString());
                    dgv_HoaDon.Rows[vitri].Cells[1].Value = soluongmoi;
                    tong = tong + (soluongmoi * int.Parse(dgv_HoaDon.Rows[vitri].Cells[3].Value.ToString()) - int.Parse(dgv_HoaDon.Rows[vitri].Cells[3].Value.ToString()));
                    txt_TongTien.Text = tong.ToString();
                    dgv_HoaDon.Rows[vitri].Cells[3].Value = soluongmoi * int.Parse(dgv_HoaDon.Rows[vitri].Cells[3].Value.ToString());
                }
            }
            catch { };
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            bool trangthai = true;
            int idTk;
            int soLuong = 0, tongTien = 0, maBanh = 0, giatien = 0, maHD;

            idTk = _idTk;
            
            soLuong=int.Parse(num_DemBanh.Value.ToString());
            tongTien = tong;

            HoaDonBUS hoadonBUS = new HoaDonBUS();
            CTHoaDonBUS ctBUS = new CTHoaDonBUS();
            try
            {   
                if (hoadonBUS.ThemHoaDon(idTk, tongTien, trangthai) == "success")
                {
                    for(int i = 0; i< dgv_HoaDon.Rows.Count-1; i++)
                    {
                        string namecake=null;
                        namecake = dgv_HoaDon.Rows[i].Cells["Tên Bánh"].Value.ToString();

                        var cake = banhBUS.GetCakeByName(namecake);
                        foreach (var item in cake)
                        {
                             maBanh = item.MaBanh;
                        }
                        soLuong = int.Parse( dgv_HoaDon.Rows[i].Cells["Số Lượng"].Value.ToString());
                        giatien = int.Parse(dgv_HoaDon.Rows[i].Cells["Số Lượng"].Value.ToString()) * int.Parse(dgv_HoaDon.Rows[i].Cells["Thành Tiền"].Value.ToString());
                        if (ctBUS.ThemCTHoaDon(maBanh,soLuong,giatien,trangthai) == "success")
                        {
                            Debug.WriteLine("success");
                        }
                    }

                    MessageBox.Show("Thanh toán thành công");
                    maHD= 0;
                    dt = new DataTable();
                    dt.Columns.Add("Tên Bánh");
                    dt.Columns.Add("Số Lượng");
                    dt.Columns.Add("Đơn Giá");
                    dt.Columns.Add("Thành Tiền");
                    dgv_HoaDon.DataSource = dt;
                    tong = 0;
                    txt_TongTien.Text = "0";
                    txt_TienThua.Text = "0";
                    txt_TienNhan.Text = "0";
                }
            }
            catch (Exception ex) {  }
        }

        private void txt_TienNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tienthua = 0;
                tienthua = int.Parse(txt_TienNhan.Text) - tong;
                if (tienthua > 0)
                {
                    txt_TienThua.Text = tienthua.ToString();
                }
                else
                {
                    txt_TienThua.Clear();
                    txt_TienThua.Text += "0";
                }
            }
            catch (Exception ex) 
            { 
                txt_TienThua.Clear() ;
                txt_TienThua.Text = "0"; 
            }
        }

        private void txt_TienNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txt_TienNhan.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void num_DemBanh_ValueChanged(object sender, EventArgs e)
        {
            if(int .Parse(num_DemBanh.Value.ToString())<1)
            {
                MessageBox.Show("Số lượng phải lớn hơn 1");
                num_DemBanh.Value= 1;
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int tongtien = 0;
                foreach (DataGridViewRow item in this.dgv_HoaDon.SelectedRows)
                {
                    dgv_HoaDon.Rows.RemoveAt(item.Index);
                }
                tongtien = int.Parse(txt_TongTien.Text.Trim()) - int.Parse(tam);
                tong = tongtien;
                txt_TongTien.Text = tongtien.ToString();
            }
            catch { }
        }

        private void num_DemBanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)
            {
                MessageBox.Show("Chỉ được nhập số nguyên");
                e.Handled = true;   
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Tên Bánh");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Đơn Giá");
            dt.Columns.Add("Thành Tiền");
            dgv_HoaDon.DataSource = dt;
            txt_TongTien.Text = "0";
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgv_HoaDon.CurrentCell.RowIndex; 
            tam = dgv_HoaDon.Rows[index].Cells[3].Value.ToString();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            bool status;
            if (rbn_Conhang.Checked)
            {
                status = true;
                dgv_Banh.DataSource = banhBUS.SearchCakeStatus(status);
            }
            else if (rbn_HetHang.Checked)
            {
                status = false;
                dgv_Banh.DataSource = banhBUS.SearchCakeStatus(status);
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
            DataGridViewRow row = this.dgv_Banh.Rows[0];
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
            //dgv_Banh.Columns["HinhAnhs"].Visible = false;
            //dgv_Banh.Columns["LoaiBanh1"].Visible = false;
            dgv_Banh.Columns["TrangThaiXoa"].Visible = false;
            dgv_Banh.Columns["TrangThaiBanh"].Visible = false;
           
        }
        private void dgv_Banh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = this.dgv_Banh.Rows[e.RowIndex];
            //dongia = row.Cells["Đơn Giá"].Value.ToString();
            //tinhtrang = row.Cells["Trạng Thái"].Value.ToString();
            //tenbanh = row.Cells["Tên Bánh"].Value.ToString();
            int index = dgv_Banh.CurrentCell.RowIndex;
            dongia = dgv_Banh.Rows[index].Cells[3].Value.ToString();
            tenbanh = dgv_Banh.Rows[index].Cells[1].Value.ToString();
            tinhtrang = dgv_Banh.Rows[index].Cells[2].Value.ToString();
            tensosanh = dgv_Banh.Rows[index].Cells[1].Value.ToString();
        }
    }
}

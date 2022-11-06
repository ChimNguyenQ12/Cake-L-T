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
    public partial class USBanhAdmin : UserControl
    {
        private static USBanhAdmin instance;
        BanhBUS banhBUS = new BanhBUS();
        LoaiBanhBUS loaiBanhBUS = new LoaiBanhBUS();
        public static USBanhAdmin Instance
        {
            get
            {
                if (instance == null)
                    instance = new USBanhAdmin();
                return instance;
            }
        }
        public USBanhAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void BanhAdmin_Load(object sender, EventArgs e)
        {
            txt_TimBanh.Text = "Tìm kiếm bánh...";
            gbLoaiBanh.Hide();
            dgvLoaiBanh.Hide();
            gbChucNangLoaiBanh.Show();

            gbBanh.Show();
            gbChucNangBanh.Show();
            dgv_Banh.Show();
        }

        private void btnQuanLyLoaiBanh_Click(object sender, EventArgs e)
        {
            LoadDataCateCake();
            gbChucNangLoaiBanh.Show();
            gbLoaiBanh.Show();
            dgvLoaiBanh.Show();

            gbBanh.Hide();
            gbChucNangBanh.Hide();
            dgv_Banh.Hide();
        }

        private void btnQuanLyBanh_Click(object sender, EventArgs e)
        {
            gbChucNangLoaiBanh.Show();
            gbLoaiBanh.Hide();
            dgvLoaiBanh.Hide();

            gbBanh.Show();
            gbChucNangBanh.Show();
            dgv_Banh.Show();
        }

        private void btn_ThemBanh_Click(object sender, EventArgs e)
        {
            if (banhBUS.AddCake(int.Parse(cbb_loaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), pb_Banh.ToString()) == "success")
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData();
            }
            else if (banhBUS.AddCake(int.Parse(cbb_loaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), pb_Banh.ToString()) == "Cake already exists")
            {
                MessageBox.Show("Sản phẩm đã tồn tại!");
                LoadData();
            }
            else if (banhBUS.AddCake(int.Parse(cbb_loaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), pb_Banh.ToString()) == "error")
            {
                MessageBox.Show("Có gì đó không ổn :/");
                LoadData();
            }
        }
        private void LoadData()
        {
            var cate = loaiBanhBUS.GetCateCakes();
            cbb_loaiBanh.DataSource = cate;
            cbb_loaiBanh.DisplayMember = "TenLoai";
            cbb_loaiBanh.ValueMember = "MaLoai";

            cbb_price.Text = "Chọn khoảng giá";
            cbbCategory.Text = "Chọn loại bánh";
            dtpNSX.Text = String.Empty;
            dtpNgayHH.Text = String.Empty;
            dtp_NgayHH.MinDate = DateTime.Today;
            dtpNgayHH.MinDate = DateTime.Today;
            txt_TimBanh.Text = "Tìm kiếm bánh...";

            dgv_Banh.DataSource = banhBUS.GetCakes();
            for (int i = 0; i < dgv_Banh.Rows.Count; i++)
            {
                //Use when column names known
                if(dgv_Banh.Rows[i].Cells["LoaiBanh"].Value.ToString() == "1")
                {
                    dgv_Banh.Rows[i].Cells["TenLoaiBanh"].Value = "Kem";
                }
            }
            dgv_Banh.Columns["HinhAnh"].Visible = false;
            dgv_Banh.Columns["LoaiBanh"].Visible = false;
            dgv_Banh.Columns["HinhAnhs"].Visible = false;
            dgv_Banh.Columns["LoaiBanh1"].Visible = false;
            dgv_Banh.Columns["TrangThaiXoa"].Visible = false;


            DataGridViewRow row = this.dgv_Banh.Rows[0];
           
            txt_MaBanh.Text = row.Cells["MaBanh"].Value.ToString();
            txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
            cbb_loaiBanh.Text = row.Cells["LoaiBanh"].Value.ToString();
            txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            txt_TenBanh.Text = row.Cells["TenBanh"].Value.ToString();
        }

        private void LoadDataCateCake()
        {
            txtTimLoaiBanh.Text = "Tìm kiếm loại bánh...";
            dgvLoaiBanh.DataSource = loaiBanhBUS.GetCateCakes();
            dgvLoaiBanh.Columns["Banhs"].Visible = false;
            dgvLoaiBanh.Columns["TrangThaiXoa"].Visible = false;
            DataGridViewRow row = this.dgvLoaiBanh.Rows[0];
            txtTenLoaiBanh.Text = row.Cells["TenLoai"].Value.ToString();
            txtMaLoaiBanh.Text = row.Cells["MaLoai"].Value.ToString();
        }

        private void Clear()
        {
            txt_DonGia.Text = "";
            txt_SoLuong.Text = "";
            txt_TenBanh.Text = "";
            cbb_loaiBanh.Text = "";
            txtMaLoaiBanh.Text = "";
            txtTenLoaiBanh.Text = "";
        }

        private void GetCakeById(int code)
        {
           
            var accountById = banhBUS.GetCakeById(code);
            if (accountById == null)
            {
                MessageBox.Show("Có gì đó không ổn");
            }
        }

        private void UpdateCake(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
        {
            banhBUS.UpdateCakeById(code, category, name, quanity, price, dateManu, dateExpire, image);
            LoadData();
        }

        private void UpdateCateCake(int code,string name)
        {
            loaiBanhBUS.UpdateCateCakeById(code, name);
            LoadData();
        }

        private void DeleteCake(int code)
        {
            banhBUS.DeleteCakeById(code);
            LoadData();
        }

        private void DeleteCateCake(int code)
        {
            loaiBanhBUS.DeleteCateCakeById(code);
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_XoaBanh_Click(object sender, EventArgs e)
        {
            var row = dgv_Banh.SelectedRows[0];
            var cell = row.Cells["MaBanh"];
            int idSelected = Convert.ToInt32(cell.Value);
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {txt_MaBanh.Text}?",
                                     "Xác nhận xóa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteCake(idSelected);
                LoadData();
                MessageBox.Show($"Sản phẩm {txt_MaBanh.Text} đã được xóa!", "Xóa sản phẩm");
            }      
        }

        private void btn_SuaBanh_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa sản phẩm {txt_MaBanh.Text}?",
                                     "Xác nhận sửa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var row = dgv_Banh.SelectedRows[0];
                var cell = row.Cells["MaBanh"];
                int idSelected = Convert.ToInt32(cell.Value);
                string image = pb_Banh.ToString();
                UpdateCake(idSelected, int.Parse(cbb_loaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), image);
                LoadData();
                MessageBox.Show($"Sửa sản phẩm {txt_MaBanh.Text} thành công", "Sửa sản phẩm");
            }
        }

        private void dgv_Banh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgv_Banh.Rows[e.RowIndex];
            txt_MaBanh.Text = row.Cells["MaBanh"].Value.ToString();
            txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
            cbb_loaiBanh.Text = row.Cells["LoaiBanh"].Value.ToString();
            txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            txt_TenBanh.Text = row.Cells["TenBanh"].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadDataCateCake();

        }

        private void txt_TimBanh_TextChanged(object sender, EventArgs e)
        {
            dgv_Banh.DataSource = banhBUS.SearchCake(txt_TimBanh.Text);
        }

        private void btnClearBanh_Click(object sender, EventArgs e)
        {
            txt_TenBanh.Text = "";
            txt_DonGia.Text = "";
            txt_SoLuong.Text = "";
            txtTenLoaiBanh.Text = "";
        }

        private void txt_TimBanh_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt_TimBanh.Text == "Tìm kiếm bánh...")
            txt_TimBanh.Text = "";
        }

        private void btn_TimHD_Click(object sender, EventArgs e)
        {
            var price = 1 ;
            var codeCategory = 1;
            if(cbb_price.SelectedItem == null || cbbCategory == null)
            {
                price = 0;
                codeCategory = 0;
            }
            else if(cbb_price.SelectedItem.ToString() == "< 50.000đ")
            {
                price = 50000;
            }
            else if (cbb_price.SelectedItem.ToString() == "50.000đ -> 100.000đ")
            {
                price = 75000;
            }
            else if (cbb_price.SelectedItem.ToString() == "100.000đ -> 200.000đ")
            {
                price = 150000;
            }
            else if (cbb_price.SelectedItem.ToString() == "> 200.000đ")
            {
                price = 200000;
            }
            string DateManu = dtpNSX.Value.ToString("yyyy-MM-dd");
            string DateExpire = dtpNgayHH.Value.ToString("yyyy-MM-dd");
            dgv_Banh.DataSource = banhBUS.SearchCakeMulti(price, codeCategory, DateTime.Parse(DateManu), DateTime.Parse(DateExpire));
        }

        private void btnThemLoaiBanh_Click(object sender, EventArgs e)
        {
            if (loaiBanhBUS.AddCateCake(txtTenLoaiBanh.Text) == "success")
            {
                MessageBox.Show("Thêm loại sản phẩm thành công!");
                LoadDataCateCake();
            }
            else if (loaiBanhBUS.AddCateCake(txtTenLoaiBanh.Text) == "Cake Category already exists")
            {
                MessageBox.Show("Loại Sản phẩm đã tồn tại!");
                LoadDataCateCake();
            }
            else if (loaiBanhBUS.AddCateCake(txtTenLoaiBanh.Text) == "error")
            {
                MessageBox.Show("Có gì đó không ổn :/");
                LoadDataCateCake();
            }
        }

        private void btnXoaLoaiBanh_Click(object sender, EventArgs e)
        {
            var row = dgvLoaiBanh.SelectedRows[0];
            var cell = row.Cells["MaLoai"];
            int idSelected = Convert.ToInt32(cell.Value);
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa loại sản phẩm {txtMaLoaiBanh.Text}?",
                                     "Xác nhận xóa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteCateCake(idSelected);
                LoadDataCateCake();
                MessageBox.Show($"Loại Sản phẩm {txtMaLoaiBanh.Text} đã được xóa!", "Xóa sản phẩm");
            }
        }

        private void btnSuaLoaiBanh_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa loại sản phẩm {txtMaLoaiBanh.Text}?",
                                     "Xác nhận sửa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var row = dgv_Banh.SelectedRows[0];
                var cell = row.Cells["MaBanh"];
                int idSelected = Convert.ToInt32(cell.Value);
                string image = pb_Banh.ToString();
                UpdateCateCake(idSelected, txtTenLoaiBanh.Text);
                LoadDataCateCake();
                MessageBox.Show($"Sửa loại sản phẩm {txtMaLoaiBanh.Text} thành công", "Sửa loại sản phẩm");
            }
        }

        private void txtTimLoaiBanh_TextChanged(object sender, EventArgs e)
        {
            dgvLoaiBanh.DataSource = loaiBanhBUS.SearchCateCake(txtTimLoaiBanh.Text);
        }

        private void txtTimLoaiBanh_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTimLoaiBanh.Text == "Tìm kiếm loại bánh...")
                txtTimLoaiBanh.Text = "";
        }
    }
}

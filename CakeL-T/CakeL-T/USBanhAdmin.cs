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
            loadCateCakeSearch();

            panel_banh.Visible = true;
            panel_loaiBanh.Visible = true;
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
            panel_banh.Visible = false;
            panel_loaiBanh.Visible = true;
            gbChucNangLoaiBanh.Show();
            gbLoaiBanh.Show();
            dgvLoaiBanh.Show();

            gbBanh.Hide();
            gbChucNangBanh.Hide();
            dgv_Banh.Hide();
        }

        private void btnQuanLyBanh_Click(object sender, EventArgs e)
        {
            panel_banh.Visible = true;
            gbChucNangLoaiBanh.Show();
            gbLoaiBanh.Hide();
            dgvLoaiBanh.Hide();

            gbBanh.Show();
            gbChucNangBanh.Show();
            dgv_Banh.Show();
        }

        private void btn_ThemBanh_Click(object sender, EventArgs e)
        {
            if(txt_MaBanh.Enabled == false)
            {
                txt_MaBanh.Enabled = true;
                btn_SuaBanh.Enabled = false;
                btn_XoaBanh.Enabled = false;
            }
            else
            {
                if (txt_MaBanh.Text == "" || txt_DonGia.Text == "" || txt_TenBanh.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    var cateCake = Convert.ToInt32(cbb_loaiBanh.SelectedValue);
                    if (banhBUS.AddCake(int.Parse(txt_MaBanh.Text), cateCake, txt_TenBanh.Text, int.Parse(txt_DonGia.Text), pb_Banh.ToString()) == "success")
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        LoadData();
                    }
                    else if (banhBUS.AddCake(int.Parse(txt_MaBanh.Text), cateCake, txt_TenBanh.Text, int.Parse(txt_DonGia.Text), pb_Banh.ToString()) == "Cake already exists")
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại!");
                        LoadData();
                    }
                    else if (banhBUS.AddCake(int.Parse(txt_MaBanh.Text), cateCake, txt_TenBanh.Text, int.Parse(txt_DonGia.Text), pb_Banh.ToString()) == "error")
                    {
                        MessageBox.Show("Có gì đó không ổn :/");
                        LoadData();
                    }
                }
            }
        }
        private void LoadData()
        {
            txt_MaBanh.Enabled = false;
            btn_SuaBanh.Enabled = true;
            btn_XoaBanh.Enabled = true;
            panel_banh.Visible = true;
            panel_loaiBanh.Visible = true;
            LoadDataCategoryCake();
            cbb_price.Text = "Chọn khoảng giá";
            cbbCategoryTim.Text = "Chọn loại bánh";

            dgv_Banh.DataSource = banhBUS.GetCakes();
            for (int i = 0; i < dgv_Banh.Rows.Count; i++)
            {   
                foreach (var item in loaiBanhBUS.GetCateCakes())
                {
                    if(dgv_Banh.Rows[i].Cells["LoaiBanh"].Value.ToString() == item.MaLoai.ToString())
                    {
                        dgv_Banh.Rows[i].Cells["TenLoaiBanh"].Value = item.TenLoai.ToString();
                    }
                }
                if (dgv_Banh.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                {
                    dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Còn hàng";
                }
                else
                {
                    dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Hết hàng";
                }
            }
            dgv_Banh.Columns["HinhAnh"].Visible = false;
            dgv_Banh.Columns["LoaiBanh"].Visible = false;
            dgv_Banh.Columns["HinhAnhs"].Visible = false;
            dgv_Banh.Columns["LoaiBanh1"].Visible = false;
            dgv_Banh.Columns["TrangThaiXoa"].Visible = false;
            dgv_Banh.Columns["TrangThai"].Visible = false;


            DataGridViewRow row = this.dgv_Banh.Rows[0];
           
            txt_MaBanh.Text = row.Cells["MaBanh"].Value.ToString();
            txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
            cbb_loaiBanh.Text = row.Cells["TenLoaiBanh"].Value.ToString();
            txt_TenBanh.Text = row.Cells["TenBanh"].Value.ToString();
            if (Convert.ToBoolean(row.Cells["TrangThai"].Value) == true)
            {
                radioActiveCake.Checked = true;
                radioUnactiveCake.Checked = false;
            }
            else
                 radioActiveCake.Checked = false;
                radioUnactiveCake.Checked = true;
        }

        private void LoadDataCategoryCake()
        {
            txtMaLoaiBanh.Enabled = false;
            btnXoaLoaiBanh.Enabled = true;
            btnSuaLoaiBanh.Enabled = true;

            var cate = loaiBanhBUS.GetCateCakes();
            cbb_loaiBanh.DataSource = cate;
            cbb_loaiBanh.DisplayMember = "TenLoai";
            cbb_loaiBanh.ValueMember = "MaLoai";
        }
        private void loadCateCakeSearch()
        {
            var cate = loaiBanhBUS.GetCateCakes();
            cbbCategoryTim.DataSource = cate;
            cbbCategoryTim.DisplayMember = "TenLoai";
            cbbCategoryTim.ValueMember = "MaLoai";
        }
        private void LoadDataCateCake()
        {
            panel_loaiBanh.Visible = true;
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

        private void UpdateCake(int code, int category, string name, bool status, int price, string image)
        {
            banhBUS.UpdateCakeById(code, category, name, status, price, image);
        }

        private void UpdateCateCake(int code,string name)
        {
            loaiBanhBUS.UpdateCateCakeById(code, name);
        }

        private void DeleteCake(int code, int category, string name, int price, string image)
        {
            banhBUS.DeleteCakeById(code, category, name, price, image);
        }

        private void DeleteCateCake(int code, string name)
        {
            loaiBanhBUS.DeleteCateCakeById(code, name);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_XoaBanh_Click(object sender, EventArgs e)
        {
            var cateCake = Convert.ToInt32(cbb_loaiBanh.SelectedValue);
            var row = dgv_Banh.SelectedRows[0];
            var cell = row.Cells["MaBanh"];
            int idSelected = Convert.ToInt32(cell.Value);
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm {txt_MaBanh.Text}?",
                                     "Xác nhận xóa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteCake(idSelected, cateCake, txt_TenBanh.Text, int.Parse(txt_DonGia.Text), pb_Banh.ToString());
                MessageBox.Show($"Sản phẩm {txt_MaBanh.Text} đã được xóa!", "Xóa sản phẩm");
                LoadData();
            }      
        }

        private void btn_SuaBanh_Click(object sender, EventArgs e)
        {
            var cateCake = Convert.ToInt32(cbb_loaiBanh.SelectedValue);
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa sản phẩm {txt_MaBanh.Text}?",
                                     "Xác nhận sửa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                var row = dgv_Banh.SelectedRows[0];
                var cell = row.Cells["MaBanh"];
                int idSelected = Convert.ToInt32(cell.Value);
                string image = pb_Banh.ToString();
                bool status;
                if (radioActiveCake.Checked)
                {
                    status = true;
                    UpdateCake(idSelected, cateCake, txt_TenBanh.Text, status, int.Parse(txt_DonGia.Text), image);
                    MessageBox.Show($"Sửa sản phẩm {txt_MaBanh.Text} thành công", "Sửa sản phẩm");
                    LoadData();
                }
                if (radioUnactiveCake.Checked)
                {
                    status = false;
                    UpdateCake(idSelected, cateCake, txt_TenBanh.Text, status, int.Parse(txt_DonGia.Text), image);
                    MessageBox.Show($"Sửa sản phẩm {txt_MaBanh.Text} thành công", "Sửa sản phẩm");
                    LoadData();
                }
            }
        }

        private void dgv_Banh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaBanh.Enabled = false;
            btn_SuaBanh.Enabled = true;
            btn_XoaBanh.Enabled = true;

            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgv_Banh.Rows[e.RowIndex];
            txt_MaBanh.Text = row.Cells["MaBanh"].Value.ToString();
            txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
            cbb_loaiBanh.Text = row.Cells["TenLoaiBanh"].Value.ToString();
            txt_TenBanh.Text = row.Cells["TenBanh"].Value.ToString();
            if (Convert.ToBoolean(row.Cells["TrangThai"].Value) == true)
            {
                radioActiveCake.Checked = true;
            }
            else
                radioUnactiveCake.Checked = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txt_MaBanh.Enabled = false;
            btn_ThemBanh.Enabled = true;
            btn_XoaBanh.Enabled = true;
        }

        private void txt_TimBanh_TextChanged(object sender, EventArgs e)
        {
            if(txt_TimBanh.Text == "") { 
               dgv_Banh.DataSource = banhBUS.SearchCake(0);
                for (int i = 0; i < dgv_Banh.Rows.Count; i++)
                {
                    foreach (var item in loaiBanhBUS.GetCateCakes())
                    {
                        if (dgv_Banh.Rows[i].Cells["LoaiBanh"].Value.ToString() == item.MaLoai.ToString())
                        {
                            dgv_Banh.Rows[i].Cells["TenLoaiBanh"].Value = item.TenLoai.ToString();
                        }
                    }
                    if (dgv_Banh.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                    {
                        dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Còn hàng";
                    }
                    else
                    {
                        dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Hết hàng";
                    }
                }
            }
            else
            {
                dgv_Banh.DataSource = banhBUS.SearchCake(int.Parse(txt_TimBanh.Text));
                for (int i = 0; i < dgv_Banh.Rows.Count; i++)
                {
                    foreach (var item in loaiBanhBUS.GetCateCakes())
                    {
                        if (dgv_Banh.Rows[i].Cells["LoaiBanh"].Value.ToString() == item.MaLoai.ToString())
                        {
                            dgv_Banh.Rows[i].Cells["TenLoaiBanh"].Value = item.TenLoai.ToString();
                        }
                    }
                    if (dgv_Banh.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                    {
                        dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Còn hàng";
                    }
                    else
                    {
                        dgv_Banh.Rows[i].Cells["TenTrangThaiBanh"].Value = "Hết hàng";
                    }
                }
            }
        }

        private void btnClearBanh_Click(object sender, EventArgs e)
        {
            txt_TenBanh.Text = "";
            txt_DonGia.Text = "";
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
            var cate = Convert.ToInt32(cbbCategoryTim.SelectedValue);
            bool status;
            if(cbb_price.SelectedItem == null || cbbCategoryTim == null)
            {
                price = 0;
                cate = 0;
            }
            else if (cbb_price.SelectedItem.ToString() == "Tất cả")
            {
                price = 1;
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
            if (radioTimActiveCake.Checked)
            {
                status = true;
                dgv_Banh.DataSource = banhBUS.SearchCakeMulti(price, cate, status);
            }
            else if (radioTimUnactiveCake.Checked)
            {
                status = false;
                dgv_Banh.DataSource = banhBUS.SearchCakeMulti(price, cate, status);
            }
        }

        private void btnThemLoaiBanh_Click(object sender, EventArgs e)
        {
            if(txtMaLoaiBanh.Enabled == false )
            {
                txtMaLoaiBanh.Enabled = true;
                btnSuaLoaiBanh.Enabled = false;
                btnXoaLoaiBanh.Enabled = false;
            }
            else
            {
                if (loaiBanhBUS.AddCateCake(txtTenLoaiBanh.Text, int.Parse(txtMaLoaiBanh.Text)) == "success")
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công!");
                    LoadDataCateCake();
                    LoadDataCategoryCake();
                }
                else if (loaiBanhBUS.AddCateCake(txtTenLoaiBanh.Text, int.Parse(txtMaLoaiBanh.Text)) == "Cake Category already exists")
                {
                    MessageBox.Show("Loại Sản phẩm đã tồn tại!");
                    LoadDataCateCake();
                }
                else if (loaiBanhBUS.AddCateCake(txtTenLoaiBanh.Text, int.Parse(txtMaLoaiBanh.Text)) == "error")
                {
                    MessageBox.Show("Có gì đó không ổn :/");
                    LoadDataCateCake();
                }
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
                DeleteCateCake(idSelected, txtTenLoaiBanh.Text);
                MessageBox.Show($"Loại Sản phẩm {txtMaLoaiBanh.Text} đã được xóa!", "Xóa sản phẩm");
                LoadDataCateCake();
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
                MessageBox.Show($"Sửa loại sản phẩm {txtMaLoaiBanh.Text} thành công", "Sửa loại sản phẩm");
                LoadDataCateCake();
            }
        }

        private void dgvLoaiBanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLoaiBanh.Enabled = false;
            btnXoaLoaiBanh.Enabled = true;
            btnSuaLoaiBanh.Enabled = true;
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgvLoaiBanh.Rows[e.RowIndex];
            txtMaLoaiBanh.Text = row.Cells["MaLoai"].Value.ToString();
            txtTenLoaiBanh.Text = row.Cells["TenLoai"].Value.ToString();
        }

        private void txt_MaBanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_TimBanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void txt_tim_loaiBanh_TextChanged(object sender, EventArgs e)
        {
            if (txt_tim_loaiBanh.Text == "")
            {
                dgvLoaiBanh.DataSource = loaiBanhBUS.SearchCateCake(0);
            }
            else
            {
                dgvLoaiBanh.DataSource = loaiBanhBUS.SearchCateCake(int.Parse(txt_tim_loaiBanh.Text));
            }
        }

        private void btnClearLoaiBanh_Click(object sender, EventArgs e)
        {
            LoadDataCateCake();
        }

    }
}

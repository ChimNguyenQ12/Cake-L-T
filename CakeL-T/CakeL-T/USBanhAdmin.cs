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
            gbLoaiBanh.Hide();
            dgvLoaiBanh.Hide();
            gbChucNangLoaiBanh.Show();

            gbBanh.Show();
            gbChucNangBanh.Show();
            dgv_Banh.Show();
        }

        private void btnQuanLyLoaiBanh_Click(object sender, EventArgs e)
        {
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
            BanhBUS banhBUS = new BanhBUS();
            if (banhBUS.AddCake(int.Parse(txt_LoaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), pb_Banh.ToString()) == "success")
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                LoadData();
            }
            else if (banhBUS.AddCake(int.Parse(txt_LoaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), pb_Banh.ToString()) == "Cake already exists")
            {
                MessageBox.Show("Sản phẩm đã tồn tại!");
                LoadData();
            }
            else if (banhBUS.AddCake(int.Parse(txt_LoaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), pb_Banh.ToString()) == "error")
            {
                MessageBox.Show("Có gì đó không ổn :/");
                LoadData();
            }
        }
        private void LoadData()
        {
            BanhBUS banhBUS = new BanhBUS();
            dgv_Banh.DataSource = banhBUS.GetCakes();
            dgv_Banh.Columns["HinhAnh"].Visible = false;
            dgv_Banh.Columns["LoaiBanh1"].Visible = false;
            DataGridViewRow row = this.dgv_Banh.Rows[0];
            txt_MaBanh.Text = row.Cells["MaBanh"].Value.ToString();
            txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
            txt_LoaiBanh.Text = row.Cells["LoaiBanh"].Value.ToString();
            txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            txt_TenBanh.Text = row.Cells["TenBanh"].Value.ToString();
        }

        private void Clear()
        {
            txt_DonGia.Text = "";
            txt_SoLuong.Text = "";
            txt_TenBanh.Text = "";
            txt_LoaiBanh.Text = "";
        }

        private void GetCakeById(int code)
        {
            BanhBUS banhBUS = new BanhBUS();
            var accountById = banhBUS.GetCakeById(code);
            if (accountById == null)
            {
                MessageBox.Show("Có gì đó không ổn");
            }
        }

        private void UpdateCake(int code, int category, string name, int quanity, int price, DateTime dateManu, DateTime dateExpire, string image)
        {
            BanhBUS banhBUS = new BanhBUS();
            banhBUS.UpdateCakeById(code, category, name, quanity, price, dateManu, dateExpire, image);
            LoadData();
        }

        private void DeleteCake(int code)
        {
            BanhBUS banhBUS = new BanhBUS();
            banhBUS.DeleteCakeById(code);
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
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?",
                                     "Xác nhận xóa!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteCake(idSelected);
                MessageBox.Show("Xóa sản phẩm thành công");
            }
            else
            {

            }
        }

        private void btn_SuaBanh_Click(object sender, EventArgs e)
        {
            //if (txt_MatKhau.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa nhập mật khẩu");
            //}
            //else if (txt_MatKhau.Text.Length < 6 || txt_MatKhau.Text.Length > 20)
            //{
            //    MessageBox.Show("Mật khẩu chứa ít nhất 6 ký tự và nhiều nhất 20 ký tự");
            //}
            //else
            //{
            var row = dgv_Banh.SelectedRows[0];
            var cell = row.Cells["MaBanh"];
            int idSelected = Convert.ToInt32(cell.Value);
            string image = pb_Banh.ToString();
            UpdateCake(idSelected, int.Parse(txt_LoaiBanh.Text), txt_TenBanh.Text, int.Parse(txt_SoLuong.Text), int.Parse(txt_DonGia.Text), DateTime.Parse(dtp_NgaySX.Text), DateTime.Parse(dtp_NgayHH.Text), image);
            //}
        }

        private void dgv_Banh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_Banh.Rows[e.RowIndex];
            txt_MaBanh.Text = row.Cells["MaBanh"].Value.ToString();
            txt_DonGia.Text = row.Cells["DonGia"].Value.ToString();
            txt_LoaiBanh.Text = row.Cells["LoaiBanh"].Value.ToString();
            txt_SoLuong.Text = row.Cells["SoLuong"].Value.ToString();
            txt_TenBanh.Text = row.Cells["TenBanh"].Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}

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
    public partial class USTaiKhoanAdmin : UserControl
    {
        string fileName;
        private static USTaiKhoanAdmin instance;
        public static USTaiKhoanAdmin Instance
        {
            get
            {
                if (instance == null)
                    instance = new USTaiKhoanAdmin();
                return instance;
            }
        }
        public USTaiKhoanAdmin()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            AdminBUS adminBUS = new AdminBUS();
            dgv_TaiKhoan.DataSource = adminBUS.GetAccounts();
            dgv_TaiKhoan.Columns["Id"].Visible = false;
            dgv_TaiKhoan.Columns["HinhAnh"].Visible = false;
            DataGridViewRow row = this.dgv_TaiKhoan.Rows[0];
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txt_TenNV.Text = row.Cells["HoTen"].Value.ToString();
            txt_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
        }

        private void Clear()
        {
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            txt_TenNV.Text = "";
            txt_TrangThai.Text = "";
        }

        private void GetAccountById(int id)
        {
            AdminBUS adminBUS = new AdminBUS();
            var accountById = adminBUS.GetAccountById(id);
            if (accountById == null)
            {
                MessageBox.Show("Có gì đó không ổn");
            }
        }

        private void UpdateAccount(int id, string fullname, string username, string password, string address, string phone, string image)
        {
            AdminBUS adminBUS = new AdminBUS();
            adminBUS.UpdateAccountById(id, fullname, username, password, address, phone, image);
            LoadData();
        }

        private void DeleteAccount(int id)
        {
            AdminBUS adminBUS = new AdminBUS();
            adminBUS.DeleteAccountById(id);
            LoadData();
        }

        private void btn_ThemTK_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.ShowDialog();
            LoadData();
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            var row = dgv_TaiKhoan.SelectedRows[0];
            var cell = row.Cells["Id"];
            int idSelected = Convert.ToInt32(cell.Value);
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?",
                                     "Xác nhận xóa!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteAccount(idSelected);
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
               
            }
        }

        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else if (txt_MatKhau.Text.Length < 6 || txt_MatKhau.Text.Length > 20)
            {
                MessageBox.Show("Mật khẩu chứa ít nhất 6 ký tự và nhiều nhất 20 ký tự");
            }
            else 
            { 
                var row = dgv_TaiKhoan.SelectedRows[0];
                var cell = row.Cells["Id"];
                int idSelected = Convert.ToInt32(cell.Value);
                string image = pb_AvatarTK.ToString();
                UpdateAccount(idSelected, txt_TenNV.Text, txt_TenTK.Text, txt_MatKhau.Text, txt_DiaChi.Text, txt_SDT.Text, image);
            }
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_TaiKhoan.Rows[e.RowIndex];
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txt_TenNV.Text = row.Cells["HoTen"].Value.ToString();
            txt_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
        }

        private void pb_AvatarTK_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName;

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

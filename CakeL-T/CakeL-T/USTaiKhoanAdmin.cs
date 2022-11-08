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
        AdminBUS adminBUS = new AdminBUS();
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
            txtTimSDT.Text = "";
            txt_TimTK.Text = "Tìm kiếm tài khoản...";
            dgv_TaiKhoan.DataSource = adminBUS.GetAccounts();
            dgv_TaiKhoan.Columns["Id"].Visible = false;
            dgv_TaiKhoan.Columns["HinhAnh"].Visible = false;
            dgv_TaiKhoan.Columns["TrangThaiXoa"].Visible = false;
            dgv_TaiKhoan.Columns["MatKhau"].Visible = false;
            DataGridViewRow row = this.dgv_TaiKhoan.Rows[0];
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txt_TenNV.Text = row.Cells["HoTen"].Value.ToString();
            txtTimTenTK.Text = row.Cells["SoDienThoai"].Value.ToString();
            txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
            if (Convert.ToBoolean(row.Cells["LoaiTK"].Value) == true)
            {
                btn_XoaTK.Enabled = false;
                txt_MatKhau.Enabled = false;
                panel1.Enabled = false;   
            }
            if (Convert.ToBoolean(row.Cells["TrangThai"].Value) == true)
            {
                radioActive.Checked = true;
                radioUnactive.Checked = false;
            }
            else
                radioUnactive.Checked = true;
                radioActive.Checked = false;

        }

        private void Clear()
        {
            txt_DiaChi.Text = "";
            txtTimTenTK.Text = "";
            txt_TenNV.Text = "";
            radioTimActive.Checked = true;
        }

        private void GetAccountById(int id)
        {
            var accountById = adminBUS.GetAccountById(id);
            if (accountById == null)
            {
                MessageBox.Show("Có gì đó không ổn");
            }
        }

        private void UpdateAccount(int id, string fullname, string username, string password, string address, string phone, string image, bool status)
        {
            adminBUS.UpdateAccountById(id, fullname, username, password, address, phone, image, status);
            LoadData();
        }

        private void DeleteAccount(int id)
        {
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
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {txt_TenTK.Text}?",
                                     "Xác nhận xóa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteAccount(idSelected);
                MessageBox.Show($"Tài khoản {txt_TenTK.Text} đã được xóa","Xóa tài khoản");
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
                bool status;
                if (radioTimActive.Checked)
                {
                    var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa tài khoản {txt_TenTK.Text}?",
                                   "Xác nhận sửa",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        status = true;
                        UpdateAccount(idSelected, txt_TenNV.Text, txt_TenTK.Text, txt_MatKhau.Text, txt_DiaChi.Text, txtTimTenTK.Text, image, status);
                        MessageBox.Show($"Tài khoản {txt_TenTK.Text} đã được sửa", "Sửa tài khoản");
                    }
                    
                }
                else if( radioTimUnactive.Checked)
                {
                    var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa tài khoản {txt_TenTK.Text}?",
                                   "Xác nhận sửa",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        status = false;
                        UpdateAccount(idSelected, txt_TenNV.Text, txt_TenTK.Text, txt_MatKhau.Text, txt_DiaChi.Text, txtTimTenTK.Text, image, status);
                        MessageBox.Show($"Tài khoản {txt_TenTK.Text} đã được sửa", "Sửa tài khoản");
                    }
                }
                MessageBox.Show($"Sửa tài khoản {txt_TenTK.Text} thành công!", "Sửa tài khoản");
            }
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.dgv_TaiKhoan.Rows[e.RowIndex];
            if (Convert.ToBoolean(row.Cells["LoaiTK"].Value) == true)
            {
                btn_XoaTK.Enabled = false;
                txt_MatKhau.Enabled = false;
                panel1.Enabled = false;
            }
            else
            {
                btn_XoaTK.Enabled = true;
                txt_MatKhau.Enabled = true;
                panel1.Enabled = true;
            }
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txt_TenNV.Text = row.Cells["HoTen"].Value.ToString();
            txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
            txt_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            if (Convert.ToBoolean(row.Cells["TrangThai"].Value) == true)
            {
                radioActive.Checked = true;
            }
            else 
            radioUnactive.Checked =  true;
           
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

        private void txt_TimTK_TextChanged(object sender, EventArgs e)
        {
            dgv_TaiKhoan.DataSource = adminBUS.SearchAccount(txt_TimTK.Text);
        }

        private void btnEyes_MouseDown(object sender, MouseEventArgs e)
        {
            txt_MatKhau.PasswordChar = (char)0;
        }

        private void btnEyes_MouseUp(object sender, MouseEventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
        }

        private void dgv_TaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void txt_TimTK_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_TimTK.Text == "Tìm kiếm tài khoản...")
                txt_TimTK.Text = "";
        }

        private void btn_TimTK_Click(object sender, EventArgs e)
        {
            bool status;
            if(radioTimActive.Checked == true)
            {
                status = true;
                dgv_TaiKhoan.DataSource = adminBUS.SearchAccountMulti(txtTimTenTK.Text,txtTimSDT.Text, status);
            }
            else 
            {
                status = false;
                dgv_TaiKhoan.DataSource = adminBUS.SearchAccountMulti(txtTimTenTK.Text, txtTimSDT.Text, status);
            }
        }

        private void btnEyes_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

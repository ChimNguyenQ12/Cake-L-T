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
    public partial class FormHomeAdmin : Form
    {
        public FormHomeAdmin()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            AdminBUS adminBUS = new AdminBUS();
            dgv_TaiKhoan.DataSource = adminBUS.GetAccounts();
        }

        private void Clear()
        {
            txtDiaChi.Text = "";
            txtMK.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            txtTrangThai.Text = "";
            txtTenTK.Text = "";
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

        private void UpdateAccount(int id, string fullname, string username, string password, string address, string phone)
        {
            AdminBUS adminBUS = new AdminBUS();
            adminBUS.UpdateAccountById(id, fullname, username, password, address, phone);
            LoadData();
        }

        private void DeleteAccount(int id)
        {
            AdminBUS adminBUS = new AdminBUS();
            adminBUS.DeleteAccountById(id);
            LoadData();
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            panel_DoanhThu.Visible = true;
            panel_TaiKhoan.Visible = false;
            panel_HoaDon.Visible = false;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            panel_HoaDon.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_TaiKhoan.Visible = false;

        }

        private void btn_ThucDon_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            panel_TaiKhoan.Visible = true;
            panel_DoanhThu.Visible = true;
            panel_HoaDon.Visible = true;
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            FormRegister frm =new FormRegister();
            frm.ShowDialog();
        }

        private void panel_TaiKhoan_Paint(object sender, PaintEventArgs e)
        {

        }
        private void FormHomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cake L&T", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_TaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgv_TaiKhoan.Rows[e.RowIndex];
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            txtMK.Text = row.Cells["MatKhau"].Value.ToString();
            txtTenNV.Text = row.Cells["HoTen"].Value.ToString();
            txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtTenTK.Text = row.Cells["TenTK"].Value.ToString();
        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            var row = dgv_TaiKhoan.SelectedRows[0];
            var cell = row.Cells["Id"];
            int idSelected = Convert.ToInt32(cell.Value);
            UpdateAccount(idSelected,  txtTenNV.Text, txtTenTK.Text, txtMK.Text, txtDiaChi.Text, txtSDT.Text);
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            var row = dgv_TaiKhoan.SelectedRows[0];
            var cell = row.Cells["Id"];
            int idSelected = Convert.ToInt32(cell.Value);
            DeleteAccount(idSelected);
        }
    }
}

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
        string fileName;
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
            txt_DiaChi.Text = "";
            txt_MatKhau.Text = "";
            txt_SDT.Text = "";
            txt_TenNV.Text = "";
            txt_TrangThai.Text = "";
            txt_TenTK.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btn_DoanhThu_Click(object sender, EventArgs e)
        {
            FormDoanhThuVaReprot formDoanhThuVaReprot = new FormDoanhThuVaReprot();
            formDoanhThuVaReprot.ShowDialog();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            //panel_HoaDon.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_TaiKhoan.Visible = false;
            //panel_TrangChu.Visible = false;
            //panel_Banh.Visible = false;
            if (!panel_chinh.Controls.Contains(USHoaDonAdmin.Instance))
            {
                panel_chinh.Controls.Add(USHoaDonAdmin.Instance);
                USHoaDonAdmin.Instance.Dock = DockStyle.Fill;
                USHoaDonAdmin.Instance.BringToFront();
            }
            else
                USBanhAdmin.Instance.BringToFront();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = false;
            //panel_Banh.Visible = false;
            if (!panel_chinh.Controls.Contains(USTaiKhoanAdmin.Instance))
            {
                panel_chinh.Controls.Add(USTaiKhoanAdmin.Instance);
                USTaiKhoanAdmin.Instance.Dock = DockStyle.Fill;
                USTaiKhoanAdmin.Instance.BringToFront();
            }
            else
                USTaiKhoanAdmin.Instance.BringToFront();
        }

        private void btThemTK_Click(object sender, EventArgs e)
        {
            FormRegister frm =new FormRegister();
            frm.ShowDialog();
            LoadData();
        }

        private void FormHomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cake L&T", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = true;
            //panel_Banh.Visible = false;
            if (!panel_chinh.Controls.Contains(USTrangChu.Instance))
            {
                panel_chinh.Controls.Add(USTrangChu.Instance);
                USTrangChu.Instance.Dock = DockStyle.Fill;
                USTrangChu.Instance.BringToFront();
            }
            else
                USTrangChu.Instance.BringToFront();
        }

        private void btn_Banh_Click(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = true;
            //panel_Banh.Visible = true;
            if (!panel_chinh.Controls.Contains(USBanhAdmin.Instance))
            {
                panel_chinh.Controls.Add(USBanhAdmin.Instance);
                USBanhAdmin.Instance.Dock = DockStyle.Fill;
                USBanhAdmin.Instance.BringToFront();
            }
            else
                USBanhAdmin.Instance.BringToFront();
        }

        private void FormHomeAdmin_Load(object sender, EventArgs e)
        {
            //panel_TaiKhoan.Visible = true;
            //panel_DoanhThu.Visible = true;
            //panel_HoaDon.Visible = true;
            //panel_TrangChu.Visible = true;
            //panel_Banh.Visible = true;
            if (!panel_chinh.Controls.Contains(USTrangChu.Instance))
            {
                panel_chinh.Controls.Add(USTrangChu.Instance);
                USTrangChu.Instance.Dock = DockStyle.Fill;
                USTrangChu.Instance.BringToFront();
            }
            else
                USBanhAdmin.Instance.BringToFront();
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {
            FormCaiDat formCaiDat = new FormCaiDat();
            formCaiDat.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            var row = dgv_TaiKhoan.SelectedRows[0];
            var cell = row.Cells["Id"];
            int idSelected = Convert.ToInt32(cell.Value);
            DeleteAccount(idSelected);
            MessageBox.Show("Xóa tài khoản thành công");
        }

        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            var row = dgv_TaiKhoan.SelectedRows[0];
            var cell = row.Cells["Id"];
            int idSelected = Convert.ToInt32(cell.Value);
            UpdateAccount(idSelected, txt_TenNV.Text, txt_TenTK.Text, txt_MatKhau.Text, txt_DiaChi.Text, txt_SDT.Text, pb_AvatarTK.ToString());
        }

        private void dgv_TaiKhoan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
    }
}

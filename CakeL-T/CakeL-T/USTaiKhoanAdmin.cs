using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            for (int i = 0; i < dgv_TaiKhoan.Rows.Count; i++)
            {
                if (dgv_TaiKhoan.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                {
                    dgv_TaiKhoan.Rows[i].Cells["TenTrangThai"].Value = "Hoạt động";
                }
                else
                {
                    dgv_TaiKhoan.Rows[i].Cells["TenTrangThai"].Value = "Khóa";
                }
            }
            dgv_TaiKhoan.Columns["Id"].Visible = false;
            dgv_TaiKhoan.Columns["HinhAnh"].Visible = false;
            dgv_TaiKhoan.Columns["TrangThaiXoa"].Visible = false;
            dgv_TaiKhoan.Columns["TrangThai"].Visible = false;
            dgv_TaiKhoan.Columns["MatKhau"].Visible = false;
            dgv_TaiKhoan.Columns["LoaiTK"].Visible = false;
            dgv_TaiKhoan.Columns["HoaDons"].Visible = false;

            DataGridViewRow row = this.dgv_TaiKhoan.Rows[0];
            txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
            txt_TenNV.Text = row.Cells["HoTen"].Value.ToString();
            txt_TenTK.Text = row.Cells["TenTK"].Value.ToString();
            txt_SDT.Text = row.Cells["SoDienThoai"].Value.ToString();
            txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
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
            {
                radioUnactive.Checked = true;
                radioActive.Checked = false;
            }
            if (row.Cells["HinhAnh"].Value != null)
            {
                MemoryStream m = new MemoryStream((byte[])row.Cells["HinhAnh"].Value);
                pb_AvatarTK.Image = Image.FromStream(m);
            }
            else
            {
                pb_AvatarTK.Image = Image.FromFile(@"..\..\Image\no_img.png");
            }

            // Auto complete
            var a = adminBUS.GetAccounts();
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (var item in a)
            {
                ac.Add(item.TenTK);
            }
            txt_TimTK.AutoCompleteCustomSource = ac;
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

        private void UpdateAccount(int id, string fullname, string username, string password, string address, string phone, byte[] image, bool status)
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
                var row = dgv_TaiKhoan.SelectedRows[0];
                var cell = row.Cells["Id"];
                int idSelected = Convert.ToInt32(cell.Value);
                MemoryStream m = new MemoryStream();
                pb_AvatarTK.Image.Save(m, ImageFormat.Jpeg);
                var image = m.ToArray();
                bool status;
                string pattern = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                Match match = regex.Match(txt_SDT.Text);
                var accounts = adminBUS.GetAccounts();
                if(txt_SDT.Text == "" || txt_DiaChi.Text == "" || txt_TenNV.Text == "")
                 {
                MessageBox.Show("Vui lòng điền đủ thông tin");
                  }
                else if (!match.Success)
                {
                    MessageBox.Show("Số điện thoại không phù hợp");
                    return;
                }
                else if (radioActive.Checked)
                {
                    var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa tài khoản {txt_TenTK.Text}?",
                                   "Xác nhận sửa",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                    status = true;
                        MessageBox.Show($"Tài khoản {txt_TenTK.Text} đã được sửa", "Sửa tài khoản");
                        UpdateAccount(idSelected, txt_TenNV.Text, txt_TenTK.Text, txt_MatKhau.Text, txt_DiaChi.Text, txt_SDT.Text, image, status);
                    }
                    
                }
                else if( radioUnactive.Checked)
                {
                    var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn sửa tài khoản {txt_TenTK.Text}?",
                                   "Xác nhận sửa",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmResult == DialogResult.Yes)
                    {
                        status = false;
                        MessageBox.Show($"Tài khoản {txt_TenTK.Text} đã được sửa", "Sửa tài khoản");
                        UpdateAccount(idSelected, txt_TenNV.Text, txt_TenTK.Text, txt_MatKhau.Text, txt_DiaChi.Text, txt_SDT.Text, image, status);
                    }
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
            {
            radioUnactive.Checked =  true;
            }
            if (row.Cells["HinhAnh"].Value != null)
            {
                MemoryStream m = new MemoryStream((byte[])row.Cells["HinhAnh"].Value);
                pb_AvatarTK.Image = Image.FromStream(m);
            }
            else
            {
                pb_AvatarTK.Image = Image.FromFile(@"..\..\Image\no_img.png");
            }

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
            for (int i = 0; i < dgv_TaiKhoan.Rows.Count; i++)
            {
                if (dgv_TaiKhoan.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                {
                    dgv_TaiKhoan.Rows[i].Cells["TenTrangThai"].Value = "Hoạt động";
                }
                else
                {
                    dgv_TaiKhoan.Rows[i].Cells["TenTrangThai"].Value = "Khóa";
                }
            }
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            var row = dgv_TaiKhoan.SelectedRows[0];
            var cell = row.Cells["Id"];
            int idSelected = Convert.ToInt32(cell.Value);
            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn reset mật khẩu của tài khoản {txt_TenTK.Text}?",
                                   "Xác nhận Reset",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                adminBUS.ResetPass(idSelected);
                MessageBox.Show($"Mật khẩu của tài khoản {txt_TenTK.Text} đã được reset thành 1", "Reset mật khẩu");
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (txt_SDT.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void USTaiKhoanAdmin_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
        }

        private void btn_ReportTK_Click(object sender, EventArgs e)
        {
            if( reportViewer1.Visible == true)
            {
                reportViewer1.Visible = false;
            }
            else
            {
                reportViewer1.Visible = true;
            }
            var listAccounts = adminBUS.GetAccounts().ToList();
            reportViewer1.LocalReport.ReportPath = "ReportTaiKhoan.rdlc";
            var source = new ReportDataSource("DataSetTaiKhoan", listAccounts);
            reportViewer1.LocalReport.DataSources.Clear();
            //Add param
            ReportParameter[] parameter = new ReportParameter[2];
            parameter[0] = new ReportParameter("rpName", txt_TenNV.Text);
            parameter[1] = new ReportParameter("rpDate", DateTime.Now.ToString());
            this.reportViewer1.LocalReport.SetParameters(parameter);

            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string Filepath = openFileDialog1.FileName;
                pb_AvatarTK.Image = Image.FromFile(Filepath);
            }catch(Exception ex)
            {

            }
        }
    }
}

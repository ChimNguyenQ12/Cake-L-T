using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Security.Cryptography;
namespace CakeL_T
{
    public partial class FormLogin : Form
    {
        int idtk = 0;
        public FormLogin()
        {
            InitializeComponent();
        }

        private string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            LoginBUS loginBUS = new LoginBUS();
            string userName = txt_TenDangNhap.Text;
            string passWord = Encrypt(txt_MatKhau.Text);

            var account = loginBUS.GetAccountByUsername(userName);

            foreach (var item in account)
            {
                idtk = item.Id;
            }

            if(passWord == "" || userName == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                if (loginBUS.checkLogin(userName, passWord) == "error")
                {
                    MessageBox.Show("Có gì đó không ổn :/");
                }
                else if (loginBUS.checkLogin(userName, passWord) == "lock")
                {
                    MessageBox.Show("Tài khoản bị khóa, vui lòng liên hệ quản trị viên!");
                }
                else if (loginBUS.checkLogin(userName, passWord) == "admin")
                {
                    FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
                    formHomeAdmin.Show();
                }
                else if (loginBUS.checkLogin(userName, passWord) == "staff")
                {
                    FormHomeStaff formHomeStaff = new FormHomeStaff(userName,idtk);
                    formHomeStaff.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                }
            }
        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = txt_TenDangNhap.Text.Replace(" ", "");
        }

        private void txt_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void btn_eyes_MouseDown(object sender, MouseEventArgs e)
        {
            txt_MatKhau.PasswordChar = (char)0;
        }

        private void btn_eyes_MouseUp(object sender, MouseEventArgs e)
        {
            txt_MatKhau.PasswordChar = '*';
        }
    }
}

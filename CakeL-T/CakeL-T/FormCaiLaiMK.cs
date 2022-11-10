using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace CakeL_T
{
    public partial class FormCaiLaiMK : Form
    {
        public int idTk;
        public FormCaiLaiMK()
        {
            InitializeComponent();
        }

        public FormCaiLaiMK(int idTK) : this()
        {
            idTk = idTK;
        }
        private void btn_eyes_MouseDown(object sender, MouseEventArgs e)
        {
            txt_mk_ht.PasswordChar = (char)0;
        }
        private void btn_eyes_MouseUp(object sender, MouseEventArgs e)
        {
            txt_mk_ht.PasswordChar = '*';
        }

        private void guna2Button3_MouseDown(object sender, MouseEventArgs e)
        {
            txt_MKMoi.PasswordChar = (char)0;
        }
        private void guna2Button3_MouseUp(object sender, MouseEventArgs e)
        {
            txt_MKMoi.PasswordChar = '*';
        }

        private void guna2Button2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_NhaplaiMK.PasswordChar = (char)0;
        }
        private void guna2Button2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_NhaplaiMK.PasswordChar = '*';
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string currentPass = Encrypt(txt_mk_ht.Text);
            string newPass = Encrypt(txt_MKMoi.Text);
            string repeatPass =  Encrypt(txt_NhaplaiMK.Text);

            if(newPass != repeatPass)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!!");
            }
            else
            {
                LoginBUS loginBUS = new LoginBUS();
                loginBUS.ChangePassword(idTk,currentPass, newPass, repeatPass);
                MessageBox.Show("Đổi mật khẩu thành công!!");
                this.Hide();
            }
        }
    }
}

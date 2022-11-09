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

namespace CakeL_T
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = txt_TenDangNhap.Text;
            string passWord = txt_MatKhau.Text;
            int idtk = 0;

            if(passWord == "" || userName == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                LoginBUS loginBUS = new LoginBUS();
                if (loginBUS.checkLogin(userName, passWord) == "error")
                {
                    MessageBox.Show("Có gì đó không ổn :/");
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
    }
}

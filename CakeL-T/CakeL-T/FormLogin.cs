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
    public partial class FormLogin : Form
    {
        CakeEntities cakeEntities = new CakeEntities(); 
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string userName = txt_TenDangNhap.Text;
            string passWord = txt_MatKhau.Text;

            if(passWord == "" || userName == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                int countStaff = cakeEntities.TaiKhoans.Count(acc => acc.TenTK == userName && acc.MatKhau == passWord && acc.LoaiTK == false && acc.TrangThai == true);
                int countAdmin = cakeEntities.TaiKhoans.Count(acc => acc.TenTK == userName && acc.MatKhau == passWord && acc.LoaiTK == true && acc.TrangThai == true);
                if (countStaff == 1)
                {
                    FormHomeStaff formHomeStaff = new FormHomeStaff();
                    formHomeStaff.Show();
                }
                else if(countAdmin == 1)
                {
                    FormHomeAdmin formHomeAdmin = new FormHomeAdmin();
                    formHomeAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!");
                }
            }
        }
    }
}

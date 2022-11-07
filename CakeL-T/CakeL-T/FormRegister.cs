using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace CakeL_T
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string username = txt_TenDangNhap.Text;
            string password = txt_MatKhau.Text;
            string repeatPW = txt_NhapLaiMatKhau.Text;
            string address = txt_DiaChi.Text;
            string fullname = txt_HoTen.Text;
            string phone = txt_SDT.Text;
            string pattern = @"^([\+]?33[-]?|[0])?[1-9][0-9]{8}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Match match = regex.Match(phone);
            
            if (password == "" || username == "" || repeatPW == "" || address == "" || fullname == "" || phone == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else if (txt_TenDangNhap.Text.Length < 4  || txt_TenDangNhap.Text.Length > 16)
            {
                MessageBox.Show("Tên đăng nhập chứa ít nhất 4 ký tự và nhiều nhất 16 ký tự");
            }
            else if (txt_MatKhau.Text.Length < 6 || txt_MatKhau.Text.Length > 20)
            {
                MessageBox.Show("Mật khẩu chứa ít nhất 6 ký tự và nhiều nhất 20 ký tự");
            }
            else if (!match.Success)
            {
                MessageBox.Show("Số điện thoại không phù hợp");
            }
            else if (password != repeatPW)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
            }
            else
            {
                RegisterBUS registerBUS = new RegisterBUS();
                if (registerBUS.Register(username, password, address, fullname, phone) == "success")
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.Hide();
                    var formLogin = new FormLogin();
                    formLogin.Closed += (s, args) => this.Close();
                    formLogin.Show();
                }
                else if (registerBUS.Register(username, password, address, fullname, phone) == "error")
                {
                    MessageBox.Show("Có gì đó không ổn :/");
                }
                else if (registerBUS.Register(username, password, address, fullname, phone) == "Username already exists")
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
                else if (registerBUS.Register(username, password, address, fullname, phone) == "Phone number already exists")
                {
                    MessageBox.Show("Số điện thoại tồn tại!");
                }
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

        private void txt_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            //if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            //{
            //    e.Handled = true;
            //}
            //if (Control.IsKeyLocked(Keys.CapsLock))
            //{
            //    MessageBox.Show("The Caps Lock key is ON.");
            //}
        }

        private void txt_NhapLaiMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            //if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = txt_TenDangNhap.Text.Replace(" ", "");
        }
    }
}

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

namespace CakeL_T
{
    public partial class FormRegister : Form
    {
        CakeEntities cakeEntities = new CakeEntities();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string userName = txt_TenDangNhap.Text;
            string passWord = txt_MatKhau.Text;
            string repeatPW = txt_NhapLaiMatKhau.Text;
            string address  = txt_DiaChi.Text;
            string fullname = txt_HoTen.Text;
            string phone    = txt_SDT.Text;

            if (passWord == "" || userName == "" || repeatPW == "" || address == "" || fullname == "" || phone == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else if (passWord != repeatPW)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
            }
            else if (cakeEntities.TaiKhoans.Any(x => x.TenTK == userName))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
            }
            else if (cakeEntities.TaiKhoans.Any(x => x.SoDienThoai == phone))
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
            }
            else
            {
                try
                {
                    cakeEntities.TaiKhoans.Add(new TaiKhoan()
                    {
                        TenTK = userName,
                        MatKhau = passWord,
                        DiaChi = address,
                        HoTen = fullname,
                        SoDienThoai = phone,
                        TrangThai = true,
                        LoaiTK = false
                    });
                    cakeEntities.SaveChanges();
                    MessageBox.Show("Tạo tài khoản thành công");
                    this.Hide();
                    var formLogin = new FormLogin();
                    formLogin.Closed += (s, args) => this.Close();
                    formLogin.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Có gì đó không đúng :(");
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
                    if (txt_SDT.Text.Length > 10)
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
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
            //if (Control.IsKeyLocked(Keys.CapsLock))
            //{
            //    MessageBox.Show("The Caps Lock key is ON.");
            //}
        }

        private void txt_NhapLaiMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (System.Text.Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class USTaiKhoanStaff : UserControl
    {
        public static int idTk;

        private static USTaiKhoanStaff instance;
        public static USTaiKhoanStaff Instance
        {
            get
            {
                if (instance == null)
                    instance = new USTaiKhoanStaff();
                return instance;
            }
        }

        public static int ID
        {
            set { idTk = value; }
        }
        public USTaiKhoanStaff()
        {
            InitializeComponent();
        }

        private void btn_CaiLaiMK_Click(object sender, EventArgs e)
        {
            int id =idTk;
            FormCaiLaiMK formCaiLaiMK = new FormCaiLaiMK(id);
            formCaiLaiMK.ShowDialog();
        }

        private void USTaiKhoanStaff_Load(object sender, EventArgs e)
        {
            AdminBUS tk = new AdminBUS();
            var item = tk.GetAccountById(idTk);
            txt_TenNV.Text = item[0].HoTen;
            txt_DiaChi.Text = item[0].DiaChi;
            txt_MaNV.Text = idTk.ToString();
            txt_SDT.Text = item[0].SoDienThoai;
            txt_tenTK.Text = item[0].TenTK;
        }
    }
}

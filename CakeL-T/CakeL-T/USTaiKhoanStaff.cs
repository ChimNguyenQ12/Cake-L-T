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
        public USTaiKhoanStaff()
        {
            InitializeComponent();
        }

        private void btn_CaiLaiMK_Click(object sender, EventArgs e)
        {
            FormCaiLaiMK formCaiLaiMK = new FormCaiLaiMK();
            formCaiLaiMK.ShowDialog();
        }
    }
}

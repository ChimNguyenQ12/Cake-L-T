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
    public partial class USTrangChuStaff : UserControl
    {
        private static USTrangChu instance;
        public static USTrangChu Instance
        {
            get
            {
                if (instance == null)
                    instance = new USTrangChu();
                return instance;
            }
        }
        public USTrangChuStaff()
        {
            InitializeComponent();
        }
    }
}

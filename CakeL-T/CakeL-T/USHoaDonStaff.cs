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
    public partial class USHoaDonStaff : UserControl
    {
        private static USHoaDonStaff instance;
        public static USHoaDonStaff Instance
        {
            get
            {
                if (instance == null)
                    instance = new USHoaDonStaff();
                return instance;
            }
        }
        public USHoaDonStaff()
        {
            InitializeComponent();
        }
    }
}

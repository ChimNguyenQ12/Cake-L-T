﻿using System;
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
    public partial class USLoaiBanh : UserControl
    {
        private static USLoaiBanh instance;
        public static USLoaiBanh Instance
        {
            get
            {
                if (instance == null)
                    instance = new USLoaiBanh();
                return instance;
            }
        }
        public USLoaiBanh()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}

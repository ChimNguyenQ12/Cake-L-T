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
    public partial class FormDoanhThuVaReprot : Form
    {
        public FormDoanhThuVaReprot()
        {
            InitializeComponent();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoanhThu formDoanhThu = new FormDoanhThu();
            formDoanhThu.MdiParent = this;
            formDoanhThu.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.MdiParent = this;
            formReport.Show();
        }
    }
}

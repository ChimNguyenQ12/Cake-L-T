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
    public partial class FormHomeStaff : Form
    {
        private string _tentk;
        private int _idTK;
        public FormHomeStaff()
        {
            InitializeComponent();
        }
        public FormHomeStaff(string tentk, int idTK) : this()
        {
            _tentk = tentk;
            _idTK = idTK;

        }
        public string ID
        {
            get { return _idTK.ToString(); }
        }

        private void btn_CaiLaiMK_Click(object sender, EventArgs e)
        {
            FormCaiLaiMK formCaiLaiMK = new FormCaiLaiMK();
            formCaiLaiMK.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormCaiDat formCaiDat = new FormCaiDat();
            formCaiDat.ShowDialog();
        }

        private void FormHomeStaff_Load(object sender, EventArgs e)
        {
            USHoaDonStaff.ID = ID;
            USTaiKhoanStaff.ID = ID;
            lb_TenNV.Text = _tentk;
            if (!panel_chinh.Controls.Contains(USTrangChuStaff.Instance))
            {
                panel_chinh.Controls.Add(USTrangChuStaff.Instance);
                USTrangChuStaff.Instance.Dock = DockStyle.Fill;
                USTrangChuStaff.Instance.BringToFront();
            }
            else
                USTrangChu.Instance.BringToFront();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            if (!panel_chinh.Controls.Contains(USHoaDonStaff.Instance))
            {
                panel_chinh.Controls.Add(USHoaDonStaff.Instance);
                USHoaDonStaff.Instance.Dock = DockStyle.Fill;
                USHoaDonStaff.Instance.BringToFront();
            }
            else
                USHoaDonStaff.Instance.BringToFront();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            if (!panel_chinh.Controls.Contains(USTaiKhoanStaff.Instance))
            {
                panel_chinh.Controls.Add(USTaiKhoanStaff.Instance);
                USTaiKhoanStaff.Instance.Dock = DockStyle.Fill;
                USTaiKhoanStaff.Instance.BringToFront();
            }
            else
                USTaiKhoanStaff.Instance.BringToFront();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            if (!panel_chinh.Controls.Contains(USTrangChu.Instance))
            {
                panel_chinh.Controls.Add(USTrangChuStaff.Instance);
                USTrangChuStaff.Instance.Dock = DockStyle.Fill;
                USTrangChuStaff.Instance.BringToFront();
            }
            else
                USTrangChuStaff.Instance.BringToFront();
        }
    }
}

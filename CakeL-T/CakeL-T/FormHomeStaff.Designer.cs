namespace CakeL_T
{
    partial class FormHomeStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeStaff));
            this.panel_Trai = new System.Windows.Forms.Panel();
            this.grb_Menu = new System.Windows.Forms.GroupBox();
            this.btn_ThucDon = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.btn_HoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_TaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.panel_Trai.SuspendLayout();
            this.grb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Trai
            // 
            this.panel_Trai.BackColor = System.Drawing.Color.LightCoral;
            this.panel_Trai.Controls.Add(this.grb_Menu);
            this.panel_Trai.Controls.Add(this.label1);
            this.panel_Trai.Controls.Add(this.pictureBox1);
            this.panel_Trai.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Trai.Location = new System.Drawing.Point(0, 0);
            this.panel_Trai.Name = "panel_Trai";
            this.panel_Trai.Size = new System.Drawing.Size(287, 843);
            this.panel_Trai.TabIndex = 1;
            // 
            // grb_Menu
            // 
            this.grb_Menu.Controls.Add(this.btn_TaiKhoan);
            this.grb_Menu.Controls.Add(this.btn_ThucDon);
            this.grb_Menu.Controls.Add(this.btn_TrangChu);
            this.grb_Menu.Controls.Add(this.btn_HoaDon);
            this.grb_Menu.Controls.Add(this.guna2Button1);
            this.grb_Menu.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Menu.ForeColor = System.Drawing.Color.Black;
            this.grb_Menu.Location = new System.Drawing.Point(12, 171);
            this.grb_Menu.Name = "grb_Menu";
            this.grb_Menu.Size = new System.Drawing.Size(254, 649);
            this.grb_Menu.TabIndex = 2;
            this.grb_Menu.TabStop = false;
            this.grb_Menu.Text = "Quản Lý";
            // 
            // btn_ThucDon
            // 
            this.btn_ThucDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThucDon.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ThucDon.BorderRadius = 24;
            this.btn_ThucDon.BorderThickness = 1;
            this.btn_ThucDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_ThucDon.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_ThucDon.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_ThucDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThucDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThucDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThucDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThucDon.FillColor = System.Drawing.Color.LightCoral;
            this.btn_ThucDon.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThucDon.ForeColor = System.Drawing.Color.Black;
            this.btn_ThucDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThucDon.Image")));
            this.btn_ThucDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ThucDon.Location = new System.Drawing.Point(31, 133);
            this.btn_ThucDon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThucDon.Name = "btn_ThucDon";
            this.btn_ThucDon.Size = new System.Drawing.Size(194, 51);
            this.btn_ThucDon.TabIndex = 16;
            this.btn_ThucDon.Text = "Thực đơn";
            this.btn_ThucDon.UseTransparentBackground = true;
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btn_TrangChu.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btn_TrangChu.BorderRadius = 24;
            this.btn_TrangChu.BorderThickness = 1;
            this.btn_TrangChu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_TrangChu.Checked = true;
            this.btn_TrangChu.CheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.btn_TrangChu.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btn_TrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TrangChu.FillColor = System.Drawing.Color.LightCoral;
            this.btn_TrangChu.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TrangChu.ForeColor = System.Drawing.Color.Black;
            this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
            this.btn_TrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TrangChu.Location = new System.Drawing.Point(31, 56);
            this.btn_TrangChu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(194, 51);
            this.btn_TrangChu.TabIndex = 15;
            this.btn_TrangChu.Text = "Trang chủ";
            this.btn_TrangChu.UseTransparentBackground = true;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.BackColor = System.Drawing.Color.Transparent;
            this.btn_HoaDon.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btn_HoaDon.BorderRadius = 24;
            this.btn_HoaDon.BorderThickness = 1;
            this.btn_HoaDon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_HoaDon.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_HoaDon.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_HoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HoaDon.FillColor = System.Drawing.Color.LightCoral;
            this.btn_HoaDon.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.Black;
            this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
            this.btn_HoaDon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_HoaDon.Location = new System.Drawing.Point(31, 210);
            this.btn_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(194, 51);
            this.btn_HoaDon.TabIndex = 14;
            this.btn_HoaDon.Text = "Hóa đơn";
            this.btn_HoaDon.UseTransparentBackground = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Button1.BorderRadius = 24;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightCoral;
            this.guna2Button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(31, 560);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(194, 51);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Cài đặt";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_TaiKhoan
            // 
            this.btn_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btn_TaiKhoan.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btn_TaiKhoan.BorderRadius = 24;
            this.btn_TaiKhoan.BorderThickness = 1;
            this.btn_TaiKhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_TaiKhoan.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_TaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TaiKhoan.FillColor = System.Drawing.Color.LightCoral;
            this.btn_TaiKhoan.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btn_TaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoan.Image")));
            this.btn_TaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_TaiKhoan.Location = new System.Drawing.Point(31, 485);
            this.btn_TaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TaiKhoan.Name = "btn_TaiKhoan";
            this.btn_TaiKhoan.Size = new System.Drawing.Size(194, 51);
            this.btn_TaiKhoan.TabIndex = 17;
            this.btn_TaiKhoan.Text = "Tài khoản";
            this.btn_TaiKhoan.UseTransparentBackground = true;
            // 
            // FormHomeStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 843);
            this.Controls.Add(this.panel_Trai);
            this.Name = "FormHomeStaff";
            this.Text = "FormHome";
            this.panel_Trai.ResumeLayout(false);
            this.panel_Trai.PerformLayout();
            this.grb_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Trai;
        private System.Windows.Forms.GroupBox grb_Menu;
        private Guna.UI2.WinForms.Guna2Button btn_ThucDon;
        private Guna.UI2.WinForms.Guna2Button btn_TrangChu;
        private Guna.UI2.WinForms.Guna2Button btn_HoaDon;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_TaiKhoan;
    }
}
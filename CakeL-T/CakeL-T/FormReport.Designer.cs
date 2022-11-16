namespace CakeL_T
{
    partial class FormReport
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
            this.reportViewerNhanVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rdbNV = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbSP = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbLoaiSP = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cbbNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbLoaiSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_HD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reportViewerNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerSanPham = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerNhanVien
            // 
            this.reportViewerNhanVien.Location = new System.Drawing.Point(2, 302);
            this.reportViewerNhanVien.Name = "reportViewerNhanVien";
            this.reportViewerNhanVien.ServerReport.BearerToken = null;
            this.reportViewerNhanVien.Size = new System.Drawing.Size(960, 454);
            this.reportViewerNhanVien.TabIndex = 0;
            // 
            // rdbNV
            // 
            this.rdbNV.AutoSize = true;
            this.rdbNV.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rdbNV.CheckedState.BorderThickness = 0;
            this.rdbNV.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rdbNV.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNV.CheckedState.InnerOffset = -4;
            this.rdbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdbNV.Location = new System.Drawing.Point(140, 205);
            this.rdbNV.Name = "rdbNV";
            this.rdbNV.Size = new System.Drawing.Size(106, 24);
            this.rdbNV.TabIndex = 1;
            this.rdbNV.Text = "Nhân viên";
            this.rdbNV.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdbNV.UncheckedState.BorderThickness = 2;
            this.rdbNV.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNV.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Báo cáo hóa đơn theo danh mục CakeL-T";
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rdbNgay.CheckedState.BorderThickness = 0;
            this.rdbNgay.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rdbNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNgay.CheckedState.InnerOffset = -4;
            this.rdbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdbNgay.Location = new System.Drawing.Point(140, 144);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(67, 24);
            this.rdbNgay.TabIndex = 1;
            this.rdbNgay.Text = "Ngày";
            this.rdbNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdbNgay.UncheckedState.BorderThickness = 2;
            this.rdbNgay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNgay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbSP
            // 
            this.rdbSP.AutoSize = true;
            this.rdbSP.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rdbSP.CheckedState.BorderThickness = 0;
            this.rdbSP.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rdbSP.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbSP.CheckedState.InnerOffset = -4;
            this.rdbSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdbSP.Location = new System.Drawing.Point(548, 144);
            this.rdbSP.Name = "rdbSP";
            this.rdbSP.Size = new System.Drawing.Size(108, 24);
            this.rdbSP.TabIndex = 1;
            this.rdbSP.Text = "Sản phẩm";
            this.rdbSP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdbSP.UncheckedState.BorderThickness = 2;
            this.rdbSP.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbSP.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbLoaiSP
            // 
            this.rdbLoaiSP.AutoSize = true;
            this.rdbLoaiSP.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.rdbLoaiSP.CheckedState.BorderThickness = 0;
            this.rdbLoaiSP.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rdbLoaiSP.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbLoaiSP.CheckedState.InnerOffset = -4;
            this.rdbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.rdbLoaiSP.Location = new System.Drawing.Point(548, 205);
            this.rdbLoaiSP.Name = "rdbLoaiSP";
            this.rdbLoaiSP.Size = new System.Drawing.Size(144, 24);
            this.rdbLoaiSP.TabIndex = 1;
            this.rdbLoaiSP.Text = "Loại sản phẩm";
            this.rdbLoaiSP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdbLoaiSP.UncheckedState.BorderThickness = 2;
            this.rdbLoaiSP.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbLoaiSP.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(858, 259);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 37);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Report";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // cbbNV
            // 
            this.cbbNV.BackColor = System.Drawing.Color.Transparent;
            this.cbbNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNV.ItemHeight = 30;
            this.cbbNV.Location = new System.Drawing.Point(251, 193);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(173, 36);
            this.cbbNV.TabIndex = 4;
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cbbSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanPham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSanPham.ItemHeight = 30;
            this.cbbSanPham.Location = new System.Drawing.Point(698, 132);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(169, 36);
            this.cbbSanPham.TabIndex = 4;
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLoaiSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLoaiSP.ItemHeight = 30;
            this.cbbLoaiSP.Location = new System.Drawing.Point(698, 193);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(169, 36);
            this.cbbLoaiSP.TabIndex = 4;
            // 
            // dtp_HD
            // 
            this.dtp_HD.Checked = true;
            this.dtp_HD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_HD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_HD.Location = new System.Drawing.Point(251, 132);
            this.dtp_HD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_HD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_HD.Name = "dtp_HD";
            this.dtp_HD.Size = new System.Drawing.Size(257, 36);
            this.dtp_HD.TabIndex = 5;
            this.dtp_HD.Value = new System.DateTime(2022, 11, 16, 21, 31, 0, 452);
            // 
            // reportViewerNgay
            // 
            this.reportViewerNgay.Location = new System.Drawing.Point(2, 302);
            this.reportViewerNgay.Name = "reportViewerNgay";
            this.reportViewerNgay.ServerReport.BearerToken = null;
            this.reportViewerNgay.Size = new System.Drawing.Size(960, 454);
            this.reportViewerNgay.TabIndex = 6;
            // 
            // reportViewerSanPham
            // 
            this.reportViewerSanPham.Location = new System.Drawing.Point(2, 302);
            this.reportViewerSanPham.Name = "reportViewerSanPham";
            this.reportViewerSanPham.ServerReport.BearerToken = null;
            this.reportViewerSanPham.Size = new System.Drawing.Size(960, 454);
            this.reportViewerSanPham.TabIndex = 7;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 756);
            this.Controls.Add(this.reportViewerSanPham);
            this.Controls.Add(this.reportViewerNgay);
            this.Controls.Add(this.dtp_HD);
            this.Controls.Add(this.cbbLoaiSP);
            this.Controls.Add(this.cbbSanPham);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbLoaiSP);
            this.Controls.Add(this.rdbNgay);
            this.Controls.Add(this.rdbSP);
            this.Controls.Add(this.rdbNV);
            this.Controls.Add(this.reportViewerNhanVien);
            this.MaximumSize = new System.Drawing.Size(981, 795);
            this.MinimumSize = new System.Drawing.Size(981, 795);
            this.Name = "FormReport";
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNhanVien;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNgay;
        private Guna.UI2.WinForms.Guna2RadioButton rdbSP;
        private Guna.UI2.WinForms.Guna2RadioButton rdbLoaiSP;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSanPham;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLoaiSP;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_HD;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSanPham;
    }
}
namespace CakeL_T
{
    partial class USHoaDonAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USHoaDonAdmin));
            this.dgv_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_maNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_maHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_ctHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_XoaHD = new System.Windows.Forms.Button();
            this.btn_ReportHD = new System.Windows.Forms.Button();
            this.btn_TimHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btn_lamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_HoaDon
            // 
            this.dgv_HoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_HoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoaDon.Location = new System.Drawing.Point(0, 180);
            this.dgv_HoaDon.Name = "dgv_HoaDon";
            this.dgv_HoaDon.ReadOnly = true;
            this.dgv_HoaDon.RowHeadersVisible = false;
            this.dgv_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HoaDon.Size = new System.Drawing.Size(650, 207);
            this.dgv_HoaDon.TabIndex = 16;
            this.dgv_HoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            this.dgv_HoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.Controls.Add(this.btn_lamMoi);
            this.groupBox2.Controls.Add(this.txt_maNV);
            this.groupBox2.Controls.Add(this.txt_maHD);
            this.groupBox2.Controls.Add(this.dgv_HoaDon);
            this.groupBox2.Controls.Add(this.dgv_ctHoaDon);
            this.groupBox2.Controls.Add(this.btn_XoaHD);
            this.groupBox2.Controls.Add(this.btn_ReportHD);
            this.groupBox2.Controls.Add(this.btn_TimHD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 649);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // txt_maNV
            // 
            this.txt_maNV.BorderRadius = 20;
            this.txt_maNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maNV.DefaultText = "";
            this.txt_maNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNV.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txt_maNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maNV.Location = new System.Drawing.Point(156, 99);
            this.txt_maNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.PasswordChar = '\0';
            this.txt_maNV.PlaceholderText = "";
            this.txt_maNV.SelectedText = "";
            this.txt_maNV.Size = new System.Drawing.Size(211, 39);
            this.txt_maNV.TabIndex = 17;
            // 
            // txt_maHD
            // 
            this.txt_maHD.BorderRadius = 20;
            this.txt_maHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maHD.DefaultText = "";
            this.txt_maHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maHD.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.txt_maHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maHD.Location = new System.Drawing.Point(156, 29);
            this.txt_maHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.PasswordChar = '\0';
            this.txt_maHD.PlaceholderText = "";
            this.txt_maHD.SelectedText = "";
            this.txt_maHD.Size = new System.Drawing.Size(211, 39);
            this.txt_maHD.TabIndex = 17;
            // 
            // dgv_ctHoaDon
            // 
            this.dgv_ctHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_ctHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ctHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctHoaDon.Location = new System.Drawing.Point(0, 395);
            this.dgv_ctHoaDon.Name = "dgv_ctHoaDon";
            this.dgv_ctHoaDon.ReadOnly = true;
            this.dgv_ctHoaDon.RowHeadersVisible = false;
            this.dgv_ctHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ctHoaDon.Size = new System.Drawing.Size(650, 237);
            this.dgv_ctHoaDon.TabIndex = 16;
            this.dgv_ctHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            this.dgv_ctHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HoaDon_CellContentClick);
            // 
            // btn_XoaHD
            // 
            this.btn_XoaHD.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_XoaHD.Image")));
            this.btn_XoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaHD.Location = new System.Drawing.Point(544, 73);
            this.btn_XoaHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaHD.Name = "btn_XoaHD";
            this.btn_XoaHD.Size = new System.Drawing.Size(120, 32);
            this.btn_XoaHD.TabIndex = 8;
            this.btn_XoaHD.Text = "Xóa";
            this.btn_XoaHD.UseVisualStyleBackColor = true;
            this.btn_XoaHD.Click += new System.EventHandler(this.btn_XoaHD_Click);
            // 
            // btn_ReportHD
            // 
            this.btn_ReportHD.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReportHD.Image")));
            this.btn_ReportHD.Location = new System.Drawing.Point(544, 118);
            this.btn_ReportHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportHD.Name = "btn_ReportHD";
            this.btn_ReportHD.Size = new System.Drawing.Size(120, 34);
            this.btn_ReportHD.TabIndex = 5;
            this.btn_ReportHD.Text = "Report";
            this.btn_ReportHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReportHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReportHD.UseVisualStyleBackColor = true;
            // 
            // btn_TimHD
            // 
            this.btn_TimHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_TimHD.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_TimHD.Image")));
            this.btn_TimHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimHD.Location = new System.Drawing.Point(544, 27);
            this.btn_TimHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TimHD.Name = "btn_TimHD";
            this.btn_TimHD.Size = new System.Drawing.Size(120, 32);
            this.btn_TimHD.TabIndex = 1;
            this.btn_TimHD.Text = "Tìm Kiếm";
            this.btn_TimHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_TimHD.UseVisualStyleBackColor = false;
            this.btn_TimHD.Click += new System.EventHandler(this.btn_TimHD_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã Hóa Đơn:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quản Lý Hóa Đơn Cake L&T";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(473, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(133, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(265, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(133, 68);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(65, 17);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(133, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.Location = new System.Drawing.Point(411, 27);
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.Size = new System.Drawing.Size(113, 32);
            this.btn_lamMoi.TabIndex = 18;
            this.btn_lamMoi.Text = "Làm Mới";
            this.btn_lamMoi.UseVisualStyleBackColor = true;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // USHoaDonAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Name = "USHoaDonAdmin";
            this.Size = new System.Drawing.Size(695, 832);
            this.Load += new System.EventHandler(this.USHoaDonAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_HoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ReportHD;
        private System.Windows.Forms.Button btn_TimHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_XoaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ctHoaDon;
        private Guna.UI2.WinForms.Guna2TextBox txt_maHD;
        private Guna.UI2.WinForms.Guna2TextBox txt_maNV;
        private System.Windows.Forms.Button btn_lamMoi;
    }
}

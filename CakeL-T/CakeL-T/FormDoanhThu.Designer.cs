namespace CakeL_T
{
    partial class FormDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhThu));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewerNgay = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDen = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTu = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_TongDtNgay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.dgv_DTNgay = new System.Windows.Forms.DataGridView();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ReportNgay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ThongKeDTNgay = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewerThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtTotalMonth = new System.Windows.Forms.Label();
            this.dgvThang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Thang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ReportDtThang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ThongKeDTThang = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel_TheoNgay = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DTNgay)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel_TheoNgay.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 808);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.reportViewerNgay);
            this.tabPage1.Controls.Add(this.dtpDen);
            this.tabPage1.Controls.Add(this.dtpTu);
            this.tabPage1.Controls.Add(this.txt_TongDtNgay);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox7);
            this.tabPage1.Controls.Add(this.pictureBox8);
            this.tabPage1.Controls.Add(this.pictureBox9);
            this.tabPage1.Controls.Add(this.dgv_DTNgay);
            this.tabPage1.Controls.Add(this.btn_ReportNgay);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btn_ThongKeDTNgay);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 782);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh Thu Theo Ngày";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewerNgay
            // 
            this.reportViewerNgay.Location = new System.Drawing.Point(0, 234);
            this.reportViewerNgay.Name = "reportViewerNgay";
            this.reportViewerNgay.ServerReport.BearerToken = null;
            this.reportViewerNgay.Size = new System.Drawing.Size(789, 548);
            this.reportViewerNgay.TabIndex = 49;
            // 
            // dtpDen
            // 
            this.dtpDen.Checked = true;
            this.dtpDen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDen.Location = new System.Drawing.Point(377, 191);
            this.dtpDen.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDen.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(222, 36);
            this.dtpDen.TabIndex = 48;
            this.dtpDen.Value = new System.DateTime(2022, 11, 17, 11, 41, 14, 844);
            // 
            // dtpTu
            // 
            this.dtpTu.Checked = true;
            this.dtpTu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTu.Location = new System.Drawing.Point(92, 191);
            this.dtpTu.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTu.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(225, 36);
            this.dtpTu.TabIndex = 47;
            this.dtpTu.Value = new System.DateTime(2022, 11, 17, 11, 41, 3, 727);
            // 
            // txt_TongDtNgay
            // 
            this.txt_TongDtNgay.AutoSize = true;
            this.txt_TongDtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongDtNgay.ForeColor = System.Drawing.Color.Red;
            this.txt_TongDtNgay.Location = new System.Drawing.Point(569, 735);
            this.txt_TongDtNgay.Name = "txt_TongDtNgay";
            this.txt_TongDtNgay.Size = new System.Drawing.Size(57, 20);
            this.txt_TongDtNgay.TabIndex = 46;
            this.txt_TongDtNgay.Text = "label3";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 33);
            this.label6.TabIndex = 45;
            this.label6.Text = "Thống Kê Doanh Thu Cake L&T";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(529, 21);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(152, 68);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 44;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(321, 21);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(152, 68);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(121, 21);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(152, 68);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 42;
            this.pictureBox9.TabStop = false;
            // 
            // dgv_DTNgay
            // 
            this.dgv_DTNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DTNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DTNgay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_DTNgay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DTNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DTNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoaDon,
            this.TenTaiKhoan,
            this.NgayMua,
            this.TongTien});
            this.dgv_DTNgay.Location = new System.Drawing.Point(79, 270);
            this.dgv_DTNgay.Name = "dgv_DTNgay";
            this.dgv_DTNgay.ReadOnly = true;
            this.dgv_DTNgay.RowHeadersVisible = false;
            this.dgv_DTNgay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DTNgay.Size = new System.Drawing.Size(635, 435);
            this.dgv_DTNgay.TabIndex = 38;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHoaDon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "TenTaiKhoan";
            this.TenTaiKhoan.HeaderText = "Tài Khoản Lập";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            // 
            // NgayMua
            // 
            this.NgayMua.DataPropertyName = "NgayMua";
            this.NgayMua.HeaderText = "Ngày Lập";
            this.NgayMua.Name = "NgayMua";
            this.NgayMua.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // btn_ReportNgay
            // 
            this.btn_ReportNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReportNgay.BackColor = System.Drawing.Color.Snow;
            this.btn_ReportNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReportNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportNgay.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReportNgay.Image")));
            this.btn_ReportNgay.Location = new System.Drawing.Point(706, 191);
            this.btn_ReportNgay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportNgay.Name = "btn_ReportNgay";
            this.btn_ReportNgay.Size = new System.Drawing.Size(74, 38);
            this.btn_ReportNgay.TabIndex = 37;
            this.btn_ReportNgay.Text = "Report";
            this.btn_ReportNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReportNgay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReportNgay.UseVisualStyleBackColor = false;
            this.btn_ReportNgay.Click += new System.EventHandler(this.btn_ReportNgay_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 75);
            this.label7.TabIndex = 33;
            this.label7.Text = "Đến\r\n\r\n\r\n";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 732);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tổng doanh thu:";
            // 
            // btn_ThongKeDTNgay
            // 
            this.btn_ThongKeDTNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThongKeDTNgay.BackColor = System.Drawing.Color.Snow;
            this.btn_ThongKeDTNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThongKeDTNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeDTNgay.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeDTNgay.Image")));
            this.btn_ThongKeDTNgay.Location = new System.Drawing.Point(604, 191);
            this.btn_ThongKeDTNgay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongKeDTNgay.Name = "btn_ThongKeDTNgay";
            this.btn_ThongKeDTNgay.Size = new System.Drawing.Size(87, 38);
            this.btn_ThongKeDTNgay.TabIndex = 36;
            this.btn_ThongKeDTNgay.Text = "Thống kê";
            this.btn_ThongKeDTNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThongKeDTNgay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKeDTNgay.UseVisualStyleBackColor = false;
            this.btn_ThongKeDTNgay.Click += new System.EventHandler(this.btn_ThongKeDTNgay_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 50);
            this.label9.TabIndex = 35;
            this.label9.Text = "Từ ngày:\r\n\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.reportViewerThang);
            this.tabPage2.Controls.Add(this.txtTotalMonth);
            this.tabPage2.Controls.Add(this.dgvThang);
            this.tabPage2.Controls.Add(this.txt_Thang);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_ReportDtThang);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_ThongKeDTThang);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 782);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu Theo Tháng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewerThang
            // 
            this.reportViewerThang.Location = new System.Drawing.Point(0, 281);
            this.reportViewerThang.Name = "reportViewerThang";
            this.reportViewerThang.ServerReport.BearerToken = null;
            this.reportViewerThang.Size = new System.Drawing.Size(789, 502);
            this.reportViewerThang.TabIndex = 48;
            // 
            // txtTotalMonth
            // 
            this.txtTotalMonth.AutoSize = true;
            this.txtTotalMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMonth.ForeColor = System.Drawing.Color.Red;
            this.txtTotalMonth.Location = new System.Drawing.Point(568, 706);
            this.txtTotalMonth.Name = "txtTotalMonth";
            this.txtTotalMonth.Size = new System.Drawing.Size(57, 20);
            this.txtTotalMonth.TabIndex = 47;
            this.txtTotalMonth.Text = "label3";
            // 
            // dgvThang
            // 
            this.dgvThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TenTK,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvThang.Location = new System.Drawing.Point(36, 298);
            this.dgvThang.Name = "dgvThang";
            this.dgvThang.ReadOnly = true;
            this.dgvThang.RowHeadersVisible = false;
            this.dgvThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThang.Size = new System.Drawing.Size(692, 371);
            this.dgvThang.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Hóa Đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTaiKhoan";
            this.TenTK.HeaderText = "Tài Khoản Lập";
            this.TenTK.Name = "TenTK";
            this.TenTK.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgayMua";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày Lập";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng Tiền";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // txt_Thang
            // 
            this.txt_Thang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Thang.BorderRadius = 15;
            this.txt_Thang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Thang.DefaultText = "";
            this.txt_Thang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Thang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Thang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Thang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Thang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Thang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Thang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Thang.Location = new System.Drawing.Point(241, 230);
            this.txt_Thang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Thang.Name = "txt_Thang";
            this.txt_Thang.PasswordChar = '\0';
            this.txt_Thang.PlaceholderText = "";
            this.txt_Thang.SelectedText = "";
            this.txt_Thang.Size = new System.Drawing.Size(69, 31);
            this.txt_Thang.TabIndex = 43;
            this.txt_Thang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Thang_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nhập Tháng Cần Thống Kê:";
            // 
            // btn_ReportDtThang
            // 
            this.btn_ReportDtThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ReportDtThang.BackColor = System.Drawing.Color.Snow;
            this.btn_ReportDtThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ReportDtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReportDtThang.Image = ((System.Drawing.Image)(resources.GetObject("btn_ReportDtThang.Image")));
            this.btn_ReportDtThang.Location = new System.Drawing.Point(638, 231);
            this.btn_ReportDtThang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ReportDtThang.Name = "btn_ReportDtThang";
            this.btn_ReportDtThang.Size = new System.Drawing.Size(90, 41);
            this.btn_ReportDtThang.TabIndex = 39;
            this.btn_ReportDtThang.Text = "Report";
            this.btn_ReportDtThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ReportDtThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ReportDtThang.UseVisualStyleBackColor = false;
            this.btn_ReportDtThang.Click += new System.EventHandler(this.btn_ReportDtThang_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 703);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // btn_ThongKeDTThang
            // 
            this.btn_ThongKeDTThang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ThongKeDTThang.BackColor = System.Drawing.Color.Snow;
            this.btn_ThongKeDTThang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ThongKeDTThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKeDTThang.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKeDTThang.Image")));
            this.btn_ThongKeDTThang.Location = new System.Drawing.Point(535, 231);
            this.btn_ThongKeDTThang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThongKeDTThang.Name = "btn_ThongKeDTThang";
            this.btn_ThongKeDTThang.Size = new System.Drawing.Size(90, 41);
            this.btn_ThongKeDTThang.TabIndex = 38;
            this.btn_ThongKeDTThang.Text = "Thống kê";
            this.btn_ThongKeDTThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThongKeDTThang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThongKeDTThang.UseVisualStyleBackColor = false;
            this.btn_ThongKeDTThang.Click += new System.EventHandler(this.btn_ThongKeDTThang_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 33);
            this.label10.TabIndex = 36;
            this.label10.Text = "Thống Kê Doanh Thu Cake L&T";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(473, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(265, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(65, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // panel_TheoNgay
            // 
            this.panel_TheoNgay.Controls.Add(this.tabControl1);
            this.panel_TheoNgay.Location = new System.Drawing.Point(0, 3);
            this.panel_TheoNgay.Name = "panel_TheoNgay";
            this.panel_TheoNgay.Size = new System.Drawing.Size(800, 811);
            this.panel_TheoNgay.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(604, 153);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 34);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(535, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 34);
            this.button1.TabIndex = 51;
            this.button1.Text = "Làm mới";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 814);
            this.Controls.Add(this.panel_TheoNgay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDoanhThu";
            this.Load += new System.EventHandler(this.FormDoanhThu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DTNgay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel_TheoNgay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView dgv_DTNgay;
        private System.Windows.Forms.Button btn_ReportNgay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ThongKeDTNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Thang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ReportDtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ThongKeDTThang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel_TheoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Label txt_TongDtNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTu;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNgay;
        private System.Windows.Forms.DataGridView dgvThang;
        private System.Windows.Forms.Label txtTotalMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerThang;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
    }
}
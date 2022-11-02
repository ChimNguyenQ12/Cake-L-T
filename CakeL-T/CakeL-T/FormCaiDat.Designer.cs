namespace CakeL_T
{
    partial class FormCaiDat
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.rbn_VietNam = new System.Windows.Forms.RadioButton();
            this.rbn_English = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightCoral;
            this.guna2Button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(115, 237);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Chuyển đổi";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // rbn_VietNam
            // 
            this.rbn_VietNam.AutoSize = true;
            this.rbn_VietNam.Checked = true;
            this.rbn_VietNam.Location = new System.Drawing.Point(89, 183);
            this.rbn_VietNam.Name = "rbn_VietNam";
            this.rbn_VietNam.Size = new System.Drawing.Size(68, 17);
            this.rbn_VietNam.TabIndex = 1;
            this.rbn_VietNam.TabStop = true;
            this.rbn_VietNam.Text = "Việt Nam";
            this.rbn_VietNam.UseVisualStyleBackColor = true;
            // 
            // rbn_English
            // 
            this.rbn_English.AutoSize = true;
            this.rbn_English.Location = new System.Drawing.Point(256, 183);
            this.rbn_English.Name = "rbn_English";
            this.rbn_English.Size = new System.Drawing.Size(59, 17);
            this.rbn_English.TabIndex = 2;
            this.rbn_English.Text = "English";
            this.rbn_English.UseVisualStyleBackColor = true;
            // 
            // FormCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 333);
            this.Controls.Add(this.rbn_English);
            this.Controls.Add(this.rbn_VietNam);
            this.Controls.Add(this.guna2Button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaiDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCaiDat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.RadioButton rbn_VietNam;
        private System.Windows.Forms.RadioButton rbn_English;
    }
}
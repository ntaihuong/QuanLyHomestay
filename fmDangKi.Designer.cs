namespace HomestayApp
{
    partial class fmDangKi
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
            this.components = new System.ComponentModel.Container();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtXNMK = new System.Windows.Forms.TextBox();
            this.lbXNMK = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbMhatkhau = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.lbTaikhoan = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel6.Controls.Add(this.txtXNMK);
            this.panel6.Controls.Add(this.lbXNMK);
            this.panel6.Location = new System.Drawing.Point(64, 416);
            this.panel6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(436, 49);
            this.panel6.TabIndex = 15;
            // 
            // txtXNMK
            // 
            this.txtXNMK.Location = new System.Drawing.Point(147, 14);
            this.txtXNMK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtXNMK.MaxLength = 15;
            this.txtXNMK.Name = "txtXNMK";
            this.txtXNMK.PasswordChar = '*';
            this.txtXNMK.Size = new System.Drawing.Size(279, 22);
            this.txtXNMK.TabIndex = 1;
            // 
            // lbXNMK
            // 
            this.lbXNMK.AutoSize = true;
            this.lbXNMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbXNMK.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXNMK.ForeColor = System.Drawing.Color.White;
            this.lbXNMK.Location = new System.Drawing.Point(5, 14);
            this.lbXNMK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbXNMK.Name = "lbXNMK";
            this.lbXNMK.Size = new System.Drawing.Size(114, 16);
            this.lbXNMK.TabIndex = 0;
            this.lbXNMK.Text = "Xác nhật mật khẩu";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel7.Controls.Add(this.txtMatKhau);
            this.panel7.Controls.Add(this.lbMhatkhau);
            this.panel7.Location = new System.Drawing.Point(64, 359);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(436, 49);
            this.panel7.TabIndex = 14;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "Matkhau", true));
            this.txtMatKhau.Location = new System.Drawing.Point(147, 11);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMatKhau.MaxLength = 15;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(279, 22);
            this.txtMatKhau.TabIndex = 1;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataSource = typeof(HomestayApp.TAIKHOAN);
            // 
            // lbMhatkhau
            // 
            this.lbMhatkhau.AutoSize = true;
            this.lbMhatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbMhatkhau.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMhatkhau.ForeColor = System.Drawing.Color.White;
            this.lbMhatkhau.Location = new System.Drawing.Point(5, 14);
            this.lbMhatkhau.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbMhatkhau.Name = "lbMhatkhau";
            this.lbMhatkhau.Size = new System.Drawing.Size(62, 16);
            this.lbMhatkhau.TabIndex = 0;
            this.lbMhatkhau.Text = "Mật khẩu";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.txtTaikhoan);
            this.panel4.Controls.Add(this.lbTaikhoan);
            this.panel4.Location = new System.Drawing.Point(64, 303);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(436, 49);
            this.panel4.TabIndex = 13;
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "TaiKhoan1", true));
            this.txtTaikhoan.Location = new System.Drawing.Point(147, 11);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(279, 22);
            this.txtTaikhoan.TabIndex = 1;
            // 
            // lbTaikhoan
            // 
            this.lbTaikhoan.AutoSize = true;
            this.lbTaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbTaikhoan.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaikhoan.ForeColor = System.Drawing.Color.White;
            this.lbTaikhoan.Location = new System.Drawing.Point(5, 14);
            this.lbTaikhoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTaikhoan.Name = "lbTaikhoan";
            this.lbTaikhoan.Size = new System.Drawing.Size(62, 16);
            this.lbTaikhoan.TabIndex = 0;
            this.lbTaikhoan.Text = "Tài khoản";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.txtPhone);
            this.panel5.Controls.Add(this.lbPhone);
            this.panel5.Location = new System.Drawing.Point(64, 246);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(436, 49);
            this.panel5.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(147, 11);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(279, 22);
            this.txtPhone.TabIndex = 1;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(5, 14);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(42, 16);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Phone";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(325, 487);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(72, 37);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKi
            // 
            this.btnDangKi.BackColor = System.Drawing.Color.White;
            this.btnDangKi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Location = new System.Drawing.Point(160, 487);
            this.btnDangKi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(72, 37);
            this.btnDangKi.TabIndex = 10;
            this.btnDangKi.Text = "Đăng Ký";
            this.btnDangKi.UseVisualStyleBackColor = false;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.lbEmail);
            this.panel3.Location = new System.Drawing.Point(64, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 49);
            this.panel3.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(147, 14);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(279, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.White;
            this.lbEmail.Location = new System.Drawing.Point(5, 14);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 16);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.txtHoten);
            this.panel2.Controls.Add(this.lbHoten);
            this.panel2.Location = new System.Drawing.Point(64, 133);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 49);
            this.panel2.TabIndex = 8;
            // 
            // txtHoten
            // 
            this.txtHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAIKHOANBindingSource, "HoTen", true));
            this.txtHoten.Location = new System.Drawing.Point(147, 14);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(279, 22);
            this.txtHoten.TabIndex = 1;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbHoten.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.ForeColor = System.Drawing.Color.White;
            this.lbHoten.Location = new System.Drawing.Point(5, 14);
            this.lbHoten.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(45, 16);
            this.lbHoten.TabIndex = 0;
            this.lbHoten.Text = "Họ tên";
            // 
            // fmDangKi
            // 
            this.AcceptButton = this.btnDangKi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HomestayApp.Properties.Resources.dk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(544, 535);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fmDangKi";
            this.Text = "fmDangKi";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtXNMK;
        private System.Windows.Forms.Label lbXNMK;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lbMhatkhau;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label lbTaikhoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
    }
}
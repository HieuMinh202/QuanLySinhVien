namespace ProjectCuoiKhoaCS0523
{
	partial class frmNguoiDungAdd
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboVaiTro = new System.Windows.Forms.ComboBox();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtTenDangNhap = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboVaiTro);
			this.groupBox1.Controls.Add(this.btnDong);
			this.groupBox1.Controls.Add(this.btnCapNhat);
			this.groupBox1.Controls.Add(this.txtMatKhau);
			this.groupBox1.Controls.Add(this.txtTenDangNhap);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(431, 228);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin thêm người dùng";
			// 
			// cboVaiTro
			// 
			this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboVaiTro.FormattingEnabled = true;
			this.cboVaiTro.Location = new System.Drawing.Point(87, 23);
			this.cboVaiTro.Name = "cboVaiTro";
			this.cboVaiTro.Size = new System.Drawing.Size(121, 21);
			this.cboVaiTro.TabIndex = 4;
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cancel;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(345, 196);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 23);
			this.btnDong.TabIndex = 10;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.save;
			this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapNhat.Location = new System.Drawing.Point(264, 196);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 9;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(320, 50);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(100, 20);
			this.txtMatKhau.TabIndex = 3;
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.Location = new System.Drawing.Point(320, 24);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new System.Drawing.Size(100, 20);
			this.txtTenDangNhap.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(232, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mật khẩu:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(87, 102);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(333, 20);
			this.txtEmail.TabIndex = 7;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(87, 76);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(333, 20);
			this.txtHoTen.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(232, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên đăng nhập:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 27);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Vai trò:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 106);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Email:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Họ Tên:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(87, 128);
			this.txtDiaChi.Multiline = true;
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(333, 62);
			this.txtDiaChi.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Địa chỉ:";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Location = new System.Drawing.Point(87, 49);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(121, 20);
			this.txtDienThoai.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Điện thoại:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmNguoiDungAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 252);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmNguoiDungAdd";
			this.Text = "Add người dùng";
			this.Load += new System.EventHandler(this.frmNguoiDungAdd_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.TextBox txtTenDangNhap;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.ComboBox cboVaiTro;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
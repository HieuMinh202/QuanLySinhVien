namespace ProjectCuoiKhoaCS0523
{
	partial class SinhVienAdd
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
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.rbtnNu = new System.Windows.Forms.RadioButton();
			this.rbtnNam = new System.Windows.Forms.RadioButton();
			this.cboKhoa = new System.Windows.Forms.ComboBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDienThoai = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMaSV);
			this.groupBox1.Controls.Add(this.btnDong);
			this.groupBox1.Controls.Add(this.btnCapNhat);
			this.groupBox1.Controls.Add(this.dtpNgaySinh);
			this.groupBox1.Controls.Add(this.rbtnNu);
			this.groupBox1.Controls.Add(this.rbtnNam);
			this.groupBox1.Controls.Add(this.cboKhoa);
			this.groupBox1.Controls.Add(this.txtDiaChi);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDienThoai);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(380, 283);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin sinh viên";
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(75, 27);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(197, 20);
			this.txtMaSV.TabIndex = 2;
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cancel;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(288, 252);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 23);
			this.btnDong.TabIndex = 8;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.save;
			this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapNhat.Location = new System.Drawing.Point(207, 252);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 7;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(260, 92);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(105, 20);
			this.dtpNgaySinh.TabIndex = 12;
			// 
			// rbtnNu
			// 
			this.rbtnNu.AutoSize = true;
			this.rbtnNu.Location = new System.Drawing.Point(128, 94);
			this.rbtnNu.Name = "rbtnNu";
			this.rbtnNu.Size = new System.Drawing.Size(39, 17);
			this.rbtnNu.TabIndex = 11;
			this.rbtnNu.TabStop = true;
			this.rbtnNu.Text = "Nữ";
			this.rbtnNu.UseVisualStyleBackColor = true;
			// 
			// rbtnNam
			// 
			this.rbtnNam.AutoSize = true;
			this.rbtnNam.Location = new System.Drawing.Point(75, 94);
			this.rbtnNam.Name = "rbtnNam";
			this.rbtnNam.Size = new System.Drawing.Size(47, 17);
			this.rbtnNam.TabIndex = 10;
			this.rbtnNam.TabStop = true;
			this.rbtnNam.Text = "Nam";
			this.rbtnNam.UseVisualStyleBackColor = true;
			// 
			// cboKhoa
			// 
			this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboKhoa.FormattingEnabled = true;
			this.cboKhoa.Location = new System.Drawing.Point(75, 225);
			this.cboKhoa.Name = "cboKhoa";
			this.cboKhoa.Size = new System.Drawing.Size(290, 21);
			this.cboKhoa.TabIndex = 9;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(75, 174);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(290, 20);
			this.txtDiaChi.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(43, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Địa chỉ:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(75, 148);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(290, 20);
			this.txtEmail.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Email:";
			// 
			// txtDienThoai
			// 
			this.txtDienThoai.Location = new System.Drawing.Point(75, 122);
			this.txtDienThoai.Name = "txtDienThoai";
			this.txtDienThoai.Size = new System.Drawing.Size(290, 20);
			this.txtDienThoai.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 229);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Khoa:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(196, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Ngày sinh:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Giới tính:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Điện thoại:";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(75, 59);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(290, 20);
			this.txtHoTen.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Họ tên:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã SV:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// SinhVienAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 303);
			this.Controls.Add(this.groupBox1);
			this.Name = "SinhVienAdd";
			this.Text = "Add Sinh Viên";
			this.Load += new System.EventHandler(this.SinhVienAdd_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.RadioButton rbtnNu;
		private System.Windows.Forms.RadioButton rbtnNam;
		private System.Windows.Forms.ComboBox cboKhoa;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDienThoai;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtMaSV;
	}
}
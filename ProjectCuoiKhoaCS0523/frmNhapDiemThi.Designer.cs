namespace ProjectCuoiKhoaCS0523
{
	partial class frmNhapDiemThi
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
			this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
			this.cboPhongThi = new System.Windows.Forms.ComboBox();
			this.cboMonThi = new System.Windows.Forms.ComboBox();
			this.btnLink = new System.Windows.Forms.Button();
			this.txtDiem = new System.Windows.Forms.TextBox();
			this.txtTenSV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpNgayThi);
			this.groupBox1.Controls.Add(this.cboPhongThi);
			this.groupBox1.Controls.Add(this.cboMonThi);
			this.groupBox1.Controls.Add(this.btnLink);
			this.groupBox1.Controls.Add(this.txtDiem);
			this.groupBox1.Controls.Add(this.txtTenSV);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtMaSV);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(630, 141);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chi tiết";
			// 
			// dtpNgayThi
			// 
			this.dtpNgayThi.CustomFormat = "dd/MM/yyyy";
			this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayThi.Location = new System.Drawing.Point(89, 102);
			this.dtpNgayThi.Name = "dtpNgayThi";
			this.dtpNgayThi.Size = new System.Drawing.Size(172, 20);
			this.dtpNgayThi.TabIndex = 5;
			// 
			// cboPhongThi
			// 
			this.cboPhongThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPhongThi.FormattingEnabled = true;
			this.cboPhongThi.Location = new System.Drawing.Point(89, 48);
			this.cboPhongThi.Name = "cboPhongThi";
			this.cboPhongThi.Size = new System.Drawing.Size(172, 21);
			this.cboPhongThi.TabIndex = 3;
			// 
			// cboMonThi
			// 
			this.cboMonThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonThi.FormattingEnabled = true;
			this.cboMonThi.Location = new System.Drawing.Point(89, 75);
			this.cboMonThi.Name = "cboMonThi";
			this.cboMonThi.Size = new System.Drawing.Size(172, 21);
			this.cboMonThi.TabIndex = 4;
			// 
			// btnLink
			// 
			this.btnLink.Location = new System.Drawing.Point(546, 21);
			this.btnLink.Name = "btnLink";
			this.btnLink.Size = new System.Drawing.Size(75, 23);
			this.btnLink.TabIndex = 8;
			this.btnLink.Text = "........";
			this.btnLink.UseVisualStyleBackColor = true;
			this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
			// 
			// txtDiem
			// 
			this.txtDiem.Location = new System.Drawing.Point(373, 102);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.Size = new System.Drawing.Size(167, 20);
			this.txtDiem.TabIndex = 6;
			// 
			// txtTenSV
			// 
			this.txtTenSV.Location = new System.Drawing.Point(373, 22);
			this.txtTenSV.Name = "txtTenSV";
			this.txtTenSV.Size = new System.Drawing.Size(167, 20);
			this.txtTenSV.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(321, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Tên SV:";
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(89, 22);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(172, 20);
			this.txtMaSV.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(321, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Điểm:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(26, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(49, 13);
			this.label9.TabIndex = 7;
			this.label9.Text = "Ngày thi:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(26, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 13);
			this.label10.TabIndex = 8;
			this.label10.Text = "Phòng thi:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(26, 78);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 13);
			this.label11.TabIndex = 9;
			this.label11.Text = "Môn Thi:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(26, 26);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 13);
			this.label12.TabIndex = 10;
			this.label12.Text = "Mã SV:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.btnCapNhat);
			this.panel1.Location = new System.Drawing.Point(13, 161);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(630, 48);
			this.panel1.TabIndex = 6;
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cross;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(546, 12);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 23);
			this.btnDong.TabIndex = 9;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.save;
			this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapNhat.Location = new System.Drawing.Point(437, 12);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
			this.btnCapNhat.TabIndex = 7;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmNhapDiemThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 221);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmNhapDiemThi";
			this.Text = "Nhập điểm";
			this.Load += new System.EventHandler(this.frmNhapDiemThi_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpNgayThi;
		private System.Windows.Forms.ComboBox cboPhongThi;
		private System.Windows.Forms.ComboBox cboMonThi;
		private System.Windows.Forms.Button btnLink;
		private System.Windows.Forms.TextBox txtDiem;
		private System.Windows.Forms.TextBox txtTenSV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMaSV;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
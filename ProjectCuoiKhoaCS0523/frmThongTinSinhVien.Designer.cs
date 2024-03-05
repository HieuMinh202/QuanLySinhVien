namespace ProjectCuoiKhoaCS0523
{
	partial class frmThongTinSinhVien
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cboKhoa = new System.Windows.Forms.ComboBox();
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.txtMaSV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gridThongTinSinhVien = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThemMoi = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridThongTinSinhVien)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cboKhoa);
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.txtMaSV);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(746, 55);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin tìm kiếm sinh viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(341, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Khoa:";
			// 
			// cboKhoa
			// 
			this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboKhoa.FormattingEnabled = true;
			this.cboKhoa.Location = new System.Drawing.Point(386, 21);
			this.cboKhoa.Name = "cboKhoa";
			this.cboKhoa.Size = new System.Drawing.Size(206, 21);
			this.cboKhoa.TabIndex = 7;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.search;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.Location = new System.Drawing.Point(654, 20);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(80, 23);
			this.btnTimKiem.TabIndex = 2;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtMaSV
			// 
			this.txtMaSV.Location = new System.Drawing.Point(88, 21);
			this.txtMaSV.Name = "txtMaSV";
			this.txtMaSV.Size = new System.Drawing.Size(131, 20);
			this.txtMaSV.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã SV:";
			// 
			// gridThongTinSinhVien
			// 
			this.gridThongTinSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridThongTinSinhVien.Location = new System.Drawing.Point(0, 52);
			this.gridThongTinSinhVien.Name = "gridThongTinSinhVien";
			this.gridThongTinSinhVien.Size = new System.Drawing.Size(743, 205);
			this.gridThongTinSinhVien.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnThemMoi);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 255);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(746, 46);
			this.panel1.TabIndex = 2;
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cancel;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(628, 11);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 23);
			this.btnDong.TabIndex = 6;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.delete;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(547, 11);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 5;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.EditTableHS;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(465, 11);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.plus_16;
			this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemMoi.Location = new System.Drawing.Point(383, 11);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
			this.btnThemMoi.TabIndex = 3;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// frmThongTinSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 301);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gridThongTinSinhVien);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmThongTinSinhVien";
			this.Text = "Thông tin sinh viên";
			this.Load += new System.EventHandler(this.frmThongTinSinhVien_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridThongTinSinhVien)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.TextBox txtMaSV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridThongTinSinhVien;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThemMoi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cboKhoa;
	}
}
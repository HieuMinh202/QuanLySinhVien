namespace ProjectCuoiKhoaCS0523
{
	partial class frmTraCuuDiemThi
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
			this.btnTimKiem = new System.Windows.Forms.Button();
			this.cboMon = new System.Windows.Forms.ComboBox();
			this.txtTuKhoa = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.gridTraCuuDiemThi = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTraCuuDiemThi)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.cboMon);
			this.groupBox1.Controls.Add(this.txtTuKhoa);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(812, 39);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập tìm kiếm";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.search;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.Location = new System.Drawing.Point(558, 12);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 4;
			this.btnTimKiem.Text = "Tìm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// cboMon
			// 
			this.cboMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMon.FormattingEnabled = true;
			this.cboMon.Location = new System.Drawing.Point(374, 13);
			this.cboMon.Name = "cboMon";
			this.cboMon.Size = new System.Drawing.Size(178, 21);
			this.cboMon.TabIndex = 3;
			// 
			// txtTuKhoa
			// 
			this.txtTuKhoa.Location = new System.Drawing.Point(62, 13);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new System.Drawing.Size(269, 20);
			this.txtTuKhoa.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(337, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Môn:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ khóa:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnThem);
			this.panel1.Location = new System.Drawing.Point(13, 318);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(812, 40);
			this.panel1.TabIndex = 1;
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cancel;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(734, 6);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 23);
			this.btnDong.TabIndex = 0;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.delete;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(653, 6);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 23);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.edit;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(572, 6);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnThem
			// 
			this.btnThem.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.plus_16;
			this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThem.Location = new System.Drawing.Point(491, 6);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 23);
			this.btnThem.TabIndex = 0;
			this.btnThem.Text = "Thêm mới";
			this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// gridTraCuuDiemThi
			// 
			this.gridTraCuuDiemThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridTraCuuDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTraCuuDiemThi.Location = new System.Drawing.Point(13, 53);
			this.gridTraCuuDiemThi.Name = "gridTraCuuDiemThi";
			this.gridTraCuuDiemThi.ReadOnly = true;
			this.gridTraCuuDiemThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridTraCuuDiemThi.Size = new System.Drawing.Size(812, 259);
			this.gridTraCuuDiemThi.TabIndex = 2;
			// 
			// frmTraCuuDiemThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 370);
			this.Controls.Add(this.gridTraCuuDiemThi);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmTraCuuDiemThi";
			this.Text = "Tra cứu điểm";
			this.Load += new System.EventHandler(this.frmTraCuuDiemThi_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTraCuuDiemThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView gridTraCuuDiemThi;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.ComboBox cboMon;
		private System.Windows.Forms.TextBox txtTuKhoa;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
	}
}
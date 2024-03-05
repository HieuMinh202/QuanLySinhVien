namespace ProjectCuoiKhoaCS0523
{
	partial class frmDanhSachNguoiDung
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
			this.gridNguoiDung = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnDong = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThemMoi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridNguoiDung)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridNguoiDung
			// 
			this.gridNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridNguoiDung.Location = new System.Drawing.Point(0, 0);
			this.gridNguoiDung.Name = "gridNguoiDung";
			this.gridNguoiDung.Size = new System.Drawing.Size(659, 275);
			this.gridNguoiDung.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.btnXoa);
			this.panel1.Controls.Add(this.btnThemMoi);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 276);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(659, 41);
			this.panel1.TabIndex = 1;
			// 
			// btnSua
			// 
			this.btnSua.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.edit;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(403, 10);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 4;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cancel;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(572, 10);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(87, 23);
			this.btnDong.TabIndex = 1;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.delete;
			this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnXoa.Location = new System.Drawing.Point(484, 10);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(82, 23);
			this.btnXoa.TabIndex = 0;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.plus_16;
			this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemMoi.Location = new System.Drawing.Point(313, 10);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(84, 23);
			this.btnThemMoi.TabIndex = 0;
			this.btnThemMoi.Text = "Thêm mới";
			this.btnThemMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// frmDanhSachNguoiDung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(659, 317);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gridNguoiDung);
			this.Name = "frmDanhSachNguoiDung";
			this.Text = "Danh sách người dùng";
			this.Load += new System.EventHandler(this.frmDanhSachNguoiDung_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridNguoiDung)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridNguoiDung;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThemMoi;
		private System.Windows.Forms.Button btnSua;
	}
}
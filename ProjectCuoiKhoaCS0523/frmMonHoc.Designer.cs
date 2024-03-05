namespace ProjectCuoiKhoaCS0523
{
	partial class frmMonHoc
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
			this.gridMonHoc = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnThemMoi = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.Xóa = new System.Windows.Forms.Button();
			this.btnDong = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridMonHoc
			// 
			this.gridMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridMonHoc.Location = new System.Drawing.Point(3, 3);
			this.gridMonHoc.Name = "gridMonHoc";
			this.gridMonHoc.Size = new System.Drawing.Size(424, 180);
			this.gridMonHoc.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDong);
			this.panel1.Controls.Add(this.Xóa);
			this.panel1.Controls.Add(this.btnSua);
			this.panel1.Controls.Add(this.btnThemMoi);
			this.panel1.Location = new System.Drawing.Point(3, 182);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(424, 57);
			this.panel1.TabIndex = 4;
			// 
			// btnThemMoi
			// 
			this.btnThemMoi.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.plus_16;
			this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnThemMoi.Location = new System.Drawing.Point(96, 18);
			this.btnThemMoi.Name = "btnThemMoi";
			this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
			this.btnThemMoi.TabIndex = 0;
			this.btnThemMoi.Text = "Thêm";
			this.btnThemMoi.UseVisualStyleBackColor = true;
			this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
			// 
			// btnSua
			// 
			this.btnSua.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.edit;
			this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSua.Location = new System.Drawing.Point(177, 18);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 23);
			this.btnSua.TabIndex = 0;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// Xóa
			// 
			this.Xóa.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.delete;
			this.Xóa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Xóa.Location = new System.Drawing.Point(258, 18);
			this.Xóa.Name = "Xóa";
			this.Xóa.Size = new System.Drawing.Size(75, 23);
			this.Xóa.TabIndex = 0;
			this.Xóa.Text = "Xóa";
			this.Xóa.UseVisualStyleBackColor = true;
			this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.logout;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(339, 18);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(75, 23);
			this.btnDong.TabIndex = 0;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// frmMonHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 239);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gridMonHoc);
			this.Name = "frmMonHoc";
			this.Text = "Danh sách môn học";
			this.Load += new System.EventHandler(this.frmMonHoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridMonHoc)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView gridMonHoc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button Xóa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThemMoi;
	}
}
namespace ProjectCuoiKhoaCS0523
{
	partial class frmMHadd
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
			this.btnDong = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.txtTenMonHoc = new System.Windows.Forms.TextBox();
			this.txtMaMonHoc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDong);
			this.groupBox1.Controls.Add(this.btnCapNhat);
			this.groupBox1.Controls.Add(this.txtTenMonHoc);
			this.groupBox1.Controls.Add(this.txtMaMonHoc);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(14, 12);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(322, 118);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết";
			// 
			// btnDong
			// 
			this.btnDong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cross;
			this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDong.Location = new System.Drawing.Point(208, 77);
			this.btnDong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(88, 23);
			this.btnDong.TabIndex = 5;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.save;
			this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCapNhat.Location = new System.Drawing.Point(112, 77);
			this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(88, 23);
			this.btnCapNhat.TabIndex = 4;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// txtTenMonHoc
			// 
			this.txtTenMonHoc.Location = new System.Drawing.Point(104, 51);
			this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtTenMonHoc.Name = "txtTenMonHoc";
			this.txtTenMonHoc.Size = new System.Drawing.Size(192, 20);
			this.txtTenMonHoc.TabIndex = 3;
			// 
			// txtMaMonHoc
			// 
			this.txtMaMonHoc.Location = new System.Drawing.Point(104, 25);
			this.txtMaMonHoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMaMonHoc.Name = "txtMaMonHoc";
			this.txtMaMonHoc.Size = new System.Drawing.Size(192, 20);
			this.txtMaMonHoc.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 55);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên môn học";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã môn học:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmMHadd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 143);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "frmMHadd";
			this.Text = "Thêm môn học";
			this.Load += new System.EventHandler(this.frmMHadd_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.TextBox txtTenMonHoc;
		private System.Windows.Forms.TextBox txtMaMonHoc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
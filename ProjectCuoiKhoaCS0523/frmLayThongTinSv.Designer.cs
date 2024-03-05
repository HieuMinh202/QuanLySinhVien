namespace ProjectCuoiKhoaCS0523
{
	partial class frmLayThongTinSv
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
			this.cboKhoa = new System.Windows.Forms.ComboBox();
			this.txtTuKhoa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gridChonSVdiemThi = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridChonSVdiemThi)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnTimKiem);
			this.groupBox1.Controls.Add(this.cboKhoa);
			this.groupBox1.Controls.Add(this.txtTuKhoa);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(567, 53);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chi tiết tìm kiếm";
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.search;
			this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimKiem.Location = new System.Drawing.Point(486, 20);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
			this.btnTimKiem.TabIndex = 3;
			this.btnTimKiem.Text = "Tìm";
			this.btnTimKiem.UseVisualStyleBackColor = true;
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// cboKhoa
			// 
			this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboKhoa.FormattingEnabled = true;
			this.cboKhoa.Location = new System.Drawing.Point(313, 21);
			this.cboKhoa.Name = "cboKhoa";
			this.cboKhoa.Size = new System.Drawing.Size(167, 21);
			this.cboKhoa.TabIndex = 2;
			// 
			// txtTuKhoa
			// 
			this.txtTuKhoa.Location = new System.Drawing.Point(68, 21);
			this.txtTuKhoa.Name = "txtTuKhoa";
			this.txtTuKhoa.Size = new System.Drawing.Size(171, 20);
			this.txtTuKhoa.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(245, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Chọn khoa:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ khóa:";
			// 
			// gridChonSVdiemThi
			// 
			this.gridChonSVdiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridChonSVdiemThi.Location = new System.Drawing.Point(13, 60);
			this.gridChonSVdiemThi.Name = "gridChonSVdiemThi";
			this.gridChonSVdiemThi.Size = new System.Drawing.Size(567, 240);
			this.gridChonSVdiemThi.TabIndex = 1;
			this.gridChonSVdiemThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChonSVdiemThi_CellContentClick);
			// 
			// frmLayThongTinSv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 305);
			this.Controls.Add(this.gridChonSVdiemThi);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmLayThongTinSv";
			this.Text = "Lấy thông tin sinh viên";
			this.Load += new System.EventHandler(this.frmChonSVdiemThi_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridChonSVdiemThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView gridChonSVdiemThi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.ComboBox cboKhoa;
		private System.Windows.Forms.TextBox txtTuKhoa;
		private System.Windows.Forms.Label label2;
	}
}
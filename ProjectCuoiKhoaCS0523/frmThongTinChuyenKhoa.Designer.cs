namespace ProjectCuoiKhoaCS0523
{
	partial class frmThongTinChuyenKhoa
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
			this.gridChuyenKhoa = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridChuyenKhoa)).BeginInit();
			this.SuspendLayout();
			// 
			// gridChuyenKhoa
			// 
			this.gridChuyenKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridChuyenKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridChuyenKhoa.Location = new System.Drawing.Point(0, 0);
			this.gridChuyenKhoa.Name = "gridChuyenKhoa";
			this.gridChuyenKhoa.Size = new System.Drawing.Size(344, 302);
			this.gridChuyenKhoa.TabIndex = 0;
			// 
			// frmThongTinChuyenKhoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 302);
			this.Controls.Add(this.gridChuyenKhoa);
			this.Name = "frmThongTinChuyenKhoa";
			this.Text = "Thông tin chuyên khoa";
			this.Load += new System.EventHandler(this.frmThongTinChuyenKhoa_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridChuyenKhoa)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridChuyenKhoa;
	}
}
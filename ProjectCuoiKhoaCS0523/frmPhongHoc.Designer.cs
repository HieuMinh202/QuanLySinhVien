namespace ProjectCuoiKhoaCS0523
{
	partial class frmPhongHoc
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
			this.gridPhongHoc = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.gridPhongHoc)).BeginInit();
			this.SuspendLayout();
			// 
			// gridPhongHoc
			// 
			this.gridPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridPhongHoc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridPhongHoc.Location = new System.Drawing.Point(0, 0);
			this.gridPhongHoc.Name = "gridPhongHoc";
			this.gridPhongHoc.Size = new System.Drawing.Size(643, 242);
			this.gridPhongHoc.TabIndex = 0;
			// 
			// frmPhongHoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 242);
			this.Controls.Add(this.gridPhongHoc);
			this.Name = "frmPhongHoc";
			this.Text = "Phòng Học";
			this.Load += new System.EventHandler(this.frmPhongHoc_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPhongHoc)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridPhongHoc;
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCuoiKhoaCS0523
{
	public partial class frmMHadd : Form
	{
		public string MaMonHoc { get; set; } = "";
		public string TenMonHoc { get; set; } = "";

		public frmMHadd()
		{
			InitializeComponent();
		}

		private void frmMHadd_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(MaMonHoc))
			{
				this.Text = "Sửa thông tin môn Học";
				txtMaMonHoc.Text = MaMonHoc;
				txtTenMonHoc.Text = TenMonHoc;
			}
			else
			{
				this.Text = "Thêm mới thông tin môn Học";
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string maMH = "", tenMH = "";
			
			maMH = txtMaMonHoc.Text.Trim();
			tenMH = txtTenMonHoc.Text.Trim();
			
			MonHoc objMH = new MonHoc();

			errorProvider1.Clear();
			if (maMH.Length == 0)
			{
				errorProvider1.SetError(txtMaMonHoc, "Bạn cần phải nhập mã Môn Học");
				txtMaMonHoc.Focus();
				return;
			}
			if (tenMH.Length == 0)
			{
				errorProvider1.SetError(txtTenMonHoc, "Bạn cần phải nhập tên Môn Học");
				txtTenMonHoc.Focus();
				return;

			}
			objMH.MaMonHoc = maMH;
			objMH.TenMonHoc = tenMH;

			bool ketQua = false;
			
			if (!string.IsNullOrEmpty(MaMonHoc))
			{
				ketQua = DataProvider.MonHocBus.CapNhat(objMH);
			}
			else
			{
				ketQua = DataProvider.MonHocBus.ThemMoi(objMH);
			}
			if (ketQua)
			{
				MessageBox.Show("Cập nhật thông tin môn học thành công", "Thông báo");
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

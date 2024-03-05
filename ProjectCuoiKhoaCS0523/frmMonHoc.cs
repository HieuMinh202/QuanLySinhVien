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
	public partial class frmMonHoc : Form
	{
		public frmMonHoc()
		{
			InitializeComponent();
		}

		private void frmMonHoc_Load(object sender, EventArgs e)
		{
			HienThiDanhSachMonHoc();
		}

		private void HienThiDanhSachMonHoc()
		{
			MonHocBusiness monHocBusiness = new MonHocBusiness();

			DataTable dtMH = monHocBusiness.LayDanhSach();

			gridMonHoc.DataSource = dtMH;
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			frmMHadd mHadd = new frmMHadd();
			mHadd.ShowDialog();
			HienThiDanhSachMonHoc();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string maMH = "", tenMH = "";

			maMH = "" + gridMonHoc.CurrentRow.Cells[0].Value;
			tenMH = "" + gridMonHoc.CurrentRow.Cells[1].Value;

			frmMHadd frmSua = new frmMHadd();

			frmSua.MaMonHoc = maMH;
			frmSua.TenMonHoc = tenMH;

			frmSua.ShowDialog();
			HienThiDanhSachMonHoc();
		}

		private void Xóa_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
			{
				string maMH = "";
				maMH = "" + gridMonHoc.CurrentRow.Cells[0].Value;
				bool ketqua = DataProvider.MonHocBus.Xoa(maMH);
				if (ketqua)
				{
					HienThiDanhSachMonHoc();
				}
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

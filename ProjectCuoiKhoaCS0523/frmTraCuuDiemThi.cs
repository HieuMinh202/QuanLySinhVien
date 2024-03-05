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
	public partial class frmTraCuuDiemThi : Form
	{
		public frmTraCuuDiemThi()
		{
			InitializeComponent();
		}

		private void frmTraCuuDiemThi_Load(object sender, EventArgs e)
		{
			HienThiDanhSachMonThi();
			HienThiDanhSachDiemThi();
		}
		
		private void HienThiDanhSachMonThi()
		{
			MonHocBusiness monHocBus = new MonHocBusiness();

			DataTable dtMon = monHocBus.LayDanhSach();

			DataRow root = dtMon.NewRow();

			root[0] = "";
			root[1] = "--Chọn Môn--";
			dtMon.Rows.InsertAt(root, 0);

			cboMon.DisplayMember = "TenMonHoc";
			cboMon.ValueMember = "MaMonHoc";
			cboMon.DataSource = dtMon;
		}
		private void HienThiDanhSachDiemThi()
		{
			string tuKhoa = "", maMH = "";

			tuKhoa = txtTuKhoa.Text.Trim();
			maMH = "" + cboMon.SelectedValue;

			DiemThiBusiness diemBusiness = new DiemThiBusiness();

			DataTable dtDT = diemBusiness.TraCuuDiemThi(tuKhoa, maMH);

			gridTraCuuDiemThi.DataSource = dtDT;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			frmNhapDiemThi frmThem = new frmNhapDiemThi();
			frmThem.ShowDialog();
			HienThiDanhSachDiemThi();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string maSV = "", monThi = "";

			maSV = "" + gridTraCuuDiemThi.CurrentRow.Cells[0].Value;
			monThi = "" + gridTraCuuDiemThi.CurrentRow.Cells[0].Value;

			frmNhapDiemThi frmSua = new frmNhapDiemThi();
			 
			
			frmSua.MaSV = maSV;
			frmSua.MaMT = monThi;
			frmSua.ShowDialog();
			HienThiDanhSachDiemThi();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dr == DialogResult.Yes)
			{
				string maSV = "", maMT = "";
				maSV = "" + gridTraCuuDiemThi.CurrentRow.Cells[0].Value;
				maMT = "" + gridTraCuuDiemThi.CurrentRow.Cells[0].Value;

				bool ketQua = DataProvider.DiemThiBus.Xoa(maSV, maMT);

				if (ketQua)
				{
					HienThiDanhSachDiemThi();
				}
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			HienThiDanhSachDiemThi();
		}
	}
}

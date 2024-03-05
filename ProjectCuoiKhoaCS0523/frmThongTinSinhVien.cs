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
	public partial class frmThongTinSinhVien : Form
	{
		public frmThongTinSinhVien()
		{
			InitializeComponent();
		}

		private void frmThongTinSinhVien_Load(object sender, EventArgs e)
		{
			HienThiDanhSachSinhVien();
			HienThiDanhSachKhoa();
		}

		private void HienThiDanhSachKhoa()
		{
			ChuyenKhoaBusiness chuyenKhoaBusiness = new ChuyenKhoaBusiness();

			DataTable dtKhoa = chuyenKhoaBusiness.LayDanhSach();

			DataRow root = dtKhoa.NewRow();

			root[0] = "";
			root[1] = "---Chọn khoa---";
			dtKhoa.Rows.InsertAt(root, 0);

			cboKhoa.DisplayMember = "TenKhoa";
			cboKhoa.ValueMember = "MaKhoa";
			cboKhoa.DataSource = dtKhoa;
		}


		private void HienThiDanhSachSinhVien()
		{
			string maSV = "", khoa = "";

			maSV = txtMaSV.Text.Trim();
			khoa = "" + cboKhoa.SelectedValue;

			SinhVienBusiness sinhVienBusiness = new SinhVienBusiness();

			DataTable dtSV = sinhVienBusiness.TimKiemSinhVien(maSV, khoa);

			gridThongTinSinhVien.DataSource = dtSV;
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			HienThiDanhSachSinhVien();
		}

		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			SinhVienAdd frmThem = new SinhVienAdd();

			frmThem.ShowDialog();

			HienThiDanhSachSinhVien();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string maSV = "";

			maSV = "" + gridThongTinSinhVien.CurrentRow.Cells[0].Value;
			SinhVienAdd frmSua = new SinhVienAdd();

			frmSua.MaSinhVien = maSV;
			frmSua.ShowDialog();

			HienThiDanhSachSinhVien();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dr == DialogResult.Yes)
			{
				string maSV = "";

				maSV = "" + gridThongTinSinhVien.CurrentRow.Cells[0].Value;

				bool ketQua = DataProvider.SinhVienBus.Xoa(maSV);

				if (ketQua)
				{
					HienThiDanhSachSinhVien();
				}
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

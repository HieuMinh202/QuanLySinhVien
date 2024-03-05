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
	public partial class frmNhapDiemThi : Form
	{
		public string MaSV { get; set; } = "";
		public string MaMT { get; set; } = "";
		public float DiemThi { get; set; } = 0;

		public frmNhapDiemThi()
		{
			InitializeComponent();
		}

		private void frmNhapDiemThi_Load(object sender, EventArgs e)
		{
			HienThiDanhSachMonThi();
			HienThiDanhSachPhongThi();
			if (!string.IsNullOrEmpty(MaSV))
			{
				this.Text = "Sửa thông tin điểm thi";
				HienThiChiTiet();
			}
			else
			{
				this.Text = "Thêm mới điểm thi";

			}
		}
		public void HienThiChiTiet()
		{
			Diemthi objDT = DataProvider.DiemThiBus.LayChiTietTheoMa(MaSV, MaMT);
			SinhVien objSV = DataProvider.SinhVienBus.LayChiTietTheoMa(MaSV);

			if (objDT != null && objSV != null)
			{
				txtMaSV.Text = objDT.SinhVienId;
				txtTenSV.Text = objSV.HoTen;
				txtDiem.Text = "" + objDT.DiemThi;
				cboMonThi.SelectedValue = objDT.MonHocId;
				cboPhongThi.SelectedValue = objDT.PhongHocId;
				dtpNgayThi.Value = objDT.NgayThi;
			}
		}

		private void HienThiDanhSachMonThi()
		{
			MonHocBusiness monHocBus = new MonHocBusiness();

			DataTable dtMT = monHocBus.LayDanhSach();

			cboMonThi.DisplayMember = "TenMonHoc";
			cboMonThi.ValueMember = "MaMonHoc";
			cboMonThi.DataSource = dtMT;
		}
		private void HienThiDanhSachPhongThi()
		{
			PhongHocBusiness phongHocBus = new PhongHocBusiness();

			DataTable dtPT = phongHocBus.LayDanhSach();

			cboPhongThi.DisplayMember = "TenPhong";
			cboPhongThi.ValueMember = "MaPhong";
			cboPhongThi.DataSource = dtPT;
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string maSV = "", tenSV = "";
			float diemThi;

			Diemthi objDT = new Diemthi();

			maSV = txtMaSV.Text;
			tenSV = txtTenSV.Text;

			errorProvider1.Clear();

			if (maSV.Length == 0)
			{
				errorProvider1.SetError(txtMaSV, "Bạn cần phải nhập mã sinh viên");
				txtMaSV.Focus();
				return;
			}

			if (tenSV.Length == 0)
			{
				errorProvider1.SetError(txtTenSV, "Bạn cần phải nhập tên sinh viên");
				txtTenSV.Focus();
				return;
			}
			
			objDT.SinhVienId = txtMaSV.Text.Trim();
			objDT.MonHocId = "" + cboMonThi.SelectedValue;
			objDT.PhongHocId = "" + cboPhongThi.SelectedValue;
			objDT.NgayThi = dtpNgayThi.Value;
			float.TryParse(txtDiem.Text.Trim(), out diemThi);
			objDT.DiemThi = diemThi;

			bool ketQua = false;
			if (!string.IsNullOrEmpty(MaSV))
			{
				ketQua = DataProvider.DiemThiBus.CapNhat(objDT);
			}
			else
			{
				ketQua = DataProvider.DiemThiBus.ThemMoi(objDT);
			}
			if (ketQua)
			{
				MessageBox.Show("Cập nhật điểm thi thành công", "Thông báo");
			}
		}

		private void btnLink_Click(object sender, EventArgs e)
		{
			frmLayThongTinSv frmCSV = new frmLayThongTinSv();
			frmCSV.ShowDialog();

			txtMaSV.Text = frmCSV.maSV.ToString();
			txtTenSV.Text = frmCSV.hoTen.ToString();
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

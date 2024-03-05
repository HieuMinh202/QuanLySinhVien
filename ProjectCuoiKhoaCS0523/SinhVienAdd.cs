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
	public partial class SinhVienAdd : Form
	{
		public string MaSinhVien { get; set; } = "";

		public SinhVienAdd()
		{
			InitializeComponent();
		}

		private void SinhVienAdd_Load(object sender, EventArgs e)
		{
			HienThiDanhSachKhoa();

			if (!string.IsNullOrEmpty(MaSinhVien))
			{
				this.Text = "Sửa thông tin sinh viên";

				txtMaSV.Text = MaSinhVien;
				txtMaSV.ReadOnly = true;
				HienThiChiTiet();
			}
			else
			{
				this.Text = "Thêm mới thông tin sinh viên";
			}
		}

		private void HienThiDanhSachKhoa()
		{
			ChuyenKhoaBusiness chuyenKhoaBusiness = new ChuyenKhoaBusiness();

			DataTable dtKhoa = chuyenKhoaBusiness.LayDanhSach();

			cboKhoa.DisplayMember = "TenKhoa";
			cboKhoa.ValueMember = "MaKhoa";
			cboKhoa.DataSource = dtKhoa;
		}

		private void HienThiChiTiet()
		{
			SinhVien objSV = DataProvider.SinhVienBus.LayChiTietTheoMa(MaSinhVien);

			if (objSV != null)
			{
				txtHoTen.Text = objSV.HoTen;
				txtDienThoai.Text = objSV.DienThoai;
				txtEmail.Text = objSV.Email;
				txtDiaChi.Text = objSV.DiaChi;

				if (objSV.GioiTinh == 1)
				{
					rbtnNu.Checked = true;
				}
				else
				{
					rbtnNam.Checked = true;
				}

				dtpNgaySinh.Value = objSV.NgaySinh;

				cboKhoa.SelectedValue = objSV.ChuyenKhoaId;
			}
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string maSV = "", hoTen = "", chuyenKhoaId = "";

			int gioiTinh = 0;

			SinhVien objSV = new SinhVien();

			maSV = txtMaSV.Text.Trim();
			hoTen = txtHoTen.Text.Trim();
			chuyenKhoaId = "" + cboKhoa.SelectedValue;

			errorProvider1.Clear();

			if (maSV.Length == 0)
			{
				errorProvider1.SetError(txtMaSV, "Bạn cần phải nhập mã sinh viên");
				txtMaSV.Focus();
				return;
			}

			if (hoTen.Length == 0)
			{
				errorProvider1.SetError(txtHoTen, "Bạn cần phải nhập họ tên sinh viên");
				txtHoTen.Focus();
				return;
			}

			objSV.MaSV = maSV;
			objSV.HoTen = hoTen;
			objSV.DienThoai = txtDienThoai.Text;
			objSV.Email = txtEmail.Text;
			objSV.DiaChi = txtDiaChi.Text;

			if (rbtnNu.Checked)
			{
				gioiTinh = 1;
			}
			else
			{
				gioiTinh = 0;
			}

			objSV.GioiTinh = gioiTinh;
			objSV.NgaySinh = dtpNgaySinh.Value;
			objSV.ChuyenKhoaId = chuyenKhoaId;


			bool ketQua = false;

			if (!string.IsNullOrEmpty(MaSinhVien))
			{
				ketQua = DataProvider.SinhVienBus.CapNhat(objSV);
			}
			else
			{
				ketQua = DataProvider.SinhVienBus.ThemMoi(objSV);
			}

			if (ketQua)
			{
				MessageBox.Show("Cập nhật thông tin sinh viên thành công", "Thông báo");
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

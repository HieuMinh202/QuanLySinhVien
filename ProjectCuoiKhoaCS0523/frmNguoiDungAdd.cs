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
	public partial class frmNguoiDungAdd : Form
	{
		public int Id { get; set; }
		public string TenDangNhap { get; set; } = "";
		public string MatKhau { get; set; } = "";
		public string HoTen { get; set; } = "";
		public string DienThoai { get; set; } = "";
		public string Email { get; set; } = "";
		public string DiaChi { get; set; } = "";
		public string VaiTro { get; set; } = "";
		public frmNguoiDungAdd()
		{
			InitializeComponent();
		}

		private void frmNguoiDungAdd_Load(object sender, EventArgs e)
		{
			HienThiDanhSachVaiTro();
			HienThiDanhSachNguoiDung();
			HienThiChiTiet();
			if (!string.IsNullOrEmpty(TenDangNhap))
			{
				this.Text = "Sửa thông tin người dùng";

				txtTenDangNhap.Text = TenDangNhap;
				txtTenDangNhap.ReadOnly = true;
				HienThiChiTiet();
			}
			else
			{
				this.Text = "Thêm mới thông tin người dùng";
			}
		}
		private void HienThiDanhSachVaiTro()
		{
			VaiTroBusiness vaiTroBus = new VaiTroBusiness();

			DataTable dtVT = vaiTroBus.LayDanhSachVT();

			DataRow root = dtVT.NewRow();

			root[0] = "";
			root[1] = "---Chọn Vai Trò---";
			dtVT.Rows.InsertAt(root, 0);

			cboVaiTro.DisplayMember = "TenVaiTro";
			cboVaiTro.ValueMember = "MaVaiTro";
			cboVaiTro.DataSource = dtVT;
		}

		private void HienThiChiTiet()
		{
			NguoiDung objND = DataProvider.NguoiDungBus.LayChiTietTheoTenDN(TenDangNhap);

			if (objND != null)
			{
				txtTenDangNhap.Text = objND.TenDangNhap;
				txtMatKhau.Text = objND.MatKhau;
				txtHoTen.Text = objND.HoTen;
				txtDienThoai.Text = objND.DienThoai;
				txtEmail.Text = objND.Email;
				txtDiaChi.Text = objND.DiaChi;

				
				cboVaiTro.SelectedValue = objND.VaiTro;
			}
		}
		private void HienThiDanhSachNguoiDung()
		{
			NguoiDungBussines nguoiDungBusiness = new NguoiDungBussines();

			DataTable dtND = nguoiDungBusiness.LayDanhSachND();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			string tenDangNhap = "", matKhau = "", hoTen = "";
			int Id = 0;

			NguoiDung objND = new NguoiDung();
			 
			tenDangNhap = txtTenDangNhap.Text;
			matKhau = txtMatKhau.Text;
			hoTen = txtHoTen.Text;

			errorProvider1.Clear();

			if (tenDangNhap.Length == 0)
			{
				errorProvider1.SetError(txtTenDangNhap, "Bạn cần phải nhập tên đăng nhập");
				txtTenDangNhap.Focus();
				return;
			}

			if (matKhau.Length == 0)
			{
				errorProvider1.SetError(txtMatKhau, "Bạn cần phải nhập mật khẩu");
				txtMatKhau.Focus();
				return;
			}
			if (hoTen.Length == 0)
			{
				errorProvider1.SetError(txtHoTen, "Bạn cần phải nhập họ tên người dùng");
				txtHoTen.Focus();
				return;
			}

			objND.Id = Id;
			objND.TenDangNhap = tenDangNhap;
			objND.MatKhau = matKhau;
			objND.HoTen = hoTen;
			objND.DienThoai = txtDienThoai.Text;
			objND.Email = txtEmail.Text;
			objND.DiaChi = txtDiaChi.Text;
			objND.VaiTro = "" + cboVaiTro.SelectedValue;

			bool ketQua = false;

			if (Id >0)
			{
				ketQua = DataProvider.NguoiDungBus.CapNhat(objND);
			}
			else
			{
				ketQua = DataProvider.NguoiDungBus.ThemMoi(objND);
			}

			if (ketQua)
			{
				MessageBox.Show("Cập nhật thông tin người dùng thành công", "Thông báo");
			}
		}
		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

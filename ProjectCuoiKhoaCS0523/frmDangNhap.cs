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
	public partial class frmDangNhap : Form
	{
		public bool isSuccessLogin { get; set; } = false;

		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			string tenDangNhap = "", matKhau = "";

			tenDangNhap = txtTenDangNhap.Text.Trim();
			matKhau = txtMatKhau.Text;

			#region Xử lý kiểm tra nhập thông tin
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

			#endregion

			NguoiDungBussines bus = new NguoiDungBussines();

			NguoiDung objUser = bus.KiemTraDangNhap(tenDangNhap);

			if (objUser != null)
			{
				string matKhauDb = objUser.MatKhau;

				if (matKhau == matKhauDb)
				{
					isSuccessLogin = true;

					frmQuanLySinhVien.UserId = objUser.Id;
					frmQuanLySinhVien.UserName = objUser.HoTen;

					this.Close();
				}
				else
				{
					MessageBox.Show("Sai mật khẩu", "Thông báo");
					txtMatKhau.Focus();
				}
			}
			else
			{
				MessageBox.Show("Tài khoản không tồn tại.", "Thông báo");
				txtTenDangNhap.Focus();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			isSuccessLogin = false;
			this.Close();
		}
	}
}

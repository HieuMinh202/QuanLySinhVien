using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class NguoiDung
	{
		public NguoiDung()
		{
			DiaChi = "";
		}

		public NguoiDung(string DiaChi)
		{
			this.DiaChi = DiaChi;
		}

		public NguoiDung( string TenDangNhap, string MatKhau, string HoTen, string DienThoai, string Email, string DiaChi, string VaiTro)
		{
			this.TenDangNhap = TenDangNhap;
			this.MatKhau = MatKhau;
			this.HoTen = HoTen;
			this.DienThoai = DienThoai;
			this.Email = Email;
			this.DiaChi = DiaChi;
			this.VaiTro = VaiTro;
		}
		public int Id { get; set; }
		public string TenDangNhap { get; set; }
		public string MatKhau { get; set; }
		public string HoTen { get; set; }
		public string DienThoai { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }
		public string VaiTro { get; set; }
	}
}

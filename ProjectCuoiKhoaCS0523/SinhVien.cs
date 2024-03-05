using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class SinhVien
	{
		public SinhVien()
		{
			DiaChi = "Hà Nội";
		}
		public SinhVien(string DiaChi)
		{
			this.DiaChi = DiaChi;
		}

		public SinhVien(string MaSV, string HoTen, string DienThoai, string Email, string DiaChi)
		{
			this.MaSV = MaSV;
			this.HoTen = HoTen;
			this.DienThoai = DienThoai;
			this.Email = Email;
			this.DiaChi = DiaChi;
		}

		public string MaSV { get; set; }

		public string HoTen { get; set; }

		public int GioiTinh { get; set; }

		public DateTime NgaySinh { get; set; }

		public string DienThoai { get; set; }

		public string Email { get; set; }

		public string DiaChi { get; set; }

		public string ChuyenKhoaId { get; set; }
	}
}

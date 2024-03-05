using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class Diemthi
	{
		public string SinhVienId { get; set; }
		public string MonHocId { get; set; }
		public DateTime NgayThi { get; set; }
		public float DiemThi { get; set; }
		public string PhongHocId { get; set; }

		public Diemthi()
		{
			this.PhongHocId = "";
		}

		public Diemthi(string SinhVienId, string MonHocId, DateTime NgayThi, float DiemThi, string PhongHocId)
		{
			this.SinhVienId = SinhVienId;
			this.MonHocId = MonHocId;
			this.NgayThi = NgayThi;
			this.DiemThi = DiemThi;
			this.PhongHocId = PhongHocId;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectCuoiKhoaCS0523
{
	public class SinhVienBusiness
	{
		List<SinhVien> lstSinhVien = new List<SinhVien>();

		public DataTable LayDanhSach()
		{
			string strSQL = "Select MaSV, HoTen, DienThoai, Email, DiaChi from SinhVien";

			return DataProvider.LayDanhSach(strSQL);
		}

		public DataTable TimKiemSinhVien(string tuKhoa, string chuyenKhoaId)
		{
			string strSQL = "Select MaSV, HoTen, DienThoai, Email, DiaChi from SinhVien where 1=1";

			if (!string.IsNullOrEmpty(tuKhoa))
			{
				strSQL += string.Format(" AND (MaSV = '{0}' OR HoTen like N'%{0}%' OR DienThoai like '%{0}%' OR Email like '%{0}%')", tuKhoa);
			}

			if (!string.IsNullOrEmpty(chuyenKhoaId))
			{
				strSQL += string.Format(" AND ChuyenKhoaId = '{0}'", chuyenKhoaId);
			}

			return DataProvider.LayDanhSach(strSQL);
		}

		public SinhVien LayChiTietTheoMa(string maSV)
		{
			SinhVien objSV = null;

			string strSQL = "Select * from SinhVien where MaSV = '" + maSV + "'";

			DataTable dtSV = DataProvider.LayDanhSach(strSQL);

			if (dtSV != null && dtSV.Rows.Count > 0)
			{
				objSV = new SinhVien();

				objSV.MaSV = "" + dtSV.Rows[0]["MaSV"];
				objSV.HoTen = "" + dtSV.Rows[0]["HoTen"];
				objSV.DienThoai = "" + dtSV.Rows[0]["DienThoai"];
				objSV.Email = "" + dtSV.Rows[0]["Email"];
				objSV.DiaChi = "" + dtSV.Rows[0]["DiaChi"];

				int gioiTinh = 0;
				int.TryParse("" + dtSV.Rows[0]["GioiTinh"], out gioiTinh);
				objSV.GioiTinh = gioiTinh;

				DateTime ngaySinh;
				DateTime.TryParse("" + dtSV.Rows[0]["NgaySinh"], out ngaySinh);
				objSV.NgaySinh = ngaySinh;

				objSV.ChuyenKhoaId = "" + dtSV.Rows[0]["ChuyenKhoaId"];
			}

			return objSV;
		}

		public bool ThemMoi(SinhVien objSV)
		{
			string strInsert = "Insert into SinhVien( MaSV, HoTen, GioiTinh, NgaySinh, DienThoai, Email, DiaChi, ChuyenKhoaId) values(@MaSV, @HoTen, @GioiTinh, @NgaySinh, @DienThoai, @Email, @DiaChi, @ChuyenKhoaId)";

			SqlParameter[] pars = new SqlParameter[8];

			pars[0] = new SqlParameter("@MaSV", SqlDbType.VarChar, 10);
			pars[0].Value = objSV.MaSV;

			pars[1] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
			pars[1].Value = objSV.HoTen;

			pars[2] = new SqlParameter("@GioiTinh", SqlDbType.Int);
			pars[2].Value = objSV.GioiTinh;

			pars[3] = new SqlParameter("@NgaySinh", SqlDbType.Date);
			pars[3].Value = objSV.NgaySinh;

			pars[4] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
			pars[4].Value = objSV.DienThoai;

			pars[5] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
			pars[5].Value = objSV.Email;

			pars[6] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 250);
			pars[6].Value = objSV.DiaChi;

			pars[7] = new SqlParameter("@ChuyenKhoaId", SqlDbType.VarChar, 10);
			pars[7].Value = objSV.ChuyenKhoaId;

			return DataProvider.ThucHien(strInsert, pars);
		}

		public bool CapNhat(SinhVien objSV)
		{
			string strUpdate = "Update SinhVien set HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, DienThoai=@DienThoai, Email = @Email, DiaChi = @DiaChi, ChuyenKhoaId = @ChuyenKhoaId where MaSV = @MaSV";

			SqlParameter[] pars = new SqlParameter[8];

			pars[0] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
			pars[0].Value = objSV.HoTen;

			pars[1] = new SqlParameter("@GioiTinh", SqlDbType.Int);
			pars[1].Value = objSV.GioiTinh;

			pars[2] = new SqlParameter("@NgaySinh", SqlDbType.Date);
			pars[2].Value = objSV.NgaySinh;

			pars[3] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
			pars[3].Value = objSV.DienThoai;

			pars[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
			pars[4].Value = objSV.Email;

			pars[5] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 250);
			pars[5].Value = objSV.DiaChi;

			pars[6] = new SqlParameter("@ChuyenKhoaId", SqlDbType.VarChar, 10);
			pars[6].Value = objSV.ChuyenKhoaId;

			pars[7] = new SqlParameter("@MaSV", SqlDbType.VarChar, 10);
			pars[7].Value = objSV.MaSV;

			return DataProvider.ThucHien(strUpdate, pars);
		}

		public bool Xoa(string MaSV)
		{
			string strDelete = "Delete from SinhVien where MaSV = @MaSV";

			SqlParameter[] pars = new SqlParameter[1];

			pars[0] = new SqlParameter("@MaSV", SqlDbType.VarChar, 10);
			pars[0].Value = MaSV;

			return DataProvider.ThucHien(strDelete, pars);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class DiemThiBusiness
	{
		public DataTable TraCuuDiemThi(string tuKhoa, string maMH)
		{
			string strSQL = "Select MaSV, HoTen, DiaChi, NgayThi, DiemThi, TenMonHoc, TenPhong from SinhVien, DiemThi, MonHoc,PhongHoc where SinhVien.MaSV = DiemThi.SinhVienId And DiemThi.MonHocId=MonHoc.MaMonHoc And DiemThi.PhongHocId = PhongHoc.MaPhong";
			if (!string.IsNullOrEmpty(tuKhoa))
			{
				strSQL += string.Format(" AND (MaSV = '{0}' OR HoTen like N'%{0}%' OR DienThoai like '%{0}%' OR Email like '%{0}%' OR DiaChi like N'%{0}%')", tuKhoa);

			}
			//if (!string.IsNullOrEmpty(tuKhoa))
			//{
			//	strSQL += string.Format(" AND MaSV = '{0}'", tuKhoa);
			//}
			if (!string.IsNullOrEmpty(maMH))
			{
				strSQL += string.Format(" AND MaMonHoc = '{0}'", maMH);
			}
			return DataProvider.LayDanhSach(strSQL);
		}

		public DataTable LayDanhSach()
		{
			string strSQL = "Select MaSV, HoTen, DiaChi, NgayThi, DiemThi, TenMonHoc, TenPhong from SinhVien, DiemThi, MonHoc,PhongHoc where SinhVien.MaSV = DiemThi.SinhVienId And DiemThi.MonHocId=MonHoc.MaMonHoc And DiemThi.PhongHocId = PhongHoc.MaPhong";
			return DataProvider.LayDanhSach(strSQL);
		}

		public bool ThemMoi(Diemthi objDT)
		{
			string strInsert = "Insert into DiemThi (SinhVienId, MonHocId, NgayThi, DiemThi, PhongHocId) VALUES (@SinhVienId, @MonHocId, @NgayThi, @DiemThi, @PhongHocId)";

			SqlParameter[] pars = new SqlParameter[5];

			pars[0] = new SqlParameter("@SinhVienId", SqlDbType.VarChar, 10);
			pars[0].Value = objDT.SinhVienId;

			pars[1] = new SqlParameter("@MonHocId", SqlDbType.VarChar, 10);
			pars[1].Value = objDT.MonHocId;

			pars[2] = new SqlParameter("@NgayThi", SqlDbType.DateTime);
			pars[2].Value = objDT.NgayThi;

			pars[3] = new SqlParameter("@DiemThi", SqlDbType.Float);
			pars[3].Value = objDT.DiemThi;

			pars[4] = new SqlParameter("@PhongHocId", SqlDbType.VarChar, 10);
			pars[4].Value = objDT.PhongHocId;

			return DataProvider.ThucHien(strInsert, pars);
		}

		public bool CapNhat(Diemthi objDT)
		{
			string strUpdate = "UPDATE DiemThi SET NgayThi=@NgayThi, DiemThi=@DiemThi, PhongHocId=@PhongHocId where SinhVienId = @SinhVienId And MonHocId = @MonHocId";

			SqlParameter[] pars = new SqlParameter[5];

			pars[0] = new SqlParameter("@NgayThi", SqlDbType.DateTime);
			pars[0].Value = objDT.NgayThi;

			pars[1] = new SqlParameter("@DiemThi", SqlDbType.Float);
			pars[1].Value = objDT.DiemThi;

			pars[2] = new SqlParameter("@PhongHocId", SqlDbType.VarChar, 10);
			pars[2].Value = objDT.PhongHocId;

			pars[3] = new SqlParameter("@SinhVienId", SqlDbType.VarChar, 10);
			pars[3].Value = objDT.SinhVienId;

			pars[4] = new SqlParameter("@MonHocId", SqlDbType.VarChar, 10);
			pars[4].Value = objDT.MonHocId;



			return DataProvider.ThucHien(strUpdate, pars);
		}

		public bool Xoa(string maSV, string maMT)
		{
			string strDelete = "Delete from DiemThi where SinhVienId = @SinhVienId AND MonHocId = @MonHocId";

			SqlParameter[] pars = new SqlParameter[2];

			pars[0] = new SqlParameter("@SinhVienId", SqlDbType.VarChar, 10);
			pars[0].Value = maSV;

			pars[1] = new SqlParameter("@MonHocId", SqlDbType.VarChar, 10);
			pars[1].Value = maMT;

			return DataProvider.ThucHien(strDelete, pars);
		}

		public Diemthi LayChiTietTheoMa(string maSV, string maMT)
		{
			Diemthi objDiem = null;
			string strSQL = "Select * from DiemThi where SinhVienId = '" + maSV + "'" + " and MonHocId = ' " + maMT + "'";
			DataTable dtDiem = DataProvider.LayDanhSach(strSQL);
			if (dtDiem != null && dtDiem.Rows.Count > 0)
			{
				objDiem = new Diemthi();
				objDiem.SinhVienId = "" + dtDiem.Rows[0]["SinhVienId"];
				objDiem.MonHocId = "" + dtDiem.Rows[0]["MonHocId"];
				DateTime ngayThi;
				DateTime.TryParse(("" + dtDiem.Rows[0]["NgayThi"]), out ngayThi);
				objDiem.NgayThi = ngayThi;
				float diemThi;
				float.TryParse(("" + dtDiem.Rows[0]["DiemThi"]), out diemThi);
				objDiem.DiemThi = diemThi;
				objDiem.PhongHocId = "" + dtDiem.Rows[0]["PhongHocId"];
			}
			return objDiem;
		}
	} 
}

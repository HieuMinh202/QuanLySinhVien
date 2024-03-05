using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ProjectCuoiKhoaCS0523
{
	public class NguoiDungBussines
	{
		public DataTable LayDanhSachND()
		{
			string strSQL = "Select Id, TenDangNhap, HoTen, DienThoai, DiaChi, VaiTro from NguoiDung";

			return DataProvider.LayDanhSach(strSQL);
		}
		

		public NguoiDung LayChiTietTheoTenDN(string id)
		{
			NguoiDung objND = null;

			string strSQL = "Select * from NguoiDung where Id = '" + id + "'";

			DataTable dtND = DataProvider.LayDanhSach(strSQL);

			if (dtND != null && dtND.Rows.Count > 0)
			{
				objND = new NguoiDung();

				objND.TenDangNhap = "" + dtND.Rows[0]["TenDangNhap"];
				objND.MatKhau = "" + dtND.Rows[0]["MatKhau"];
				objND.HoTen = "" + dtND.Rows[0]["HoTen"];
				objND.DienThoai = "" + dtND.Rows[0]["DienThoai"];
				objND.Email = "" + dtND.Rows[0]["Email"];
				objND.DiaChi = "" + dtND.Rows[0]["DiaChi"];

				objND.VaiTro = "" + dtND.Rows[0]["VaiTro"];

			}

			return objND;
		}
		public NguoiDung KiemTraDangNhap(string userName)
		{
			NguoiDung objUser = null;

			string strSQL = "Select * from NguoiDung where TenDangNhap='" + userName + "'";

			DataTable dtUser = DataProvider.LayDanhSach(strSQL);

			if (dtUser != null && dtUser.Rows.Count > 0)
			{
				objUser = new NguoiDung();

				objUser.Id = int.Parse("" + dtUser.Rows[0]["Id"]);
				objUser.TenDangNhap = "" + dtUser.Rows[0]["TenDangNhap"];
				objUser.MatKhau = "" + dtUser.Rows[0]["MatKhau"];
				objUser.HoTen = "" + dtUser.Rows[0]["HoTen"];
				objUser.VaiTro = "" + dtUser.Rows[0]["VaiTro"];
			}

			return objUser;
		}
		public bool ThemMoi(NguoiDung objND)
		{
			string strInsert = "Insert into NguoiDung( TenDangNhap, MatKhau, HoTen, DienThoai, Email, DiaChi, VaiTro) values( @TenDangNhap, @MatKhau, @HoTen, @DienThoai, @Email, @DiaChi, @VaiTro)";

			SqlParameter[] pars = new SqlParameter[7];

			pars[0] = new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50);
			pars[0].Value = objND.TenDangNhap;

			pars[1] = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 50);
			pars[1].Value = objND.MatKhau;

			pars[2] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
			pars[2].Value = objND.HoTen;

			pars[3] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
			pars[3].Value = objND.DienThoai;

			pars[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
			pars[4].Value = objND.Email;

			pars[5] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 150);
			pars[5].Value = objND.DiaChi;

			pars[6] = new SqlParameter("@VaiTro", SqlDbType.VarChar, 10);
			pars[6].Value = objND.VaiTro;

			return DataProvider.ThucHien(strInsert, pars);
		}

		public bool CapNhat(NguoiDung objND)
		{
			string strUpdate = "Update NguoiDung Set TenDangNhap = @TenDangNhap, MatKhau = @MatKhau, HoTen=@HoTen, DienThoai = @DienThoai, Email=@Email, DiaChi=@DiaChi, VaiTro=@VaiTro where Id = @Id";

			SqlParameter[] pars = new SqlParameter[8];

			pars[0] = new SqlParameter("@TenDangNhap", SqlDbType.VarChar, 50);
			pars[0].Value = objND.TenDangNhap;

			pars[1] = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 50);
			pars[1].Value = objND.HoTen;

			pars[2] = new SqlParameter("@HoTen", SqlDbType.NVarChar, 30);
			pars[2].Value = objND.HoTen;

			pars[3] = new SqlParameter("@DienThoai", SqlDbType.VarChar, 20);
			pars[3].Value = objND.DienThoai;

			pars[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
			pars[4].Value = objND.Email;

			pars[5] = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 150);
			pars[5].Value = objND.DiaChi;

			pars[6] = new SqlParameter("@VaiTro", SqlDbType.VarChar, 10);
			pars[6].Value = objND.VaiTro;

			pars[7] = new SqlParameter("@Id", SqlDbType.Int);
			pars[7].Value = objND.Id;

			

			return DataProvider.ThucHien(strUpdate, pars);
		}

		public bool Xoa(string Id)
		{
			string strDelete = "Delete from NguoiDung where Id = @Id";

			SqlParameter[] pars = new SqlParameter[1];

			pars[0] = new SqlParameter("@Id", SqlDbType.Int);
			pars[0].Value = Id;

			return DataProvider.ThucHien(strDelete, pars);
		}
	}
}

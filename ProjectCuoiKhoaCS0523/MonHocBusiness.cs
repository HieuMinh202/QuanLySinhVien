using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class MonHocBusiness
	{
		public DataTable LayDanhSach()
		{
			string strSQL = "Select * from MonHoc";

			return DataProvider.LayDanhSach(strSQL);
		}

		public bool CapNhat(MonHoc objMh)
		{
			string strUpdate = "Update MonHoc set TenMonHoc = @TenMonHoc where MaMonHoc = @MaMonHoc";

			SqlParameter[] pars = new SqlParameter[2];
			
			pars[0] = new SqlParameter("@TenMonHoc", SqlDbType.NVarChar, 30);
			pars[0].Value = objMh.TenMonHoc;

			pars[1] = new SqlParameter("@MaMonHoc", SqlDbType.VarChar, 10);
			pars[1].Value = objMh.MaMonHoc;


			return DataProvider.ThucHien(strUpdate, pars);
		}
		public bool ThemMoi(MonHoc objMh)
		{
			string strInsert = "Insert into MonHoc( MaMonHoc, TenMonHoc) values(@MaMonHoc,@TenMonHoc)";

			SqlParameter[] pars = new SqlParameter[2];

			pars[0] = new SqlParameter("@MaMonHoc", SqlDbType.VarChar, 10);
			pars[0].Value = objMh.MaMonHoc;

			pars[1] = new SqlParameter("@TenMonHoc", SqlDbType.NVarChar, 30);
			pars[1].Value = objMh.TenMonHoc;

			return DataProvider.ThucHien(strInsert, pars);
		}
		public bool Xoa(string MaMonHoc)
		{
			string strDelete = "Delete from MonHoc where MaMonHoc = @MaMonHoc";
			SqlParameter[] pars = new SqlParameter[1];
			pars[0] = new SqlParameter("@MaMonHoc", SqlDbType.VarChar, 10);
			pars[0].Value = MaMonHoc;

			return DataProvider.ThucHien(strDelete, pars);
		}
	}
}

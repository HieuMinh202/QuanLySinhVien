using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectCuoiKhoaCS0523
{
	public class DataProvider
	{
		private static SinhVienBusiness _SinhVienBus = null;

		public static SinhVienBusiness SinhVienBus
		{
			get
			{
				if (_SinhVienBus == null)
				{
					_SinhVienBus = new SinhVienBusiness();
				}

				return _SinhVienBus;
			}
		}

		private static NguoiDungBussines _NguoiDungBus = null;

		public static NguoiDungBussines NguoiDungBus
		{
			get
			{
				if (_NguoiDungBus == null)
				{
					_NguoiDungBus = new NguoiDungBussines();
				}

				return _NguoiDungBus;
			}
		}
		private static MonHocBusiness _MonHocBus = null;
		public static MonHocBusiness MonHocBus
		{
			get
			{
				if (_MonHocBus == null)
				{
					_MonHocBus = new MonHocBusiness();
				}
				return _MonHocBus;
			}
		}
		private static PhongHocBusiness _PhongHoc = null;
		public static PhongHocBusiness PhongHocBus
		{
			get
			{
				if (_PhongHoc == null)
				{
					_PhongHoc = new PhongHocBusiness();
				}
				return _PhongHoc;
			}
		}


		private static DiemThiBusiness _DiemThi = null;
		public static DiemThiBusiness DiemThiBus
		{
			get
			{
				if (_DiemThi == null)
				{
					_DiemThi = new DiemThiBusiness();
				}
				return _DiemThi;
			}
		}

		private static VaiTroBusiness _VaiTro = null;
		public static VaiTroBusiness VaiTroBus
		{
			get
			{
				if (_VaiTro == null)
				{
					_VaiTro = new VaiTroBusiness();
				}
				return _VaiTro;
			}
		}

		private const string _ConnectString = "Server=HieuMinh\\SQLEXPRESS; Database=ProjectCuoiKhoaCS0523; Integrated Security=true;";

		public static string ConnectString
		{
			get
			{
				return _ConnectString;
			}
		}
		public static DataTable LayDanhSach(string strSQL)
		{
			DataTable dt = new DataTable();

			SqlConnection conn = null;

			try
			{
				conn = new SqlConnection(ConnectString);

				conn.Open();

				SqlCommand comm = new SqlCommand();
				comm.Connection = conn;
				comm.CommandType = CommandType.Text;
				comm.CommandText = strSQL;

				SqlDataAdapter adapter = new SqlDataAdapter(comm);

				adapter.Fill(dt);

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				conn.Close();
			}

			return dt;
		}

		public static bool ThucHien(string strSQL, SqlParameter[] pars)
		{
			bool ketQua = false;

			SqlConnection conn = null;

			try
			{
				conn = new SqlConnection(ConnectString);

				conn.Open();

				SqlCommand comm = new SqlCommand();
				comm.Connection = conn;
				comm.CommandType = CommandType.Text;
				comm.CommandText = strSQL;

				if (pars != null && pars.Length > 0)
				{
					comm.Parameters.AddRange(pars);
				}

				ketQua = comm.ExecuteNonQuery() > 0;

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				conn.Close();
			}
			return ketQua;
		}
	}
}

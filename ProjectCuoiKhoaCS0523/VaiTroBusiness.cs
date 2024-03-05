using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class VaiTroBusiness
	{
		public DataTable LayDanhSachVT()
		{
			string strSQL = "Select * from VaiTro";

			return DataProvider.LayDanhSach(strSQL);
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class PhongHocBusiness
	{
		public DataTable LayDanhSach()
		{
			string strSQL = "Select * from PhongHoc";

			return DataProvider.LayDanhSach(strSQL);
		}
	}
}

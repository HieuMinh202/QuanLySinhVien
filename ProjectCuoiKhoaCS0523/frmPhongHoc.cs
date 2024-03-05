using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCuoiKhoaCS0523
{
	public partial class frmPhongHoc : Form
	{
		public frmPhongHoc()
		{
			InitializeComponent();
		}

		private void frmPhongHoc_Load(object sender, EventArgs e)
		{
			HienThiDanhSachPhongHoc();
		}

		private void HienThiDanhSachPhongHoc()
		{
			PhongHocBusiness phongHocBusiness = new PhongHocBusiness();

			DataTable dtPH = phongHocBusiness.LayDanhSach();

			gridPhongHoc.DataSource = dtPH;
		}
	}
}

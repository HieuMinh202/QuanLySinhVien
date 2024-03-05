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
	public partial class frmThongTinChuyenKhoa : Form
	{
		public frmThongTinChuyenKhoa()
		{
			InitializeComponent();
		}

		private void frmThongTinChuyenKhoa_Load(object sender, EventArgs e)
		{
			HienThiDanhSachKhoa();
		}

		private void HienThiDanhSachKhoa()
		{
			ChuyenKhoaBusiness chuyenKhoaBusiness = new ChuyenKhoaBusiness();

			DataTable dtCK = chuyenKhoaBusiness.LayDanhSach();

			gridChuyenKhoa.DataSource = dtCK;
		}
	}
}

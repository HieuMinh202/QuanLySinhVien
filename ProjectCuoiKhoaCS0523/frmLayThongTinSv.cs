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
	public partial class frmLayThongTinSv : Form
	{
		
		public string maSV = "", iD = "", hoTen = "";

		public frmLayThongTinSv()
		{
			InitializeComponent();
		}

		private void frmChonSVdiemThi_Load(object sender, EventArgs e)
		{
			HienThiDanhSachKhoa();

			HienThiDanhSachSinhVien();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			HienThiDanhSachSinhVien();
		}
		private void HienThiDanhSachKhoa()
		{
			ChuyenKhoaBusiness chuyenKhoaBusiness = new ChuyenKhoaBusiness();

			DataTable dtKhoa = chuyenKhoaBusiness.LayDanhSach();

			DataRow root = dtKhoa.NewRow();

			root[0] = "";
			root[1] = "---Chọn khoa---";
			dtKhoa.Rows.InsertAt(root, 0);

			cboKhoa.DisplayMember = "TenKhoa";
			cboKhoa.ValueMember = "MaKhoa";
			cboKhoa.DataSource = dtKhoa;
		}

		private void gridChonSVdiemThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int numrow;
			numrow = e.RowIndex;
			maSV = gridChonSVdiemThi.Rows[numrow].Cells[0].Value.ToString();
			hoTen = gridChonSVdiemThi.Rows[numrow].Cells[1].Value.ToString();
			this.Close();
		}

		private void HienThiDanhSachSinhVien()
		{
			string tuKhoa = "", maKhoa = "";

			tuKhoa = txtTuKhoa.Text.Trim();
			maKhoa = "" + cboKhoa.SelectedValue;

			SinhVienBusiness sinhVienBusiness = new SinhVienBusiness();

			DataTable dtCSV = sinhVienBusiness.TimKiemSinhVien(tuKhoa, maKhoa);

			gridChonSVdiemThi.DataSource = dtCSV;
		}
	}
}

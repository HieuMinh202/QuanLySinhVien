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
	public partial class frmDanhSachNguoiDung : Form
	{
		public frmDanhSachNguoiDung()
		{
			InitializeComponent();
		}

		private void frmDanhSachNguoiDung_Load(object sender, EventArgs e)
		{
			HienThiNguoiDung();
			HienThiDanhSachVaiTro();
		}
		private void HienThiDanhSachVaiTro()
		{
			VaiTroBusiness vaiTroBus = new VaiTroBusiness();

			DataTable dtVT = vaiTroBus.LayDanhSachVT();

			DataRow root = dtVT.NewRow();

			root[0] = "";
			root[1] = "---Chọn Vai Trò---";
			dtVT.Rows.InsertAt(root, 0);

			
		}
		private void HienThiNguoiDung()
		{
			NguoiDungBussines nguoiDungBusiness = new NguoiDungBussines();

			DataTable dtND = nguoiDungBusiness.LayDanhSachND();

			VaiTroBusiness vaiTroBusiness = new VaiTroBusiness();

			DataTable dtVT = vaiTroBusiness.LayDanhSachVT();

			gridNguoiDung.DataSource = dtND;
		}
		
		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			frmNguoiDungAdd frmThem = new frmNguoiDungAdd();

			frmThem.ShowDialog();

			HienThiNguoiDung();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			string tenDangNhap = "", matKhau = "", hoTen = "", vaiTro = "";
			int Id = 0;

			int.TryParse("" + gridNguoiDung.CurrentRow.Cells[0].Value, out Id);
			tenDangNhap = "" + gridNguoiDung.CurrentRow.Cells[0].Value;
			matKhau = "" + gridNguoiDung.CurrentRow.Cells[0].Value;
			hoTen = "" + gridNguoiDung.CurrentRow.Cells[0].Value;
			vaiTro = "" + gridNguoiDung.CurrentRow.Cells[0].Value;

			frmNguoiDungAdd frmSua = new frmNguoiDungAdd();

			frmSua.Id = Id;
			frmSua.TenDangNhap = tenDangNhap;
			frmSua.MatKhau = matKhau;
			frmSua.HoTen = hoTen;
			frmSua.VaiTro = vaiTro;

			frmSua.ShowDialog();

			HienThiNguoiDung();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (dr == DialogResult.Yes)
			{
				string tenDangNhap = "";

				tenDangNhap = "" + gridNguoiDung.CurrentRow.Cells[0].Value;

				bool ketQua = DataProvider.NguoiDungBus.Xoa(tenDangNhap);

				if (ketQua)
				{
					HienThiNguoiDung();
				}
			}
		}

		private void btnDong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

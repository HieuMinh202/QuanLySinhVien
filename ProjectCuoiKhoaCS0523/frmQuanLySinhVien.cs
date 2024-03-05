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
	public partial class frmQuanLySinhVien : Form
	{
		public static int UserId { get; set; } = 0;

		public static string UserName { get; set; } = "";

		public frmQuanLySinhVien()
		{
			InitializeComponent();
		}

		private void frmQuanLySinhVien_Load(object sender, EventArgs e)
		{
			DangNhap();
		}

		private void menuItemNguoiDung_Click_1(object sender, EventArgs e)
		{
			frmDanhSachNguoiDung frmDanhSachNguoiDung = new frmDanhSachNguoiDung();
			frmDanhSachNguoiDung.MdiParent = this;
			frmDanhSachNguoiDung.Show();
		}

		private void menuItemSinhVien_Click(object sender, EventArgs e)
		{
			frmThongTinSinhVien frmThongTinSinhVien = new frmThongTinSinhVien();
			frmThongTinSinhVien.MdiParent=this;
			frmThongTinSinhVien.Show();
		}

		private void menuItemChuyenKhoa_Click(object sender, EventArgs e)
		{
			frmThongTinChuyenKhoa frmThongTinChuyenKhoa = new frmThongTinChuyenKhoa();
			frmThongTinChuyenKhoa.MdiParent = this;
			frmThongTinChuyenKhoa.Show();
		}

		private void menuItemThoatChuongTrinh_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void menuItemDangNhap_Click(object sender, EventArgs e)
		{
			DangNhap();
		}

		private void menuItemMonHoc_Click(object sender, EventArgs e)
		{
			frmMonHoc frmMH = new frmMonHoc();
			frmMH.MdiParent = this;
			frmMH.Show();
		}

		private void menuItemPhongHoc_Click(object sender, EventArgs e)
		{
			frmPhongHoc frmPH = new frmPhongHoc();
			frmPH.MdiParent = this;
			frmPH.Show();
		}

		private void menuItemTacGia_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Lê Thị Trà Giang!", "Tác giả");
		}

		private void menuItemBaoLoi_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đã báo cáo lỗi, lỗi sẽ được khắc phục trong thời gian ngắn nhất.", "Thông báo");
		}

		private void menuItemHuongDan_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Làm gì có hướng dẫn nào mà xem.", "Thông báo");
		}

		private void menuItemNhapDiemThi_Click(object sender, EventArgs e)
		{
			frmNhapDiemThi frmNhapDiem = new frmNhapDiemThi();
			frmNhapDiem.MdiParent = this;
			frmNhapDiem.Show();
		}

		private void menuItemTraCuuDiemThi_Click(object sender, EventArgs e)
		{
			frmTraCuuDiemThi frmTraCuu = new frmTraCuuDiemThi();
			frmTraCuu.MdiParent = this;
			frmTraCuu.Show();
		}

		private void menuItemDangXuat_Click(object sender, EventArgs e)
		{
			DangNhap();
		}
		private void DangNhap()
		{
			KiemTraQuyenSuDung(false);

			frmDangNhap frmLogin = new frmDangNhap();

			frmLogin.ShowDialog();

			KiemTraQuyenSuDung(frmLogin.isSuccessLogin);
		}
		private void KiemTraQuyenSuDung(bool isXem)
		{
			menuItemNguoiDung.Visible = isXem;

			menuItemDangNhap.Visible = !isXem;
			menuItemDangXuat.Visible = isXem;
			menuNghiepVu.Enabled = isXem;
			menuDanhMuc.Enabled = isXem;
			menuItemHuongDan.Enabled = isXem;
			menuItemTacGia.Enabled = isXem;

			if (isXem)
			{
				lblTrangThaiDN.Text = UserName;
			}
			else
			{
				UserId = 0;
				UserName = "";
				lblTrangThaiDN.Text = "Chưa đăng nhập";
			}
		}
	}
}

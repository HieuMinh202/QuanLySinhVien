namespace ProjectCuoiKhoaCS0523
{
	partial class frmQuanLySinhVien
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemDangNhap = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemThoatChuongTrinh = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemPhongHoc = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemSinhVien = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemChuyenKhoa = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemMonHoc = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuItemNhapDiemThi = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemTraCuuDiemThi = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemBaoLoi = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemHuongDan = new System.Windows.Forms.ToolStripMenuItem();
			this.menuItemTacGia = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblTrangThaiDN = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong,
            this.menuDanhMuc,
            this.menuNghiepVu,
            this.menuBaoCao,
            this.menuTroGiup});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(821, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuHeThong
			// 
			this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNguoiDung,
            this.menuItemDangNhap,
            this.menuItemDangXuat,
            this.menuItemThoatChuongTrinh});
			this.menuHeThong.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.settings_16;
			this.menuHeThong.Name = "menuHeThong";
			this.menuHeThong.Size = new System.Drawing.Size(85, 20);
			this.menuHeThong.Text = "Hệ thống";
			// 
			// menuItemNguoiDung
			// 
			this.menuItemNguoiDung.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.Login_Manager32x32;
			this.menuItemNguoiDung.Name = "menuItemNguoiDung";
			this.menuItemNguoiDung.Size = new System.Drawing.Size(176, 22);
			this.menuItemNguoiDung.Text = "Người dùng";
			this.menuItemNguoiDung.Click += new System.EventHandler(this.menuItemNguoiDung_Click_1);
			// 
			// menuItemDangNhap
			// 
			this.menuItemDangNhap.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.icon_login_16x16;
			this.menuItemDangNhap.Name = "menuItemDangNhap";
			this.menuItemDangNhap.Size = new System.Drawing.Size(176, 22);
			this.menuItemDangNhap.Text = "Đăng nhập";
			this.menuItemDangNhap.Click += new System.EventHandler(this.menuItemDangNhap_Click);
			// 
			// menuItemDangXuat
			// 
			this.menuItemDangXuat.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.logout;
			this.menuItemDangXuat.Name = "menuItemDangXuat";
			this.menuItemDangXuat.Size = new System.Drawing.Size(176, 22);
			this.menuItemDangXuat.Text = "Đăng xuất";
			this.menuItemDangXuat.Click += new System.EventHandler(this.menuItemDangXuat_Click);
			// 
			// menuItemThoatChuongTrinh
			// 
			this.menuItemThoatChuongTrinh.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.cross;
			this.menuItemThoatChuongTrinh.Name = "menuItemThoatChuongTrinh";
			this.menuItemThoatChuongTrinh.Size = new System.Drawing.Size(176, 22);
			this.menuItemThoatChuongTrinh.Text = "Thoát chương trình";
			this.menuItemThoatChuongTrinh.Click += new System.EventHandler(this.menuItemThoatChuongTrinh_Click);
			// 
			// menuDanhMuc
			// 
			this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPhongHoc});
			this.menuDanhMuc.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.List_BulletsHS;
			this.menuDanhMuc.Name = "menuDanhMuc";
			this.menuDanhMuc.Size = new System.Drawing.Size(90, 20);
			this.menuDanhMuc.Text = "Danh mục";
			// 
			// menuItemPhongHoc
			// 
			this.menuItemPhongHoc.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.Home_2;
			this.menuItemPhongHoc.Name = "menuItemPhongHoc";
			this.menuItemPhongHoc.Size = new System.Drawing.Size(132, 22);
			this.menuItemPhongHoc.Text = "Phòng học";
			this.menuItemPhongHoc.Click += new System.EventHandler(this.menuItemPhongHoc_Click);
			// 
			// menuNghiepVu
			// 
			this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSinhVien,
            this.menuItemChuyenKhoa,
            this.menuItemMonHoc,
            this.toolStripSeparator1,
            this.menuItemNhapDiemThi,
            this.menuItemTraCuuDiemThi});
			this.menuNghiepVu.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.Group_3;
			this.menuNghiepVu.Name = "menuNghiepVu";
			this.menuNghiepVu.Size = new System.Drawing.Size(90, 20);
			this.menuNghiepVu.Text = "Nghiệp vụ";
			// 
			// menuItemSinhVien
			// 
			this.menuItemSinhVien.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.Login_Manager32x32;
			this.menuItemSinhVien.Name = "menuItemSinhVien";
			this.menuItemSinhVien.Size = new System.Drawing.Size(159, 22);
			this.menuItemSinhVien.Text = "Sinh viên";
			this.menuItemSinhVien.Click += new System.EventHandler(this.menuItemSinhVien_Click);
			// 
			// menuItemChuyenKhoa
			// 
			this.menuItemChuyenKhoa.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.EditTableHS;
			this.menuItemChuyenKhoa.Name = "menuItemChuyenKhoa";
			this.menuItemChuyenKhoa.Size = new System.Drawing.Size(159, 22);
			this.menuItemChuyenKhoa.Text = "Chuyên khoa";
			this.menuItemChuyenKhoa.Click += new System.EventHandler(this.menuItemChuyenKhoa_Click);
			// 
			// menuItemMonHoc
			// 
			this.menuItemMonHoc.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.edoc_register;
			this.menuItemMonHoc.Name = "menuItemMonHoc";
			this.menuItemMonHoc.Size = new System.Drawing.Size(159, 22);
			this.menuItemMonHoc.Text = "Môn học";
			this.menuItemMonHoc.Click += new System.EventHandler(this.menuItemMonHoc_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
			// 
			// menuItemNhapDiemThi
			// 
			this.menuItemNhapDiemThi.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.edit;
			this.menuItemNhapDiemThi.Name = "menuItemNhapDiemThi";
			this.menuItemNhapDiemThi.Size = new System.Drawing.Size(159, 22);
			this.menuItemNhapDiemThi.Text = "Nhập điểm thi";
			this.menuItemNhapDiemThi.Click += new System.EventHandler(this.menuItemNhapDiemThi_Click);
			// 
			// menuItemTraCuuDiemThi
			// 
			this.menuItemTraCuuDiemThi.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.search;
			this.menuItemTraCuuDiemThi.Name = "menuItemTraCuuDiemThi";
			this.menuItemTraCuuDiemThi.Size = new System.Drawing.Size(159, 22);
			this.menuItemTraCuuDiemThi.Text = "Tra cứu điểm thi";
			this.menuItemTraCuuDiemThi.Click += new System.EventHandler(this.menuItemTraCuuDiemThi_Click);
			// 
			// menuBaoCao
			// 
			this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBaoLoi});
			this.menuBaoCao.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.docs;
			this.menuBaoCao.Name = "menuBaoCao";
			this.menuBaoCao.Size = new System.Drawing.Size(77, 20);
			this.menuBaoCao.Text = "Báo cáo";
			// 
			// menuItemBaoLoi
			// 
			this.menuItemBaoLoi.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.delete;
			this.menuItemBaoLoi.Name = "menuItemBaoLoi";
			this.menuItemBaoLoi.Size = new System.Drawing.Size(110, 22);
			this.menuItemBaoLoi.Text = "Báo lỗi";
			this.menuItemBaoLoi.Click += new System.EventHandler(this.menuItemBaoLoi_Click);
			// 
			// menuTroGiup
			// 
			this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHuongDan,
            this.menuItemTacGia});
			this.menuTroGiup.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.Help;
			this.menuTroGiup.Name = "menuTroGiup";
			this.menuTroGiup.Size = new System.Drawing.Size(78, 20);
			this.menuTroGiup.Text = "Trợ giúp";
			// 
			// menuItemHuongDan
			// 
			this.menuItemHuongDan.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.docs;
			this.menuItemHuongDan.Name = "menuItemHuongDan";
			this.menuItemHuongDan.Size = new System.Drawing.Size(134, 22);
			this.menuItemHuongDan.Text = "Hướng dẫn";
			this.menuItemHuongDan.Click += new System.EventHandler(this.menuItemHuongDan_Click);
			// 
			// menuItemTacGia
			// 
			this.menuItemTacGia.Image = global::ProjectCuoiKhoaCS0523.Properties.Resources.kuser32x32;
			this.menuItemTacGia.Name = "menuItemTacGia";
			this.menuItemTacGia.Size = new System.Drawing.Size(134, 22);
			this.menuItemTacGia.Text = "Tác giả";
			this.menuItemTacGia.Click += new System.EventHandler(this.menuItemTacGia_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblTrangThaiDN});
			this.statusStrip1.Location = new System.Drawing.Point(0, 318);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(821, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
			this.toolStripStatusLabel1.Text = "Đang đăng nhập:";
			// 
			// lblTrangThaiDN
			// 
			this.lblTrangThaiDN.Name = "lblTrangThaiDN";
			this.lblTrangThaiDN.Size = new System.Drawing.Size(95, 17);
			this.lblTrangThaiDN.Text = "Chưa đăng nhập";
			// 
			// frmQuanLySinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 340);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmQuanLySinhVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý sinh viên";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuHeThong;
		private System.Windows.Forms.ToolStripMenuItem menuItemNguoiDung;
		private System.Windows.Forms.ToolStripMenuItem menuItemDangNhap;
		private System.Windows.Forms.ToolStripMenuItem menuItemDangXuat;
		private System.Windows.Forms.ToolStripMenuItem menuItemThoatChuongTrinh;
		private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
		private System.Windows.Forms.ToolStripMenuItem menuItemPhongHoc;
		private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
		private System.Windows.Forms.ToolStripMenuItem menuItemSinhVien;
		private System.Windows.Forms.ToolStripMenuItem menuItemChuyenKhoa;
		private System.Windows.Forms.ToolStripMenuItem menuItemMonHoc;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuItemNhapDiemThi;
		private System.Windows.Forms.ToolStripMenuItem menuItemTraCuuDiemThi;
		private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
		private System.Windows.Forms.ToolStripMenuItem menuItemBaoLoi;
		private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
		private System.Windows.Forms.ToolStripMenuItem menuItemHuongDan;
		private System.Windows.Forms.ToolStripMenuItem menuItemTacGia;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lblTrangThaiDN;
	}
}
USE [ProjectCuoiKhoaCS0523]
GO
/****** Object:  Table [dbo].[ChuyenKhoa]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenKhoa](
	[MaKhoa] [varchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
	[DienThoai] [varchar](20) NULL,
 CONSTRAINT [PK_ChuyenKhoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DiemThi]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemThi](
	[SinhVienId] [varchar](10) NOT NULL,
	[MonHocId] [varchar](10) NOT NULL,
	[NgayThi] [date] NULL,
	[DiemThi] [float] NULL,
	[PhongHocId] [varchar](10) NULL,
 CONSTRAINT [PK_DiemThi] PRIMARY KEY CLUSTERED 
(
	[SinhVienId] ASC,
	[MonHocId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](30) NULL,
 CONSTRAINT [PK_MonHocT] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[HoTen] [nvarchar](30) NULL,
	[DienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[VaiTro] [varchar](10) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongHoc]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongHoc](
	[MaPhong] [varchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[MoTa] [nvarchar](250) NULL,
	[SapXep] [nvarchar](30) NULL,
 CONSTRAINT [PK_PhongHoc2] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [varchar](10) NOT NULL,
	[HoTen] [nvarchar](30) NULL,
	[GioiTinh] [tinyint] NULL,
	[NgaySinh] [date] NULL,
	[DienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[DiaChi] [nvarchar](250) NULL,
	[ChuyenKhoaId] [varchar](10) NULL,
 CONSTRAINT [PK_SinhVienTable] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 05-Mar-24 6:03:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[MaVaiTro] [varchar](10) NOT NULL,
	[TenVaiTro] [nvarchar](150) NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_VaiTro] PRIMARY KEY CLUSTERED 
(
	[MaVaiTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChuyenKhoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'CNTT', N'Công nghệ thông tin', N'0243000555')
INSERT [dbo].[ChuyenKhoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'DCN', N'Điện công nghiệp', N'0281555444')
INSERT [dbo].[ChuyenKhoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'DT', N'Điện tử', N'0281000222')
INSERT [dbo].[ChuyenKhoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'KT', N'Kế toán', N'0204222333')
GO
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'BKA001', N'KTS', CAST(N'2023-09-04' AS Date), 4, N'P01')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'BKA001', N'NLS', CAST(N'2023-08-26' AS Date), 8, N'P01')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'BKA002', N'KTS', CAST(N'2023-08-26' AS Date), 8, N'P03')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'BKA002', N'NLS', CAST(N'2023-08-26' AS Date), 9, N'P02')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'DCN001', N'KTS', CAST(N'2023-09-05' AS Date), 8, N'P01')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'DCN001', N'NLS', CAST(N'2023-09-05' AS Date), 8, N'P01')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'DCN003', N'TCDN', CAST(N'2023-08-26' AS Date), 8, N'P02')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'KKT004', N'MKT', CAST(N'2023-08-27' AS Date), 8, N'P01')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'TLA001', N'KTS', CAST(N'2023-08-27' AS Date), 8, N'P01')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'TLA001', N'MKT', CAST(N'2023-08-27' AS Date), 7, N'P02')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'TLA001', N'TKT', CAST(N'2023-08-26' AS Date), 8, N'P04')
INSERT [dbo].[DiemThi] ([SinhVienId], [MonHocId], [NgayThi], [DiemThi], [PhongHocId]) VALUES (N'TLA002', N'KTS', CAST(N'2023-08-26' AS Date), 9, N'P01')
GO
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'KTS', N'Kỹ thuật số')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'MKT', N'Marketing')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'NLS', N'Năng lực số')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'TCDN', N'Tài chính doanh nghiệp')
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc]) VALUES (N'TKT', N'Toán kinh tế')
GO
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi], [VaiTro]) VALUES (2, N'manhtt', N'123', N'Trịnh Tiến Mạnh', N'', N'', N'', N'01')
INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi], [VaiTro]) VALUES (3, N'nhanvien', N'123', N'Nhân viên', N'', N'', N'', N'02')
INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi], [VaiTro]) VALUES (4, N'admin1', N'123', N'Quản trị hệ thống 1', N'', N'', N'', N'01')
INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi], [VaiTro]) VALUES (5, N'ktv1', N'123', N'Kỹ thuật viên', N'', N'', N'', N'02')
INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi], [VaiTro]) VALUES (14, N'admin', N'123', N'Quản trị hệ thống', N'', N'', N'', N'01')
INSERT [dbo].[NguoiDung] ([Id], [TenDangNhap], [MatKhau], [HoTen], [DienThoai], [Email], [DiaChi], [VaiTro]) VALUES (1014, N'admin', N'123', N'admin', N'0973232839', N'a@gmail.com', N'Hà Nội', N'01')
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
GO
INSERT [dbo].[PhongHoc] ([MaPhong], [TenPhong], [MoTa], [SapXep]) VALUES (N'P01', N'Phòng 1', N'Cầu thang chính rẽ phải phòng thứ nhất', N'01')
INSERT [dbo].[PhongHoc] ([MaPhong], [TenPhong], [MoTa], [SapXep]) VALUES (N'P02', N'Phòng 2', N'Cầu thang chính rẽ phải phòng thứ hai', N'02')
INSERT [dbo].[PhongHoc] ([MaPhong], [TenPhong], [MoTa], [SapXep]) VALUES (N'P03', N'Phòng 3', N'Cầu thang chính rẽ trái phòng thứ nhất', N'03')
INSERT [dbo].[PhongHoc] ([MaPhong], [TenPhong], [MoTa], [SapXep]) VALUES (N'P04', N'Phòng 4', N'Cầu thang chính rẽ trái phòng thứ hai', N'04')
GO
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'BKA001', N'Nguyễn Hải Hà', 0, CAST(N'2002-08-15' AS Date), N'0325648951', N'ha@gmail.com', N'Hải Phòng', N'DCN')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'BKA002', N'Nguyễn Thành Công', 0, CAST(N'1990-07-27' AS Date), N'0983215684', N'cong@gmail.com', N'Hải Dương', N'DT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'BKA003', N'Bùi Hải Nam', 0, CAST(N'2000-05-05' AS Date), N'0321445687', N'nam@gmail.com', N'Vĩnh Phúc', N'DT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'BKA004', N'Nguyễn Văn Cương', 0, CAST(N'2001-06-05' AS Date), N'0365421789', N'cuong@gmail.com', N'Bắc Giang', N'DCN')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'DCN001', N'Trần Văn Cường', 0, CAST(N'2001-09-06' AS Date), N'0321654879', N'tvcuong@gmail.com', N'Vĩnh Phúc', N'DCN')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'DCN002', N'Nguyễn Thị Thu', 1, CAST(N'1999-09-08' AS Date), N'0976523157', N'thu@gmail.com', N'Hải Phòng', N'KT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'DCN003', N'Trần Văn Nam', 0, CAST(N'2000-12-23' AS Date), N'0978521456', N'vnam@gmail.com', N'Hà Nội', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'DCN004', N'Trần Văn Quảng', 0, CAST(N'1997-11-29' AS Date), N'0986547231', N'quang@gmail.com', N'Hà Nam', N'DCN')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'KKT001', N'Nguyễn Thị Hồng', 1, CAST(N'1998-08-25' AS Date), N'0523145789', N'hong@gmail.com', N'Hà Nội', N'DT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'KKT002', N'Nguyễn Thị Hường', 1, CAST(N'1994-05-26' AS Date), N'0512345784', N'huong@gmail.com', N'Hà Nội', N'KT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'KKT003', N'Trần Thị Hương', 1, CAST(N'1990-03-08' AS Date), N'0563213589', N'tthuong@gmail.com', N'Thái Nguyên', N'KT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'KKT004', N'Lê Thị Trà Giang', 1, CAST(N'2004-01-18' AS Date), N'0325687412', N'giang@gmail.com', N'Bắc Giang', N'KT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'TLA001', N'Trịnh Tiến Mạnh', 0, CAST(N'1996-12-21' AS Date), N'0973232839', N'manh@gmail.com', N'Bắc Giang', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'TLA002', N'Trần Thanh Phương', 0, CAST(N'1993-01-01' AS Date), N'0976582314', N'phuong@gmail.com', N'Hà Nội', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'TLA003', N'Bùi Thị Trang', 1, CAST(N'1997-03-05' AS Date), N'0321456897', N'trang@gmail.com', N'Hà Nội', N'CNTT')
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [Email], [DiaChi], [ChuyenKhoaId]) VALUES (N'TLA004', N'Nguyễn Tiến Dũng', 0, CAST(N'2000-12-05' AS Date), N'0985632145', N'dung@gmail.com', N'Hải Dương', N'DT')
GO
INSERT [dbo].[VaiTro] ([MaVaiTro], [TenVaiTro], [MoTa]) VALUES (N'01', N'Admin', N'Quản lý')
INSERT [dbo].[VaiTro] ([MaVaiTro], [TenVaiTro], [MoTa]) VALUES (N'02', N'KTV', N'Kỹ thuật viên')
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD  CONSTRAINT [FK_DiemThi_MonHoc] FOREIGN KEY([MonHocId])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[DiemThi] CHECK CONSTRAINT [FK_DiemThi_MonHoc]
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD  CONSTRAINT [FK_DiemThi_PhongHoc] FOREIGN KEY([PhongHocId])
REFERENCES [dbo].[PhongHoc] ([MaPhong])
GO
ALTER TABLE [dbo].[DiemThi] CHECK CONSTRAINT [FK_DiemThi_PhongHoc]
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD  CONSTRAINT [FK_DiemThi_PhongHoc1] FOREIGN KEY([PhongHocId])
REFERENCES [dbo].[PhongHoc] ([MaPhong])
GO
ALTER TABLE [dbo].[DiemThi] CHECK CONSTRAINT [FK_DiemThi_PhongHoc1]
GO
ALTER TABLE [dbo].[DiemThi]  WITH CHECK ADD  CONSTRAINT [FK_DiemThi_SinhVien] FOREIGN KEY([SinhVienId])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[DiemThi] CHECK CONSTRAINT [FK_DiemThi_SinhVien]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_VaiTro] FOREIGN KEY([VaiTro])
REFERENCES [dbo].[VaiTro] ([MaVaiTro])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_VaiTro]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_ChuyenKhoa] FOREIGN KEY([ChuyenKhoaId])
REFERENCES [dbo].[ChuyenKhoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_ChuyenKhoa]
GO

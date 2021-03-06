USE [master]
GO
/****** Object:  Database [QuanLyHangHoa]    Script Date: 7/28/2020 5:56:31 PM ******/
CREATE DATABASE [QuanLyHangHoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHangHoa', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyHangHoa.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyHangHoa_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyHangHoa_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyHangHoa] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHangHoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHangHoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHangHoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHangHoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHangHoa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHangHoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHangHoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHangHoa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyHangHoa]
GO
/****** Object:  StoredProcedure [dbo].[GetDoanhThuReport]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetDoanhThuReport](
@FromDate date,
@ToDate date
)
as
select @FromDate as 'TuNgay',@ToDate as 'DenNgay',count("Mahoadon") as Soluong,sum("Tongtien") as Tongdoanhthu
from Hoadon
where Ngaylap between @FromDate and @ToDate
GO
/****** Object:  StoredProcedure [dbo].[GetHoaDonReport]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetHoaDonReport]
(
@FromDate date,
@ToDate date
)as
select *
from Hoadon
where Ngaylap between @FromDate and @ToDate
GO
/****** Object:  StoredProcedure [dbo].[GetKhachHangReport]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetKhachHangReport]
(
@Trangthai int
)as
select *
from Khachhang
where Trangthai=@Trangthai
GO
/****** Object:  StoredProcedure [dbo].[GetNhanVienReport]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetNhanVienReport]
(
@Trangthai int
)as
select *
from Nhanvien
where Trangthai=@Trangthai
GO
/****** Object:  StoredProcedure [dbo].[GetSanPhamReport]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetSanPhamReport]
(
@Trangthai int
)as
select *
from Sanpham
where Trangthai=@Trangthai
GO
/****** Object:  Table [dbo].[Chitiethoadon]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chitiethoadon](
	[Mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[Masanpham] [nvarchar](50) NULL,
	[Tensanpham] [nvarchar](50) NULL,
	[Dongia] [nvarchar](10) NULL,
	[Soluong] [nvarchar](50) NULL,
	[Chietkhau] [nvarchar](50) NULL,
	[Thanhtien] [int] NULL,
 CONSTRAINT [PK_Chitiethoadon] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hoadon]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoadon](
	[Mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[Manhanvien] [nvarchar](50) NOT NULL,
	[Makhachhang] [nvarchar](50) NOT NULL,
	[Ngaylap] [date] NULL,
	[Tongtien] [int] NULL,
	[Trangthai] [int] NULL,
 CONSTRAINT [PK_Hoadon] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[Makhachhang] [nvarchar](50) NOT NULL,
	[Tenkhachhang] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](3) NULL,
	[Ngaysinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sodienthoai] [nvarchar](11) NULL,
	[Trangthai] [int] NULL,
 CONSTRAINT [PK_Khachhang] PRIMARY KEY CLUSTERED 
(
	[Makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhacungcap]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhacungcap](
	[MaNCC] [nchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
 CONSTRAINT [PK_Nhacungcap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhanvien]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvien](
	[Manhanvien] [nvarchar](50) NOT NULL,
	[Password] [nchar](100) NULL,
	[Hoten] [nvarchar](50) NULL,
	[Gioitinh] [nvarchar](3) NULL,
	[Ngaysinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sodienthoai] [nvarchar](11) NULL,
	[Chucvu] [nvarchar](20) NULL,
	[Quyen] [int] NULL,
	[Trangthai] [int] NULL,
 CONSTRAINT [PK_Nhanvien] PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sanpham]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sanpham](
	[Masanpham] [nvarchar](50) NOT NULL,
	[Tensanpham] [nvarchar](50) NULL,
	[Dongia] [int] NULL,
	[Soluong] [int] NULL,
	[Trangthai] [int] NULL,
	[MaNCC] [nchar](10) NULL,
	[Hinhanh] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sanpham] PRIMARY KEY CLUSTERED 
(
	[Masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 7/28/2020 5:56:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[Manhanvien] [nchar](10) NULL,
	[username] [nchar](20) NULL,
	[password] [nchar](100) NULL,
	[type] [int] NULL,
	[status] [int] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Chitiethoadon] ON 

INSERT [dbo].[Chitiethoadon] ([Mahoadon], [Masanpham], [Tensanpham], [Dongia], [Soluong], [Chietkhau], [Thanhtien]) VALUES (29, N'SP01', N'God Breaker Jacket (Black Edition)', N'99', N'1', N'0', 99)
INSERT [dbo].[Chitiethoadon] ([Mahoadon], [Masanpham], [Tensanpham], [Dongia], [Soluong], [Chietkhau], [Thanhtien]) VALUES (30, N'SP03', N'test3', N'200', N'1', N'0', 200)
INSERT [dbo].[Chitiethoadon] ([Mahoadon], [Masanpham], [Tensanpham], [Dongia], [Soluong], [Chietkhau], [Thanhtien]) VALUES (31, N'SP01', N'God Breaker Jacket (Black Edition)', N'99', N'2', N'0', 198)
INSERT [dbo].[Chitiethoadon] ([Mahoadon], [Masanpham], [Tensanpham], [Dongia], [Soluong], [Chietkhau], [Thanhtien]) VALUES (32, N'SP03', N'test3', N'200', N'1', N'0', 200)
INSERT [dbo].[Chitiethoadon] ([Mahoadon], [Masanpham], [Tensanpham], [Dongia], [Soluong], [Chietkhau], [Thanhtien]) VALUES (33, N'SP01', N'God Breaker Jacket (Black Edition)', N'99', N'1', N'0', 99)
INSERT [dbo].[Chitiethoadon] ([Mahoadon], [Masanpham], [Tensanpham], [Dongia], [Soluong], [Chietkhau], [Thanhtien]) VALUES (34, N'SP01', N'God Breaker Jacket (Black Edition)', N'99', N'4', N'0', 396)
SET IDENTITY_INSERT [dbo].[Chitiethoadon] OFF
SET IDENTITY_INSERT [dbo].[Hoadon] ON 

INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Makhachhang], [Ngaylap], [Tongtien], [Trangthai]) VALUES (29, N'NV02', N'KVL', CAST(0x23410B00 AS Date), 200, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Makhachhang], [Ngaylap], [Tongtien], [Trangthai]) VALUES (30, N'NV02', N'KVL', CAST(0x33410B00 AS Date), 99, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Makhachhang], [Ngaylap], [Tongtien], [Trangthai]) VALUES (31, N'NV02', N'KVL', CAST(0x33410B00 AS Date), 198, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Makhachhang], [Ngaylap], [Tongtien], [Trangthai]) VALUES (32, N'NV03', N'KVL', CAST(0x54410B00 AS Date), 200, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Makhachhang], [Ngaylap], [Tongtien], [Trangthai]) VALUES (33, N'NV02', N'KVL', CAST(0x60410B00 AS Date), 99, 1)
INSERT [dbo].[Hoadon] ([Mahoadon], [Manhanvien], [Makhachhang], [Ngaylap], [Tongtien], [Trangthai]) VALUES (34, N'NV02', N'KVL', CAST(0x60410B00 AS Date), 396, 1)
SET IDENTITY_INSERT [dbo].[Hoadon] OFF
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KH01', N'Nguyen Hoang Minh Phat', N'Nam', CAST(0x57250B00 AS Date), N'Dinh Quan, Dong Nai', N'095481234', 1)
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KH02', N'Hoang Vinh Quang', N'Nam', CAST(0x98240B00 AS Date), N'TP HCM', N'092189265', 1)
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KH03', N'Le Huu Hieu', N'Nam', CAST(0x9C240B00 AS Date), N'Bui Vien, TP HCM', N'092843458', 1)
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KH04', N'Le Thanh Tai', N'Nu', CAST(0xE4240B00 AS Date), N'Long An', N'091554748', 1)
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KH05', N'Nguyen Tran Thanh Quang', N'Nu', CAST(0x0E240B00 AS Date), N'Da Nang', N'091842354', 1)
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KH06', N'Trương Vĩnh Tấn Đạt', N'Nam', CAST(0x27240B00 AS Date), N'Gò Vấp', N'0932029546', 1)
INSERT [dbo].[Khachhang] ([Makhachhang], [Tenkhachhang], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Trangthai]) VALUES (N'KVL', N'Khách vãng lai', NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[Nhacungcap] ([MaNCC], [TenNCC], [Diachi], [sdt]) VALUES (N'Add       ', N'Addidas', N'Mỹ', 123456)
INSERT [dbo].[Nhacungcap] ([MaNCC], [TenNCC], [Diachi], [sdt]) VALUES (N'Fil       ', N'Fila', N'Hàn Quốc', 123456)
INSERT [dbo].[Nhacungcap] ([MaNCC], [TenNCC], [Diachi], [sdt]) VALUES (N'Ni        ', N'Nike - Just do it', N'Mỹ', 123456)
INSERT [dbo].[Nhacungcap] ([MaNCC], [TenNCC], [Diachi], [sdt]) VALUES (N'Pum       ', N'Puma', N'Mỹ', 123456)
INSERT [dbo].[Nhanvien] ([Manhanvien], [Password], [Hoten], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Chucvu], [Quyen], [Trangthai]) VALUES (N'B01', N'1962026656160185351301320480154111117132155                                                         ', N'Truc Tran', N'Nữ', CAST(0x1E250B00 AS Date), N'Bình Dương', N'123456789', N'Nhân viên', 0, 1)
INSERT [dbo].[Nhanvien] ([Manhanvien], [Password], [Hoten], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Chucvu], [Quyen], [Trangthai]) VALUES (N'B05', N'1962026656160185351301320480154111117132155                                                         ', N'Trần Đức Dương', N'Nam', CAST(0x3E250B00 AS Date), N'Bình Dương', N'0989243760', N'Nhân viên', NULL, 1)
INSERT [dbo].[Nhanvien] ([Manhanvien], [Password], [Hoten], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Chucvu], [Quyen], [Trangthai]) VALUES (N'NV01', N'33354741122871651676713774147412831195                                                              ', N'Bùi Quốc Bảo', N'Nam', CAST(0x8F240B00 AS Date), N'Thuận An, Bình Dương', N'0932029546', N'Nhân viên', 0, 1)
INSERT [dbo].[Nhanvien] ([Manhanvien], [Password], [Hoten], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Chucvu], [Quyen], [Trangthai]) VALUES (N'NV02', N'33354741122871651676713774147412831195                                                              ', N'Trần Đức Dương', N'Nam', CAST(0x83240B00 AS Date), N'Bình Dương', N'0989243760', N'Quản lý', 1, 1)
INSERT [dbo].[Nhanvien] ([Manhanvien], [Password], [Hoten], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Chucvu], [Quyen], [Trangthai]) VALUES (N'NV03', N'1962026656160185351301320480154111117132155                                                         ', N'Trần Đức Dương', N'Nam', CAST(0x15240B00 AS Date), N'Bình Dương', N'0815126312', N'Quản lý', 0, 1)
INSERT [dbo].[Nhanvien] ([Manhanvien], [Password], [Hoten], [Gioitinh], [Ngaysinh], [Diachi], [Sodienthoai], [Chucvu], [Quyen], [Trangthai]) VALUES (N'NV04', N'33354741122871651676713774147412831195                                                              ', N'Dương Hoàng Kim', N'Nữ', CAST(0x42250B00 AS Date), N'Tân Cảng', N'0932029546', N'Quản lý', 1, 0)
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP01', N'God Breaker Jacket (Black Edition)', 99, 82, 1, N'Ni        ', N'..\..\product\8ts20s027-sk010-m-.jpg')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP02', N'God Breaker Jacket (El Nino Edition)', 89, 200, 1, N'Ni        ', N'..\..\product\8ts20s027-sk010-m-.jpg')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP03', N'test3', 200, 0, 1, N'Fil       ', N'product\8ts20s027-sk010-m-.jpg')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP05', N'Gndz High-End Jeans', 69, 399, 1, N'Add       ', N'..\..\product\Caroulse2_2000x.jpg')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP06', N'Sport Shorts Nike (Black)', 78, 300, 1, N'Add       ', N'..\..\product\f5c4ad8cf9a603f85ab7_2000x.jpg')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP07', N'test', 10, 96, 1, N'Fil       ', N'..\..\product\backr.png')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP08', N'test2', 50, 10, 1, N'Ni        ', N'..\..\product\ao.png')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP09', N'test 4', 2000, 20, 1, N'Add       ', N'..\..\product\ao.png')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP10', N'áo', 2000, 52, 0, N'Add       ', N'..\..\product\8ts20s032-sy158-m-.jpg')
INSERT [dbo].[Sanpham] ([Masanpham], [Tensanpham], [Dongia], [Soluong], [Trangthai], [MaNCC], [Hinhanh]) VALUES (N'SP11', N'srwe', 2000, 20, 1, N'Add       ', N'..\..\product\8ts20s027-sk010-m-.jpg')
INSERT [dbo].[Taikhoan] ([Manhanvien], [username], [password], [type], [status]) VALUES (N'NV02      ', N'admin               ', N'33354741122871651676713774147412831195                                                              ', 1, 1)
ALTER TABLE [dbo].[Chitiethoadon]  WITH CHECK ADD  CONSTRAINT [FK_Chitiethoadon_Sanpham] FOREIGN KEY([Masanpham])
REFERENCES [dbo].[Sanpham] ([Masanpham])
GO
ALTER TABLE [dbo].[Chitiethoadon] CHECK CONSTRAINT [FK_Chitiethoadon_Sanpham]
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK_Hoadon_Khachhang] FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[Khachhang] ([Makhachhang])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK_Hoadon_Khachhang]
GO
ALTER TABLE [dbo].[Hoadon]  WITH CHECK ADD  CONSTRAINT [FK_Hoadon_Nhanvien] FOREIGN KEY([Manhanvien])
REFERENCES [dbo].[Nhanvien] ([Manhanvien])
GO
ALTER TABLE [dbo].[Hoadon] CHECK CONSTRAINT [FK_Hoadon_Nhanvien]
GO
ALTER TABLE [dbo].[Sanpham]  WITH CHECK ADD  CONSTRAINT [FK__Sanpham__MaNCC__1DE57479] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[Nhacungcap] ([MaNCC])
GO
ALTER TABLE [dbo].[Sanpham] CHECK CONSTRAINT [FK__Sanpham__MaNCC__1DE57479]
GO
USE [master]
GO
ALTER DATABASE [QuanLyHangHoa] SET  READ_WRITE 
GO

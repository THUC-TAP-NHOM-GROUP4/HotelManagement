USE [master]
GO
/****** Object:  Database [TTN_QLNS]    Script Date: 04/22/2017 10:44:41 PM ******/
CREATE DATABASE [TTN_QLNS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TTN_QLNS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTN_QLNS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TTN_QLNS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TTN_QLNS_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TTN_QLNS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TTN_QLNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TTN_QLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TTN_QLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TTN_QLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TTN_QLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TTN_QLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TTN_QLNS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TTN_QLNS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TTN_QLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TTN_QLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TTN_QLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TTN_QLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TTN_QLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TTN_QLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TTN_QLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TTN_QLNS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TTN_QLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TTN_QLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TTN_QLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TTN_QLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TTN_QLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TTN_QLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TTN_QLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TTN_QLNS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TTN_QLNS] SET  MULTI_USER 
GO
ALTER DATABASE [TTN_QLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TTN_QLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TTN_QLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TTN_QLNS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TTN_QLNS]
GO
/****** Object:  StoredProcedure [dbo].[DSNHANVIEN]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DSNHANVIEN]
 AS
   BEGIN
      SELECT NV_PB.ma,NV_PB.ten,NV_PB.diachi,NV_PB.dienthoai,NV_PB.email,NV_PB.gioitinh,NV_PB.ngaysinh,NV_PB.socmnd,NV_PB.TD,NV_PB.PHONGBAN,CV.ten,NV_PB.maluong
	  FROM ChucVu CV
	       INNER JOIN(SELECT  NV_L.ma,NV_L.ten,NV_L.diachi,NV_L.dienthoai,NV_L.email,NV_L.gioitinh,NV_L.maChucVu,NV_L.maluong,NV_L.TD,PB.ten AS [PHONGBAN],NV_L.ngaysinh,NV_L.socmnd
		              FROM    PhongBan PB
					          INNER JOIN (SELECT NV_T.ma,NV_T.ten,NV_T.diachi,NV_T.dienthoai,NV_T.email,NV_T.gioitinh,NV_T.maChucVu,NV_T.maluong,NV_T.maphongban,NV_T.TD,NV_T.ngaysinh,NV_T.socmnd
							              FROM      Luong L
										           INNER JOIN(SELECT NV.ma,NV.ten,NV.diachi,NV.dienthoai,NV.email,NV.gioitinh,NV.maChucVu,NV.maluong,NV.maphongban,TDHV.ten AS TD,NV.socmnd,NV.ngaysinh
												              FROM   TrinhDoHocVan TDHV INNER JOIN NhanVien NV ON TDHV.ma = NV.maTDHV
															   GROUP BY NV.ma,NV.ten,NV.diachi,NV.dienthoai,NV.email,NV.socmnd,NV.gioitinh,NV.socmnd,NV.ngaysinh,NV.maChucVu,NV.maluong,NV.maphongban,TDHV.ten )
												   AS NV_T ON NV_T.maluong = L.ma
										  GROUP BY NV_T.ma,NV_T.ten,NV_T.diachi,NV_T.dienthoai,NV_T.email,NV_T.gioitinh,NV_T.maChucVu,NV_T.maluong,NV_T.maphongban,NV_T.TD,NV_T.ngaysinh,NV_T.socmnd
							 ) AS NV_L ON PB.ma = NV_L.maphongban
					  GROUP BY NV_L.ma,NV_L.ten,NV_L.diachi,NV_L.dienthoai,NV_L.email,NV_L.gioitinh,NV_L.ngaysinh,NV_L.socmnd,NV_L.maChucVu,NV_L.maluong,NV_L.TD,PB.ten
		  )AS NV_PB ON CV.ma = NV_PB.maChucVu
   END
GO
/****** Object:  StoredProcedure [dbo].[Getten]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Getten]
  @ten nvarchar(30)
 as
    begin 
	   select ma 
	   from   dbo.ChucVu
	   where   ten like @ten

end

GO
/****** Object:  StoredProcedure [dbo].[GettenL]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GettenL]
  @luongcoban float
 as
    begin 
	   select ma 
	   from   dbo.Luong 
	   where  luongcoban like @luongcoban

end
GO
/****** Object:  StoredProcedure [dbo].[GettenPB]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GettenPB]
  @ten nvarchar(30)
 as
    begin 
	   select ma 
	   from   dbo.PhongBan
	   where   ten like @ten

end

GO
/****** Object:  StoredProcedure [dbo].[GettenTDHV]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GettenTDHV]
  @ten nvarchar(30)
 as
    begin 
	   select ma 
	   from   dbo.TrinhDoHocVan
	   where   ten like @ten

end

GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[ma] [varchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[phuCap] [varchar](10) NULL,
	[ghiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Luong]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Luong](
	[ma] [varchar](10) NOT NULL,
	[hesoluong] [float] NULL DEFAULT ((0)),
	[luongcoban] [float] NULL DEFAULT ((0)),
	[hesophucap] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[NhanVien](
	[ma] [varchar](10) NULL,
	[ten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [bit] NULL,
	[diachi] [nvarchar](200) NULL,
	[socmnd] [varchar](15) NULL,
	[dienthoai] [varchar](10) NULL,
	[email] [nvarchar](50) NULL,
	[maChucVu] [varchar](10) NULL,
	[maluong] [varchar](10) NULL,
	[maphongban] [varchar](10) NULL,
	[maTDHV] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhongBan](
	[ma] [varchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[dienthoai] [varchar](10) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrinhDoHocVan]    Script Date: 04/22/2017 10:44:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TrinhDoHocVan](
	[ma] [varchar](10) NOT NULL,
	[ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_TrinhDoHocVan] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [TTN_QLNS] SET  READ_WRITE 
GO

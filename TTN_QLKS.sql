
USE [TTN_QLKS]

CREATE function [dbo].[auto_ma_DangKy]() returns varchar(6)
as
begin
declare @ma varchar(50)
if(select count(ma) from DangKy)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from DangKy
set @ma=case
when
@ma>=0 and @ma<9 then 'DK000'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=9 and @ma<99then 'DK00'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=99 and @ma<999then 'DK0'+CONVERT(char,CONVERT(int,@ma)+1)
end
return @ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_DichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_DichVu]() returns varchar(6)
as
begin
declare @ma varchar(50)
if(select count(ma) from DichVu)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from DichVu
set @ma=case
when
@ma>=0 and @ma<9 then 'DV000'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=9 and @ma<99then 'DV00'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=99 and @ma<999then 'DV0'+CONVERT(char,CONVERT(int,@ma)+1)
end
return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_Khach]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_Khach]() returns varchar(5)
as
begin
declare @ma varchar(50)
if(select count(ma) from Khach)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from Khach
set @ma=case
when
@ma>=0 and @ma<9 then 'K000'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=9 and @ma<99then 'K00'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=99 and @ma<999then 'K0'+CONVERT(char,CONVERT(int,@ma)+1)
end
return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_NhanVien]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_ma_NhanVien]() returns varchar(6)
as
begin
declare @ma varchar(50)
if(select count(ma) from NhanVien)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from NhanVien
set @ma=case
when
@ma>=0 and @ma<9 then 'NV000'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=9 and @ma<99then 'NV00'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=99 and @ma<999then 'NV0'+CONVERT(char,CONVERT(int,@ma)+1)
end
return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_ma_phong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[auto_ma_phong]() returns varchar(5)
as
begin
declare @ma varchar(50)
if(select count(ma) from Phong)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from Phong
set @ma=case
when
@ma>=0 and @ma<9 then 'P000'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=9 and @ma<99then 'P00'+CONVERT(char,CONVERT(int,@ma)+1)
when @ma>=99 and @ma<999then 'P0'+CONVERT(char,CONVERT(int,@ma)+1)
end
return @ma
end
GO
/****** Object:  UserDefinedFunction [dbo].[auto_maLoaiPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create function [dbo].[auto_maLoaiPhong]() returns varchar(6)
as
begin
declare @ma varchar(6)
if(select count(ma) from LoaiPhong)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from LoaiPhong
set @ma=case
when 
@ma>=0 and @ma<9 then 'LP000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'LP00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'LP0'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end

GO
/****** Object:  UserDefinedFunction [dbo].[auto_maSuDungDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[auto_maSuDungDichVu]() returns varchar(8)
as
begin
declare @ma varchar(8)
if(select count(ma) from SuDungDichVu)=0
set @ma='0'
else 
select @ma=max(right(ma,4)) from SuDungDichVu
set @ma=case
when 
@ma>=0 and @ma<9 then 'SDDV000'+CONVERT(char,convert(int,@ma)+1)
when @ma>=9 and @ma<99 then 'SDDV00'+CONVERT(char,convert(int,@ma)+1)
when @ma>=99 and @ma<999 then 'SDDV0'+CONVERT(char,convert(int,@ma)+1)
end
return 
@ma
end
GO
/****** Object:  Table [dbo].[ChitietThietBi]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ChitietThietBi](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
	[chitiet] [nvarchar](100) NOT NULL,
	[soluong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[DangKy](
	[ma] [varchar](20) NOT NULL,
	[ngaydangky] [date] NOT NULL,
	[khachma] [varchar](20) NOT NULL,
	[ngayden] [date] NOT NULL,
	[gioden] [int] NOT NULL,
	[ngaydi] [date] NOT NULL,
	[giodi] [int] NOT NULL,
	[phongma] [varchar](20) NOT NULL,
	[tiendatcoc] [float] NOT NULL,
	[nhanvienma] [varchar](20) NOT NULL,
 CONSTRAINT [PK__DangKy__3213C8B7ED430A41] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DichVu](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
	[dongia] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HuyDangKy]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HuyDangKy](
	[ma] [varchar](20) NOT NULL,
	[dangkyma] [varchar](20) NOT NULL,
	[khachma] [varchar](20) NOT NULL,
	[ngayhuy] [date] NOT NULL,
	[giohuy] [time](7) NOT NULL,
	[nhanvienma] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khach]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khach](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[quoctich] [nvarchar](30) NOT NULL,
	[chungminhthu] [varchar](20) NOT NULL,
	[sodienthoai] [varchar](12) NOT NULL,
	trangthai bit 
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiDichVu](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
	[mota] [nvarchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[giaquadem] [money] NOT NULL,
	[giaquangay] [money] NULL,
 CONSTRAINT [PK__LoaiPhon__3213C8B72370E907] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanPhong](
	[ma] [varchar](20) NOT NULL,
	[khachma] [varchar](20) NOT NULL,
	[phongma] [varchar](20) NOT NULL,
	[ngaynhan] [date] NOT NULL,
	[gionhan] [time](7) NOT NULL,
	[nhanvienma] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[chucvu] [nvarchar](20) NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[dienthoai] [varchar](12) NOT NULL,
	[taikhoan] [varchar](20) NULL,
	[matkhau] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Phong](
	[ma] [varchar](20) NOT NULL,
	[sophong] [int] NOT NULL,
	[loaiphongma] [varchar](20) NOT NULL,
	[trangthai] [int] NOT NULL,
	[dongia] [float] NULL,
 CONSTRAINT [PK__Phong__3213C8B7666BC360] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuDungDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SuDungDichVu](
	[ma] [varchar](20) NOT NULL,
	[phongma] [varchar](20) NOT NULL,
	[khachma] [varchar](20) NOT NULL,
	[dichvuma] [varchar](20) NOT NULL,
	[ngaysudung] [date] NOT NULL,
	[soluong] [int] NOT NULL,
	[thanhtien] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[ma] [varchar](20) NOT NULL,
	[dangkyma] [varchar](20) NOT NULL,
	[ngaythanhtoan] [date] NOT NULL,
	[giothanhtoan] [time](7) NOT NULL,
	[tienphong] [float] NOT NULL,
	[tiendichvu] [float] NOT NULL,
	[tongtien] [float] NOT NULL,
	[nhanvienma] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThietBiPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThietBiPhong](
	[ma] [varchar](20) NOT NULL,
	[ten] [nvarchar](30) NOT NULL,
	[chitietthietbima] [varchar](20) NOT NULL,
	[phongma] [varchar](20) NOT NULL,
	[soluong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TraPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TraPhong](
	[ma] [varchar](20) NOT NULL,
	[khachma] [varchar](20) NOT NULL,
	[dangkyma] [varchar](20) NOT NULL,
	[ngaytra] [date] NOT NULL,
	[giotra] [time](7) NOT NULL,
	[nhanvienma] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK__DangKy__khachma__24927208] FOREIGN KEY([khachma])
REFERENCES [dbo].[Khach] ([ma])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK__DangKy__khachma__24927208]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK__DangKy__nhanvien__47DBAE45] FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK__DangKy__nhanvien__47DBAE45]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK__DangKy__phongma__25869641] FOREIGN KEY([phongma])
REFERENCES [dbo].[Phong] ([ma])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK__DangKy__phongma__25869641]
GO
ALTER TABLE [dbo].[HuyDangKy]  WITH CHECK ADD  CONSTRAINT [FK__HuyDangKy__dangk__286302EC] FOREIGN KEY([dangkyma])
REFERENCES [dbo].[DangKy] ([ma])
GO
ALTER TABLE [dbo].[HuyDangKy] CHECK CONSTRAINT [FK__HuyDangKy__dangk__286302EC]
GO
ALTER TABLE [dbo].[HuyDangKy]  WITH CHECK ADD FOREIGN KEY([khachma])
REFERENCES [dbo].[Khach] ([ma])
GO
ALTER TABLE [dbo].[HuyDangKy]  WITH CHECK ADD FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[NhanPhong]  WITH CHECK ADD FOREIGN KEY([khachma])
REFERENCES [dbo].[Khach] ([ma])
GO
ALTER TABLE [dbo].[NhanPhong]  WITH CHECK ADD FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[NhanPhong]  WITH CHECK ADD  CONSTRAINT [FK__NhanPhong__phong__2D27B809] FOREIGN KEY([phongma])
REFERENCES [dbo].[Phong] ([ma])
GO
ALTER TABLE [dbo].[NhanPhong] CHECK CONSTRAINT [FK__NhanPhong__phong__2D27B809]
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([dichvuma])
REFERENCES [dbo].[DichVu] ([ma])
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([khachma])
REFERENCES [dbo].[Khach] ([ma])
GO
ALTER TABLE [dbo].[SuDungDichVu]  WITH CHECK ADD FOREIGN KEY([phongma])
REFERENCES [dbo].[Phong] ([ma])
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD  CONSTRAINT [FK__ThanhToan__dangk__35BCFE0A] FOREIGN KEY([dangkyma])
REFERENCES [dbo].[DangKy] ([ma])
GO
ALTER TABLE [dbo].[ThanhToan] CHECK CONSTRAINT [FK__ThanhToan__dangk__35BCFE0A]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
ALTER TABLE [dbo].[ThietBiPhong]  WITH CHECK ADD FOREIGN KEY([ma])
REFERENCES [dbo].[ChitietThietBi] ([ma])
GO
ALTER TABLE [dbo].[ThietBiPhong]  WITH CHECK ADD  CONSTRAINT [FK__ThietBiPh__phong__70DDC3D8] FOREIGN KEY([phongma])
REFERENCES [dbo].[Phong] ([ma])
GO
ALTER TABLE [dbo].[ThietBiPhong] CHECK CONSTRAINT [FK__ThietBiPh__phong__70DDC3D8]
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD  CONSTRAINT [FK__TraPhong__dangky__31EC6D26] FOREIGN KEY([dangkyma])
REFERENCES [dbo].[DangKy] ([ma])
GO
ALTER TABLE [dbo].[TraPhong] CHECK CONSTRAINT [FK__TraPhong__dangky__31EC6D26]
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD FOREIGN KEY([khachma])
REFERENCES [dbo].[Khach] ([ma])
GO
ALTER TABLE [dbo].[TraPhong]  WITH CHECK ADD FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[NhanVien] ([ma])
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[procedure_insertDichVu](@ten nvarchar(20),@dongia money)
as
begin
insert into DichVu(ma,ten,dongia)
values(dbo.auto_ma_DichVu(),@ten,@dongia)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_insertLoaiPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[procedure_insertLoaiPhong](@ten nvarchar(20),@mota nvarchar(50),@soluong int,@giaquangay money,@giaquadem money)
as
begin
insert into LoaiPhong(ma,ten,mota,soluong,giaquangay,giaquadem)
values(dbo.auto_maLoaiPhong(),@ten,@mota,@soluong,@giaquangay,@giaquadem)
end



GO
/****** Object:  StoredProcedure [dbo].[procedure_insertPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_insertPhong](@sophong int,@loaiphong varchar(20),@trangthai int)
as
begin
insert into Phong(ma,sophong,loaiphongma,trangthai)
values(dbo.auto_ma_phong(),@sophong,@loaiphong,@trangthai)
end

GO
/****** Object:  StoredProcedure [dbo].[procedure_insertSuDungDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create  proc [dbo].[procedure_insertSuDungDichVu](@phongma varchar(20),@khachma varchar(20),@dichvuma varchar(20),@soluong int)
as
begin
declare @thanhtien money
set @thanhtien=@soluong*(select dongia from DichVu where ma=@dichvuma)
insert into SuDungDichVu(ma,phongma,khachma,dichvuma,ngaysudung,soluong,thanhtien)
values(dbo.auto_maSuDungDichVu(),@phongma,@khachma,@dichvuma,GETDATE(),@soluong,@thanhtien)
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_updateDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[procedure_updateDichVu](@ma varchar(20),@ten nvarchar(20),@dongia money)
as
begin
update DichVu
set ten=@ten,dongia=@dongia where ma=@ma
end

GO
/****** Object:  StoredProcedure [dbo].[procedure_updateLoaiPhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[procedure_updateLoaiPhong](@ma varchar(20),@ten nvarchar(20),@mota nvarchar(50),@soluong int,@giaquangay money,@giaquadem money)
as
begin
update LoaiPhong
set ten=@ten,mota=@mota,soluong=@soluong,giaquangay=@giaquangay,giaquadem=@giaquadem
where ma=@ma
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_updatePhong]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_updatePhong](@ma varchar(20),@sophong int,@loaiphong varchar(20),@trangthai int)
as
begin
update Phong
set sophong=@sophong,loaiphongma=@loaiphong,trangthai=@trangthai
where ma=@ma
end
GO
/****** Object:  StoredProcedure [dbo].[procedure_updateSuDungDichVu]    Script Date: 30/05/2017 7:21:17 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[procedure_updateSuDungDichVu](@ma varchar(20),@phongma varchar(20),@khachma varchar(20),@dichvuma varchar(20),@soluong int)
as
begin
declare @thanhtien money
set @thanhtien=@soluong*(select dongia from DichVu where ma=@dichvuma)
update SuDungDichVu
set  phongma=@phongma,khachma=@khachma,dichvuma=@dichvuma,soluong=@soluong,thanhtien=@thanhtien
where ma=@ma
end
GO
-----------hòa-----------------------------------------
create proc [dbo].[proc_insert_DatPhong](@khachma varchar(20), @phongma varchar(20),@ngaydangky date, @ngayden date, @gioden int, 
@ngaydi date, @giodi int, @tiendatcoc money , @nhanvienma varchar(20))
as
begin 
	insert into DangKy(ma, 	ngaydangky,	 khachma, ngayden, gioden, ngaydi, 	giodi, phongma, tiendatcoc, nhanvienma)
	values (dbo.auto_ma_DangKy(), @ngaydangky, @khachma, @ngayden, @gioden, @ngaydi, @giodi, @phongma, @tiendatcoc, @nhanvienma)
	update phong set trangthai = 1 where phong.ma = @phongma

end 

ALTER proc [dbo].[proc_insertKhach](@ten nvarchar(50), @ngaysinh date, @gioitinh int, @diachi nvarchar(50),
 @quoctich nvarchar(30), @chungminhthu varchar(20), @sodienthoai varchar(12))
as
begin
	if(@ten = '' or @ngaysinh = '' or @ngaysinh = '' or @diachi = '' or @quoctich = '' or @chungminhthu = '' 
	or @sodienthoai = '')
		print ''
		--rollback tran
	else if not exists (select ma from khach where ten= @ten and ngaysinh = @ngaysinh  and chungminhthu = @chungminhthu)
	begin
		insert into Khach(ma, ten, ngaysinh, gioitinh, diachi, quoctich, chungminhthu, sodienthoai)
		values (dbo.auto_ma_Khach(), @ten, @ngaysinh, @gioitinh, @diachi, @quoctich, @chungminhthu, @sodienthoai)
	end
	
end



---------------------4/6----------------------Nga



--1.


ALTER proc [dbo].[DanhSachKhachHang]
 as
 begin
  declare @count int
  select @count =(select count(*) from Khach)
   if @count >0
     begin
	    select k.ma as [Mã khách hàng], k.ten as [Tên khách hàng], k.ngaysinh as [Ngày sinh], k.gioitinh as [Giới tính],
		k.diachi as [Địa chỉ], k.quoctich as [Quốc tịch],k.chungminhthu as [Chứng minh thư], k.sodienthoai as [Số điện thoại] from Khach k where  k.trangthai=1
	 end
  else 
    begin
	  select null as [Mã khách hàng], null as [Tên khách hàng], null as [Ngày sinh], null as [Giới tính], null as [Địa chỉ],
	  null as [Quốc tịch],null as [Chứng minh thư] , null as [Số điện thoại]
	end
 end


 --2.

 ALTER proc [dbo].[SuaThongTinKhach]
  @ma varchar(20),
  @ten nvarchar(50),
  @ngaysinh date,
  @gioitinh bit,
  @diachi nvarchar(50),
  @quoctich nvarchar(50),
  @socmnd varchar(20),
  @sodt varchar(20)
  as
   begin
     update Khach set ten=@ten,ngaysinh=@ngaysinh,gioitinh=@gioitinh,diachi= @diachi,
	 quoctich=@quoctich,chungminhthu=@socmnd,sodienthoai =@sodt
	 where ma= @ma
   end

   --3.

   ALTER proc [dbo].[ThemKhachHang]
@ten nvarchar(50),
@ngaysinh date,
@gioitinh bit,
@diachi nvarchar(50),
@quoctich nvarchar(50),
@socmnd varchar(20),
@sodienthoai varchar(20)
as
 begin
 insert into Khach(ma,ten,ngaysinh,gioitinh,diachi,quoctich,chungminhthu,sodienthoai,trangthai) 
 values(dbo.auto_ma_Khach(),@ten,@ngaysinh,@gioitinh,@diachi,@quoctich,@socmnd,@sodienthoai,1)
 end

 --4.

  ALTER proc [dbo].[XoaThongTinKhach]
 @ma varchar(20)
 as
 begin
   update Khach set trangthai=0 where ma=@ma
 end

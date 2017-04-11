create database TTN_QLKS
use  TTN_QLKS

create table Khach
(
 ma varchar(20) primary key not null,
 ten nvarchar(30) not null,
 ngaysinh date not null,
 gioitinh bit not null,
 diachi nvarchar(50) not null,
 quoctich nvarchar(30) not null,
 chungminhthu varchar(20) not null,
 sodienthoai varchar(12) not null
)
create table LoaiPhong
(
ma varchar(20) primary key  not null,
ten nvarchar(20) not null,
mota nvarchar(50) not null,
gia float not null,
soluong  int not null

)
create table Phong
(
ma varchar(20) primary key not null,
sophong int not null,
loaiphongma varchar(20) not null,
foreign key(loaiphongma) references LoaiPhong(ma),
dongia float  not null,
trangthai varchar(10) not null
)
create table DichVu
(
ma varchar(20) primary key not null,
ten nvarchar(20) not null,
dongia float not null
)
create table NhanVien
(
ma varchar(20) primary key not null,
ten nvarchar(30) not null,
ngaysinh date not null,
gioitinh bit not null,
chucvu nvarchar(20) not null,
diachi nvarchar(50)  not null,
dienthoai varchar(12) not null
)
create table ChitietThietBi
(
ma varchar(20) primary key not null,
ten nvarchar(50) not null,
chitiet nvarchar(100) not null,
soluong int not null
)

create table ThietBiPhong
(
ma varchar(20) primary key not null foreign key(ma) references ChitietThietBi(ma),
ten nvarchar(30) not null,
phongma varchar(20) not null  foreign key(phongma) references Phong(ma),
soluong int  not null
)
create table DangKy
(
ma varchar(20) primary key not null,
ngaydangky date not null,
khachma varchar(20) not null foreign key(khachma) references Khach(ma),
ngayden date not null,
gioden time not null,
ngaydi date not null,
giodi time not null,
phongma  varchar(20) not null foreign key(phongma) references Phong(ma),
tiendatcoc float not null
)
create table HuyDangKy
(
ma varchar(20) primary key not null,
dangkyma varchar(20) not null foreign key(dangkyma) references DangKy(ma),
khachma varchar(20) not null foreign key(khachma) references Khach(ma),
ngayhuy date not null,
giohuy time not null
)
create table NhanPhong
(
ma varchar(20) primary  key  not null,
khachma varchar(20) not null foreign key(khachma) references Khach(ma),
phongma varchar(20) not null foreign key(phongma) references Phong(ma),
ngaynhan date not null,
gionhan time not null
)
create table TraPhong
(
ma varchar(20) primary key not null,
khachma varchar(20) not null foreign key(khachma) references Khach(ma),
dangkyma varchar(20) not null foreign key(dangkyma) references DangKy(ma),
ngaytra date not null,
giotra time not null
)
create table ThanhToan
(
ma varchar(20) primary key not null,
khachma varchar(20) not null foreign key(khachma) references Khach(ma),
dangkyma varchar(20) not null foreign key(dangkyma) references DangKy(ma),
phongma varchar(20) not null foreign key(phongma) references Phong(ma),
ngaythanhtoan date  not null,
giothanhtoan time not null,
tienphong float not  null,
tiendichvu float not null,
tongtien float not null
)
create table SuDungDichVu
(
ma varchar(20) primary key not null,
khachma varchar(20) not null foreign key(khachma) references Khach(ma),
dangkyma varchar(20) not null foreign key(dangkyma) references DangKy(ma),
dichvuma varchar(20) not null foreign key(dichvuma) references DichVu(ma),
ngaysudung date not null,
dongia float not null
)


select *from Khach
 
 insert into Khach values('K0001',N'Nguyễn Văn Nam','1975-1-1',1,N'Nam Định',N'Việt Nam','163636261','01233456789')
 insert into Khach values('K0002',N'Nguyễn Văn Nghĩa','1975-3-1',1,N'Nam Định',N'Việt Nam','163637261','01239456789')
 insert into Khach values('K0003',N'Nguyễn Văn Nam','1975-1-11',1,N'Nam Định',N'Việt Nam','168636261','01234456789')
 insert into Khach values('K0004',N'Nguyễn Văn Nam','1975-1-12',1,N'Nam Định',N'Việt Nam','163639261','01236456789')
 insert into Khach values('K0005',N'Nguyễn Văn Nam','1975-1-14',1,N'Nam Định',N'Việt Nam','165636261','01232456789')

 select *from LoaiPhong

 insert  into LoaiPhong values('LP0001',N'Phòng standard(STD)',N'phòng tiêu chuẩn,giá rẻ nhất',650000,100)
 insert  into LoaiPhong values('LP0002',N'Phòng Superior (SUP)',N'phòng chất  lượng hơn STD',750000,100)
 insert  into LoaiPhong values('LP0003',N'Phòng DeluxeTwin',N'phòng đôi chất lượng',850000,100)
 insert  into LoaiPhong values('LP0004',N'Phòng Deluxe(DLX)',N'phòng đơn chất lượng',800000,100)
 insert  into LoaiPhong values('LP0005',N'Phòng Suite (SUT)',N'phòng cao cấp',1000000,100)

 select *From phong
 insert into Phong values('P0001',201,'LP0001',650000,N'Còn phòng') 
 insert into Phong values('P0002',301,'LP0002',750000,N'Còn phòng')
 insert into Phong values('P0003',401,'LP0003',850000,N'Còn phòng')
 insert into Phong values('P0004',501,'LP0004',800000,N'Còn phòng')
 insert into Phong values('P0005',601,'LP0005',1000000,N'Còn phòng')

 select *from NhanVien
 insert into NhanVien values('NV0001',N'Nguyễn Vân  Anh','1976-1-1',0,N'Lễ tân',N'Hà Nội','01239456789')
 insert into NhanVien values('NV0002',N'Nguyễn Thị  Anh','1973-1-1',0,N'Lễ tân',N'Hà Nội','01233496789')
 insert into NhanVien values('NV0003',N'Nguyễn Vân  A','1976-4-1',0,N'Lễ tân',N'Hà Nội','01233458789')
 insert into NhanVien values('NV0004',N'Nguyễn  Anh Nam','1970-1-1',1,N'giám đốc',N'Hà Nội','01233457789')
 insert into NhanVien values('NV0005',N'Nguyễn Thị Vân  Anh','1989-1-1',0,N'Lễ tân',N'Hà Nội','01233455789')

 select *from  ChitietThietBi
insert into ChitietThietBi values('CTTB0001',N'giường đôi',N'Giường ngủ 1,6m',500)
insert into ChitietThietBi values('CTTB0002',N'Ti  Vi LCD',N'TV LCD 32 inch truyền hình vệ tinh',500)
insert into ChitietThietBi values('CTTB0003',N'Điện thoại',N'Điện thoại gọi trực tiếp trong nước và quốc tế',500)
insert into ChitietThietBi values('CTTB0004',N'wifi',N'Internet wifi và cáp miễn phí tốc độ cao',500)
insert into ChitietThietBi values('CTTB0005',N'Điều hòa Daikin',N'Điều hòa Daikin 2 chiều công suất lớn',500)
insert into ChitietThietBi values('CTTB0006',N'Tủ quần  áo',N'Tủ treo quần áo, mắc áo',500)
insert into ChitietThietBi values('CTTB0007',N' Bàn trà',N' Bàn trà',500)
insert into ChitietThietBi values('CTTB0008',N'Bộ pha trà, cà phê',N'Bộ pha trà, cà phê',500)
insert into ChitietThietBi values('CTTB0009',N'Bàn làm việc',N'Bàn làm việc',500)
insert into ChitietThietBi values('CTTB0010',N'Tủ lạnh (Minibar) và đồ uống các loại',N'Tủ lạnh (Minibar) và đồ uống các loại',500)
insert into ChitietThietBi values('CTTB0011',N'Bàn làm việc',N'Bàn làm việc',500)
insert into ChitietThietBi values('CTTB0012',N'Bình đun nước siêu tốc',N'Bình đun nước siêu tốc',500)
insert into ChitietThietBi values('CTTB0013',N'Chăn, Ga, Gối ngoại',N'Chăn, Ga, Gối 100% cotton nhập ngoại',500)
insert into ChitietThietBi values('CTTB0014',N'Bình nóng lạnh siêu tốc',N'Bình nóng lạnh siêu tốc',500)
insert into ChitietThietBi values('CTTB0015',N'Bồn tắm',N'Bồn tắm đứng vách kính và vòi tắm hoa sen.',500)
insert into ChitietThietBi values('CTTB0016',N'máy sấy tóc',N'máy sấy tóc',500)
insert into ChitietThietBi values('CTTB0017',N'Bộ đồ dùng',N'dầu gội đầu, sữa tắm, lược,bàn chải đánh răng,bông tăm,chụp tóc, dao cạo râu.',500)
insert into ChitietThietBi values('CTTB0018',N'Bộ đồ tắm',N'Khăn tắm, khăn mặt, khăn chân ( khăn cao cấp, dài rộng và bông mềm)',500)
insert into ChitietThietBi values('CTTB0019',N'Báo cháy',N'Hệ thống báo cháy tự động',500)
insert into ChitietThietBi values('CTTB0020',N'Camera',N'Camera giám sát an ninh 24/24 ',500)

select *From ThietBiPhong

insert into ThietBiPhong values('CTTB0001',N'giường đôi','P0001',1)

select *from DichVu

insert into DichVu values('DV0001',N'giặt là',100000)
insert into DichVu values('DV0002',N'spa',1000000)
insert into DichVu values('DV0003',N'giải trí',1000000)
insert into DichVu values('DV0004',N'thức ăn',600000)

select *from SuDungDichVu
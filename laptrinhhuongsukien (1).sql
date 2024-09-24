create database QLBanSach
go
use QLBanSach
go


--Tạo bảng nhân và ràng buộc
create table tblNhanVien
(	sMaNV varchar(6)  primary key,
	sTenNV nvarchar(25) ,
	dNgaysinh date  check (datediff(year,dNgaysinh , getdate()) >=18),
	sGioiTinh nvarchar(4),
	sQueQuan nvarchar(25) ,
	sSDT varchar(11),
	iLuongCB int  ,
	fHSL float  check (fHSL >= 1),
	iPC int check (iPC > 0),
	sTenCV nvarchar(25) ,
	sTaiKhoan varchar(50) ,
	sMatKhau varchar (50)
)
go
create proc prDoiMK (@taikhoan varchar(50), @matkhau varchar(50))
as begin 
update tblNhanVien set sTaiKhoan = @taikhoan,
sMatKhau = @matkhau
where sTaiKhoan = @taikhoan
end
drop proc prDoiMK
create table tblKhachHang 
(	sMaKH varchar(6) primary key,
	sTenKH nvarchar(60) not null,
	sDiaChi nvarchar(25) not null,
	sSDT varchar(11) not null
)
go
create table tblNXB 
(	sMaNXB varchar(7) primary key,
	sTenNXB nvarchar(60) not null,
	sDiaChi nvarchar(25),
	sSDT varchar(11),
)
go
create table tblSach 
(	sMaSach varchar(6) primary key,
	sTenSach nvarchar(25) not null,
	sMaNXB varchar(7) not null references tblNXB(sMaNXB),
	sTacGia nvarchar(25) not null,
	sTheLoai nvarchar(30),
	iGia int check (iGia > 0)
)
go

create table tblHoaDon
(	sMaHD varchar(6) primary key,
	sMaNV varchar(6) not null references tblNhanVien(sMaNV),
	sMaKH varchar(6) not null references tblKhachHang(sMaKH),
	dNgayLap date check(dNgayLap <= getDate())
)
go
create table tblChiTietHD 
(	sMaHD varchar(6) references tblHoaDon(sMaHD),
	sMaSach varchar(6) references tblSach(sMaSach),
	sTenSach nvarchar(25) ,
	iSl int not null check (iSL >0),
	iTien int not null 
	constraint pk primary key (sMaHD, sMaSach)
	)
go

insert into tblNhanVien
values	('nv01',N'Đỗ Trọng Ninh','2003/09/28',N'Nam',N'Thái Bình','0382127239',5500000,3.1,700000,N'Quản Lý','DoTrongNinhABC','redandblue1'),
	('nv02',N'Vũ Việt Anh','2003/08/09',N'Nam',N'Thái Bình','0435859656',3000000,2,700000,N'Trợ Lý','VuVietAnhABC','redandblue2'),
	('nv03',N'Hà Anh Tuấn','2003/05/18',N'Nam',N'Hà Nội','0582133024',7000000,1.3,500000,N'Giám Đốc','HaAnhTuanABC','redandblue3'),
	('nv04',N'Bùi Thị An','2002/01/26',N'Nữ',N'Cao Bằng','0975542678',3000000,2,1000000,N'Saler','BuiThiAnABC','redandblue4'),
	('nv05',N'Nguyễn Đức Cường','2003/07/31',N'Nam',N'Hà Nội','0582198024',6000000,1.3,500000,N'Trưởng Phòng','NguyenDucCuongABC','redandblue5')
select * from tblNhanVien

insert tblKhachHang
values ('kh01',N'Vũ Đình Kiên',N'Thái Nguyên','0345557892'),
		('kh02',N'Hoàng Văn Mạnh',N'Hòa Bình','0375457836'),
		('kh03',N'Lê Thảo Mai',N'Hà Nội','0345557891'),
		('kh04',N'Phùng Thanh Độ',N'Cao Bằng','0567337890'),
		('kh05',N'Hoàng Bảo',N'Bắc Cạn','0237757836')

insert tblNXB
values ('nx1',N'Kim Đồng',N'Hà Nội','0985622222'),
		('nx2',N'Quốc Gia',N'Đà Nẵng','0934839393'),
		('nx3',N'Lê Khánh',N'Hồ Chí Minh','0384688888'),
		('nx4',N'Đình Kiên',N'Thái Nguyên','0345555896')

insert tblSach
values ('s1',N'Toán 1','nx2',N'Hoàng Long',N'Sách giáo khoa', 25000),
		('s2',N'Doreamon','nx1',N'Fujiko Fujio',N'Truyện', 20000),
		('s3',N'Chuông Gió','nx4',N'Ninz Leo',N'Tiểu Thuyết', 50000),
		('s4',N'Học tốt văn','nx2',N'Bảo Anh',N'Sách tham khảo', 70000),
		('s5',N'Lập trình','nx1',N'Tâm Tâm',N'Giáo Trình', 150000),
		('s6',N'Bạch Tuyết','nx4',N'AnDec Xen',N'Truyện', 30000),
		('s7',N'Đắc Nhân Tâm','nx1',N'Dale Carnegie',N'Tâm Lý Học', 90000),
		('s8',N'Tôi Tài Giỏi','nx3',N'Lê Chung',N'Tâm Lý Học', 200000),
		('s9',N'Sherlock Holmes','nx4',N'Conan Doyle',N'Trinh Thám', 120000)
		delete  from tblSach

insert tblHoaDon
values ('hd1','nv01','kh02','2022/05/05'),
		('hd2','nv03','kh05','2021/03/01'),
		('hd3','nv05','kh04','2020/11/23'),
		('hd4','nv02','kh01','2022/02/15'),
		('hd6','nv03','kh03','2019/04/13'),
		('hd7','nv01','kh04','2022/07/28'),
		('hd8','nv03','kh02','2022/03/01')
		


--Vũ Việt Anh
--Hà Anh Tuấn
--Ngô Thị Trang
--Nguyễn Đức Anh (Me)

select * from tblNhanVien
select * from tblKhachHang
select * from tblNXB
select * from tblSach
select * from tblHoaDon
select * from tblChiTietHD
go

-- tblSach
CREATE PROC Update_tblSach
@maSach varchar(6), 
@tenSach nvarchar(25),
@maNXB varchar(7), 
@tacGia nvarchar(25),
@theLoai nvarchar(30),
@gia int
AS
BEGIN
	UPDATE tblSach SET
	sTenSach = @tenSach,
	sMaNXB = @maNXB,
	sTacGia = @tacGia,
	sTheLoai = @theLoai,
	iGia = @gia
	WHERE sMaSach = @maSach
END
go

-- tblNhanVien
CREATE PROC Delete_tblNhanVien
@manv varchar(6)
AS
BEGIN
	DELETE tblNhanVien
	WHERE sMaNV = @manv
END
go

-- tblSach
CREATE PROC Delete_tblSach
@maSach varchar(6)
AS
BEGIN
	DELETE tblSach
	WHERE sMaSach = @maSach
END
go

-- tblKhachHang
CREATE PROC Delete_tblKhachHang
@makh varchar(6)
AS
BEGIN
	DELETE tblKhachHang
	WHERE sMaKH = @makh
END
go

--delete from tblKhachHang
--where sMaKH = 'kh01'
--go

-- tblSach
CREATE PROC Insert_tblSach
@maSach varchar(6), 
@tenSach nvarchar(25),
@maNXB varchar(7), 
@tacGia nvarchar(25),
@theLoai nvarchar(30),
@gia int
AS
INSERT INTO tblSach(sMaSach, sTenSach, sMaNXB, sTacGia, sTheLoai, iGia)
VALUES(@maSach, @tenSach, @maNXB, @tacGia, @theLoai, @gia)
go

-- tblNXB
CREATE PROC Insert_tblNXB
@maNXB varchar(6), 
@tenNXB nvarchar(25),
@diaChi nvarchar(25),
@sdt nvarchar(25)
AS
INSERT INTO tblNXB(sMaNXB, sTenNXB, sDiaChi, sSDT)
VALUES(@maNXB, @tenNXB, @diaChi, @sdt)
go

CREATE PROC Delete_tblNXB
@maNXB varchar(6)
AS
BEGIN
	DELETE tblNXB
	WHERE sMaNXB = @maNXB
END
go

CREATE PROC Update_tblNXB
@maNXB varchar(6), 
@tenNXB nvarchar(25),
@diaChi nvarchar(25),
@sdt nvarchar(25)
AS
BEGIN
	UPDATE tblNXB SET
	sTenNXB = @tenNXB,
	sDiaChi = @diaChi,
	sSDT = @sdt
	WHERE sMaNXB = @maNXB
END
go
create view vv_ChiTiet
as
select tblSach.sMaSach, sTenSach,iSl,iGia,sum(iSl* iGia)[Tong Tien]
from tblSach, tblChiTietHD
where tblChiTietHD.sMaSach = tblSach.sMaSach
group by tblSach.sMaSach, sTenSach,iSl,iGia

insert into tblNhanVien
values	('nv06',N'Ngô Thị Trang','2003/12/22',N'Nữ',N'Hà Nội','0377964321',9500000,3.5,800000,N'CEO','TrangNgoThi','123')

CREATE PROC Select_All
@maHD varchar(6)
AS
BEGIN
	SELECT HD.*, sMaSach, sTenSach, iSl, iTien  FROM tblHoaDon HD 
	INNER JOIN tblChiTietHD CTHD
	ON HD.sMaHD = CTHD.sMaHD
	WHERE HD.sMaHD = @maHD
END
create view vv_NVnghihuu
as
select sTenNV,dNgaysinh,sGioiTinh,sQueQuan,iLuongCB
from tblNhanVien
where (sGioiTinh = N'Nam'  and (datediff(year,dNgaysinh , getdate()) >=60)) or (sGioiTinh =  N'Nữ'and(datediff(year,dNgaysinh , getdate()) >=55))
select*from vv_NVnghihuu
drop view vv_NVnghihuu
insert into tblNhanVien
values	('nv07',N'Đỗ Trọng Ninh','1965/09/28',N'Nam',N'Thái Bình','0382127239',5500000,3.1,700000,N'Quản Lý','DoTrongNinh','redandblue1'),
	('nv08',N'Vũ Việt Anh','1962/08/09',N'Nữ',N'Thái Bình','0435859656',3000000,2,700000,N'Trợ Lý','VuVietAnh','redandblue2')

create view vwThongKeTheoNgay
as
select tblHoaDon.sMaHD, tblHoaDon.dNgayLap, tblKhachHang.sMaKH, tblNhanVien.sTenNV, sum(tblChiTietHD.iTien) as iTongTien
from tblHoaDon, tblKhachHang, tblNhanVien, tblChiTietHD
where tblHoaDon.sMaKH = tblKhachHang.sMaKH
and tblChiTietHD.sMaHD = tblHoaDon.sMaHD
and tblHoaDon.sMaNV = tblNhanVien.sMaNV
group by tblHoaDon.sMaHD, tblHoaDon.dNgayLap, tblKhachHang.sMaKH, tblNhanVien.sTenNV
go

select * from vwThongKeTheoNgay
go

create view vwTongDoanhThu
as
select sum(iTongTien) as iTongDoanhThu
from vwThongKeTheoNgay
go
create database NhanVien3
use NhanVien3
drop database NhanVien1

create table TblNguoiDung (
	Id uniqueidentifier primary key,
	IdNhanVien uniqueidentifier not null,
	TenDangNhap varchar(20) not null,
	Pass varchar(20) not null,
	KichHoat bit not null,
	IdVaiTro uniqueidentifier not null,
	TrangThai bit not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null
)
--DROP TABLE TblNguoiDung

create table TblVaiTro(
	Id uniqueidentifier primary key,
	VaiTro nvarchar(50) not null,
	QuyenThem bit not null,
	QuyenSua bit not null,
	QuyenXoa bit not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null,
	TrangThai bit not null
)
	ALTER TABLE TblNguoiDung
	ADD CONSTRAINT fk_ND_VT
	FOREIGN KEY(IdVaiTro) 
	REFERENCES TblVaiTro(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE 

--DROP TABLE TblVaiTro

create table TblNhanVien (
	Id uniqueidentifier primary key,
	HoNhanVien nvarchar(10) not null,
	TenNhanVien nvarchar(50) not null,
	NamSinh date not null,
	NgayVaoLam date not null,
	SDT int not null,
	Gmail varchar(50) not null,
	DiaChi nvarchar(50) not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null,
	TrangThai bit not null
)

create table TblKhachHang (
	Id uniqueidentifier primary key,
	HoTen nvarchar(50) not null,
	DiaChi nvarchar(100) null,
	SDT int not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null,
	TrangThai bit not null
)

--drop table TblKhachHang
create table TblRaVao ( 
	Id uniqueidentifier primary key,
	IdNhanVien uniqueidentifier not null,
	ThoiGian Datetime not null,
	IdVanPhong uniqueidentifier not null,
	MoTa uniqueidentifier not null,
	--Loai nvarchar(100) not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null,
	TrangThai bit not null,
	IdKhachHang uniqueidentifier null
)

--alter table TblRaVao drop column Loai

--ALTER TABLE TblRaVao ALTER COLUMN IdKhachHang varchar(16) null

create table TblMauThongBao(
	Id uniqueidentifier primary key,
	TenMauThongBao nvarchar(100) not null,
	NoiDung ntext not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null,
	TrangThai bit not null
)

create table TblVanPhong(
	Id uniqueidentifier primary key,
	TenVanPhong nvarchar(200) not null,
	NgayTao datetime not null,
	NguoiTao nvarchar(50) not null,
	NgayCapNhat datetime null,
	NguoiCapNhat nvarchar(50) null,
	TrangThai bit not null
)

create table TblBinhLuan (
	Id uniqueidentifier primary key,
	IdNguoiBinhLuan uniqueidentifier not null,
	NoiDung ntext not null,
	IdThoiGianRaVao uniqueidentifier not null,
	TrangThai bit not null,
	NgayTao datetime not null,
	NgayCapNhat datetime null
)

	ALTER TABLE TblBinhLuan
	ADD CONSTRAINT fk_BL_NV
	FOREIGN KEY (IdNguoiBinhLuan)
	REFERENCES  TblNhanVien(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE 

--	ALTER TABLE PhanQuyen
--	ADD CONSTRAINT fk_NV_PQ
--	FOREIGN KEY(MaNV) 
--	REFERENCES NhanVien(MaNV)
--	ON DELETE CASCADE 
--	ON UPDATE CASCADE 

 --ALTER TABLE BinhLuan DROP CONSTRAINT fk_BL_NV

	ALTER TABLE TblRaVao
	ADD CONSTRAINT fk_NV_RV
	FOREIGN KEY(IdNhanVien) 
	REFERENCES TblNhanVien(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE 

	ALTER TABLE TblRaVao
	ADD CONSTRAINT fk_NV_VP
	FOREIGN KEY(IdVanPhong) 
	REFERENCES TblVanPhong(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE 

	ALTER TABLE TblNguoiDung
	ADD CONSTRAINT fk_ND_NV
	FOREIGN KEY(IdNhanVien) 
	REFERENCES TblNhanVien(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE 

--ALTER TABLE TblNguoiDung DROP CONSTRAINT fk_ND_NV

	ALTER TABLE TblNguoiDung
	ADD CONSTRAINT fk_ND_NND
	FOREIGN KEY(IdVaiTro) 
	REFERENCES TblVaiTro(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE 

	--ALTER TABLE TblVaiTro DROP CONSTRAINT fk_Q_NND
	--ALTER TABLE TblNguoiDung DROP CONSTRAINT fk_ND_NND
	--ALTER TABLE TblNguoiDung DROP CONSTRAINT fk_ND_NV

	ALTER TABLE TblRaVao
	ADD CONSTRAINT fk_RV_MTT
	FOREIGN KEY(MoTa) 
	REFERENCES TblMauThongBao(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE

	
	ALTER TABLE TblRaVao
	ADD CONSTRAINT fk_RV_KH
	FOREIGN KEY(IdKhachHang) 
	REFERENCES TblKhachHang(Id)
	ON DELETE CASCADE 
	ON UPDATE CASCADE

--ALTER TABLE TblRaVao DROP CONSTRAINT fk_RV_KH



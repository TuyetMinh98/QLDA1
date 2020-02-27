insert into TblKhachHang values ('4b5e95a7-745a-462f-ae53-709a8583700a',N'Nguyễn Thi', N'Khánh Hòa','0963254178','2000/10/10','NV1','','','1')
insert into TblKhachHang values (NEWID(),N'Nguyễn Thi', N'Khánh Hòa','0963254178','2000/10/10','NV1','','','1')
insert into TblKhachHang values (NEWID(),N'Trần Hạnh', N'Phú Yên','0960001111','2001/11/06','NV1','','','1')
insert into TblKhachHang values (NEWID(),N'Kì Hạ', N'Phú Yên','091252111','2001/11/06 06:17:00.000','NV1','','','1')
insert into TblKhachHang values (NEWID(),N' Hạ hí', N'Phú Yên','095852111','2001/11/06 06:17:00.000','NV2','','','1')
select * from TblKhachHang

insert into TblMauThongBao values (NEWID(),N'Gặp Khách Hàng',N'Gặp khách hàng bàn hợp đồng','2000/10/10 07:00:00.000','Minh','','','1')
insert into TblMauThongBao values (NEWID(),N'Vấn đề cá nhân',N'vấn đề cá nhân ','2000/10/10 07:00:00.000','Minh','','','1')
insert into TblMauThongBao values (NEWID(),N'Công việc của công ty',N'giải quyết công việc của công ty','2000/10/10 07:00:00.000','Minh','','','1')
insert into TblMauThongBao values (NEWID(),N'Vào ca',N'Vào ca làm','2000/10/10 07:00:00.000','Thu','','','1')
insert into TblMauThongBao values (NEWID(),N'Tan Ca',N'Tan Ca Về Nhà','2000/10/10 07:00:00.000','Thu','','','1')


insert into TblVanPhong values (NEWID(),N'SweetSoft Trần Qúy Cáp','2000/10/10 07:00:00.000',N'Hà','','','1')
insert into TblVanPhong values (NEWID(),N'SweetSoft Khu Đô Thị VCN 02 Tố Hữu','2000/10/10 07:00:00.000',N'Hà','','','1')


insert into TblVaiTro values (NEWID(),N'Trưởng Phòng','1','1','1','2000/10/10 07:00:00.000','Thu','','','1')
insert into TblVaiTro values (NEWID(),N'Nhân Viên','1','1','0','2000/10/10 07:00:00.000','Thu','','','1')

insert into TblNhanVien values (NEWID(),N'Phạm',N'Thị Thu','1975/01/02','2000/01/10','0985858371','thu123@gmail.com',N'01 Cam Lâm Nha Trang','2000/01/10','Hà','','','1')
insert into TblNhanVien values (NEWID(),N'Nguyễn',N'Vân','1980/01/01','2000/01/10','096325417','van@gmail.com',N'10 Thống Nhất Nha Trang','2000/01/10','Thu','','','1')
insert into TblNhanVien values (NEWID(),N'Trần',N'Thị Hà','1975/01/02','2000/01/10','0903030172','tranthiha@gmail.com',N'Ninh Hòa Nha Trang','2000/01/10','Hà','','','1')
insert into TblNhanVien values (NEWID(),N'Trần',N'Cường','1990/01/02','2000/01/10','094568498','cuong0101@gmail.com',N'Ninh Hòa Nha Trang','2001/01/10','Hà','','','1')
insert into TblNhanVien values (NEWID(),N'Hoàng',N'Mỹ Duyên','1970/01/02','2000/01/10','0903991701','myduyen08@gmail.com',N'Tp Hồ Chí Minh','2000/01/10','Hà','','','1')
insert into TblNhanVien values (NEWID(),N'Phùng',N'Minh','1969/01/02','2000/01/10','0911191701','minh12308@gmail.com',N'Đà Nẵng','2000/01/10','Hà','','','1')
insert into TblNhanVien values (NEWID(),N'Cao',N'NV1','1969/01/02','2000/01/10','0911191701','nv1@gmail.com',N'Đà Nẵng','2000/01/10','Hà','','','1')

select * from TblNhanVien
select * from TblVaiTro

insert into TblNguoiDung values (NEWID(),'57ECCE16-E17B-4A37-AD62-13E869782E68','vannguyen','123456@','1','248ED7C7-2C2B-4076-8AA5-3DEFBBD6D3E2','1','2000/01/10 07:00:00.000','Thu','','')
insert into TblNguoiDung values (NEWID(),'150597FD-7D84-47E2-8CEA-14BC554F5F5D','thupham','123456@','1','D58995DB-1B07-4383-8C22-4DE4CD9F67A4','1','2000/01/10 07:00:00.000','Thu','','')
insert into TblNguoiDung values (NEWID(),'05937B65-C29A-445B-99D0-8D1EE4B21DA2','hatran','123456@','1','D58995DB-1B07-4383-8C22-4DE4CD9F67A4','1','2000/01/10 07:00:00.000','Thu','','')
insert into TblNguoiDung values (NEWID(),'1250254C-F654-415A-AA36-9F84F3A9F577','nv1','123456@','1','D58995DB-1B07-4383-8C22-4DE4CD9F67A4','1','2000/01/10 07:00:00.000','Thu','','')
insert into TblNguoiDung values (NEWID(),'BC0EED40-DD4A-4D44-AB9B-A51E434476C5','cuongtran','123456@','1','D58995DB-1B07-4383-8C22-4DE4CD9F67A4','1','2000/01/10 07:00:00.000','Thu','','')
insert into TblNguoiDung values (NEWID(),'CFF65EE6-9FAB-4F4D-BD54-D156F7879CA1','myduyen','123456@','1','248ED7C7-2C2B-4076-8AA5-3DEFBBD6D3E2','1','2000/01/10 07:00:00.000','Thu','','')
insert into TblNguoiDung values (NEWID(),'3A18D7DD-4D35-4479-AB64-7BA1FA1A8E8C','minhminh','123456@','1','D58995DB-1B07-4383-8C22-4DE4CD9F67A4','1','2000/01/10 07:00:00.000','Thu','','')

select * from TblNhanVien
select * from TblVanPhong
select * from TblMauThongBao
select * from TblKhachHang
select * from TblNhanVien
select * from  TblThongBao

delete from TblThongBao

insert into TblThongBao values (NEWID(),'57ECCE16-E17B-4A37-AD62-13E869782E68','2001/01/01 08:00:00.000','BA0CD0F3-628D-4E40-AC0A-8C351DA063EE','96D697C3-05C6-43A3-BFA3-F16F40C69B77','2000/01/10 08:00:00.000',N'Vân','','','1','')
insert into TblThongBao values (NEWID(),'150597FD-7D84-47E2-8CEA-14BC554F5F5D','2001/01/01 08:00:00.000','BA0CD0F3-628D-4E40-AC0A-8C351DA063EE','96D697C3-05C6-43A3-BFA3-F16F40C69B77','2000/01/10 08:00:00.000','Thu','','','1','')
insert into TblThongBao values (NEWID(),'150597FD-7D84-47E2-8CEA-14BC554F5F5D','2001/01/01 09:00:00.000','BA0CD0F3-628D-4E40-AC0A-8C351DA063EE','7CCA07DF-F333-4BC6-8AD3-019B98A31E81','2000/01/10 09:00:00.000','Thu','','','1','4B5E95A7-745A-462F-AE53-709A8583700A')
insert into TblThongBao values (NEWID(),'57ECCE16-E17B-4A37-AD62-13E869782E68','2001/01/01 17:30:00.000','BA0CD0F3-628D-4E40-AC0A-8C351DA063EE','07B34DFE-0FDD-401D-89DC-74DBF0D24B73','2000/01/10 17:30:00.000',N'Vân','','','1','')
insert into TblThongBao values (NEWID(),'3A18D7DD-4D35-4479-AB64-7BA1FA1A8E8C','2002/10/10 08:00:00.000','8AE1C8ED-A03A-4F52-8C8D-B7FABFEDA60A','96D697C3-05C6-43A3-BFA3-F16F40C69B77','2002/10/10 08:00:00.000',N'Minh','','','1','')

insert into TblBinhLuan values (NEWID(),'05937B65-C29A-445B-99D0-8D1EE4B21DA2','Đúng giờ quá','949D9B71-255A-428F-A366-938D07016A15','1','2001/01/01 17:30:00.000','','')

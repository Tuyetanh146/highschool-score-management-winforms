--Thiết kế CSDL--
USE QL_HOCSINH_THPT;
Go
--Bảng lớp
Drop table if exists Lop;
Go
Create table Lop(
Malop char(10) Primary Key,
Tenlop nvarchar(50) not null,
SiSo int check (SiSo >=0)
);
Go

--Bảng Học sinh
Drop table if exists HocSinh;
Go
Create table HocSinh(
MaHS char(10) Primary Key,
HoTen nvarchar(100) not null,
NgaySinh Date Check (NgaySinh <= GetDate()),  --Ràng buộc ktra ngày sinh phải nhỏ hơn hoăc bằng ngày hiện tại
GioiTinh nvarchar(5) check (GioiTinh in (N'Nam' , N'Nữ')),
Diachi nvarchar(200) , 
Malop char(10) not null,
Foreign Key (Malop) References Lop(Malop)
     On Delete Cascade On Update Cascade 
);
Go
--Bảng Môn học 
Drop table if exists MonHoc;
Go
Create table MonHoc(
MaMH char(10) Primary Key,
TenMH nvarchar(50) not null,
HeSo int check (HeSo > 0)
);
Go

--Bảng Giáo Viên 
Drop table if exists GiaoVien;
Go
Create table GiaoVien(
MaGV char(10) Primary Key ,
HoTen nvarchar(100) not null,
GioiTinh nvarchar(5) check(GioiTinh in(N'Nam' , N'Nữ')),
SĐT varchar(15) unique, 
MaMH char(10),
Foreign Key (MaMh) References MonHoc(MaMH)
);
Go

--Bảng Điểm 
Drop table if exists Diem;
Go
Create table Diem(
MaHS char(10) ,
MaMH char (10),
Hocky int Check (Hocky in (1,2)),
DiemMieng float Check(DiemMieng Between 0 and 10),
Diem15p float Check (Diem15p Between 0 and 10),
Diem1Tiet float Check (Diem1Tiet Between 0 and 10),
DiemThi float Check (DiemThi Between 0 and 10),
Primary Key(MaHS , MaMH , HocKy),
Foreign Key (MaHS) References HocSinh(MaHS),
Foreign Key (MaMH) References MonHoc(MaMH)
);   
Go

--Bảng Tài khoản (phục vụ qly)
Drop table if exists TAIKHOAN;
Go
Create table TAIKHOAN (
    TenDangNhap VARCHAR(50) PRIMARY KEY,
    MatKhau VARCHAR(100) NOT NULL,
    Quyen NVARCHAR(20) CHECK (Quyen IN (N'Admin', N'GiaoVien', N'GiaoVu'))
);
Go
--Tạo dữ liệu mẫu --
--BẢNG Lớp 
Insert into Lop(Malop , Tenlop , SiSo)
Values 
('10A1' , N'Lớp 10A1' , '40'),
('11A1' , N'Lớp 11A1' , '35'),
('12A1' , N'Lớp 12A1' , '45');
Go

--BẢNG Học sinh
Insert into HocSinh (MaHS , HoTen , NgaySinh , GioiTinh , Diachi , Malop)
Values
('HS001' , N'Nguyễn Minh Anh' , '2010-02-12' , N'Nữ' , N'Hà Nội' , '10A1'),
('HS002' , N'Nguyễn Đức Duy' , '2010-04-23' , N'Nam' , N'Hà Nội' , '10A1'),
('HS003' , N'Phạm Ngọc Mai' , '2010-06-09' , N'Nữ' , N'Hà Nội' , '10A1'),
('HS004' , N'Phạm Quốc Việt ' , '2009-08-20' , N'Nam' , N'Đà Nẵng' , '11A1'),
('HS005' , N'Hoàng Đức Nam' , '2009-11-26' , N'Nam' , N'Đà Nẵng' , '11A1'),
('HS006' , N'Lê Thị Ngọc Ánh' , '2009-03-20' , N'Nữ' , N'Đà Nẵng' , '11A1'),
('HS007' , N'Trần Phương Linh' , '2008-11-03' , N'Nữ' , N'Ninh Bình' , '12A1'),
('HS008' , N'Trần Thu Giang' , '2008-10-15' , N'Nữ' , N'Ninh Bình' , '12A1'),
('HS009' , N'Nguyễn Phong' , '2008-04-11' , N'Nam' , N'Ninh Bình' , '12A1');
Go
--Lop10A1
Insert into HocSinh (MaHS , HoTen , NgaySinh , GioiTinh , Diachi , Malop)
Values
('HS011', N'Lê Thị Hương', '2010-03-18', N'Nữ', N'Hà Nội', '10A1'),
('HS012', N'Phạm Tuấn Anh', '2010-05-20', N'Nam', N'Hà Nội', '10A1'),
('HS013', N'Ngô Thu Trang', '2010-07-11', N'Nữ', N'Hà Nội', '10A1'),
('HS014', N'Trần Đức Minh', '2010-09-09', N'Nam', N'Hà Nội', '10A1'),
('HS015', N'Hoàng Mai Anh', '2010-10-02', N'Nữ', N'Hà Nội', '10A1'),
('HS016', N'Nguyễn Quốc Huy', '2010-11-22', N'Nam', N'Hà Nội', '10A1'),
('HS017', N'Lê Ngọc Ánh', '2010-12-01', N'Nữ', N'Hà Nội', '10A1'),
('HS018', N'Bùi Thanh Tùng', '2010-06-06', N'Nam', N'Hà Nội', '10A1'),
('HS019', N'Đặng Thị Mai', '2010-08-18', N'Nữ', N'Hà Nội', '10A1'),
('HS020', N'Phan Văn Khánh', '2010-04-04', N'Nam', N'Hà Nội', '10A1'),
('HS021', N'Nguyễn Thùy Linh', '2010-02-28', N'Nữ', N'Hà Nội', '10A1');
Go
--Lop11A1
Insert into HocSinh (MaHS , HoTen , NgaySinh , GioiTinh , Diachi , Malop)
Values
('HS022', N'Nguyễn Văn Dũng', '2009-01-10', N'Nam', N'Đà Nẵng', '11A1'),
('HS023', N'Lê Thị Hoa', '2009-02-15', N'Nữ', N'Đà Nẵng', '11A1'),
('HS024', N'Phạm Hồng Sơn', '2009-03-19', N'Nam', N'Đà Nẵng', '11A1'),
('HS025', N'Trần Thị Ngọc', '2009-04-21', N'Nữ', N'Đà Nẵng', '11A1'),
('HS026', N'Hoàng Quốc Việt', '2009-05-30', N'Nam', N'Đà Nẵng', '11A1'),
('HS027', N'Vũ Thanh Hà', '2009-06-14', N'Nữ', N'Đà Nẵng', '11A1'),
('HS028', N'Đinh Văn Long', '2009-07-09', N'Nam', N'Đà Nẵng', '11A1'),
('HS029', N'Nguyễn Thị Lan', '2009-08-11', N'Nữ', N'Đà Nẵng', '11A1'),
('HS030', N'Lý Minh Tuấn', '2009-09-22', N'Nam', N'Đà Nẵng', '11A1'),
('HS031', N'Phạm Thị Hạnh', '2009-10-01', N'Nữ', N'Đà Nẵng', '11A1'),
('HS032', N'Ngô Đức Anh', '2009-11-05', N'Nam', N'Đà Nẵng', '11A1');

Go
--Lop12A1
Insert into HocSinh (MaHS , HoTen , NgaySinh , GioiTinh , Diachi , Malop)
Values
('HS034', N'Nguyễn Văn Thành', '2008-01-17', N'Nam', N'Ninh Bình', '12A1'),
('HS035', N'Lê Thị Phương', '2008-02-20', N'Nữ', N'Ninh Bình', '12A1'),
('HS036', N'Phạm Quốc Toàn', '2008-03-18', N'Nam', N'Ninh Bình', '12A1'),
('HS037', N'Trần Ngọc Hân', '2008-04-25', N'Nữ', N'Ninh Bình', '12A1'),
('HS038', N'Hoàng Đức Cường', '2008-05-29', N'Nam', N'Ninh Bình', '12A1'),
('HS039', N'Vũ Thị Mai', '2008-06-14', N'Nữ', N'Ninh Bình', '12A1'),
('HS040', N'Nguyễn Văn Khôi', '2008-07-07', N'Nam', N'Ninh Bình', '12A1'),
('HS041', N'Đặng Thị Thảo', '2008-08-08', N'Nữ', N'Ninh Bình', '12A1'),
('HS042', N'Phan Minh Tuấn', '2008-09-09', N'Nam', N'Ninh Bình', '12A1'),
('HS043', N'Lê Thị Ngân', '2008-10-10', N'Nữ', N'Ninh Bình', '12A1'),
('HS044', N'Bùi Văn Duy', '2008-11-11', N'Nam', N'Ninh Bình', '12A1'),
('HS045', N'Nguyễn Thu Hà', '2008-12-12', N'Nữ', N'Ninh Bình', '12A1');
Go

Insert into  HocSinh (MaHS, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop)
Values
('HS031', N'Nguyễn Thị Hạnh', '2008-01-01', N'Nữ', N'', '11A1'),
('HS044', N'Phạm Văn Duy ', '2007-01-01', N'Nam', N'', '12A1'),
('HS045', N'Nguyễn Thu Trà', '2007-01-01', N'Nữ', N'', '12A1');
Go

--BẢNG Môn học 
Insert into MonHoc (MaMH , TenMH,HeSo )
Values
('MH01', N'Toan', 2),
('MH02', N'Ly', 2),
('MH03', N'Hoa', 2),
('MH04', N'Sinh', 1),
('MH05', N'Van', 2),
('MH06', N'Su', 1);
Go
Insert into MonHoc (MaMH , TenMH,HeSo )
Values
('MH07', N'Địa', 1);
Go

-- BẢNG GiaoVien
Insert into GiaoVien (MaGV, HoTen, GioiTinh, SĐT, MaMH)
values ('GV02', N'Thanh Mai V', N'Nữ', '0911222333', 'MH02');

Insert into GiaoVien (MaGV, HoTen, GioiTinh, SĐT, MaMH)
values ('GV04', N'Nam Thi W', N'Nữ', '0933444555', 'MH04');

Insert into GiaoVien (MaGV, HoTen, GioiTinh, SĐT, MaMH)
values ('GV05', N'Nguyen Van Z', N'Nam', '0965667788', 'MH05');

Insert into GiaoVien (MaGV, HoTen, GioiTinh,SĐT, MaMH)
values ('GV06', N'Dang Thi E', N'Nữ', '0977888999', 'MH06');

Insert into GiaoVien (MaGV, HoTen, GioiTinh,SĐT, MaMH)
values ('GV07', N'Pham Thi H', N'Nữ', '0909090909', 'MH07');
Go

--BẢNG Điểm Học kỳ 1
Insert into Diem(MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
Values
('HS001' , 'MH01' , 1,8,9,7,8),
('HS002' , 'MH05' , 1,6,7,7,9),
('HS003' , 'MH02' , 1,8,9,9,8),
('HS004' , 'MH06' , 1,5,7,8,7),
('HS005' , 'MH04' , 1,9,6,7,8),
('HS006' , 'MH03' , 1,10,9,8,8),
('HS007' , 'MH05' , 1,7,9,8,7),
('HS008' , 'MH07' , 1,9,9,7,10),
('HS009' , 'MH02' , 1,6,8,9,7);
Go
Insert into Diem(MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
Values
('HS003' , 'MH03' , 1,6,8,9,9),
('HS004' , 'MH01' , 1,9,5,7,8),
('HS006' , 'MH07' , 1,7,9,6,6),
('HS007' , 'MH06' , 1,7,7,8,8),
('HS008' , 'MH03' , 1,9,9,8,6),
('HS009' , 'MH01' , 1,8,9,6,9);
Go
--Lop 10A1
Insert into Diem (MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
values
('HS011','MH01',1,9,8,7,8),
('HS012','MH01',1,6,7,7,6),
('HS013','MH01',1,8,8,8,9),
('HS014','MH01',1,7,6,7,7),
('HS015','MH01',1,8,7,8,8),
('HS016','MH01',1,6,6,7,6),
('HS017','MH01',1,7,7,8,7),
('HS018','MH01',1,8,8,7,8),
('HS019','MH01',1,9,8,9,8),
('HS020','MH01',1,7,7,7,7),
('HS021','MH01',1,8,9,8,9);
Go

--Lop 11A1
Insert into Diem (MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
values
('HS022','MH05',1,7,8,7,8),
('HS023','MH05',1,9,8,9,8),
('HS024','MH05',1,6,6,7,6),
('HS025','MH05',1,7,8,7,8),
('HS026','MH05',1,8,9,8,9),
('HS027','MH05',1,7,7,8,7),
('HS028','MH05',1,6,7,6,7),
('HS029','MH05',1,8,8,8,8),
('HS030','MH05',1,7,7,7,7),
('HS031','MH05',1,9,8,9,8),
('HS032','MH05',1,8,7,8,7),
('HS033','MH05',1,7,6,7,6);
Go
--Lop 12A1
Insert into Diem (MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
values
('HS034','MH02',1,8,8,9,8),
('HS035','MH02',1,7,6,7,6),
('HS036','MH02',1,6,7,6,7),
('HS037','MH02',1,9,9,8,9),
('HS038','MH02',1,7,7,8,7),
('HS039','MH02',1,8,7,8,7),
('HS040','MH02',1,7,8,7,8),
('HS041','MH02',1,6,7,6,7),
('HS042','MH02',1,8,8,8,8),
('HS043','MH02',1,7,7,7,7),
('HS044','MH02',1,9,8,9,8),
('HS045','MH02',1,8,9,8,9);
Go
--BẢNG Điểm Học ky 2
Insert into Diem(MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
Values
('HS001','MH02',2,7,8,7,8),
('HS002','MH05',2,9,8,8,9),
('HS003','MH03',2,7,6,7,7),
('HS004','MH01',2,7,7,8,8),
('HS005','MH04',2,8,9,7,9),
('HS006','MH07',2,7,8,6,7),
('HS007','MH06',2,7,9,6,8),
('HS008','MH03',2,8,8,9,7),
('HS009','MH01',2,9,8,6,7);
Go
--Lop 10A1
Insert into Diem(MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
Values
('HS010','MH01',2,8,8,9,8),
('HS011','MH01',2,9,9,8,9),
('HS012','MH01',2,7,7,8,7),
('HS013','MH01',2,8,9,8,9),
('HS014','MH01',2,7,7,8,7),
('HS015','MH01',2,8,8,8,8),
('HS016','MH01',2,7,7,7,7),
('HS017','MH01',2,8,8,9,8),
('HS018','MH01',2,8,9,8,9),
('HS019','MH01',2,9,9,9,9),
('HS020','MH01',2,7,8,7,8),
('HS021','MH01',2,8,9,8,9);
Go
--Lop 11A1
Insert into Diem(MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
Values
('HS022','MH05',2,8,8,8,8),
('HS023','MH05',2,9,9,8,9),
('HS024','MH05',2,7,7,7,7),
('HS025','MH05',2,8,8,8,8),
('HS026','MH05',2,9,9,8,9),
('HS027','MH05',2,8,8,9,8),
('HS028','MH05',2,7,7,8,7),
('HS029','MH05',2,8,9,8,9),
('HS030','MH05',2,7,7,7,7),
('HS031','MH05',2,9,9,9,9),
('HS032','MH05',2,8,8,8,8),
('HS033','MH05',2,7,7,7,7);
Go
--Lop 12A1
Insert into Diem(MaHS, MaMH, HocKy, DiemMieng , Diem15p , Diem1Tiet , DiemThi)
Values
('HS034','MH02',2,9,8,9,8),
('HS035','MH02',2,7,7,8,7),
('HS036','MH02',2,7,7,8,7),
('HS037','MH02',2,9,9,9,9),
('HS038','MH02',2,8,8,8,8),
('HS039','MH02',2,8,8,9,8),
('HS040','MH02',2,7,8,7,8),
('HS041','MH02',2,7,7,7,7),
('HS042','MH02',2,8,8,8,8),
('HS043','MH02',2,7,7,7,7),
('HS044','MH02',2,9,9,9,9),
('HS045','MH02',2,8,9,8,9);
Go

--BẢNG Tài khoản
Insert into TAIKHOAN(TenDangNhap , MatKhau , Quyen) 
Values
('Admin1' , '45678' , N'Admin'),
('GV01' , '890' , N'GiaoVien');
Go
Insert into TAIKHOAN(TenDangNhap , MatKhau , Quyen) 
Values
('GVU01', '125698' , N'GiaoVu');
Go

Select * From TAIKHOAN;
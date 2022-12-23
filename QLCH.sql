create database QuanLyCuaHang
GO
USE QuanLyCuaHang
GO



CREATE TABLE LOAIHANGHOA(
  MaLoaiHangHoa char(50) PRIMARY KEY,
  TenHangHoa nvarchar(100),
  GhiChu Nvarchar(100),
)
GO
CREATE TABLE NHACUNGCAP(
  MaNhaCungCap char(50) PRIMARY key,
  TenNhaCungCap nvarchar(100),
  DiaChi nvarchar(100),
  DienThoai int,
  MaTaiKhoan char(50),
  KhuVuc nvarchar(100),
  GhiChu nvarchar(100)
)
GO
CREATE TABLE PHIEUCUNGUNG(
  SoPhieu char(50) PRIMARY KEY,
  NgayLapPhieu datetime,
  TriGiaPhieu int,
  MaNhaCungCap char(50),
  FOREIGN KEY(MaNhaCungCap) REFERENCES NHACUNGCAP(MaNhaCungCap)
)
GO
CREATE TABLE HANGHOA(
  MaHangHoa char(50) PRIMARY KEY,
  TenHangHoa nvarchar(100),
  QuyCach nvarchar(100),
  DonViTinh nvarchar(100),
  DonGia int,
  MaLoaiHangHoa char(50),
  FOREIGN key(MaLoaiHangHoa) REFERENCES LOAIHANGHOA(MaLoaiHangHoa)
)
GO
CREATE TABLE CHITIETCUNGUNG(
  SoPhieu char(50) PRIMARY KEY,
  MaHangHoa char(50),
  SoLuong int,
  ThanhTien int,
  FOREIGN key(MaHangHoa) REFERENCES HANGHOA(MaHangHoa),
  FOREIGN key(SoPhieu) REFERENCES PHIEUCUNGUNG(SoPhieu)
)
GO
CREATE TABLE KHANANG(
  MaNhaCungCap char(50) primary key,
  MaHangHoa char(50),
  GhiChu nvarchar(100),
  FOREIGN key (MaNhaCungCap) REFERENCES NHACUNGCAP(MaNhaCungCap),
  FOREIGN key (MaHangHoa) REFERENCES HANGHOA(MaHangHoa)
)
GO


GO
INSERT INTO NHACUNGCAP VALUES('NCC1', N'TH True milk tại Hà Nội', N'Đống Đa Hà Nội', 0123456789, N'101475612', 'Chi nhánh phường 5 Hà Nội', 'Ghi chú 1')
INSERT INTO NHACUNGCAP VALUES('NCC2',  N'Công ty bánh ngọt miền Nam', N'Quận 7 thành phố Hồ Chí Minh', 0175368179, N'10278423', 'Chi nhánh phường 6 quận 8 Thành phố Hồ Chí Minh', 'Ghi chú 2')
INSERT INTO NHACUNGCAP VALUES('NCC3',  N'Cà Phê Trung Nguyên', N'Ba Vì Hà Nội', 0182176654, N'6972813364', 'Chi nhánh phường 6 Hà Nội', 'Ghi chú 3')
INSERT INTO NHACUNGCAP VALUES('NCC4',  N'Chuyên sỉ và lẻ các nguyên liệu đóng hộp', N'Quận 10 thành phố Hồ Chí Minh', 0182176654, N'6972813364', 'Chi nhánh phường 6 Hà Nội', 'Ghi chú 4')
INSERT INTO NHACUNGCAP VALUES('NCC5',  N'Nước uống  nguyên chất', N'Châu Thành, Đồng Nai', 0182176654, N'6972813364', 'Chi nhánh phường 6 Hà Nội', 'Ghi chú 5')
GO
INSERT INTO PHIEUCUNGUNG VALUES('SP1', '2022/01/06', 1205462, 'NCC1')
INSERT INTO PHIEUCUNGUNG VALUES('SP2', '2022/02/07', 578322, 'NCC2')
INSERT INTO PHIEUCUNGUNG VALUES('SP3', '2022/03/08', 269822, 'NCC3')
INSERT INTO PHIEUCUNGUNG VALUES('SP4', '2022/05/02', 269822, 'NCC4')
INSERT INTO PHIEUCUNGUNG VALUES('SP5', '2022/06/03', 269822, 'NCC5')
GO
INSERT INTO LOAIHANGHOA VALUES ('MLHH1', N'Sữa', N'Thùng')
INSERT INTO LOAIHANGHOA VALUES ('MLHH2', N'Bánh', N'Hộp')
INSERT INTO LOAIHANGHOA VALUES ('MLHH3', N'Cà phê', N'Lốc')
INSERT INTO LOAIHANGHOA VALUES ('MLHH4', N'Sản phẩm đóng hộp', N'Lốc')
INSERT INTO LOAIHANGHOA VALUES ('MLHH5', N'Nước uống đóng chai', N'Lốc')
GO
INSERT INTO HANGHOA VALUES('MHH1', N'Sữa TH True Milk vị dâu', N'Bán theo thùng', N'Thùng', 2450000, 'MLHH1')
INSERT INTO HANGHOA VALUES('MHH2', N'Bánh qui kinh đô vị trà xanh', N'Bán theo hộp', N'Hộp', 150000, 'MLHH3')
INSERT INTO HANGHOA VALUES('MHH3', N'Cà phê chồn', N'Bán theo lốc', N'Lốc', 350000, 'MLHH2')
INSERT INTO HANGHOA VALUES('MHH4', N'Cá hộp ba cô gái', N'Bán theo lốc', N'Lốc', 350000, 'MLHH5')
INSERT INTO HANGHOA VALUES('MHH5', N'Nước khoáng Lavi', N'Bán theo lốc', N'Lốc', 350000, 'MLHH4')
GO
INSERT INTO CHITIETCUNGUNG VALUES('SP1', 'MHH1', 10, 1000000)
INSERT INTO CHITIETCUNGUNG VALUES('SP2', 'MHH2', 20, 2000000)
INSERT INTO CHITIETCUNGUNG VALUES('SP3', 'MHH3', 30, 3000000)
INSERT INTO CHITIETCUNGUNG VALUES('SP4', 'MHH4', 40, 4000000)
INSERT INTO CHITIETCUNGUNG VALUES('SP5', 'MHH5', 50, 5000000)
GO
INSERT INTO KHANANG values ('NCC1', 'MHH1', N'Ghi chú 1')
INSERT INTO KHANANG values ('NCC2', 'MHH2', N'Ghi chú 2')
INSERT INTO KHANANG values ('NCC3', 'MHH3', N'Ghi chú 3')
INSERT INTO KHANANG values ('NCC4', 'MHH4', N'Ghi chú 4')
INSERT INTO KHANANG values ('NCC5', 'MHH5', N'Ghi chú 5')
GO








	






















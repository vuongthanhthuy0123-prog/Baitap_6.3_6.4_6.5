/* =====================================================================
   SCRIPT TẠO CẢ 3 CSDL: ProjectTaskDB (6.3), GarageDB (6.4), KaraokeDB (6.5)
   Mở file trong SQL Server Management Studio -> bấm Execute (F5)
   ===================================================================== */

/* =====================================================================
   BÀI 6.3 - HỆ THỐNG QUẢN LÝ CÔNG VIỆC & TIẾN ĐỘ DỰ ÁN
   CSDL: ProjectTaskDB
   ===================================================================== */
USE master;
GO
IF DB_ID(N'ProjectTaskDB') IS NOT NULL
BEGIN
    ALTER DATABASE ProjectTaskDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE ProjectTaskDB;
END
GO
CREATE DATABASE ProjectTaskDB;
GO
USE ProjectTaskDB;
GO

CREATE TABLE DuAn
(
    MaDuAn      INT IDENTITY(1,1) PRIMARY KEY,
    TenDuAn     NVARCHAR(150) NOT NULL,
    NgayBatDau  DATETIME NULL,
    NgayKetThuc DATETIME NULL,
    TrangThai   NVARCHAR(50) NULL          -- 'Đang chạy', 'Hoàn thành', 'Tạm dừng'
);
GO

CREATE TABLE ThanhVien
(
    MaThanhVien INT IDENTITY(1,1) PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    Email       VARCHAR(100) NULL CONSTRAINT UQ_ThanhVien_Email UNIQUE,
    ChuyenMon   NVARCHAR(100) NULL
);
GO

-- Xóa dự án thì tự xóa các công việc con (ON DELETE CASCADE)
CREATE TABLE CongViec
(
    MaTask    INT IDENTITY(1,1) PRIMARY KEY,
    MaDuAn    INT NOT NULL CONSTRAINT FK_CongViec_DuAn REFERENCES DuAn(MaDuAn) ON DELETE CASCADE,
    TenTask   NVARCHAR(200) NOT NULL,
    MoTa      NVARCHAR(MAX) NULL,
    HanNop    DATETIME NULL,
    DoUuTien  NVARCHAR(20) NULL,            -- 'Cao', 'Trung bình', 'Thấp'
    TrangThai NVARCHAR(50) NOT NULL CONSTRAINT DF_CongViec_TrangThai DEFAULT N'To Do'   -- 'To Do', 'In Progress', 'Review', 'Done'
);
GO

CREATE TABLE PhanCong
(
    MaTask      INT NOT NULL CONSTRAINT FK_PhanCong_CongViec REFERENCES CongViec(MaTask) ON DELETE CASCADE,
    MaThanhVien INT NOT NULL CONSTRAINT FK_PhanCong_ThanhVien REFERENCES ThanhVien(MaThanhVien),
    NgayGiao    DATETIME NOT NULL CONSTRAINT DF_PhanCong_NgayGiao DEFAULT GETDATE(),
    CONSTRAINT PK_PhanCong PRIMARY KEY (MaTask, MaThanhVien)
);
GO

/* ---------- Dữ liệu mẫu ---------- */
INSERT INTO DuAn (TenDuAn, NgayBatDau, NgayKetThuc, TrangThai) VALUES
(N'Website bán hàng online',      DATEADD(DAY, -40, GETDATE()), DATEADD(DAY, 30, GETDATE()), N'Đang chạy'),
(N'Ứng dụng quản lý thư viện',    DATEADD(DAY, -20, GETDATE()), DATEADD(DAY, 45, GETDATE()), N'Đang chạy'),
(N'Hệ thống chấm công nội bộ',    DATEADD(DAY, -90, GETDATE()), DATEADD(DAY, -10, GETDATE()), N'Hoàn thành');

INSERT INTO ThanhVien (HoTen, Email, ChuyenMon) VALUES
(N'Vương Thanh Thúy', 'thuy.vt@example.com',  N'Quản lý dự án'),
(N'Nguyễn Văn An',    'an.nv@example.com',    N'Lập trình Backend'),
(N'Trần Thị Bích',    'bich.tt@example.com',  N'Lập trình Frontend'),
(N'Lê Minh Cường',    'cuong.lm@example.com', N'Kiểm thử phần mềm'),
(N'Phạm Thu Dung',    'dung.pt@example.com',  N'Thiết kế UI/UX');

INSERT INTO CongViec (MaDuAn, TenTask, MoTa, HanNop, DoUuTien, TrangThai) VALUES
(1, N'Phân tích yêu cầu',           N'Thu thập yêu cầu từ khách hàng',      DATEADD(DAY, -30, GETDATE()), N'Cao',        N'Done'),
(1, N'Thiết kế giao diện trang chủ', N'Mockup trang chủ và trang sản phẩm',  DATEADD(DAY, -10, GETDATE()), N'Cao',        N'Done'),
(1, N'Xây dựng API sản phẩm',       N'CRUD sản phẩm, tìm kiếm',             DATEADD(DAY, -3, GETDATE()),  N'Cao',        N'In Progress'),
(1, N'Trang giỏ hàng',              N'Thêm/xóa sản phẩm, tính tiền',        DATEADD(DAY, 5, GETDATE()),   N'Trung bình', N'In Progress'),
(1, N'Tích hợp thanh toán',         N'Kết nối cổng thanh toán',             DATEADD(DAY, 15, GETDATE()),  N'Cao',        N'To Do'),
(1, N'Kiểm thử chức năng đặt hàng', NULL,                                   DATEADD(DAY, -1, GETDATE()),  N'Trung bình', N'Review'),
(2, N'Thiết kế CSDL thư viện',      N'Bảng sách, độc giả, phiếu mượn',      DATEADD(DAY, -8, GETDATE()),  N'Cao',        N'Done'),
(2, N'Form quản lý sách',           NULL,                                   DATEADD(DAY, -2, GETDATE()),  N'Trung bình', N'To Do'),
(2, N'Chức năng mượn - trả',        NULL,                                   DATEADD(DAY, 10, GETDATE()),  N'Cao',        N'To Do'),
(2, N'Báo cáo sách quá hạn',        NULL,                                   DATEADD(DAY, 20, GETDATE()),  N'Thấp',       N'To Do'),
(3, N'Module chấm công vân tay',    NULL,                                   DATEADD(DAY, -20, GETDATE()), N'Cao',        N'Done'),
(3, N'Báo cáo công tháng',          NULL,                                   DATEADD(DAY, -12, GETDATE()), N'Trung bình', N'Done');

INSERT INTO PhanCong (MaTask, MaThanhVien) VALUES
(1, 1), (2, 3), (2, 5), (3, 2), (4, 3), (5, 2), (6, 4),
(7, 2), (8, 3), (9, 2), (9, 3), (10, 4), (11, 2), (12, 1);
GO

/* =====================================================================
   BÀI 6.4 - HỆ THỐNG QUẢN LÝ GARAGE VÀ BẢO DƯỠNG XE Ô TÔ
   CSDL: GarageDB
   ===================================================================== */
USE master;
GO
IF DB_ID(N'GarageDB') IS NOT NULL
BEGIN
    ALTER DATABASE GarageDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE GarageDB;
END
GO
CREATE DATABASE GarageDB;
GO
USE GarageDB;
GO

CREATE TABLE KhachHang
(
    MaKH      INT IDENTITY(1,1) PRIMARY KEY,
    TenKH     NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) NULL CONSTRAINT UQ_KhachHang_DienThoai UNIQUE,
    DiaChi    NVARCHAR(200) NULL
);
GO

CREATE TABLE Xe
(
    BienSo     VARCHAR(20) PRIMARY KEY,
    MaKH       INT NOT NULL CONSTRAINT FK_Xe_KhachHang REFERENCES KhachHang(MaKH),
    HieuXe     NVARCHAR(50) NULL,          -- 'Toyota', 'Honda', 'VinFast'...
    NamSanXuat INT NULL
);
GO

CREATE TABLE PhuTung
(
    MaPhuTung  INT IDENTITY(1,1) PRIMARY KEY,
    TenPhuTung NVARCHAR(150) NOT NULL,
    DonGia     DECIMAL(18,2) NOT NULL CONSTRAINT CK_PhuTung_DonGia CHECK (DonGia >= 0),
    SoLuongTon INT NOT NULL CONSTRAINT CK_PhuTung_SoLuongTon CHECK (SoLuongTon >= 0)
);
GO

CREATE TABLE PhieuSuaChua
(
    MaPhieu    INT IDENTITY(1,1) PRIMARY KEY,
    BienSo     VARCHAR(20) NOT NULL CONSTRAINT FK_Phieu_Xe REFERENCES Xe(BienSo),
    NgayNhan   DATETIME NOT NULL CONSTRAINT DF_Phieu_NgayNhan DEFAULT GETDATE(),
    NoiDungSua NVARCHAR(MAX) NULL,
    TongTien   DECIMAL(18,2) NOT NULL CONSTRAINT DF_Phieu_TongTien DEFAULT 0,
    TrangThai  NVARCHAR(30) NOT NULL CONSTRAINT DF_Phieu_TrangThai DEFAULT N'Đang sửa'   -- 'Đang sửa', 'Đã hoàn thành', 'Đã thanh toán'
);
GO

CREATE TABLE ChiTietSuaChua
(
    MaPhieu   INT NOT NULL CONSTRAINT FK_CTSC_Phieu REFERENCES PhieuSuaChua(MaPhieu),
    MaPhuTung INT NOT NULL CONSTRAINT FK_CTSC_PhuTung REFERENCES PhuTung(MaPhuTung),
    SoLuong   INT NOT NULL CONSTRAINT CK_CTSC_SoLuong CHECK (SoLuong > 0),
    TienCong  DECIMAL(18,2) NOT NULL CONSTRAINT DF_CTSC_TienCong DEFAULT 0,
    CONSTRAINT PK_ChiTietSuaChua PRIMARY KEY (MaPhieu, MaPhuTung)
);
GO

/* ---------- Dữ liệu mẫu ---------- */
INSERT INTO KhachHang (TenKH, DienThoai, DiaChi) VALUES
(N'Nguyễn Văn Hùng', '0903111222', N'12 Lê Lợi, Quận 1, TP.HCM'),
(N'Trần Thị Mai',    '0912333444', N'45 Nguyễn Trãi, Thanh Xuân, Hà Nội'),
(N'Lê Quốc Bảo',     '0988555666', N'8 Trần Phú, Hải Châu, Đà Nẵng');

INSERT INTO Xe (BienSo, MaKH, HieuXe, NamSanXuat) VALUES
('51H-123.45', 1, N'Toyota',  2019),
('30G-678.90', 2, N'Honda',   2021),
('43A-246.80', 3, N'VinFast', 2023),
('51K-999.01', 1, N'Mazda',   2017);

INSERT INTO PhuTung (TenPhuTung, DonGia, SoLuongTon) VALUES
(N'Dầu động cơ 5W-30 (4 lít)',  850000,  30),
(N'Lọc dầu',                    150000,  40),
(N'Lọc gió động cơ',            250000,  25),
(N'Má phanh trước (bộ)',        900000,  12),
(N'Bugi (bộ 4 cái)',            600000,  10),
(N'Ắc quy 12V 60Ah',            2200000, 5),
(N'Lốp xe 205/55R16',           1800000, 8),
(N'Nước làm mát (1 lít)',       120000,  20),
(N'Gạt mưa (cặp)',              350000,  2);

INSERT INTO PhieuSuaChua (BienSo, NgayNhan, NoiDungSua, TongTien, TrangThai) VALUES
('51H-123.45', DATEADD(DAY, -12, GETDATE()), N'Bảo dưỡng định kỳ 40.000 km', 1300000, N'Đã thanh toán'),
('30G-678.90', DATEADD(DAY, -3,  GETDATE()), N'Thay má phanh trước',         1300000, N'Đã hoàn thành');

INSERT INTO ChiTietSuaChua (MaPhieu, MaPhuTung, SoLuong, TienCong) VALUES
(1, 1, 1, 200000),
(1, 2, 1, 100000),
(2, 4, 1, 400000);
GO

/* =====================================================================
   BÀI 6.5 - HỆ THỐNG QUẢN LÝ ĐẶT PHÒNG & DỊCH VỤ KARAOKE
   CSDL: KaraokeDB
   ===================================================================== */
USE master;
GO
IF DB_ID(N'KaraokeDB') IS NOT NULL
BEGIN
    ALTER DATABASE KaraokeDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE KaraokeDB;
END
GO
CREATE DATABASE KaraokeDB;
GO
USE KaraokeDB;
GO

CREATE TABLE PhongHat
(
    MaPhong    INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong   NVARCHAR(50) NOT NULL,
    LoaiPhong  NVARCHAR(30) NULL,              -- 'VIP', 'Thường'
    GiaTheoGio DECIMAL(18,2) NOT NULL CONSTRAINT CK_PhongHat_Gia CHECK (GiaTheoGio >= 0),
    TrangThai  NVARCHAR(20) NOT NULL CONSTRAINT DF_PhongHat_TrangThai DEFAULT N'Trống'   -- 'Trống', 'Đang hát'
);
GO

CREATE TABLE DichVu
(
    MaDV   INT IDENTITY(1,1) PRIMARY KEY,
    TenDV  NVARCHAR(100) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL CONSTRAINT CK_DichVu_DonGia CHECK (DonGia >= 0),
    TonKho INT NOT NULL CONSTRAINT CK_DichVu_TonKho CHECK (TonKho >= 0)
);
GO

CREATE TABLE HoaDon
(
    MaHD           INT IDENTITY(1,1) PRIMARY KEY,
    MaPhong        INT NOT NULL CONSTRAINT FK_HoaDon_PhongHat REFERENCES PhongHat(MaPhong),
    GioVao         DATETIME NOT NULL,
    GioRa          DATETIME NULL,
    TongTienPhong  DECIMAL(18,2) NOT NULL CONSTRAINT DF_HoaDon_TienPhong DEFAULT 0,
    TongTienDichVu DECIMAL(18,2) NOT NULL CONSTRAINT DF_HoaDon_TienDV DEFAULT 0,
    TrangThai      BIT NOT NULL CONSTRAINT DF_HoaDon_TrangThai DEFAULT 0     -- 0: Chưa thanh toán, 1: Đã thanh toán
);
GO

CREATE TABLE ChiTietDichVu
(
    MaHD    INT NOT NULL CONSTRAINT FK_CTDV_HoaDon REFERENCES HoaDon(MaHD),
    MaDV    INT NOT NULL CONSTRAINT FK_CTDV_DichVu REFERENCES DichVu(MaDV),
    SoLuong INT NOT NULL CONSTRAINT CK_CTDV_SoLuong CHECK (SoLuong > 0),
    DonGia  DECIMAL(18,2) NOT NULL,
    CONSTRAINT PK_ChiTietDichVu PRIMARY KEY (MaHD, MaDV)
);
GO

/* ---------- Dữ liệu mẫu ---------- */
INSERT INTO PhongHat (TenPhong, LoaiPhong, GiaTheoGio, TrangThai) VALUES
(N'Phòng VIP 01',    N'VIP',    350000, N'Trống'),
(N'Phòng VIP 02',    N'VIP',    350000, N'Đang hát'),
(N'Phòng VIP 03',    N'VIP',    400000, N'Trống'),
(N'Phòng Thường 01', N'Thường', 180000, N'Trống'),
(N'Phòng Thường 02', N'Thường', 180000, N'Đang hát'),
(N'Phòng Thường 03', N'Thường', 150000, N'Trống'),
(N'Phòng Thường 04', N'Thường', 150000, N'Trống'),
(N'Phòng Thường 05', N'Thường', 150000, N'Trống');

INSERT INTO DichVu (TenDV, DonGia, TonKho) VALUES
(N'Bia Heineken (lon)',   30000,  120),
(N'Bia Tiger (lon)',      25000,  150),
(N'Nước suối Aquafina',   15000,  100),
(N'Coca-Cola (lon)',      20000,  80),
(N'Trái cây dĩa',         150000, 20),
(N'Khô bò',               90000,  30),
(N'Đậu phộng rang',       35000,  40),
(N'Rượu vang đỏ (chai)',  650000, 3);

/* 2 phòng đang hát (chưa thanh toán) + vài hóa đơn đã thanh toán cho báo cáo */
INSERT INTO HoaDon (MaPhong, GioVao, GioRa, TongTienPhong, TongTienDichVu, TrangThai) VALUES
(2, DATEADD(MINUTE, -95, GETDATE()), NULL, 0, 0, 0),
(5, DATEADD(MINUTE, -40, GETDATE()), NULL, 0, 0, 0),
(1, DATEADD(HOUR, -26, GETDATE()), DATEADD(HOUR, -24, GETDATE()), 700000, 330000, 1),
(4, DATEADD(HOUR, -5, GETDATE()),  DATEADD(HOUR, -3, GETDATE()),  360000, 195000, 1);

INSERT INTO ChiTietDichVu (MaHD, MaDV, SoLuong, DonGia) VALUES
(1, 1, 6, 30000),
(1, 5, 1, 150000),
(2, 3, 4, 15000),
(3, 1, 6, 30000),
(3, 5, 1, 150000),
(4, 2, 3, 25000),
(4, 4, 6, 20000);
GO

PRINT N'Đã tạo xong 3 CSDL: ProjectTaskDB, GarageDB, KaraokeDB.';
GO

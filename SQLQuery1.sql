CREATE DATABASE QuanLyTraiThuCung;
GO

USE QuanLyTraiThuCung;
GO
-- Xoa
DROP TABLE IF EXISTS SuDungDV;
DROP TABLE IF EXISTS ChamSoc;
DROP TABLE IF EXISTS DichVu;
DROP TABLE IF EXISTS ThuCung;
DROP TABLE IF EXISTS ChuNhan;
GO

-- Thú cưng
CREATE TABLE ThuCung (
    MaTC VARCHAR(5) PRIMARY KEY,   -- Mã thú cưng (TC01, TC02...)
    TenTC NVARCHAR(50),            -- Tên thú cưng
    Loai NVARCHAR(20),             -- Loại: Chó, Mèo
    NgaySinh DATE                   -- Ngày sinh
);

-- Chủ nhân
CREATE TABLE ChuNhan (
    MaCN VARCHAR(5) PRIMARY KEY,   -- Mã chủ nhân (CN01, CN02...)
    TenCN NVARCHAR(100),           -- Tên chủ nhân
    SDT VARCHAR(15)                 -- Số điện thoại
);

-- Dịch vụ
CREATE TABLE DichVu (
    MaDV VARCHAR(5) PRIMARY KEY,   -- Mã dịch vụ (DV01, DV02...)
    TenDV NVARCHAR(50),            -- Tên dịch vụ
    Gia INT                        -- Giá dịch vụ
);

-- Chăm sóc
CREATE TABLE ChamSoc (
    MaCS VARCHAR(5) PRIMARY KEY,   -- Mã chăm sóc (CS01, CS02...)
    MaTC VARCHAR(5),               -- FK Thú cưng
    MaCN VARCHAR(5),               -- FK Chủ nhân
    NgayCS DATE,                   -- Ngày chăm sóc
    FOREIGN KEY (MaTC) REFERENCES ThuCung(MaTC),
    FOREIGN KEY (MaCN) REFERENCES ChuNhan(MaCN)
);

-- Sử dụng dịch vụ
CREATE TABLE SuDungDV (
    MaCS VARCHAR(5),               -- FK Chăm sóc
    MaDV VARCHAR(5),               -- FK Dịch vụ
    PRIMARY KEY (MaCS, MaDV),
    FOREIGN KEY (MaCS) REFERENCES ChamSoc(MaCS),
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);
GO
--Tạo Join cho dgvChamSoc
CREATE OR ALTER VIEW vw_ChamSocFull
AS
SELECT
    cs.MaCS,
    cs.MaTC,
    cs.MaCN,
    tc.TenTC,
    tc.Loai,
    tc.NgaySinh,
    cn.TenCN,
    cn.SDT,
    cs.NgayCS
FROM ChamSoc cs
JOIN ThuCung tc ON cs.MaTC = tc.MaTC
JOIN ChuNhan cn ON cs.MaCN = cn.MaCN;
GO
CREATE OR ALTER VIEW vw_DanhSachSuDungDV
AS
SELECT
    cs.MaCS,
    tc.TenTC,
    tc.Loai,
    cn.TenCN,
    cn.SDT,
    cs.NgayCS,
    dv.MaDV,
    dv.TenDV,
    dv.Gia
FROM ChamSoc cs
JOIN ThuCung tc ON cs.MaTC = tc.MaTC
JOIN ChuNhan cn ON cs.MaCN = cn.MaCN
JOIN SuDungDV sd ON cs.MaCS = sd.MaCS
JOIN DichVu dv ON sd.MaDV = dv.MaDV;
GO
-- Thú cưng
INSERT INTO ThuCung VALUES
('TC01', N'Milu', N'Chó', '2022-05-10'),
('TC02', N'Miu', N'Mèo', '2023-01-15'),
('TC03', N'Ron', N'Chó', '2024-02-11'),
('TC04', N'Miro', N'Mèo', '2025-03-22'),
('TC05', N'Su', N'Mèo', '2025-04-13'),
('TC06', N'Mực', N'Chó', '2025-04-24'),
('TC07', N'Long', N'Chó', '2025-04-25'),
('TC08', N'Mao', N'Mèo', '2025-04-27'),
('TC09', N'Siu', N'Mèo', '2025-05-09'),
('TC10', N'Kiki', N'Chó', '2025-05-11'),
('TC11', N'Chiu', N'Mèo', '2025-05-13'),
('TC12', N'Niro', N'Mèo', '2025-05-23');

-- Chủ nhân
INSERT INTO ChuNhan VALUES
('CN01', N'Nguyễn Văn A', '0909123456'),
('CN02', N'Trần Thị B', '0911222333'),
('CN03', N'Lê Văn C', '0922333444'),
('CN04', N'Phạm Thị D', '0933444555'),
('CN05', N'Hoàng Văn E', '0944555666'),
('CN06', N'Vũ Thị F', '0955666777'),
('CN07', N'Đặng Văn G', '0966777888'),
('CN08', N'Bùi Thị H', '0977888999'),
('CN09', N'Đỗ Văn I', '0988999000'),
('CN10', N'Ngô Thị K', '0901111222'),
('CN11', N'Trịnh Văn L', '0912222333'),
('CN12', N'Phan Thị M', '0923333444');

-- Dịch vụ
INSERT INTO DichVu VALUES
('DV01', N'Tắm', 50000),
('DV02', N'Cắt lông', 80000),
('DV03', N'Khám sức khỏe', 100000),
('DV04', N'Tiêm phòng', 120000),
('DV05', N'Vệ sinh tai', 40000);

-- Chăm sóc
INSERT INTO ChamSoc VALUES
('CS01', 'TC01', 'CN01', '2024-12-01'),
('CS02', 'TC02', 'CN02', '2024-12-02'),
('CS03', 'TC03', 'CN03', '2024-12-03'),
('CS04', 'TC04', 'CN04', '2024-12-04'),
('CS05', 'TC05', 'CN05', '2024-12-05'),
('CS06', 'TC06', 'CN06', '2024-12-06'),
('CS07', 'TC07', 'CN07', '2024-12-07'),
('CS08', 'TC08', 'CN08', '2024-12-08'),
('CS09', 'TC09', 'CN09', '2024-12-09'),
('CS10', 'TC10', 'CN10', '2024-12-10'),
('CS11', 'TC11', 'CN11', '2024-12-11'),
('CS12', 'TC12', 'CN12', '2024-12-12');

-- Sử dụng dịch vụ
INSERT INTO SuDungDV VALUES
('CS01', 'DV01'), ('CS01', 'DV02'),
('CS02', 'DV01'), ('CS02', 'DV03'),
('CS03', 'DV02'),
('CS04', 'DV01'), ('CS04', 'DV04'),
('CS05', 'DV01'),
('CS06', 'DV05'),
('CS07', 'DV02'),
('CS08', 'DV03'),
('CS09', 'DV01'),
('CS10', 'DV04'),
('CS11', 'DV05'),
('CS12', 'DV01'), ('CS12', 'DV02');

SELECT * FROM ThuCung;
SELECT * FROM ChuNhan;
SELECT * FROM ChamSoc;
SELECT * FROM SuDungDV;
SELECT * FROM vw_ChamSocFull;
SELECT * FROM vw_DanhSachSuDungDV;
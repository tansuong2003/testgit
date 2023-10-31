-- Tạo cơ sở dữ liệu
CREATE DATABASE MyDatabase;
USE MyDatabase;

-- Tạo bảng LoaiVi
CREATE TABLE LoaiVi (
    MaLoai INT PRIMARY KEY,
    TenLoai NVARCHAR(50)
);

-- Thêm dữ liệu cho bảng LoaiVi
INSERT INTO LoaiVi (MaLoai, TenLoai) VALUES
(1, 'Cầm tay'),
(2, 'Dáng ngang'),
(3, 'Dáng đứng'),
(4, 'Hộ chiếu');

-- Tạo bảng Hang
CREATE TABLE Hang (
    MaHang INT PRIMARY KEY,
    TenHang NVARCHAR(50)
);

-- Thêm dữ liệu cho bảng Hang
INSERT INTO Hang (MaHang, TenHang) VALUES
(1, 'Hermes'),
(2, 'Chanel'),
(3, 'Louis Vuitton');

-- Tạo bảng Vi
CREATE TABLE Vi (
    MaVi INT PRIMARY KEY,
    TenVi NVARCHAR(50),
    Gia FLOAT,
    MauSac NVARCHAR(50),
    MaLoai INT,
    MaHang INT,
    FOREIGN KEY (MaLoai) REFERENCES LoaiVi(MaLoai),
    FOREIGN KEY (MaHang) REFERENCES Hang(MaHang)
);


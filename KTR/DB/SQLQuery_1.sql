DROP DATABASE ktra;
GO
CREATE DATABASE ktra;
GO
USE ktra;
GO

CREATE TABLE SINHVIEN
(
    MaSV INT NOT NULL IDENTITY(1,1),
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    DiaChi NVARCHAR(50),
    SDT int,
    NamVaoTruong DATE,
    Khoa int,
    PRIMARY KEY(MaSV)
);
GO

CREATE TABLE HOCPHAN
(
    MaHP INT NOT NULL IDENTITY(1,1),
    TenHP NVARCHAR(50),
    SoTinChi int,
    PRIMARY KEY(MaHP)
);
GO

CREATE TABLE DANGKYHOCPHAN
(
    MaSV INT,
    MaHP INT,
    ThoiGianDangKy DATE,
    DaDangKy TINYINT,
    FOREIGN KEY(MaSV) REFERENCES SINHVIEN(MaSV),
    FOREIGN KEY(MaHP) REFERENCES HOCPHAN(MaHP),
);
GO

INSERT INTO SINHVIEN (HoTen, NgaySinh, DiaChi, SDT, NamVaoTruong, Khoa)
VALUES 
    (N'Nguyễn Văn A', '2000-01-01', N'Hà Nội', 123456789, '2018-09-01', 1),
    (N'Lê Thị B', '1999-02-15', N'Hồ Chí Minh', 987654321, '2017-09-01', 2),
    (N'Phạm Văn C', '2001-03-20', N'Hải Phòng', 555555555, '2019-09-01', 3),
    (N'Trần Thị D', '2002-04-10', N'Đà Nẵng', 111111111, '2020-09-01', 4),
    (N'Hoàng Minh E', '2000-05-25', N'Cần Thơ', 222222222, '2018-09-01', 1);
GO

-- Thêm 5 dòng vào bảng HOCPHAN
INSERT INTO HOCPHAN (TenHP, SoTinChi)
VALUES 
    (N'Toán cao cấp', 4),
    (N'Lập trình cơ bản', 3),
    (N'Cơ sở dữ liệu', 3),
    (N'Mạng máy tính', 4),
    (N'Phát triển phần mềm', 3);
GO

-- Thêm 5 dòng vào bảng DANGKYHOCPHAN
INSERT INTO DANGKYHOCPHAN (MaSV, MaHP, ThoiGianDangKy, DaDangKy)
VALUES 
    (1, 1, '2023-01-15', 1),
    (2, 2, '2023-01-16', 1),
    (3, 3, '2023-01-17', 1),
    (4, 4, '2023-01-18', 1),
    (5, 5, '2023-01-19', 1);
GO

select * from SINHVIEN

UPDATE SINHVIEN SET HoTen='aa', NgaySinh='2000-01-01', DiaChi='a', SDT=225, Khoa=3, NamVaoTruong='2000-01-01' WHERE MaSV=6


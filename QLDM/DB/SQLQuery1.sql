
CREATE DATABASE QLDM;
go

USE QLDM;
go

CREATE TABLE DANHMUC
(
    id INT NOT NULL IDENTITY(1,1),
    tenDanhMuc NVARCHAR(50) NOT NULL,
    PRIMARY KEY(id)
);


CREATE TABLE SANPHAM
(
    idSanPham INT NOT NULL IDENTITY(1,1),
    tenSanPham NVARCHAR(50) NOT NULL,
    size VARCHAR(50) NOT NULL,
    soLuong INT,
    mauSac NVARCHAR(10),
    ngayCapNhat DATE,
    idDanhMuc INT,
    PRIMARY KEY(idSanPham),
    FOREIGN KEY(idDanhMuc) REFERENCES DANHMUC(id)
);

INSERT INTO DANHMUC  VALUES 
('Truong Hoc'),
('Tiem Cafe'),
('Quan an');
INSERT INTO SANPHAM values
(N'May Tinh', 'S', 6, 'Den', '3-21-2000', 1),
(N'Cafe', 'L', 90,'Do', '3-21-2000', 2),
(N'Ban ghe', 'XL', 10,'Xanh', '3-21-2000', 3);

select * from DANHMUC
select * from SANPHAM
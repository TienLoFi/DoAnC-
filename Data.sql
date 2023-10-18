-- Create the database
CREATE DATABASE QuanLiQuanCafe;
GO

-- Use the database
USE QuanLiQuanCafe;
GO

-- Create the TableFood table
CREATE TABLE TableFood
(
    id INT IDENTITY PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
    status NVARCHAR(100) NOT NULL DEFAULT N'Trống' --Trống || có người
);
GO

-- Create the Account table
CREATE TABLE Account
(
    UserName NVARCHAR(100) PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL DEFAULT N'NGOCTIEN',
    Password NVARCHAR(1000) NOT NULL DEFAULT '0', -- Remove the 0 from quotes
    Type INT NOT NULL DEFAULT 0 -- 1: admin && 0: staff
);
GO

-- Create the FoodCategory table
CREATE TABLE FoodCategory
(
    id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa đặt tên'
);
GO

-- Create the Food table
CREATE TABLE Food
(
    id INT IDENTITY PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
    idCategory INT NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)
);
GO

-- Create the Bill table
CREATE TABLE Bill
(
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL,
    DateCheckOut DATE NOT NULL,
    price FLOAT NOT NULL,
    status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
    idTable INT, -- Add idTable column
    FOREIGN KEY (idTable) REFERENCES TableFood(id)
);
GO

-- Create the BillInfo table
CREATE TABLE BillInfo
(
    id INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES Bill(id),
    FOREIGN KEY (idFood) REFERENCES Food(id)
);
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'K3', N'TienK3', N'1', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [PassWord], [Type]) VALUES (N'tien', N'ngoctien', N'1', 0)
GO
CREATE PROC [dbo].[USP_GetAccountByUserName]
@userName nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO
EXEC dbo.USP_GetAccountByUserName @UserName=N'tien' 
GO

CREATE PROC [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName AND PassWord = @passWord
END
GO
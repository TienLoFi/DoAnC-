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
    Password NVARCHAR(1000) NOT NULL DEFAULT 0, -- Remove the 0 from quotes
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
    FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
);
GO

-- Create the Bill table
CREATE TABLE Bill
(
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATE,
    status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
    idTable INT NOT NULL, -- Add idTable column
	    FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)

);
GO

-- Create the BillInfo table
CREATE TABLE BillInfo
(
    id INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
    FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
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

DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood(name) VALUES (N'Bàn' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO 
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO
UPDATE dbo.TableFood SET STATUS =N'Có Người' WHERE id=9
EXEC dbo.USP_GetTableList

----thêm bàn 
DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood(name) VALUES (N'Bàn' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO 
---thêm category
SET IDENTITY_INSERT [dbo].[FoodCategory] ON
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Đồ Uống Cà Phê')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Nước Ép')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Thức Ăn Nhanh')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Nước Uống Đóng Chai')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Sinh Tố')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF

--- thêm đồ uống 
SET IDENTITY_INSERT [dbo].[Food] ON
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Cà Phê Đen', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Bạc Xỉu', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Nước Ép Dưa Lưới', 2, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Bánh mì sandwich', 3, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'PepSi Không Calo', 4, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Sinh Tố Bơ', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Sinh Tố Mãng Cầu', 5, 25000)
SET IDENTITY_INSERT [dbo].[Food] OFF
--thêm BIll
INSERT dbo.Bill (
DateCheckIn, 
DateCheckOut,
idTable,
status
)
VALUES ( GETDATE(),
NULL,1,0)
--
 INSERT dbo.Bill (
DateCheckIn, 
DateCheckOut,
idTable,
status
)
VALUES ( GETDATE(),
GETDATE(),2,0)
--
INSERT dbo.Bill (
DateCheckIn, 
DateCheckOut,
idTable,
status
)
VALUES ( GETDATE(),
GETDATE(),2,1)
--THÊM BILL INFO
INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES ( 19,
5,1)
--
INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES (21,
1,2)
INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES ( 20,
6,2)

INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES ( 19,
5,3)
SELECT * FROM dbo.TableFood
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Food
SELECT * FROM dbo.FoodCategory



SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable =5
GO
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
    Password NVARCHAR(1000) NOT NULL DEFAULT 0, -- Remove the 0 from quotes
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
    FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
);
GO

-- Create the Bill table
CREATE TABLE Bill
(
    id INT IDENTITY PRIMARY KEY,
    DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
    DateCheckOut DATE,
    status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
    idTable INT NOT NULL, -- Add idTable column
	    FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)

);
GO

-- Create the BillInfo table
CREATE TABLE BillInfo
(
    id INT IDENTITY PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
    FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
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

DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood(name) VALUES (N'Bàn' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO 
CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO
UPDATE dbo.TableFood SET STATUS =N'Có Người' WHERE id=9
EXEC dbo.USP_GetTableList

----thêm bàn 
DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT dbo.TableFood(name) VALUES (N'Bàn' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO 
---thêm category
SET IDENTITY_INSERT [dbo].[FoodCategory] ON
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (1, N'Đồ Uống Cà Phê')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (2, N'Nước Ép')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (3, N'Thức Ăn Nhanh')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (4, N'Nước Uống Đóng Chai')
INSERT [dbo].[FoodCategory] ([id], [name]) VALUES (5, N'Sinh Tố')
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF

--- thêm đồ uống 
SET IDENTITY_INSERT [dbo].[Food] ON
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (1, N'Cà Phê Đen', 1, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Bạc Xỉu', 1, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Nước Ép Dưa Lưới', 2, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Bánh mì sandwich', 3, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'PepSi Không Calo', 4, 15000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Sinh Tố Bơ', 5, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Sinh Tố Mãng Cầu', 5, 25000)
SET IDENTITY_INSERT [dbo].[Food] OFF
--thêm BIll
INSERT dbo.Bill (
DateCheckIn, 
DateCheckOut,
idTable,
status
)
VALUES ( GETDATE(),
NULL,1,0)
--
 INSERT dbo.Bill (
DateCheckIn, 
DateCheckOut,
idTable,
status
)
VALUES ( GETDATE(),
GETDATE(),2,0)
--
INSERT dbo.Bill (
DateCheckIn, 
DateCheckOut,
idTable,
status
)
VALUES ( GETDATE(),
GETDATE(),2,1)
--THÊM BILL INFO
INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES ( 19,
5,1)
--
INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES (21,
1,2)
INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES ( 20,
6,2)

INSERT dbo.BillInfo(
idBill, 
idFood,
count
)
VALUES ( 19,
5,3)
SELECT * FROM dbo.TableFood
SELECT * FROM dbo.Bill
SELECT * FROM dbo.BillInfo
SELECT * FROM dbo.Food
SELECT * FROM dbo.FoodCategory



SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable =5
GO
CREATE PROC USP_InsertBill
@idTable INT
AS
BEGIN
    INSERT dbo.Bill 
    ( DateCheckIn ,
      DateCheckOut ,
      idTable ,
      status
    )
    VALUES  ( GETDATE() , -- DateCheckIn - date
              NULL , -- DateCheckOut - date
              @idTable , -- idTable - int
              0  -- status - int
            )
END
GO

	CREATE PROC USP_InsertBillInfo
	@idBill INT, @idFood INT, @count INT
AS

	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	
	SELECT @isExitsBillInfo = id, @foodCount = b.count 
	FROM dbo.BillInfo AS b 
	WHERE idBill = @idBill AND idFood = @idFood

	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE dbo.BillInfo	SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT	dbo.BillInfo
        ( idBill, idFood, count )
		VALUES  ( @idBill, -- idBill - int
          @idFood, -- idFood - int
          @count  -- count - int
          )
	END
	GO

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
ALTER PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO
UPDATE dbo.TableFood SET status = N'Có Người' WHERE id=9
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
      status,
	  discount
    )
    VALUES  ( GETDATE() , -- DateCheckIn - date
              NULL , -- DateCheckOut - date
              @idTable , -- idTable - int
              0,  -- status - int
			  0
            )
END
GO

	CREATE PROC USP_InsertBillInfo
	@idBill INT, @idFood INT, @count INT
AS
BEGIN 
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
	END

	GO

	DELETE FROM dbo.TableFood;
	ALTER TRIGGER UTG_UpdateBillInfo
	ON dbo.BillInfo FOR INSERT, UPDATE 
	AS
	BEGIN 
		DECLARE @idBill INT 
		SELECT @idBill =idBill FROM Inserted 
		DECLARE @idTable INT 
		SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0
	
		UPDATE dbo.TableFood SET status = N'Có Người' WHERE id=@idTable 
	END
	GO 
	CREATE TRIGGER UTG_UpdateBill
	ON dbo.Bill FOR UPDATE 
	AS
	BEGIN 
		DECLARE @idBill  INT 
		SELECT @idBill=id FROM Inserted 
		DECLARE @idTable INT 
		SELECT @idTable = idTable FROM  dbo.Bill WHERE id =@idBill
		DECLARE @count int =0
		SELECT @count =COUNT(*) FROM dbo.Bill  WHERE idTable =@idTable AND status=0
		IF (@count =0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id=@idTable
	END
	GO
	CREATE TABLE dbo.Bill 

	ADD discount INT
UPDATE dbo.Bill SET discount =0;
SELECT* FROM dbo.Bill
SELECT* FROM dbo.TableFood
GO

CREATE PROC USP_SwitchTable

@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idFirstBill IS NULL)
	BEGIN
		PRINT '0000001'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'
	
	IF (@idSeconrdBill IS NULL)
	BEGIN
		PRINT '0000002'
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          status
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	PRINT @idFirstBill
	PRINT @idSeconrdBill
	PRINT '-----------'

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

	DELETE dbo.BillInfo
	DELETE dbo.Bill

ALTER TABLE dbo.Bill ADD totalPrice FLOAT 





GO
CREATE PROC [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
AS 
BEGIN

SELECT t.name AS [Tên bàn], b.totalPrice AS [Tổng tiền], DateCheckIn AS [Ngày vào], DateCheckOut AS [Ngày ra], discount AS [Giảm giá]
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
	END
GO

CREATE PROC [dbo].[USP_UpdateAccount]
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE USERName = @userName AND PassWord = @password
	
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName = @displayName WHERE UserName = @userName
		END		
		ELSE
			UPDATE dbo.Account SET DisplayName = @displayName, PassWord = @newPassword WHERE UserName = @userName
	end
END
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
DECLARE @idBillInfo INT
DECLARE @idBill INT
SELECT @idBillInfo id, @idBill Deleted, idBill FROM Deleted
DECLARE @idTable INT
SELECT @idTable = idTable FROM dbo.Bill WHERE id=@idBill
DECLARE @count INT = 0
SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo. Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
IF (@count = 0)
UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable

	END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
select * from Account




DELETE FROM FoodCategory WHERE id = 8;

	/*DROP DATABASE QuanLyThuVien
GO*/
CREATE database QuanLyThuVien
go


/*DROP TABLE dbo.Major
DROP TABLE dbo.Book
DROP TABLE dbo.Bill
DROP TABLE dbo.Account */


use QuanLyThuVien
go

--Book
--Major
--Account
--Bill

create table Major
(
	majorid nvarchar(100) primary key,
	majorname nvarchar(100),
);
GO 

CREATE TABLE Account
(
	AccountID INT IDENTITY PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL UNIQUE ,
	PassWord NVARCHAR(100) NOT NULL,
	DisplayName NVARCHAR(100) NOT NULL ,
	Checkstatus NVARCHAR(100) NOT NULL DEFAULT N'Không nợ',
	Auth NVARCHAR(100) NOT NULL DEFAULT N'Student',-- Nhà truong && Thu thu && Sinh viên
)
GO

CREATE TABLE Book
(
	BookID NVARCHAR(100) NOT NULL PRIMARY KEY ,
	Name NVARCHAR(100) NOT NULL ,
	RentPrice NCHAR(100) NOT NULL DEFAULT 0,   -- Float de có the thêm so le
	BuyPrice NVARCHAR(100) NOT NULL DEFAULT 0, -- Default 0 là mac dinh 0
	Status NVARCHAR(100) NOT NULL DEFAULT N'Còn sách',
	MajorID nvarchar(100)  ,-- Neu sài 2 khóa chính thì thêm , ngay idMajor và id
)
GO

CREATE TABLE Bill
(
	BillID NVARCHAR(100) PRIMARY KEY,
	Username NVARCHAR(100) NOT NULL ,
	Name NVARCHAR(100)  ,
	DateSell DATE NOT NULL DEFAULT GETDATE(), -- Date là lay ngày
	DateRent DATE NOT NULL DEFAULT GETDATE(), -- Default getdate là tức ngày hôm nay
	COUNT NVARCHAR(100) NOT NULL DEFAULT N'0',
)
GO

/*Store Procedure*/
CREATE PROCEDURE checklogin
@UserName nvarchar(100),
@PassWord nvarchar(100)
as
begin

select * from dbo.Account where UserName = @UserName and PassWord = @PassWord
end
GO


CREATE PROCEDURE checkauth
@username nvarchar(50),
@checkstatus nvarchar(50)
as
begin

select username,checkstatus from dbo.Account where username = @username and checkstatus=@checkstatus
end
GO

CREATE PROCEDURE checkdecode
@username nvarchar(50)
as
begin
select username,PassWord from dbo.Account where username = @username 
end
GO

create proc checkduppass
@username nvarchar(50),
@passwords nvarchar(50)
as
begin
select username,PassWord from dbo.Account where username = @username and PassWord = @passwords
end
go

/*book*/
CREATE PROCEDURE loadbook
as
begin

select BookID,Name,RentPrice,BuyPrice,Status,Book.MajorID,majorname from dbo.Book,dbo.Major where book.MajorID = major.majorid;
end
GO

CREATE PROCEDURE checkdupbook
@name nvarchar(50)
as
begin

select Name from dbo.Book where Name = @name
END
go

CREATE PROCEDURE insertbook
@bookid NVARCHAR(100),
@name nvarchar(100),
@majorid NVARCHAR(100),
@rentprice FLOAT,
@buyprice FLOAT,
@status NVARCHAR(100)
as
begin
insert into book(BookID,Name,MajorID,RentPrice,BuyPrice,Status) values (@bookid,@name,@majorid,@rentprice,@buyprice,@status)
end
go

CREATE PROCEDURE editbook
@bookid NVARCHAR(100),
@name nvarchar(100),
@majorid NVARCHAR(100),
@rentprice FLOAT,
@buyprice FLOAT,
@status NVARCHAR(100),
@id nvarchar(50)
AS
begin
Update dbo.Book set BookID = @bookid,Name = @name, MajorID = @majorid,RentPrice = @rentprice, BuyPrice = @buyprice WHERE BookID = @id
end
go



CREATE PROCEDURE editbooknameinbill
@name nvarchar(100)
as
begin
update dbo.Bill set name = NULL where Name = @name
end
go

CREATE PROCEDURE deletebook
@bookid NVARCHAR(100),
@name nvarchar(100),
@majorid NVARCHAR(100),
@rentprice FLOAT,
@buyprice FLOAT,
@status NVARCHAR(100)
as
begin
delete from dbo.Book where BookID = @bookid AND Name = @name AND MajorID = @majorid AND RentPrice = @rentprice AND BuyPrice = @buyprice
end
GO

CREATE PROCEDURE searchbook
@name NVARCHAR(100)
as
begin
SELECT @name = RTRIM(@name) + '%'; 
select BookID,Name,Book.MajorID,RentPrice,BuyPrice,Status from dbo.Book,major where dbo.Book.MajorID = major.majorid and Name like @name
end
go

/*major*/
CREATE PROCEDURE loadmajor
as
begin

select majorid,majorname from major
end
GO

CREATE PROCEDURE checkdupmajor
@majorid nvarchar(50)
as
begin
select majorid from major where majorid = @majorid
end
go

CREATE PROCEDURE insertmajor
@majorid nvarchar(50),
@majorname nvarchar(50)
as
begin
insert into major(majorid,majorname) values (@majorid,@majorname)
END
GO

CREATE PROCEDURE searchmajor
@majorid nvarchar(50)
as
begin
SELECT @majorid = RTRIM(@majorid) + '%'; 
select majorid,majorname from dbo.Major where MajorID like @majorid
end
go

CREATE PROCEDURE updatemajor
@majorid nvarchar(50),
@majorname nvarchar(50),
@majorid1 NVARCHAR(50)
as
begin

Update major Set majorid=@majorid, majorname=@majorname where majorid = @majorid1
end
GO

CREATE PROCEDURE editmajoridinbook
@majorid nvarchar(50)
as
begin

update book set majorid = NULL where majorid = @majorid
end
GO

CREATE PROCEDURE deletemajor
@majorid NVARCHAR(100),
@majorname NVARCHAR(100)
as
begin

delete from dbo.Major where majorid= @majorid AND majorname=@majorname 
end
GO


CREATE PROCEDURE searchmajor
@majorid NVARCHAR(100)
as
begin
SELECT @majorid = RTRIM(@majorid) + '%'; 
select Major.majorid,majorname from dbo.Major where @majorid LIKE majorid
end
go

/*account*/
CREATE PROCEDURE loadaccount
as
begin

select AccountID,UserName,PassWord,Checkstatus,DisplayName,auth from dbo.Account
end
go

CREATE PROCEDURE insertaccount
@username nvarchar(50),
@passwords nvarchar(50),
@displayname nvarchar(50)
as
begin

insert into account(username,PassWord,DisplayName) values (@username,@passwords,@displayname)
end
GO

CREATE PROCEDURE searchaccount
@username nvarchar(50)
as
begin
SELECT @username = RTRIM(@username) + '%'; 
select AccountID,UserName,PassWord,Checkstatus,DisplayName,auth from dbo.Account where UserName like @username
end
go

CREATE PROCEDURE checkdupaccount
@username nvarchar(50)
as
begin

select username from dbo.Account where username = @username
end
GO


CREATE PROCEDURE updateaccount
@username nvarchar(100),
@passwords nvarchar(100),
@displayname NVARCHAR(100),
@checkstatus NVARCHAR(100),
@id NVARCHAR(100)
as
begin

Update dbo.Account Set username=@username,PassWord=@passwords,DisplayName=@displayname,Checkstatus=@checkstatus WHERE AccountID=@id
end
GO

CREATE PROCEDURE deleteaccount
@username nvarchar(100),
@passwords nvarchar(100),
@displayname NVARCHAR(100),
@checkstatus NVARCHAR(100),
@id NVARCHAR(100)
as
begin

delete from dbo.Account where username= @username AND PassWord=@passwords AND DisplayName = @displayname AND Checkstatus = @checkstatus AND AccountID = @id
end
GO

CREATE PROCEDURE deleteaccountinbill
@username int
as
begin
update bill set Username = NULL where Username = @username
end
GO

/*bill*/
CREATE PROCEDURE loadbill
as
begin
select BillID,bill.Username,bill.name,DateSell,DateRent,COUNT,RentPrice,BuyPrice,Major.MajorID from dbo.Bill,dbo.Account,dbo.Book,dbo.Major where bill.Username = Account.UserName and bill.name = book.Name AND book.MajorID=Major.MajorID
end
GO

CREATE PROCEDURE loadbillname
as
begin
select book.name,majorname from book,major where book.MajorID = major.majorid
end
GO

CREATE PROCEDURE checkdupbill
@username NVARCHAR(50),
@billid nvarchar(50)
as
begin
select Username,BillID from dbo.Bill where Username =@username or BillID = @billid
end
go

CREATE PROCEDURE insertbill
@username nvarchar(100),
@name nvarchar(100),
@datesell DATE,
@daterent DATE,
@count int
as
begin
insert into bill(Username,Name,DateSell,DateRent,COUNT) values (@username,@name,@datesell,@daterent,@count)
end
GO

CREATE PROCEDURE updatebill
@username nvarchar(100),
@name nvarchar(100),
@datesell DATE,
@daterent DATE,
@count INT,
@count1 INT,
@username1 nvarchar(100),
@name1 NVARCHAR(100)
as
begin
update bill set Username=@username,Name=@name,DateSell=@datesell,DateRent=@daterent,COUNT=@count WHERE Username=@username1 or COUNT = @count1 OR Name = @name1
end
go

CREATE PROCEDURE deletebill
@username nvarchar(100),
@name nvarchar(100),
@datesell DATE,
@daterent DATE,
@count INT,
@count1 INT,
@username1 nvarchar(100),
@name1 nvarchar(100)
as
begin
delete from dbo.Bill where Username=@username and Name=@name and DateSell=@datesell and DateRent=@daterent and COUNT=@count
end
GO

CREATE PROCEDURE searchbill
@name nvarchar(50)
as
begin
SELECT @name = RTRIM(@name) + '%'; 
select UserName from dbo.Bill where UserName like @name
end
go

-- Thêm khoa
	INSERT INTO dbo.Major
	(
		MajorID,
		MAjorName
	)
	VALUES
	(   
		N'TH',  -- id - int
		N'Công nghệ thông tin' -- name - nvarchar(100)
		)

	INSERT INTO dbo.Major
	(
		MajorID,
		MAjorName
	)
	VALUES
	(   
		N'KT',  -- id - int
		N'Kinh tế' -- name - nvarchar(100)
		)

	INSERT INTO dbo.Major
	(
		MajorID,
		MAjorName
	)
	VALUES
	(   
		N'TA',  -- id - int
		N'Tiếng anh' -- name - nvarchar(100)
		)


	-- Thêm tài khoản
	INSERT INTO dbo.Account
	(
		UserName,
		PassWord,
		DisplayName,
		Checkstatus,
		Auth
	)
	VALUES
	(   N'UEF',   -- UserName - nvarchar(100)
		N'1', -- PassWord - nvarchar(100)
		N'School', -- DisplayName - nvarchar(100)
		DEFAULT,
		N'Admin' -- Auth - nvarchar(100)
	)

	INSERT INTO dbo.Account
	(
		UserName,
		PassWord,
		DisplayName,
		Checkstatus,
		Auth
	)
	VALUES
	(   N'Thuvien',   -- UserName - nvarchar(100)
		N'2', -- PassWord - nvarchar(100)
		N'Librarian', -- DisplayName - nvarchar(100)
		DEFAULT,
		N'Admin2' -- Auth - nvarchar(100)
		)

	INSERT INTO dbo.Account
	(
		UserName,
		PassWord,
		DisplayName,
		Checkstatus,
		Auth
	)
	VALUES
	(   N'175050001',   -- UserName - nvarchar(100)
		N'175050001', -- PassWord - nvarchar(100)
		N'Nguyễn Viết Thanh', -- DisplayName - nvarchar(100)
		DEFAULT,
		N'Student' -- Type - nvarchar(100)
		)

	INSERT INTO dbo.Account
	(
		UserName,
		PassWord,
		DisplayName,
		Checkstatus,
		Auth
	)
	VALUES
	(   N'175050002',   -- UserName - nvarchar(100)
		N'175050002', -- PassWord - nvarchar(100)
		N'Nguyễn Hoàng Minh', -- DisplayName - nvarchar(100)
		DEFAULT,
		N'Student' -- Type - nvarchar(100)
		)

	INSERT INTO dbo.Account
	(
		UserName,
		PassWord,
		DisplayName,
		Checkstatus,
		Auth
	)
	VALUES
	(   N'175050003',   -- UserName - nvarchar(100)
		N'175050003', -- PassWord - nvarchar(100)
		N'Nguyễn Gia Huy', -- DisplayName - nvarchar(100)
		DEFAULT,
		N'Student' -- Type - nvarchar(100)
		)

	-- Thêm sách
	INSERT INTO dbo.Book
	(
		BookID,
		Name,
		RentPrice,
		BuyPrice,
		Status,
		MajorID
	)
	VALUES
	(  
		N'1',
		N'AI', -- Name - nvarchar(100)
		N'10000', -- RentPrice - float
		N'100000', -- BuyPrice - float
		DEFAULT, -- Status - nvarchar(100)
		N'TH'  -- MajorName - nvarchar(100)
		)

	INSERT INTO dbo.Book
	(
		BookID,
		Name,
		RentPrice,
		BuyPrice,
		Status,
		MajorID
	)
	VALUES
	( 
		N'2',
		N'English', -- Name - nvarchar(100)
		N'12000', -- RentPrice - float
		N'120000', -- BuyPrice - float
		DEFAULT, -- Status - nvarchar(100)
		N'TA'  -- MajorName - nvarchar(100)
		)

	INSERT INTO dbo.Book
	(
		BookID,
		Name,
		RentPrice,
		BuyPrice,
		Status,
		MajorID
	)
	VALUES
	( 
		N'3',
		N'Unity', -- Name - nvarchar(100)
		N'15000', -- RentPrice - float
		N'150000', -- BuyPrice - float
		DEFAULT, -- Status - nvarchar(100)
		N'KT'  -- MajorName - nvarchar(100)
		)


	-- Thêm bill
	INSERT INTO dbo.Bill
	(
		BillID,
		Username,
		Name,
		DateSell,
		DateRent,
		COUNT
	)
	VALUES
	(   
		N'1',
		N'175050001',       -- Username - nvarchar(100)
		N'Unity',       -- Name - nvarchar(100)
		GETDATE(), -- DateSell - date
		GETDATE(), -- DateRent - date
		5         -- COUNT - int
		)

	INSERT INTO dbo.Bill
	(
		BillID,
		Username,
		Name,
		DateSell,
		DateRent,
		COUNT
	)
	VALUES
	( 
		N'2',
		N'175050002',         -- Username - int
		N'AI',       -- Name - nvarchar(100)
		GETDATE(), -- DateSell - date
		GETDATE(), -- DateRent - date
		3          -- COUNT - int
		)

	INSERT INTO dbo.Bill
	(
		BillID,
		Username,
		Name,
		DateSell,
		DateRent,
		COUNT
	)
	VALUES
	(
		N'3',
		N'175050003',         -- Username - int
		N'English',       -- Name - nvarchar(100)
		GETDATE(), -- DateSell - date
		GETDATE(), -- DateRent - date
		1          -- COUNT - int
		)


SELECT DISTINCT Account.UserName,bill.Name,DateSell,DateRent,COUNT,rentprice,BuyPrice FROM bill,account,dbo.Book WHERE account.UserName = bill.Username and book.NAME = bill.name
SELECT dbo.Account.UserName FROM dbo.Account
SELECT * FROM dbo.Major
SELECT * FROM dbo.Book
SELECT COUNT(*) FROM dbo.Book

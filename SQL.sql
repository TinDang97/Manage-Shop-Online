Create database ShopOnlinev2
Use ShopOnlinev2
go

CREATE TABLE Sizes
(
  Size NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Size)
);

CREATE TABLE Colors
(
  Color NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Color)
);

CREATE TABLE Countries
(
  Country NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Country)
);

CREATE TABLE TypeCards
(
  Type NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Type)
);

CREATE TABLE Banks
(
  Name NVARCHAR(255) NOT NULL,
  Address NVARCHAR(1000) NOT NULL,
  Email CHAR(255) NOT NULL,
  Hotline CHAR(255) NOT NULL,
  Website CHAR(255) NOT NULL,
  PRIMARY KEY (Name)
);

CREATE TABLE DeliverService
(
  Name NVARCHAR(255) NOT NULL,
  Phone CHAR(50) NOT NULL,
  Address NVARCHAR(1000) NOT NULL,
  Website CHAR(255) NOT NULL,
  EMail CHAR(255) NOT NULL,
  PRIMARY KEY (Name)
);

CREATE TABLE Status
(
  Status NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Status)
);

CREATE TABLE Warranty
(
  Type NVARCHAR(100) NOT NULL,
  PRIMARY KEY (Type)
);

CREATE TABLE Provinces
(
  Province NVARCHAR(155) NOT NULL,
  Country NVARCHAR(255) NOT NULL,
  FOREIGN KEY (Country) REFERENCES Countries(Country),
  PRIMARY KEY (Province)
);


CREATE TABLE Districts
(
  District NVARCHAR(255) NOT NULL,
  Province NVARCHAR(155) NOT NULL,
  PRIMARY KEY (District),
  FOREIGN KEY (Province) REFERENCES Provinces(Province)
);

CREATE TABLE Genders
(
  Sex NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Sex)
);

CREATE TABLE ShipFees
(
  ShipFee NUMERIC(12,3) NOT NULL,
  HowLong NVARCHAR(255) NOT NULL,
  Province NVARCHAR(155) NOT NULL,
  Deliver NVARCHAR(255) NOT NULL,
  PRIMARY KEY (Province, Deliver),
  FOREIGN KEY (Province) REFERENCES Provinces(Province),
  FOREIGN KEY (Deliver) REFERENCES DeliverService(Name)
);

CREATE TABLE Address
(
  Country NVARCHAR(255) NOT NULL,
  ID INT NOT NULL IDENTITY(1,1),
  Location NVARCHAR(1000) NOT NULL,
  Province NVARCHAR(155) NOT NULL,
  District NVARCHAR(255) NOT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (Province) REFERENCES Provinces(Province),
  FOREIGN KEY (District) REFERENCES Districts(District)
);

CREATE TABLE Payments
(
  ID INT IDENTITY(1,1),
  MasterName NVARCHAR(255) NOT NULL,
  NumberCard CHAR(100) NOT NULL,
  SecureCode CHAR(255) NOT NULL,
  TypeCard NVARCHAR(255) NOT NULL,
  BankName NVARCHAR(255) NOT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (TypeCard) REFERENCES TypeCards(Type),
  FOREIGN KEY (BankName) REFERENCES Banks(Name)
);

CREATE TABLE Customers
(
  ID INT IDENTITY(1,1),
  FirstName NVARCHAR(255) NOT NULL,
  LastName NVARCHAR(255) NOT NULL,
  Avatar CHAR(255),
  Email CHAR(255),
  Phone INT NOT NULL,
  TimeCreated DATE DEFAULT getDate(),
  Birthday DATE,
  PaymentID INT,
  IDAddress INT NOT NULL,
  Sex NVARCHAR(255) NOT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (PaymentID) REFERENCES Payments(ID),
  FOREIGN KEY (IDAddress) REFERENCES Address(ID),
  FOREIGN KEY (Sex) REFERENCES Genders(Sex)
);

CREATE TABLE Accounts
(
  ID INT IDENTITY(1,1),
  UserName CHAR(255) NOT NULL UNIQUE,
  Passwords CHAR(255) NOT NULL,
  CustomerID INT NOT NULL,
  PRIMARY KEY (ID),
  FOREIGN KEY (CustomerID) REFERENCES Customers(ID)
);

CREATE TABLE Orders
(
  ID INT IDENTITY(1,1) ,
  Timed DATE DEFAULT getDate(),
  IDCustomer INT NOT NULL,
  Status NVARCHAR(255) NOT NULL default N'Chuẩn bị',
  Discount numeric(12,3) default 0,
  Staff nvarchar(255) default user_name() ,
  Total numeric(12, 3) default 0,
  PRIMARY KEY (ID),
  FOREIGN KEY (IDCustomer) REFERENCES Customers(ID),
  FOREIGN KEY (Status) REFERENCES Status(Status)
);


CREATE TABLE Categories
(
  Category NVARCHAR(255),
  CategoryParent NVARCHAR(255),
  PRIMARY KEY (Category),
  FOREIGN KEY (CategoryParent) REFERENCES Categories(Category)
);

CREATE TABLE Products
(
  ID INT NOT NULL IDENTITY(1,1),
  Name NVARCHAR(100) NOT NULL,
  Price NUMERIC(12,3) NOT NULL check (Price >= 0),
  Quantity INT,
  Views INT DEFAULT 0,
  Content NVARCHAR(255),
  Color NVARCHAR(255) NOT NULL,
  Size NVARCHAR(255) NOT NULL,
  Category NVARCHAR(255),
  Image char(255),
  MadeIn NVARCHAR(255),
  PRIMARY KEY (ID),
  FOREIGN KEY (Color) REFERENCES Colors(Color),
  FOREIGN KEY (Size) REFERENCES Sizes(Size),
  FOREIGN KEY (Category) REFERENCES Categories(Category)
);

CREATE TABLE Comments
(
  ID INT IDENTITY(1,1),
  Content NVARCHAR(4000) NOT NULL,
  CustumerID INT NOT NULL,
  ProductID INT NOT NULL,
  Time DATE DEFAULT getdate(),
  PRIMARY KEY (ID),
  FOREIGN KEY (CustumerID) REFERENCES Customers(ID),
  FOREIGN KEY (ProductID) REFERENCES Products(ID)
);

CREATE TABLE Rating
(
  CustumerID INT NOT NULL,
  ProductID INT NOT NULL,
  Level INT NOT NULL,
  PRIMARY KEY (CustumerID, ProductID),
  FOREIGN KEY (CustumerID) REFERENCES Customers(ID),
  FOREIGN KEY (ProductID) REFERENCES Products(ID)
);

CREATE TABLE OrdersDetail
(
  ID INT IDENTITY(1,1),
  IDProduct INT,
  IDOrder INT,
  TypeWarranty NVARCHAR(100),
  Quantity int check (Quantity > 0),
  PRIMARY KEY (ID),
  FOREIGN KEY (IDProduct) REFERENCES Products(ID),
  FOREIGN KEY (IDOrder) REFERENCES Orders(ID),
  FOREIGN KEY (TypeWarranty) REFERENCES Warranty(Type)
);

INSERT INTO Sizes(Size) VALUES (N'64 GB');
INSERT INTO Sizes(Size) VALUES (N'32 GB');
INSERT INTO Sizes(Size) VALUES (N'M');
INSERT INTO Sizes(Size) VALUES (N'S');
INSERT INTO Sizes(Size) VALUES (N'L');
INSERT INTO Sizes(Size) VALUES (N'XL');
INSERT INTO Sizes(Size) VALUES (N'XXL');

INSERT INTO Colors(Color) VALUES (N'Đen');
INSERT INTO Colors(Color) VALUES (N'Trắng');
INSERT INTO Colors(Color) VALUES (N'Vàng');
INSERT INTO Colors(Color) VALUES (N'Bạc');

INSERT INTO Countries(Country) VALUES (N'Trung Quốc');
INSERT INTO Countries(Country) VALUES (N'Việt Nam');
INSERT INTO Countries(Country) VALUES (N'Hàn Quốc');

INSERT INTO TypeCards(Type) VALUES (N'Master');
INSERT INTO TypeCards(Type) VALUES (N'Visa');

INSERT INTO Banks(Name, Email, Address, Hotline, Website) 
	VALUES (N'ACB', 'acbanking@acb.vn', N'123 Nguyễn Hữu Thọ, P.Tân Phong, Q.7, Tp.HCM', '19001099', 'abc.vn');
INSERT INTO Banks(Name, Email, Address, Hotline, Website) 
	VALUES (N'Argibank', 'argibank@acb.vn', N'124 Nguyễn Hữu Thọ, P.Tân Phong, Q.7, Tp.HCM', '19001091', 'Argibank.vn');

INSERT INTO DeliverService(Name, Email, Address, Phone, Website) 
	VALUES (N'Giao Hàng Nhanh', 'giaohangnhanh@gmail.com', N'125 Nguyễn Hữu Thọ, P.Tân Phong, Q.7, Tp.HCM', '19001092', 'ghn.vn');

INSERT INTO Status(Status) VALUES (N'Chuẩn bị');
INSERT INTO Status(Status) VALUES (N'Đã gửi');
INSERT INTO Status(Status) VALUES (N'Thành công');
INSERT INTO Status(Status) VALUES (N'Huỷ');
INSERT INTO Status(Status) VALUES (N'Thất bại');

INSERT INTO Warranty(Type) VALUES (N'Hoá đơn 6 tháng');
INSERT INTO Warranty(Type) VALUES (N'Hoá đơn 12 tháng');
INSERT INTO Warranty(Type) VALUES (N'Không');

INSERT INTO Provinces(Province, Country) VALUES (N'Tp Hồ Chí Minh', N'Việt Nam');
INSERT INTO Provinces(Province, Country) VALUES (N'Bến Tre', N'Việt Nam');
INSERT INTO Provinces(Province, Country) VALUES (N'Quảng Nam', N'Trung Quốc');
INSERT INTO Provinces(Province, Country) VALUES (N'Long An', N'Việt Name');

INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 7');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 1');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 2');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 3');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 4');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 5');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 6');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 8');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 9');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 10');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 11');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận 12');
INSERT INTO Districts(Province, District) VALUES (N'Tp Hồ Chí Minh', N'Quận Tân Bình');

INSERT INTO Genders(Sex) VALUES (N'Nam');
INSERT INTO Genders(Sex) VALUES (N'Nữ');
INSERT INTO Genders(Sex) VALUES (N'Không');

INSERT INTO ShipFees(Deliver, Province, ShipFee, HowLong) VALUES (N'Giao Hàng Nhanh', N'Tp Hồ Chí Minh', '20000', '2-3 ngày');

INSERT INTO Categories(Category, CategoryParent) VALUES (N'Điên thoại', NULL);
INSERT INTO Categories(Category, CategoryParent) VALUES (N'Apple', N'Điên thoại');
INSERT INTO Categories(Category, CategoryParent) VALUES (N'iPhone', N'Apple');
INSERT INTO Categories(Category, CategoryParent) VALUES (N'Samsung', N'Điên thoại');
INSERT INTO Categories(Category, CategoryParent) VALUES (N'Galaxy', N'Samsung');

INSERT INTO Products(Name, Color, Size, Price, Quantity, Category, MadeIn) 
	VALUES (N'S9', N'Trắng', N'32 GB', '11999000', 2, N'Galaxy', N'Việt Nam');
INSERT INTO Products(Name, Color, Size, Price, Quantity, Category, MadeIn) 
	VALUES (N'iPhone X', N'Trắng', N'64 GB', '31900000', 2, N'iPhone', N'Trung Quốc');

CREATE INDEX ProductName
on products (name);

CREATE INDEX ProductPrice
on products (price);

CREATE INDEX Catogories
on Categories(Category);

use ShopOnline
go
CREATE TRIGGER countDown On OrdersDetail
AFTER  insert
as
begin
	update Products 
	set Quantity = Quantity - (
		SELECT top 1 I.Quantity 
		FROM INSERTED I 
	)
	where ID = ( 
		select p.ID
		from Products p, INSERTED I
		where p.ID = I.IDProduct)

	update Orders
	set Total = (select dbo.tinh_tong(ID))
	where ID = ( 
		select o.ID
		from Orders o, INSERTED I
		where o.ID = I.IDOrder)
end;
/*
go
CREATE TRIGGER countUP On OrdersDetail
AFTER  delete
as
begin
	if(N'Thành công' =
	(select top 1 o.Status 
	from deleted d, Orders o
	where d.IDOrder = o.ID)
	)
	begin
		return
	end
	
	update Products 
	set Quantity = Quantity + (
		SELECT top 1 I.Quantity 
		FROM INSERTED I 
	)
	where ID = ( 
		select p.ID
		from Products p, INSERTED I
		where p.ID = I.IDProduct)

	update Orders
	set Total = (select dbo.tinh_tong(ID))
	where ID = ( 
		select o.ID
		from Orders o, INSERTED I
		where o.ID = I.IDOrder)
end;*/



go
CREATE TRIGGER checkQ On OrdersDetail
for insert
as
begin
	DECLARE @contain int;
	

	select @contain = p.Quantity - i.Quantity
		from Products p, inserted i
		where p.ID = i.IDProduct;

		DECLARE @check int;
		select @check = Quantity - 1
		from Products
		where ID = '29';
	
	if( @contain <= 0)
	begin		
		print N'Không có hàng';
		print @contain;
		print @check;
		rollback
	end;
end;

go
create trigger delOrder on Orders
INSTEAD OF delete
as
begin

	delete from OrdersDetail
	where IDOrder = (select ID from deleted);

	delete from Orders
	where ID = (select ID from deleted)
end

go
create trigger delProvince on Provinces
for delete
as
begin
	delete from Districts
	where Province = (
		select d.Province
		from DELETED d)
end

go
create trigger delCountry on Countries
for delete
as
begin
	delete from Provinces
	where Country = (
		select d.Country
		from DELETED d)
end


go
create trigger delAccount on Customers
after delete
as
begin
	delete from Accounts
	where CustomerID = (
		select ID
		from DELETED );
end

go
create trigger delOrders on Customers
INSTEAD OF DELETE
as
begin
	delete from Accounts
	where CustomerID = (
		select a.CustomerID
		from DELETED d, Accounts a
		where d.ID = a.CustomerID );

	delete from Orders
	where IDCustomer = (
		select o.IDCustomer
		from DELETED d, Orders o
		where d.ID = o.IDCustomer
		);

	delete from Customers
	where ID = (select id from deleted)
end;

delete from Customers where ID = 10;

Select a.ID, a.UserName, a.Passwords, a.CustomerID, c.Avatar, c.FirstName, c.LastName, c.Sex, c.Birthday, c.Email, c.Phone,ad.Country, ad.Province, ad.District, ad.Location from Customers c , Accounts a , Address ad where c.ID = a.CustomerID AND c.IDAddress = ad.ID

go
CREATE FUNCTION tinh_tong( @order_id int) 
RETURNS float
AS 
BEGIN
	DECLARE @KetQua float;
	select @KetQua = sum(p.Price * o.Quantity)
		from Products p, OrdersDetail o
		where o.IDOrder = @order_id AND o.IDProduct = p.ID;
		return @KetQua;
END

drop function dbo.tinh_tong

go
CREATE FUNCTION giam_gia( @tong_tien float) 
RETURNS float
AS 
BEGIN
	if (@tong_tien >= 10000000)
		return 500000;

	if (@tong_tien >= 5000000)
		return 200000;

	if (@tong_tien >= 2000000)
		return 500000;

	if (@tong_tien >= 1000000)
		return 25000;

	return 0;
END


go
CREATE TRIGGER sales On Orders
after update
as
begin
	update Orders
	set Discount = (select dbo.giam_gia(Total))
	where ID = (
		select o.ID
		from Orders o, inserted i
		where o.ID = i.ID
	)
end;

go
sp_addlogin 'customer' , 'customer123456', 'ShopOnline'

go
sp_adduser 'customer' , 'customer'

GO
GRANT connect, select, execute
TO customer

GO
GRANT execute
on dbo.giam_gia
TO customer

GO
GRANT execute
on dbo.tinh_tong
TO customer

GO
GRANT SELECT, INSERT, UPDATE
ON Accounts
TO customer

GO
GRANT SELECT, INSERT, UPDATE, DELETE
ON Address
TO customer

GO
GRANT SELECT
ON Banks
TO customer


GO
GRANT SELECT
ON Categories
TO customer

GO
GRANT SELECT
ON Colors
TO customer

GO
GRANT SELECT, INSERT, UPDATE, DELETE
ON Comments
TO customer

GO
GRANT SELECT, INSERT, UPDATE
ON Customers
TO customer

GO
GRANT SELECT
ON DeliverService
TO customer

GO
GRANT SELECT
ON Districts
TO customer

GO
GRANT SELECT
ON Gender
TO customer

GO
GRANT SELECT
ON Countries
TO customer

GO
GRANT SELECT, INSERT
ON Orders
TO customer

GO
GRANT SELECT, INSERT
ON OrdersDetail
TO customer

GO
GRANT SELECT, INSERT, UPDATE
ON Payments
TO customer

GO
GRANT SELECT
ON Products
TO customer

GO
GRANT SELECT
ON Provinces
TO customer

GO
GRANT SELECT, INSERT, UPDATE, DELETE
ON Rating
TO customer

GO
GRANT SELECT
ON ShipFee
TO customer

GO
GRANT SELECT
ON Sizes
TO customer

GO
GRANT SELECT
ON TypeCards
TO customer

GO
GRANT SELECT
ON Warranty
TO customer

go
sp_addlogin 'admin' , '123456', 'ShopOnline'

go
sp_adduser 'admin' , 'admin'

GRANT ALL
TO admin

GO
GRANT execute
on dbo.giam_gia
TO admin

GO
GRANT execute
on dbo.tinh_tong
TO admin

GO
GRANT Select, insert, update ,delete
ON Accounts
TO admin

GO
GRANT select, insert, update ,delete
ON Address
TO admin

GO
GRANT select, insert, update, delete
ON Banks
TO admin


GO
GRANT select, insert, update, delete
ON Categories
TO admin

GO
GRANT select, insert, update, delete
ON Colors
TO admin

GO
GRANT SELECT, DELETE
ON Comments
TO admin

GO
GRANT SELECT
ON Customers
TO admin

GO
GRANT select, insert, update, delete
ON DeliverService
TO admin

GO
GRANT select, insert, update, delete
ON Districts
TO admin

GO
GRANT select, insert, update, delete
ON Genders
TO admin

GO
GRANT select, insert, update, delete
ON Countries
TO admin

GO
GRANT select, update, insert, delete
ON Orders
TO admin

GO
GRANT SELECT, update, insert, delete
ON OrdersDetail
TO admin

GO
GRANT select
ON Payments
TO admin

GO
GRANT select, insert, update, delete
ON Products
TO admin

GO
GRANT select, insert, update, delete
ON Provinces
TO admin

GO
GRANT SELECT, DELETE
ON Rating
TO admin

GO
GRANT select, insert, update, delete
ON ShipFees
TO admin

GO
GRANT select, insert, update, delete
ON Sizes
TO admin

GO
GRANT select, insert, update, delete
ON TypeCards
TO admin

GO
GRANT select, insert, update, delete
ON Warranty
TO admin


go
sp_addlogin 'nvTin' , '123456', 'ShopOnline'

go
sp_adduser 'nvTin' , 'nvTin'

GRANT ALL
TO nvTin

GO
GRANT execute
on dbo.giam_gia
TO nvTin

GO
GRANT execute
on dbo.tinh_tong
TO nvTin

GO
GRANT Select, insert, update, delete
ON Accounts
TO nvTin

GO
GRANT select, insert
ON Address
TO nvTin

GO
GRANT select, insert, update, delete
ON Banks
TO nvTin


GO
GRANT select, insert, update, delete
ON Categories
TO nvTin

GO
GRANT select, insert, update, delete
ON Colors
TO nvTin

GO
GRANT SELECT, DELETE
ON Comments
TO nvTin

GO
GRANT SELECT, update, insert, delete
ON Customers
TO nvTin

GO
GRANT select
ON DeliverService
TO nvTin

GO
GRANT select, insert, update, delete
ON Districts
TO nvTin

GO
GRANT select, insert, update, delete
ON Genders
TO nvTin

GO
GRANT select, insert, update, delete
ON Countries
TO nvTin

GO
GRANT select, update, insert, delete
ON Orders
TO nvTin

GO
GRANT SELECT, update, insert, delete
ON OrdersDetail
TO nvTin

GO
GRANT select
ON Payments
TO nvTin

GO
GRANT select, insert, update, delete
ON Products
TO nvTin

GO
GRANT select, insert, update, delete
ON Provinces
TO nvTin

GO
GRANT SELECT, DELETE
ON Rating
TO nvTin

GO
GRANT select, insert, update, delete
ON ShipFees
TO nvTin

GO
GRANT select, insert, update, delete
ON Sizes
TO nvTin

GO
GRANT select, insert, update, delete
ON Status
TO nvTin

GO
GRANT select, insert, update, delete
ON TypeCards
TO nvTin

GO
GRANT select, insert, update, delete
ON Warranty
TO nvTin

ALTER LOGIN admin WITH PASSWORD=N'123456'
create database MINH
go
use [MINH]
go
create table Category (
    CategoryID int primary key identity(1,1),
    CategoryName nvarchar(100) NOT NULL
);
insert into Category (CategoryName)
values ('Modular Helmets')
select * from Category

create table Items (
    ItemsID int primary key identity(1,1),
    ItemsCode nvarchar(50) not null,
    ItemsName nvarchar(100) not null,
    Price decimal(10, 2) not null,
    InventoryQuantity int not null,
    ProductImage nvarchar(max),
    CategoryID int
    foreign key (CategoryID) references Category(CategoryID),
);
INSERT INTO Items (ItemsCode, ItemsName, Price, InventoryQuantity, ProductImage, CategoryID)
VALUES ('M2', 'Full face hat2', 1000000, 300,Null, NULL);
update  items
SET ItemsName = 'Locust helmet' 
WHERE ItemsID = 6;
delete from Items
where ItemsID = '2'
Select * from Items

create table Employee (
    EmployeeID int primary key identity(1,1),
    EmployeeCode nvarchar(50) not null,
    EmployeeName nvarchar(100) not null,
	EmployeePhone int not null,
	EmployeeBirth nvarchar(100) not null,
    Position nvarchar(50),
    AuthorityLevel nvarchar(50),
    Username nvarchar(50) not null unique,--unique: không ðc giá tri nào trùng lop 
    Password nvarchar(255) not null,
	PasswordChanged Bit Default 0,
);
-- them du lieu vao bang1
Insert into [dbo].[Employee]
Values ('Emp2','Dao Duy Long','0123','14/12/2003','Staff','Staff','staff','123',1);
update  Employee
SET AuthorityLevel = 'Warehouse' 
WHERE EmployeeID = 3;
Select * from [dbo].[Employee]

create table Customer (
    CustomerID int primary key identity(1,1),
    CustomerCode nvarchar(50)  not null,
    CustomerName nvarchar(100)  not null,
    PhoneNumber nvarchar(20),
	CustomerBirth nvarchar(100) not null,
    Address nvarchar(200),
);
INSERT INTO [dbo].[Customer] (CustomerCode, CustomerName, PhoneNumber, CustomerBirth, Address)
VALUES ('cs2', 'BuiGiaDuy', '08126196', '19/1/2000', 'HaNoi');
Select * from [dbo].[Customer]	

create table Sale (
    SaleID int primary key identity(1,1),
    SaleDate DATETIME NOT NULL,
    EmployeeID int
	foreign key (EmployeeID) references Employee(EmployeeID),
    CustomerID int
	foreign key (CustomerID) references Customer(CustomerID),
);


select * from [dbo].[Sale]

create table SaleDetail (
    SaleDetailID int primary key identity(1,1),
    SaleID int
	foreign key (SaleID) references Sale(SaleID),
    ItemsID int
	foreign key (ItemsID) references Items(ItemsID),
    QuantitySold int NOT NULL,

);		
select * from [dbo].[SaleDetail]
create table Import (
    ImportID int primary key identity(1,1),
    ImportDate datetime NOT NULL,
    EmployeeID int
	foreign key (EmployeeID) references Employee(EmployeeID),
);

select * from [dbo].[Import]
create table ImportDetail (
    ImportDetailID int primary key identity(1,1),
    ImportID int
	foreign key (ImportID) references Import(ImportID),
    ItemsID int
	foreign key (ItemsID) references Items(ItemsID),
    QuantityImported int NOT NULL,
    ImportCost decimal(10, 2),
);

select * from [dbo].[ImportDetail]

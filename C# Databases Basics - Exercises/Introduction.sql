insert into Towns(Id,[Name])
values (1,'Sofia'),(2,'Plovdiv'),(3,'Varna')
	
	

	insert into Minions(id,[Name],Age,TownId)
	values (1,'Kevin',22,1),
	(2,'Bob',15,3),
	(3,'Steward',null,2)

    ----
    Create table People(
Id bigint primary key IDENTITY not null,
[Name] nvarchar(200)not null,
Picture varbinary(max)check(datalength(Picture)<=2000*1024),
Height float(2) ,
[Weight] float(2) ,
Gender char(2) constraint one_letter check(Gender in ('f','m')) not null,
Birthdate  Date not null,
Biography nvarchar(max) 

)
insert into People ([Name],Gender,Birthdate)
values 
('Niki','m',Getdate()),
('Niki2','m',Getdate()),
('Niki3','m',Getdate()),
('Niki4','m',Getdate()),
('Niki5','m',Getdate())

---
CREATE TABLE Users
(
Id BigInt Primary key identity not null,
Username varchar(30)unique not null,
[Password] varchar(26) not null,
ProfilePicture varbinary(MAX)CHECK (datalength (ProfilePicture)<= 900*1024),
LastTimeLogin datetime2 not null,
IsDeleted bit not null,
)

Insert Into Users(Username,[Password],LastTimeLogin,IsDeleted)
values 
('Pesho','123456','10.10.2020',0),
('Pesho1','123456','10.10.2020',1),
('Pesho2','123456','10.10.2020',0),
('Pesho3','123456','10.10.2020',2),
('Pesh2o','123456','10.10.2020',0)


---

create table Directors (
Id int primary key  identity not null,
DirectorName nvarchar(50)not null,
Notes nvarchar(max),
)
create table Genres (
Id int primary key  identity not null,
GenreName nvarchar(50)not null,
Notes nvarchar(max),
)
create table Categories  (
Id int primary key  identity not null,
CategoriesName nvarchar(50)not null,
Notes nvarchar(max),
)
create table Movies   (
Id int primary key  identity not null,
Title nvarchar(50) not null,
DirectorId int foreign key references Directors(Id), 
CopyrightYear datetime2 not null, 
[Length] time not null,
GenreId int foreign key references Genres(Id) , 
CategoryId int foreign key references Categories(Id),
Rating tinyint not null, 
Notes nvarchar(max),
)

insert into Directors([DirectorName],Notes)
values ('Georgi','georgiNote'),
('Maria','mariaNote'),
('Ivan','ivanNote'),
('Pesho','peshoNote'),
('Marin','marinNote')

insert into Genres([GenreName],Notes)
values ('Trailer','georgiNote'),
('Horror','mariaNote'),
('Action','ivanNote'),
('Comedy','peshoNote'),
('Anime','marinNote')

insert into Categories([CategoriesName],Notes)
values ('Teen','georgiNote'),
('Creampie','mariaNote'),
('Blowjob','ivanNote'),
('Pronebone','peshoNote'),
('BBC','marinNote')


insert into Movies([Title],[DirectorId],[CopyrightYear],[Length],[GenreId],[CategoryId],[Rating],[Notes])
values ('War1',1,'01.02.2005','01:30:33',1,1,'5','Awesome'),
('War2',2,'02.02.2005','01:10:33',2,2,'2','Awesome'),
('War3',5,'03.02.2005','01:20:33',5,5,'1','Awesome'),
('War4',3,'04.02.2005','01:50:33',3,3,'3','Awesome'),
('War5',4,'05.02.2005','01:40:33',4,4,'2','Awesome')



----
CREATE TABLE Categories (
    Id INT IDENTITY(1, 1),
    CategoryName NVARCHAR(50) NOT NULL,
    DailyRate DECIMAL(9, 2),
    WeekLyRate DECIMAL(9, 2),
    MonthlyRate DECIMAL(9, 2),
    WeekendRate DECIMAL(9, 2),
    
    CONSTRAINT PK_Categories
    PRIMARY KEY (Id)
)

CREATE TABLE Cars (
    Id INT IDENTITY(1, 1),
    PlateNumber NVARCHAR(10) NOT NULL,
    Manufacturer NVARCHAR(20) NOT NULL,
    Model NVARCHAR(20) NOT NULL,
    CarYear INT NOT NULL,
    CategoryId INT,
    Doors INT NOT NULL,
    Picture VARBINARY(MAX),
    Condition NVARCHAR(MAX),
    Available BIT NOT NULL,
    
    CONSTRAINT PK_Cars
    PRIMARY KEY (Id),
    
    CONSTRAINT FK_Cars_Categories
    FOREIGN KEY (CategoryId)
    REFERENCES Categories(Id)
)

CREATE TABLE Employees (
    Id INT IDENTITY(1, 1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Title NVARCHAR(50) NOT NULL,
    Notes NVARCHAR(MAX),
    
    CONSTRAINT PK_Employees
    PRIMARY KEY (Id)
)

CREATE TABLE Customers (
    Id INT IDENTITY(1, 1),
    DriverLicenseNumber INT NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Adress NVARCHAR(100) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    ZIPCode INT NOT NULL,
    Notes NVARCHAR(MAX),
    
    CONSTRAINT PK_Customers
    PRIMARY KEY (Id)
)

CREATE TABLE RentalOrders (
    Id INT IDENTITY(1, 1),
    EmployeeId INT,
    CustomerId INT,
    CarId INT FOREIGN KEY REFERENCES Cars(Id),
    TankLevel INT NOT NULL,
    KilometrageStart INT NOT NULL,
    KilometrageEnd INT NOT NULL,
    TotalKilometrage AS KilometrageEnd - KilometrageStart,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    TotalDays AS DATEDIFF(DAY, StartDate, EndDate),
    RateApplied DECIMAL(9, 2),
    TaxRate DECIMAL(9, 2),
    OrderStatus NVARCHAR(50),
    Notes NVARCHAR(MAX),
    
    CONSTRAINT PK_RentalOrders
    PRIMARY KEY (Id),
    
    CONSTRAINT FK_RentalOrders_Employees
    FOREIGN KEY (EmployeeId)
    REFERENCES Employees(Id),
    
    CONSTRAINT FK_RentalOrders_Customers
    FOREIGN KEY (CustomerId)
    REFERENCES Customers(Id),
)

INSERT INTO Categories (CategoryName, DailyRate, WeekLyRate, MonthlyRate, WeekendRate) 
     VALUES ('Car', 20, 120, 500, 42.50),
            ('Bus', 250, 1600, 6000, 489.99),
            ('Truck', 500, 3000, 11900, 949.90)

INSERT INTO Cars (PlateNumber, Manufacturer, Model, CarYear, CategoryId, Doors, Picture, Condition, Available) 
     VALUES ('123456ABCD', 'Mazda', 'CX-5', 2016, 1, 5, 123456, 'Perfect', 1),
            ('asdafof145', 'Mercedes', 'Tourismo', 2017, 2, 3, 99999, 'Perfect', 1),
            ('asdp230456', 'MAN', 'TGX', 2016, 3, 2, 123456, 'Perfect', 1)

INSERT INTO Employees (FirstName, LastName, Title, Notes) 
     VALUES ('Ivan', 'Ivanov', 'Seller', 'I am Ivan'),
            ('Georgi', 'Georgiev', 'Seller', 'I am Gosho'),
            ('Mitko', 'Mitkov', 'Manager', 'I am Mitko')

INSERT INTO Customers (DriverLicenseNumber, FullName, Adress, City, ZIPCode, Notes)
     VALUES (123456789, 'Gogo Gogov', 'óë. Ïèðîòñêà 5', 'Ñîôèÿ', 1233, 'Good driver'),
            (347645231, 'Mara Mareva', 'óë. Èâàí Äðàñîâ 14', 'Âàðíà', 5678, 'Bad driver'),
            (123574322, 'Strahil Strahilov', 'óë. Êåñòåí 4', 'Äóïíèöà', 5689, 'Good driver')

INSERT INTO RentalOrders (EmployeeId, CustomerId, CarId, TankLevel, KilometrageStart, KilometrageEnd, StartDate, EndDate) 
     VALUES (1, 1, 1, 54, 2189, 2456, '2017-11-05', '2017-11-08'),
            (2, 2, 2, 22, 13565, 14258, '2017-11-06', '2017-11-11'),
            (3, 3, 3, 180, 1202, 1964, '2017-11-09', '2017-11-12')



            ----
            create table Employees(
Id int primary key identity ,
FirstName varchar(50) not null,
LastName varchar(50) not null,
Title varchar(50)  not null,
Notes varchar(50)
)
create table Customers (
Id int primary key identity ,
AccountNumber smallint,
FirstName varchar(50) not null,
LastName varchar(50) not null,
PhoneNumber smallint ,
EmergencyName varchar(50)not  null,
EmergencyNumber int not null,
Notes varchar(max)
)
create table RoomStatus (
Id int primary key identity,
RoomStatus bit not null,
Notes varchar(max)
)

create table RoomTypes 
(Id int primary key identity,
RoomType varchar(50)not null,
Notes varchar(max)
)
create table BedTypes 
(Id int primary key identity,
BedTypes varchar(50) not null,
Notes varchar(max)
)
create table Rooms (
Id int primary key identity,
RoomNumber tinyint not null,
RoomType int foreign key references RoomTypes(Id),
BedType int foreign key references BedTypes(Id),
Rate smallint not null,
RoomStatus int foreign key references RoomStatus(Id),
Notes varchar(max))

create table Payments (
Id int primary key identity,
EmployeeId int foreign key references Employees(Id),
PaymentDate date ,
AccountNumber tinyint ,
FirstDateOccupied date ,
LastDateOccupied date ,
TotalDays tinyint,
AmountCharged decimal (5,2),
TaxRate decimal (5,2) not null,
TaxAmount decimal (5,2) ,
PaymentTotal decimal (10,2),
Notes varchar(50)
)
create table Occupancies (
Id int primary key identity,
EmployeeId int foreign key references Employees(Id),
DateOccupied date ,
AccountNumber smallint ,
RoomNumber int foreign key references Rooms(id) ,
RateApplied tinyint,
PhoneCharge bit 
,Notes varchar(50))

insert into Employees (FirstName, LastName, Title)
values ('Niki','Nikolov','CEO'),
('Niki','Ivanov','Manager'),
('Niki','Petkov','Chef')

insert into Customers (FirstName, LastName, EmergencyName, EmergencyNumber)
values ('Niki','Niki','Niki','1233210505'),
('Niki3','Niki1','Niki5','1233211505'),
('Niki4','Niki2','Niki6','1233212505')

insert into RoomStatus (RoomStatus)
values (1),(0),(1)

insert into RoomTypes (RoomType)
values ('One'),('Two'),('Three')

insert into BedTypes (BedTypes)
values ('One'),('Two'),('Three')

insert into Rooms (RoomNumber, RoomType, BedType, Rate, RoomStatus)

values 
(1,1,1,10,1),
(2,2,2,5,2),
(3,3,3,6,3)

insert into Payments([TaxRate])
values (200.20),
 (220.20),
 (240.20)


insert into Occupancies (Notes)
values ('very good'),
('very g0dd'),
('very bad')



---
select * from Towns
select * from Departments
select * from Employees


----
select * from Towns
order by [name] ASC

select * from Departments
order by [name] ASC

select *from Employees
order by [Salary]DESC


---
select [Name]
from Towns
order by [Name] ASC

select [Name]
from Departments
order by [Name] ASC

select  [FirstName],[LastName],[JobTitle],[Salary]
from Employees 
order by [Salary]DESC


---
Update Employees
set Salary +=Salary*0.1;

select [Salary]
from [Employees]


---
update Payments
set TaxRate -=TaxRate*0.03

select TaxRate
from Payments

---
truncate table Occupancies







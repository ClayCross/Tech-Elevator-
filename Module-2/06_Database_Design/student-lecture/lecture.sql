-- Use master so that we are not "sitting" in the art database
Use master
GO
--Drop the ddatabse to start from search
Drop database if exists ArtGallery

--Create a new empty database

Create Database ArtGallery


-- First Create any tables with no Foreign Keys

--Address
Create Table Address(
AddressId int identity(1,1),
Street nvarchar(100),
City nvarchar(50),
State nvarchar (50),
PostalCode nvarchar(10),
Constraint PK_Address Primary Key (AddressId)

)

-- Customer
Create Table Customer(
CustomerId int identity(1,1),
CustomerName nvarchar(100),
Phone varchar(20),
Constraint PK_Customer Primary Key (CustomerID),

)

-- Artist

Create Table Artist(

ArtistId int Identity(1000, 10),   --  1000 is starting number and 10 is increment
ArtistName nvarchar(50) Not Null,
AddressID int Null,
Phone varchar(20),

Constraint PK_Artist Primary Key (ArtistId),
Constraint FK_Artist_Address Foreign Key (AddressID) References Address(AddressId)

)

--Painting
Create table Painting (
PaintingId int identity(1,1),
ArtistId int not null,
Title nvarchar(100) not null,
AskingPrice money null,
Constraint PK_Painting Primary Key (PaintingID),
Constraint FK_Painting_Artist Foreign Key (ARtistID) References Artist(ArtistId)

)

--Transaction
Create Table ArtTransaction(
ArtTransactionId int identity(1,1),
TransactionType varchar(8) not null,
CustomerId int not null,
PaintingId int not null,
TransactionDate datetime not null Default(getdate()),
Price money not null,
Constraint PK_ArtTransaction Primary Key (ArtTransactionId),
Constraint FK_ArtTransaction_Customer Foreign Key (CustomerId) References Customer(CustomerId),
Constraint FK_ArtTransaction_Painting Foreign Key (PaintingId) References Painting(PaintingId),
Constraint CK_ArtTransaction_TransactionType Check (TransactionType In('sale', 'purchase')),

)
-- CustomerAddress
Create Table CustomerAddress(
CustomerId itn,
AddressId int,




)






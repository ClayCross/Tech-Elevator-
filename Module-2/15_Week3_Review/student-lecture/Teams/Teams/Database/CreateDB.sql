--Create the tables for the Team database
-- Here is another comment

Use master
Go

Drop Database if exists NFLDB;

Create Database NFLDB;
Go

Use NFLDB
Go

-- Create the Team Table first
Create Table Team (
    TeamId int Primary Key identity,
    Location varchar(25) not null,
    TeamName varchar(25) not null,
    Conference int not null,
    Division int not null,
    Wins int not null default 0,
    Losses int not null default 0,
    Constraint Check_TeamConference Check (Conference Between 1 and 2),
    Constraint Check_TeamDivision Check (Division Between 1 and 4)
);

-- Create the Player
Create Table Player (
   PlayerId int identity,
   FirstName nvarchar(30) not null,
   LastName nvarchar(30) not null,
   TeamId int Null,
   BirthDate date not null,
   Position varchar(3) not null, 
   Constraint PK_Player Primary Key (PlayerId),
   Constraint FK_PlayerTeam Foreign Key(TeamId) References Team(TeamId)
);

--Insert Data here...
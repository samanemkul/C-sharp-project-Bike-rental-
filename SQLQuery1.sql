create database Petrolbikes
Use petrolbikes
go
 create table Pbike(
 id int not null primary key identity(1,1),
 name nvarchar(255) not null,
 bikeno int not null,
 year int not null
 );
 create table Ebike(
 id int not null primary key identity(1,1),
 name nvarchar(255) not null,
 bikeno int not null,
 year int not null
 );
 insert into Pbike(name,bikeno,year)
 VALUES ('TVS','7998','2021');
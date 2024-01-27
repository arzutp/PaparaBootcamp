---DDL veritabanı veya tablo oluşturmayı, silmeyi be güncelleme yapmayı sağlayan ifadelerdir. 
---Create, Alter, Drop

--Create
--CREATE DATABASE — Veritabanı oluşturmak için kullanılır.
--CREATE TABLE — Tablo oluşturmak için kullanılır.

---veritabanı oluşturmak için 
Create Database BookShopierDb

--veritabanında tablo oluşturmak için
Create Table Users(
	id int IDENTITY(1,1) primary key,
    username varchar(50) not null,
	email varchar(50) not null,
	password varchar(50) not null
);


Create Table Author(
	id int IDENTITY(1,1) primary key,
    name varchar(100) not null,
);

Create Table Books(
	id int IDENTITY(1,1) primary key,
    bookName varchar(50) not null,
	authorId int not null,
	foreign key (authorId) references Author(id)
);

create table Genres(
	id int IDENTITY(1,1) primary key,
	name varchar(50) not null
);

create table BookGenres (
	id int IDENTITY(1,1) primary key,
	bookId int not null,
	foreign key (bookId) references Books(id),
	genreId int null,
	foreign key(genreId) references Genres(id)
);

create table Orders(
	id int IDENTITY(1,1) primary key,
	userId int not null,
	foreign key (userId) references Users(id),
	OrderDate datetime not null
);

create table OrderItems (
    id int IDENTITY(1,1) primary key,
    orderId int,
	foreign key (orderId) references Orders(id),
    bookId int,
	foreign key (bookId) references Books(id),
    Quantity int,
    Price DECIMAL(10,2)
);


--ALTER : tablolarda değişiklik yapılmasını sağlar
alter table Author
alter column name varchar(50) NOT NULL;


--tabloya yeni sütun eklemek için
alter table users
add address varchar(50) not null

--tabloya yeni sütun ekleyip silme denemesi yaptım
--ekleme
alter table books
add address varchar(100) not null

--DROP-Tabloların nesnelerin silinmesini sağlar.
--silme
alter table books
drop column address


alter table books
add publicationYear int



--tabloyu silmek için kullanılır
drop table BookGenres 

create table BookGenres (
	id int IDENTITY(1,1) primary key,
	bookId int not null,
	foreign key (bookId) references Books(id),
	genreId int null,
	foreign key(genreId) references Genres(id)
);


alter table orders 
alter column OrderDate date not null
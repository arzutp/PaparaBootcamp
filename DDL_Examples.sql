---DDL veritabaný veya tablo oluþturmayý, silmeyi be güncelleme yapmayý saðlayan ifadelerdir. 
---Create, Alter, Drop

--Create
--CREATE DATABASE — Veritabaný oluþturmak için kullanýlýr.
--CREATE TABLE — Tablo oluþturmak için kullanýlýr.

---veritabaný oluþturmak için 
Create Database BookShopierDb

--veritabanýnda tablo oluþturmak için
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


--ALTER : tablolarda deðiþiklik yapýlmasýný saðlar
alter table Author
alter column name varchar(50) NOT NULL;


--tabloya yeni sütun eklemek için
alter table users
add address varchar(50) not null

--tabloya yeni sütun ekleyip silme denemesi yaptým
--ekleme
alter table books
add address varchar(100) not null

--DROP-Tablolarýn nesnelerin/sütun silinmesini saðlar.
--silme
alter table books
drop column address

--sütun ekleme
alter table books
add publicationYear int

--not null yapmayý unuttuðum için güncelleme yaptým
alter table books
alter column publicationYear int not null

--tabloyu silmek için kullanýlýr
drop table BookGenres 

create table BookGenres (
	id int IDENTITY(1,1) primary key,
	bookId int not null,
	foreign key (bookId) references Books(id),
	genreId int null,
	foreign key(genreId) references Genres(id)
);

--güncelleme
alter table orders 
alter column OrderDate date not null




--baðlantýsý olan bir tabloyu silmek için önce baðlantýlarý temizlemek gerekir
--ForeignKeyName = FK__Books__authorId__3B75D760
--ForeignKeyName farklý olabilir!!!
----altta ki sorgu ile baðlantýyý kopardýk
alter table Books drop constraint FK__Books__authorId__3B75D760;

--daha sonra books tablosundan authorId yi sildik
alter table Books
drop column authorId

--daha sonra author tablosunu sildik
drop table Author


--tekrar ekledim
Create Table Author(
	id int IDENTITY(1,1) primary key,
    name varchar(50) not null,
);

--daha sonra books tablosuna tekrar baðlama iþlemi gerçekleþtirmek için author id ekledim
alter table Books 
add authorId int not null


--daha sonra baðlama iþlemini yaptým
ALTER TABLE Books
ADD CONSTRAINT FK_Books_Author
FOREIGN KEY (authorId) REFERENCES Author(id);


--database silme iþlemi
--önce tüm baðlantýlarý sona erdirdik çünkü halla kullanýyor diye hata veriyor

alter database BookShopierDb set single_user with rollback immediate;

--nu sorgu da kullanýldýðý yerleri listeler
use master;
select
   d.name,
   d.dbid,
   spid,
   login_time,
   nt_domain,
   nt_username,
   loginame
from
   sysprocesses p
join
   sysdatabases d
on
   p.dbid = d.dbid
where
   d.name = 'BookShopierDb';

--sonra silme iþlemini gereçekleþtirdik
drop database BookShopierDb

---DDL veritaban� veya tablo olu�turmay�, silmeyi be g�ncelleme yapmay� sa�layan ifadelerdir. 
---Create, Alter, Drop

--Create
--CREATE DATABASE�� Veritaban� olu�turmak i�in kullan�l�r.
--CREATE TABLE�� Tablo olu�turmak i�in kullan�l�r.

---veritaban� olu�turmak i�in 
Create Database BookShopierDb

--veritaban�nda tablo olu�turmak i�in
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


--ALTER : tablolarda de�i�iklik yap�lmas�n� sa�lar
alter table Author
alter column name varchar(50) NOT NULL;


--tabloya yeni s�tun eklemek i�in
alter table users
add address varchar(50) not null

--tabloya yeni s�tun ekleyip silme denemesi yapt�m
--ekleme
alter table books
add address varchar(100) not null

--DROP-Tablolar�n nesnelerin/s�tun silinmesini sa�lar.
--silme
alter table books
drop column address

--s�tun ekleme
alter table books
add publicationYear int

--not null yapmay� unuttu�um i�in g�ncelleme yapt�m
alter table books
alter column publicationYear int not null

--tabloyu silmek i�in kullan�l�r
drop table BookGenres 

create table BookGenres (
	id int IDENTITY(1,1) primary key,
	bookId int not null,
	foreign key (bookId) references Books(id),
	genreId int null,
	foreign key(genreId) references Genres(id)
);

--g�ncelleme
alter table orders 
alter column OrderDate date not null




--ba�lant�s� olan bir tabloyu silmek i�in �nce ba�lant�lar� temizlemek gerekir
--ForeignKeyName = FK__Books__authorId__3B75D760
--ForeignKeyName farkl� olabilir!!!
----altta ki sorgu ile ba�lant�y� kopard�k
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

--daha sonra books tablosuna tekrar ba�lama i�lemi ger�ekle�tirmek i�in author id ekledim
alter table Books 
add authorId int not null


--daha sonra ba�lama i�lemini yapt�m
ALTER TABLE Books
ADD CONSTRAINT FK_Books_Author
FOREIGN KEY (authorId) REFERENCES Author(id);


--database silme i�lemi
--�nce t�m ba�lant�lar� sona erdirdik ��nk� halla kullan�yor diye hata veriyor

alter database BookShopierDb set single_user with rollback immediate;

--nu sorgu da kullan�ld��� yerleri listeler
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

--sonra silme i�lemini gere�ekle�tirdik
drop database BookShopierDb

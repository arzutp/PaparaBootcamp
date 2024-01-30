--DML 
--- SELECT :  verileri �ekmek i�in kullan�l�r

--bir tablodaki t�m verileri getirme
select * from Books

select *  from books where authorId=3

--bu �ekilde tablo ismini belirleyebiliriz
select bookname 'Book Name' from books where authorId=2

select * from Orders where userId=1


select * from OrderItems
where orderId = 1;


--join examples
--iki tabloyu birle�tirme
select bookname 'Book Name', name 'Author Name'
From Books 
join Author on Books.authorId = Author.id



--3 tane tabloyu birle�tirme
select u.username, o.OrderDate, oitems.Price from Users u
Join Orders o on o.userId=u.id 
join OrderItems oitems on o.id=oitems.orderId


--4 tane tabloyu birle�tirme
select u.username, b.bookName ,o.OrderDate, oitems.Price from Users u
Join Orders o on o.userId=u.id 
join OrderItems oitems on o.id=oitems.orderId
join Books b on b.id=oitems.bookId


--5 tane tabloyu birle�tirme
select u.username, b.bookName, a.name ,o.OrderDate, oitems.Price from Users u
Join Orders o on o.userId=u.id 
join OrderItems oitems on o.id=oitems.orderId
join Books b on b.id=oitems.bookId
join Author a on b.authorId=a.id


--left join
--otomatik olarakta left join yapar zaten 
select bookname as 'Book Name', name as 'Author Name'
From Books 
left join Author on Books.authorId = Author.id


--right join
--books tablosunda kar��l��� olmayan authors lar� da al demek oluyor
select bookname as 'Book Name', name as 'Author Name'
From Books 
right join Author on Books.authorId = Author.id


--ad�nda ba ge�en kitap var m� ?
Select * from Books where  bookName like'%ba%'


--ortalama fiyat
select avg(Price) from OrderItems 


--en �ok bulunan yazarlar� ve kitap say�lar�
select Author.name as 'Author Name', COUNT(*) as 'Book Count' from Books
inner join Author 
on Author.id = Books.authorId
group by Author.name order by COUNT(*) desc


--en �ok kitab� bulunan yazar 
select top(1) name as 'Author Name', COUNT(*) as 'Book Count' from Books
inner join Author 
on Author.id = Books.authorId
group by name order by COUNT(*) desc


--�oka �ok ili�kili tablolaro birle�tirme
select Books.bookName as 'Book Name',  Genres.name as 'Genre Name'
FROM Books
join BookGenres ON Books.id = BookGenres.bookId
join Genres ON BookGenres.genreId = Genres.id;


--ka� t�rde kitap var
select Distinct(Genres.name)
FROM Books
join BookGenres ON Books.id = BookGenres.bookId
join Genres ON BookGenres.genreId = Genres.id;


--ka� farkl� �e�itte kitap var
select COUNT(Distinct(Genres.name))
FROM Books
join BookGenres ON Books.id = BookGenres.bookId
join Genres ON BookGenres.genreId = Genres.id;


--and - iki ko�ulun da do�ru olmas� gerek
select * from Books
join Author on Author.id = Books.authorId 
where bookName = 'Yabanc�' and name= 'Albert Camus'


--or - bir ko�ulun do�ru olmas� yeterli
select * from Books
join Author on Author.id = Books.authorId 
where bookName = 'Yabanc�' or name= 'Fyodor Dostoyevski'


--order by - s�ralama yapar 
--desc ekledi�imiz de b�y�kten k����e s�ralar
select * from OrderItems
order by Price 

select * from OrderItems
order by Price desc


--bir tablodaki t�m kayotlar� silmek i�in 
delete from BookGenres


--sonu a ile biten kitaplar
select * from Books where bookName like '%a'


--g ile ba�layan kitaplar
select * from Books where bookName like 'g%'


-- kitap ad� a g ya da i ile ba�layan kay�tlar
select * from Books
WHERE bookName like '[agi]%'


-- in kullan�m� where ile birden fazla de�eri aratabilmemizi sa�lar
select * from Books
WHERE bookName in ('�nsanc�klar', 'Yabanc�')


--between kullan�m�
select * from Books
where publicationYear between 2012 and 2019


select count(*) from Books



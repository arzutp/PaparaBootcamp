--DML 
--- SELECT :  verileri çekmek için kullanılır

--bir tablodaki tüm verileri getirme
select * from Books

select *  from books where authorId=3

--bu şekilde tablo ismini belirleyebiliriz
select bookname 'Book Name' from books where authorId=2

select * from Orders where userId=1


select * from OrderItems
where orderId = 1;


--join examples
--iki tabloyu birleştirme
select bookname 'Book Name', name 'Author Name'
From Books 
join Author on Books.authorId = Author.id



--3 tane tabloyu birleştirme
select u.username, o.OrderDate, oitems.Price from Users u
Join Orders o on o.userId=u.id 
join OrderItems oitems on o.id=oitems.orderId


--4 tane tabloyu birleştirme
select u.username, b.bookName ,o.OrderDate, oitems.Price from Users u
Join Orders o on o.userId=u.id 
join OrderItems oitems on o.id=oitems.orderId
join Books b on b.id=oitems.bookId


--5 tane tabloyu birleştirme
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
--books tablosunda karşılığı olmayan authors ları da al demek oluyor
select bookname as 'Book Name', name as 'Author Name'
From Books 
right join Author on Books.authorId = Author.id


--adında ba geçen kitap var mı ?
Select * from Books where  bookName like'%ba%'


--ortalama fiyat
select avg(Price) from OrderItems 


--en çok bulunan yazarları ve kitap sayıları
select Author.name as 'Author Name', COUNT(*) as 'Book Count' from Books
inner join Author 
on Author.id = Books.authorId
group by Author.name order by COUNT(*) desc


--en çok kitabı bulunan yazar 
select top(1) name as 'Author Name', COUNT(*) as 'Book Count' from Books
inner join Author 
on Author.id = Books.authorId
group by name order by COUNT(*) desc


--çoka çok ilişkili tablolaro birleştirme
select Books.bookName as 'Book Name',  Genres.name as 'Genre Name'
FROM Books
join BookGenres ON Books.id = BookGenres.bookId
join Genres ON BookGenres.genreId = Genres.id;


--kaç türde kitap var
select Distinct(Genres.name)
FROM Books
join BookGenres ON Books.id = BookGenres.bookId
join Genres ON BookGenres.genreId = Genres.id;


--kaç farklı çeşitte kitap var
select COUNT(Distinct(Genres.name))
FROM Books
join BookGenres ON Books.id = BookGenres.bookId
join Genres ON BookGenres.genreId = Genres.id;


--and - iki koşulun da doğru olması gerek
select * from Books
join Author on Author.id = Books.authorId 
where bookName = 'Yabancı' and name= 'Albert Camus'


--or - bir koşulun doğru olması yeterli
select * from Books
join Author on Author.id = Books.authorId 
where bookName = 'Yabancı' or name= 'Fyodor Dostoyevski'


--order by - sıralama yapar 
--desc eklediğimiz de büyükten küçüğe sıralar
select * from OrderItems
order by Price 

select * from OrderItems
order by Price desc


--bir tablodaki tüm kayotları silmek için 
delete from BookGenres


--sonu a ile biten kitaplar
select * from Books where bookName like '%a'


--g ile başlayan kitaplar
select * from Books where bookName like 'g%'


-- kitap adı a g ya da i ile başlayan kayıtlar
select * from Books
WHERE bookName like '[agi]%'


-- in kullanımı where ile birden fazla değeri aratabilmemizi sağlar
select * from Books
WHERE bookName in ('İnsancıklar', 'Yabancı')


--between kullanımı
select * from Books
where publicationYear between 2012 and 2019


select count(*) from Books



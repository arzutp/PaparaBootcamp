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


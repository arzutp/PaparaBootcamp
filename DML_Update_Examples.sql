--DML
--- UPDATE g�ncelleme i�lemler i�in

update Author 
Set name = 'Albert aaaa' where id=5

update OrderItems
set Quantity = 4, Price = 400
where id = 3;

update Books
Set authorId = 3 where id = 5

update Users
set password = 123456 where id = 1

--id d���nda bir de�ere g�re g�ncelleme
update Genres set name = 'Japon Edebiyat�' where name = 'Japon Edb'
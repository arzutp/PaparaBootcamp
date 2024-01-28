--DML
--- UPDATE güncelleme işlemler için

update Author 
Set name = 'Albert Camus' where id=5

update OrderItems
set Quantity = 4, Price = 400
where id = 3;

update Books
Set authorId = 3 where id = 5

update Users
set password = 123456 where id = 1

--id dışında bir değere göre güncelleme
update Genres set name = 'Japon Edebiyatı' where name = 'Japon Edb'
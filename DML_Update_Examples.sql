--DML
--- UPDATE güncelleme iþlemler için

update Author 
Set name = 'Albert aaaa' where id=5

update OrderItems
set Quantity = 4, Price = 400
where id = 3;

update Books
Set authorId = 3 where id = 5

update Users
set password = 123456 where id = 1

--id dýþýnda bir deðere göre güncelleme
update Genres set name = 'Japon Edebiyatý' where name = 'Japon Edb'
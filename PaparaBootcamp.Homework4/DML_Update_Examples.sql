--DML
--- UPDATE güncelleme işlemleriçin

update Author 
Set name = 'Albert Camus' where id=5

update OrderItems
set Quantity = 4, Price = 400
where id = 3;

update Books
Set authorId = 3 where id = 5
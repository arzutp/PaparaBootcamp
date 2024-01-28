--DML
--- DELETE : silme işlemleri için 

delete Books where id=6

--id dışında bir değere göre silme
delete Genres where name = 'Korku'

--silme işlemi yaparken ilişkili olduğu tablolarda veri kullanıldıysa sorun olur
--bunu ortadan kaldırmak için önce o verileri sileriz.
delete from OrderItems
where bookId = 1;

delete BookGenres where bookId = 1

delete Books where id=1





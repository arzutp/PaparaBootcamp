--DML
--- DELETE : silme iþlemleri için 

delete Books where id=6

--id dýþýnda bir deðere göre silme
delete Genres where name = 'Korku'

--silme iþlemi yaparken iliþkili olduðu tablolarda veri kullanýldýysa sorun olur
--bunu ortadan kaldýrmak için önce o verileri sileriz.
delete from OrderItems
where bookId = 1;

delete BookGenres where bookId = 1

delete Books where id=1





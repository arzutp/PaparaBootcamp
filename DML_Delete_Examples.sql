--DML
--- DELETE : silme i�lemleri i�in 

delete Books where id=6

--id d���nda bir de�ere g�re silme
delete Genres where name = 'Korku'

--silme i�lemi yaparken ili�kili oldu�u tablolarda veri kullan�ld�ysa sorun olur
--bunu ortadan kald�rmak i�in �nce o verileri sileriz.
delete from OrderItems
where bookId = 1;

delete BookGenres where bookId = 1

delete Books where id=1





--DML
-- Tabloya kayıt girmek, kayıt silmek ve güncellemek gibi işlemlerin yapılması . 
--- SELECT - INSERT - UPDATE - DELETE 

--Insert tabloya kayıt girmek için
insert into Author (name) values ('Franz Kafka');
insert into Author (name) values ('Honoré de Balzac');
insert into Author (name) values ('Fyodor Dostoyevski');
insert into Author (name) values ('Lev Tolstoy')
insert into Author (name) values ('Camus')

insert into Books (bookName, authorId, publicationYear) values ('Dönüşüm', 1, 2001);
insert into Books (bookName, authorId, publicationYear) values ('İnsancıklar', 3, 2019);
insert into Books (bookName, authorId, publicationYear) values ('Goriot Baba', 2, 2019);
insert into Books (bookName, authorId, publicationYear) values ('Yabancı', 5, 2019);
insert into Books (bookName, authorId, publicationYear) values ('Suç ve Ceza', 5, 2001);

insert into Genres (name) values ('Roman');
insert into Genres (name) values ('Çeviri');
insert into Genres (name) values ('Korku');

insert into BookGenres (bookId, genreId) values (1,1)
insert into BookGenres (bookId, genreId) values (1,2)
insert into BookGenres (bookId, genreId) values (2,1)
insert into BookGenres (bookId, genreId) values (2,2)
insert into BookGenres (bookId, genreId) values (3,1)
insert into BookGenres (bookId, genreId) values (3,2)

insert into Users (username, email, password, address) values ('ahmet', 'ahmet@gmail.com', '22222', 'istanbul üsküdar')
insert into Users (username, email, password, address) values ('arzu', 'arzu@gmail.com', '021222', 'izmir buca')

insert into Orders (userId, OrderDate) values (1, '2024-01-27')
insert into Orders (userId, OrderDate) values (2, '2024-01-27')

insert into OrderItems (orderId, bookId, Quantity, Price) values (1, 1, 2, 200)
insert into OrderItems (orderId, bookId, Quantity, Price) values (1, 3, 2, 500)
insert into OrderItems (orderId, bookId, Quantity, Price) values (2, 2, 1, 200)
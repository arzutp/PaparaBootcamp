--DML
-- Tabloya kay�t girmek, kay�t silmek ve g�ncellemek gibi i�lemlerin yap�lmas� . 
--- SELECT - INSERT - UPDATE - DELETE 

--Insert tabloya kay�t girmek i�in
insert into Author (name) values ('Franz Kafka');
insert into Author (name) values ('Honor� de Balzac');
insert into Author (name) values ('Fyodor Dostoyevski');
insert into Author (name) values ('Lev Tolstoy')
insert into Author (name) values ('Camus')


insert into Books (bookName, authorId, publicationYear) values ('D�n���m', 1, 2001);
insert into Books (bookName, authorId, publicationYear) values ('�nsanc�klar', 3, 2019);
insert into Books (bookName, authorId, publicationYear) values ('Goriot Baba', 2, 2019);
insert into Books (bookName, authorId, publicationYear) values ('Yabanc�', 5, 2019);
insert into Books (bookName, authorId, publicationYear) values ('Su� ve Ceza', 5, 2001);
insert into Books (bookName, authorId, publicationYear) values ('Vadideki Zambak', 2, 2001);


insert into Genres (name) values ('Roman');
insert into Genres (name) values ('�eviri');
insert into Genres (name) values ('Korku');
insert into Genres (name) values ('Japon Edb');
insert into Genres (name) values ('Tiyatro');
insert into Genres (name) values ('Fabl');

insert into BookGenres (bookId, genreId) values (1,1)
insert into BookGenres (bookId, genreId) values (1,2)
insert into BookGenres (bookId, genreId) values (2,1)
insert into BookGenres (bookId, genreId) values (2,2)
insert into BookGenres (bookId, genreId) values (3,1)
insert into BookGenres (bookId, genreId) values (3,2)

insert into Users (username, email, password, address) values ('ahmet', 'ahmet@gmail.com', '22222', 'istanbul �sk�dar')
insert into Users (username, email, password, address) values ('arzu', 'arzu@gmail.com', '021222', 'izmir buca')

insert into Orders (userId, OrderDate) values (1, '2024-01-27')
insert into Orders (userId, OrderDate) values (2, '2024-01-27')

insert into OrderItems (orderId, bookId, Quantity, Price) values (1, 1, 2, 200)
insert into OrderItems (orderId, bookId, Quantity, Price) values (1, 3, 2, 500)
insert into OrderItems (orderId, bookId, Quantity, Price) values (2, 2, 1, 200)
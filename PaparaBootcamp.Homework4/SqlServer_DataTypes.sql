--Sql Server Veri tipleri örnek ve açıklamaları
--hepsinin örnekleri en altta verilmiştir.


--metinsel veri tipleri
--char(n)
--sabit uzunluktaki karakter dizilerini temsil eder. 
--ascii karakter seti için 1 byte yer kaplar
--bu sebepler data da kapladığı yer n*1 şeklinde olur
--name char(10)


--nchar(n)
-- Unicode karakter setini kullanır.
-- sabit bir uzunluğa sahiptir.


--nvarchar(n)
--değişken uzunlukta veri tipleri için n max karakter uzunluğunu belirtir.
--vachar(50) olsa da 20 karakter bir değer girilse 20 karakterlik yer kaplar bu yüzden data da ne kadar yer kapladığı değişkenlik gösterir
--Unicode karakter setini kullanır. 
--bu sebeple her karakter için data da 2 byte yer kaplar


--varchar(n)
--ascii karakter setini kullanır bu sebeple 1 byte yer kaplar
-- değişken uzunluktadır.


--text 
-- uzun veri tipleri için kullanılır ama sql 2005 ten sonra ki sürümlerde kullanımı tavsiye edilmemektedir bunun yerine 
--varchar(max), nvarchar(max) ve varbinary(max) kullanılır.
-- 2 gb'ye kadar depolamaya izin verir
--ntext
--unicode veri tipleri için

---binary veri tipleri
--resimler, dosyalar, şifrelenmiş veriler gibi ikili formatlardaki verileri saklamak için

--binary(n) 
-- 0 ve 1 leri temsil eden veri tipleri
--sabit uzunluktaki ikili veri tiplerini depolamak için kullanılır.

--varbinary(n)
--değişken uzunluktaki ikili veri tipleri için kullanılır.

--image 
--büyük ikili nesneler için kullanılır ama artık bunun yerine
-- varbinary(max) tercih edilir.


-- sayısal veri tipleri
--bit
--0 ve 1 değerini temsil eder
--1 bit yer kaplar
-- örnek veri 1


-- tinyint
--8 bitlik (1 byte) bir tamsayıyı temsil eder
-- 0-255 arası
--örnek 255, 125, 


--smallint
-- 16 bitlik (2 byte) değerleri temsil eder
-- -32.768 ve 32.768 arası  
--örnek 32767, -2345


--int 
--32 bit (4 byte ) büyüklüğünde
-- -2 milyar ve +2 milyar arasında 
--örnek 2147483647


--bigint
--64 bit (8 byte) bir tamsayıyı
-- -2⁶³ ve 2⁶³ arasında
--örnek 9223372036854775807

--decimal(p,s)
--tam sayı ve ondalık kısmı içeren bir sayıyı depolamak için kullanılır
--s ondalık kısmı temsil eder
--değer girilmezse direkt (10,2) olarak algılar



-- parasal veri tipleri
--para cinsinden miktarları
--8 byte boyutunda
-- dört ondalık basamağa kadar hassaslık sunar.

--smallmoney
--küçük bir miktarı temsil eder
--4 byte uzunluğunda yer kaplar
--dört ondalık basamağa kadar hassaslık sunar.


--tarih - zaman veri tipleri
--date
--yıl, ay ve gün bilgileri
--3 byte
-- örnek '2024-01-29'


--time
-- saat, dakika, saniye ve milisaniye 
-- boyutu kullanıcı tarafından değiştirilebilen 3–5 byte arası yer kaplar
-- örnek '12:30:45.500'


--datetime 
--yıl, ay, gün, saat, dakika, saniye ve milisaniye 
--8 byte
-- örnek '2024-01-29 12:30:45.500'

--smalldatetime
-- yıl, ay, gün, saat, dakika
-- saniye bilgisini içermez
-- 4 byte
-- örnek '2024-01-29 12:30'

--datetime2
--datetime a göre daha hassastır.
--milisaniye değerlerini de tutar
--salise hassasiyetine göre 6–8 byte
-- örnek '2024-01-29 12:30:45.1234567'


--GUID
--UNIQUEIDENTIFIER benzersiz kimlik alanlarda kullanılır.
--16 byte uzunluğunda benzersiz GUID tipinde veri tutar.

--Xml
-- XML türünde veri saklamak için kullanılır. Kapasitesi 2 GB’dır.
-- xml metin tabanlı verileri organize etmek ve değişik sistemler arasında veri alışverişini sağlamak için 

--sql_variant
--sayı,metin, binary gibi farklı veri tiplerini depolamak için kullanılan veri tipidir.
--Yani bir sütun ya da fonksiyonda birden fazla veri tipi kullanmamız gerektiğinde tercih etmeliyiz.


--geography 
-- Coğrafi koordinat ve GPS verilerini tutmak için kullanılır.



create table DataTypesExamples(
 id UNIQUEIDENTIFIER,
 name char(10),
 nameNChar nchar(10),
 nameNVarchar nvarchar(20),
 nameVarchar nvarchar(20),
 text nvarchar(max),
 image varbinary(max),
 bitValue bit,
 tinyIntValue tinyint,
 smallintValue smallint,
 bigintValue bigint,
 decimalNumber decimal(10,3),
 moneyValue money,
 dateValue date,
 timeValue time,
 datetimeValue datetime,
 datetime2Value datetime2,
 XmlData XML,

);

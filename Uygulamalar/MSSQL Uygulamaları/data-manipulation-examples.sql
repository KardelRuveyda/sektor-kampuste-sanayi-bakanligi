--Select kullanımı
select * from Products

--Where koşulu kullanımı
-- Id ilk  kayıtlardan son kayıtlara doğru.
select * from Products
where UnitPrice > 53 
order by ProductID

-- Id son kayıttan ilk kayıta doğru
select * from Products
where UnitPrice>53
order by ProductID desc 

--Where koşulu ( üç condition,sıralama ve top ile sayı belirleme)
select top 1 * from Products
where UnitPrice>53 and  UnitsInStock<42 and Discontinued =0
order by ProductID desc 

-- Tablodaki kayıt sayısını getir.
-- SQL kullanımında alians kavramı: as Urun_Sayisi
select COUNT(*) as Urun_Sayisi from Products
where UnitPrice>53 and UnitsInStock<42

--Tablodaki ortalama fiyatı getirme
select AVG(UnitPrice) as Ortalama_Fiyat from Products

--Yuvarlama ortalama: Küsüratlı bir sayıyıyı yuvarlama işlemi
select CEILING(AVG(UnitPrice)) from Products

-- Tablodaki stock oranlarının toplamı getirme
select SUM(UnitsInStock) as Stok_Toplam from Products

--Tabloda aynı olan verilerin,tekrarlı bir şekilde gelmesini engelleyelim.
-- DISTINCT
select DISTINCT SupplierID from Products

--Tabloda olmayan kayıtları getirsin.( Discontinued 0 olmayanları getir.)
select * from Products
where Discontinued!=0

select * from Products
where Discontinued<>0

--Tablo içerisinde "x" değer içeren kayıtları getir. ( Proudt Name)
-- Alice Mutton
-- Alice ile başlayan, Alice ile biten ve içerisinde Alice geçen

--Alice ile başlayan
--Like komutundan yararlanılır. 

select * from Products
where ProductName like 'Alice%'

--Alice ile biten
select * from Products
where ProductName like '%Alice'

-- İçerisinde ALice geçen
select * from Products
where ProductName like '%Alice%'

-- İçerisinde Alice ile biten olmayan ( Not Like )   
select * from Products
where ProductName NOT LIKE '%Alice'


--Birden fazla kayıt için 
-- CategoryId 1 yada 2 yada 3 olanlar
-- Or komutunu kullanırız.

select * from Products
where CategoryID =1 or CategoryID=2 or CategoryID=3

--Or yerine IN de kullanabilirsiniz.
select * from Products
where CategoryID in(1,2,3)

--UnitPrice'ı 18 ile 40 arasındaki kayıtları getirsin.
select * from Products
where UnitPrice>=18 and UnitPrice<=40

--Between komutu da kullanılabilir.
select * from Products
where UnitPrice BETWEEN 18 and 40

-- Insert Data Manipulation
insert into TestTable(name,surname,age)
values('kardel','test',18)

--Kayıt eklenmiş mi kontrol et
select * from TestTable

--spesifik bir kayıt çek
select * from TestTable
where id= 1 

--Update Data Manipulation
update TestTable
set age = 17
where id =1

--Güncelleme gerçekleştirdikten sonra kontrol et
select * from TestTable
where id= 1 

--Delete Data Manipulation 
delete from TestTable
where id =1 

-- Silme işlemin gerçekleştirdikten sonra kontrol et
select * from TestTable
where id= 2




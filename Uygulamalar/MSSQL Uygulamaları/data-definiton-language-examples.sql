--Data Definition Language Examples
--Create Table
-- id int IDENTITY(1,1) id sütunun tam sayı türünde ve 
--ve otomatik artan olarak tanımlanmasını sağlamış olursunuz.
create table TestTable(
	id int IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	surname nvarchar(50),
	age int
);


-- YeniSutun diye bir alan eklemek istiyorum. ( int tipinde ) 
ALTER TABLE TestTable
ADD NewColumn int default 0

-- -- YeniSutun diye bir alan eklemek istiyorum. ( NVARCHAR tipinde ) 

ALTER TABLE TestTable
ADD NewColumn_2 NVARCHAR(100)

-- TesTable tablosundaki tüm kayıtları silmek için
-- DDL sorgusunu kullanmam gerekir. O da Truncate metotudur. 
Truncate table TestTable

-- Eklenen kolonları silmek için 
-- DDL sorgusu olan Drop kullanılır. 
-- NewColumn_2 silindi.

ALTER TABLE TestTable
DROP COLUMN NewColumn_2

--NewColumn silinsin
ALTER TABLE TestTable
DROP COLUMN NewColumn

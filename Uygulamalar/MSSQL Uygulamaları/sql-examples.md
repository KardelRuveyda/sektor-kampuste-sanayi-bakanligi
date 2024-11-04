# Northwind Veritabanında INNER JOIN ve GROUP BY Kullanımı

Bu dosyada, Northwind veritabanını kullanarak örnekler gerçekleştirilmiştir.


## Senaryo 1 



```sql
SELECT 
    Categories.CategoryName,
    SUM(Order_Details.Quantity) AS TotalQuantitySold
FROM 
    Categories
INNER JOIN 
    Products ON Categories.CategoryID = Products.CategoryID
INNER JOIN 
    Order_Details ON Products.ProductID = Order_Details.ProductID
GROUP BY 
    Categories.CategoryName;

```

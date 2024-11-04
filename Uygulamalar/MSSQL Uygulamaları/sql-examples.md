# Northwind Veritabanında INNER JOIN ve GROUP BY Kullanımı

Bu dosyada, **Northwind** veritabanını kullanarak örnekler gerçekleştirilmiştir.


## Senaryo 1 

* Her bir ürünün kategori adını ve tedarikçi adını getiren bir sorgu oluşturun.
* Products tablosu **Categories** ve **Suppliers** tablolarıyla birleştirildi.
* Bu sorgu, her ürünün adı, kategori adı ve tedarikçi adını getirir.

```sql
SELECT 
    Products.ProductName,
    Categories.CategoryName,
    Suppliers.CompanyName AS SupplierName
FROM 
    Products
INNER JOIN 
    Categories ON Products.CategoryID = Categories.CategoryID
INNER JOIN 
    Suppliers ON Products.SupplierID = Suppliers.SupplierID;


```

## Senaryo 2

* Her müşterinin verdiği siparişleri ve bu siparişlerde yer alan ürünleri listeleyin.
* **Customers** tablosu **Orders** ile, **Orders** tablosu **Order_Details** ile ve **Order_Details** tablosu **Products** ile birleştirildi.
* Sorgu, müşteri adı, sipariş kimliği, siparişte yer alan ürün adı, miktarı ve birim fiyatını listeler.

```sql
SELECT 
    Customers.CustomerID,
    Customers.CompanyName AS CustomerName,
    Orders.OrderID,
    Products.ProductName,
    Order_Details.Quantity,
    Order_Details.UnitPrice
FROM 
    Customers
INNER JOIN 
    Orders ON Customers.CustomerID = Orders.CustomerID
INNER JOIN 
    Order_Details ON Orders.OrderID = Order_Details.OrderID
INNER JOIN 
    Products ON Order_Details.ProductID = Products.ProductID;

```

## Senaryo 3: Çalışanların Sattığı Ürünler ve Sipariş Bilgileri

* Her çalışanın sattığı ürünleri, sipariş tarihini ve ürünlerin toplam tutarını listeleyin.
* **Employees**, **Orders**, **Order_Details** ve **Products** tabloları birbirine bağlandı.
* Sorgu, çalışan adı, sipariş kimliği, sipariş tarihi, ürün adı, miktarı, birim fiyatı ve toplam tutarı listeler.



```sql
SELECT 
    Employees.EmployeeID,
    Employees.FirstName + ' ' + Employees.LastName AS EmployeeName,
    Orders.OrderID,
    Orders.OrderDate,
    Products.ProductName,
    Order_Details.Quantity,
    Order_Details.UnitPrice,
    (Order_Details.Quantity * Order_Details.UnitPrice) AS TotalAmount
FROM 
    Employees
INNER JOIN 
    Orders ON Employees.EmployeeID = Orders.EmployeeID
INNER JOIN 
    Order_Details ON Orders.OrderID = Order_Details.OrderID
INNER JOIN 
    Products ON Order_Details.ProductID = Products.ProductID;

```

## Senaryo 4: En Çok Satılan Ürünler

* Her ürün için toplam satış miktarını hesaplayın ve en çok satılan ürünleri azalan sırayla listeleyin.
* **Products** ve **Order_Details** tabloları birleştirildi.
* Her ürün için toplam satış miktarı hesaplandı ve en çok satılandan en aza doğru sıralandı.


```sql
SELECT 
    Products.ProductID,
    Products.ProductName,
    SUM(Order_Details.Quantity) AS TotalQuantitySold
FROM 
    Products
INNER JOIN 
    Order_Details ON Products.ProductID = Order_Details.ProductID
GROUP BY 
    Products.ProductID, Products.ProductName
ORDER BY 
    TotalQuantitySold DESC;
```

## Senaryo 5: Müşterilerin Tedarikçilerden Aldığı Ürünlerin Detayları

* Müşterilerin tedarikçilerden aldığı ürünleri, sipariş tarihi, tedarikçi adı ve ürün fiyatıyla birlikte listeleyin.
* **Customers**, **Orders**, **Order_Details**, **Products** ve **Suppliers** tabloları birbirine bağlandı.
* Sorgu, müşterilerin sipariş verdiği ürünleri, tedarikçi adı, sipariş tarihi, miktar ve birim fiyat bilgisiyle birlikte listeleyerek detay sağlar.


```sql
SELECT 
    Customers.CustomerID,
    Customers.CompanyName AS CustomerName,
    Suppliers.CompanyName AS SupplierName,
    Products.ProductName,
    Orders.OrderDate,
    Order_Details.Quantity,
    Order_Details.UnitPrice
FROM 
    Customers
INNER JOIN 
    Orders ON Customers.CustomerID = Orders.CustomerID
INNER JOIN 
    Order_Details ON Orders.OrderID = Order_Details.OrderID
INNER JOIN 
    Products ON Order_Details.ProductID = Products.ProductID
INNER JOIN 
    Suppliers ON Products.SupplierID = Suppliers.SupplierID;
```

## Senaryo 6 Kategorilere Göre Toplam Satış Miktarını Hesaplama

* Her bir kategoriye ait toplam satış miktarını (ürün sayısını) bulmak için GROUP BY ve SUM ifadelerini kullanabilirsiniz.
* **Categories** ve **Products** tabloları, ardından **Order_Details** tablosu ile **INNER JOIN** kullanılarak bağlandı
* GROUP BY ifadesi ile her kategoriye göre gruplama yapılır ve SUM(Order_Details.Quantity) ile her kategorideki toplam satış miktarı hesaplanır.




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


## ÖDEV: Müşterilerin Toplam Sipariş Tutarlarını Hesaplama

Görev Tanımı: Northwind veritabanını kullanarak, her müşterinin verdiği siparişlerin toplam tutarını hesaplayan bir SQL sorgusu yazmanız beklenmektedir. Bu sorgu, müşteri bilgilerini ve sipariş detaylarını birleştirerek, her müşterinin toplam harcamasını gösterecektir.

**Gereksinimler:**

* Customers: Müşteri bilgilerini içeren tablo.
* Orders: Sipariş bilgilerini içeren tablo.
* Order_Details: Sipariş detaylarını içeren tablo.

Bu tabloları kullanarak, müşterilerin sipariş bilgilerini birleştirin.

**Gruplama:**

* Her müşterinin toplam sipariş tutarını hesaplamak için GROUP BY ifadesini kullanarak gruplama yapın.
* Müşteri kimliği ve adı gibi bilgileri de gösterin.

**Toplama:**

* Her müşterinin siparişlerinin toplam tutarını hesaplamak için SUM fonksiyonunu kullanın.

**Çıktı Formatı:**

* Sorgunun çıktısı, her müşterinin kimliğini, adını (şirket adı olarak) ve toplam sipariş tutarını içermelidir.

**Beklentiler:**

* Yazdığınız SQL sorgusunun doğru çalıştığını ve istenen sonuçları verdiğini göstermek için sorgu çıktısını bir ekran görüntüsü ile belgeleyin.
* Sorgunuzun her bir bölümünü (tablo bağlantıları, gruplama ve toplama) açıklayan kısa bir açıklama ekleyin.

**Ödevin Teslimi:** 

* Sorgu kodunu ve çıktısını içeren bir dosya (Word veya PDF formatında) oluşturun.
* Dosyanızda, sorgu ile birlikte her bölümün açıklamasını ve ekran görüntüsünü eklemeyi unutmayın.
* ruveydakardelcetin@gmail.com 'a atabilirsiniz.
* **Teslim Tarihi**: **18.11.2024 00.00**

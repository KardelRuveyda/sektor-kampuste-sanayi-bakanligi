#  Modern Web Geliştirme 5

## MSSQL Uygulamaları

-> [https://www.w3schools.com/ ](https://www.w3schools.com/sql/default.asp) ( SQL ile ilgili alıştırmalara bu siteden de bakabilirsiniz.) 

### SQL Nedir?

Structured Query Language kelimelerinin kısaltılmışı olan SQL bir veri tabanı uygulamasıdır. Türkçe karşılığı Yapılandırılmış Sorgu Dili anlamına gelmektedir.
Birçok veriyi farklı boyutlarda ve farklı fonksiyonlarda barındıran veri tabanlarını yönetim sistemine verilen isimdir. SQL ile bu verilerin yönetimi, silinmesi, aktif edilmesi ve üzerinde çalışılması mümkündür.Bir programlama dili olmamasına karşın çoğu kişi tarafından bir dil olarak algılanır ve bilinir. Oysa tam anlamıyla veri tabanında kullanılabilecek bir alt dildir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/de8f5bae-02b9-43cf-a76d-f97ac5eccd3e)

### SQL Sistemleri

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/2509b971-821d-426a-848f-958565570d4a)

### MSSQL Nedir?

Sunduğu birçok özellikler sebebi ile, diğer veri tabanlarından daha iyidir. MYSQL gibi ücretsiz değildir. Sunduğu birçok özellikler sebebi ile diğer veri tabanlarına oranla daha avantajlıdır. MSSQL Access’e oranla veri tabanı konularında daha yeterli ve donanımlıdır. Bu yüzden çoğu kullanıcı tarafından MSSQL tercih edilmektedir.Access de veri tabanı kullanıcılar tarafından oluşturulur ve bu veri tabanları mobil olarak taşınabilir. Ancak MSSQL ‘de durum farklıdır. Veri tabanları server üzerine oluşturulur ve herkes bu server üzerine bağlanabilir. Veri tabanı tek bir noktadan kontrolü sağladığı için hem çok hızlı hem de çok güvenlidir. MSSQL kullanımı için SQL Server 2008, SQL Server 2008 R2, SQL Server 2014 gibi sürümler kullanılabilir.

### Microsoft SQL Server’ın İncelenmesi!

Microsoft SQL Server sürümleri; yazılımı, yazılımı geliştiren programcıyı, yazılımın geliştirildiği şirketi ve yazılımı kullanacak müşterileri ilgilendirmektedir. Bu nedenle doğru bir SQL Sürümünü kullanmak platformu kullanacak olan herkese fayda sağlar. Microsoft, hemen hemen her yıl SQL Server’ı geliştirerek yeni bir sürümünü kullanıcılara sunmaktadır. Ancak SQL Server’ın bütün sürümlerinin özellikleri genel olarak aynı niteliklere sahiptir. Kullanıcılar herhangi bir sürümü seçerek veri tabanı işlemlerini kolaylıkla halledebilir.

### Microsoft SQL Server 2019(veya hangi sürümü isterseniz) Kurulum

- Microsoft SQL Server kurulumunda dikkat edilmesi gereken hususlarda en önemlisi doğru işletim sistemini seçmektir. Günümüze yakın işletim sistemlerini seçmek kullanıcıya hız kazandırabilir, ancak alt sürümlerle de rahatlıkla veri tabanı uygulamaları yapılabilmektedir.
- Microsoft SQL Server kurulumu için .NET Framework 3.4,4.0 ve 4.5 sürümlerinden herhangi biri yüklü olmalıdır.
- Microsoft SQL sürümleri için gerekli setup bileşenleri Microsoft sitesinden kolaylıkla indirilebilir.
- Bilgisayarın özelliğine göre 32 bit mi, 64 bit mi indirilmesi gerektiği hakkında gözlem yapılır.
- Microsoft SQL Server sürümleri Setup’u; gerekli şartlara uygun bir şekilde, Microsoft’un resmî sitesinden indirildikten sonra “Setup” dosyası yönetici olarak çalıştırılır ve daha sonrasında kuruluma geçilir.

### Sürümlere nerden ulaşabilirim?

- https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15 linkinden ulaşabilirsiniz.

### Hazır Veri Tabanları İle Çalışma

NorthWind veya başka hazır veri tabanı kullanarak SQL çalışmalarımızı daha efektif hale getirip ; sorgu pekiştirmesi gerçekleştirme imkanı bulabiliriz. Northwind veri tabanı için aşağıdaki linkten kurulum sağlayabilirsiniz.

![Picture10](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/72779678-e1e7-4457-a22c-ff0fc703c4f2)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/3714ce78-893d-4251-9600-6b35aee6a87c)


### Temel SQL Komutları Giriş

Structure Query Language namıdeğer SQL bir sorgulama dilidir. Bu sorgulama dilinin sorguladığı zat ise veritabanıdır. Yani o zaman SQL ‘e veritabanını sorgulama dili de diyebiliriz.
SQL de aslında bir programlama dili gibidir. Bir programlama dili kadar kapsamlı olmasa da onun da kendine göre SYNTAX’ları vardır. Bir geliştirici gözü ile de bakıldığında; aslında bir projenin kilit noktalarından birisi de veritabanıdır. Bunu unutmamak gerekir. Veritabanının doğru tasarlanması hatta oluşturulan tablolardaki veri tiplerinin bile seçimi; ileride yapılan geliştirmelerde geliştiricinin karşısına avantaj olarak da çıkabilir; dezavantaj da..

## Veri Tipleri

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/688260aa-caed-4c1e-bf46-b714f4201027)



## Yerleşik Fonksiyonlar

**SQL Çoklu Satır (Aggregate) Fonksiyonları**

Bu fonksiyonlar bir sütunda yer alan birden fazla değerler üzerinde yaptığı hesaplamalar sonrası tek bir değer geri verir.

- **AVG() :** Sayısal değer içeren bir tablo sütunundaki değerlerin ortalamasını verir.
- **COUNT() :** Verilen kriterlere uyan tablo satır sayısını verir.
- **FIRST() :** Tabloda belirtilen sütundaki ilk değeri verir.
- **LAST() :** Tabloda belirtilen sütundaki son değeri verir.
- **MAX() :** Tabloda belirtilen sütundaki en büyük değeri verir.
- **MIN() :** Tabloda belirtilen sütundaki en küçük değeri verir.
- **SUM() :** Sayısal değer içeren bir tablo sütunundaki değerlerin toplamını verir.


**SQL Sayısal (Scalar) Fonksiyonları**


Bu fonksiyonlar bir sütunda yer alan tek bir değere işlem yapar ve tek bir değer geri verir.

- **LCASE() :** Bir alan değerini küçük harfe çevirir.
- **LEN() :** Bir metin alanının uzunluğunu verir.
- **MID() :** Bir metin alanındaki karakterlerin bir kısmını elde etmek kullanılır.
- **NOW() :** Bilgisayarın tarih ve saat değerlerini verir.
- **FORMAT() :** Bir veri alanının ne şekilde gösterileceğini belirler.
- **ROUND() :** Sayısal bir veri alanının değerini bir tamsayıya yuvarlar.
- **CEILING() :** Aşağı yuvarla (Herhangi bir ondalık için sayının kendinden büyük, en küçük tam sayıyı verir)
- **FLOOR :** Aşağı yuvarla (Herhangi bir ondalık için sayının kendinden küçük, en büyük tam sayıyı verir)
- **UCASE() :** Bir alan değerini büyük harfe çevirir.


## SQL komutlarına bakıldığında ; iki şekilde değerlendirillir!**
- Data'yı çeken,
- Data'yı değiştiren

## DDL & DML Farkı

DDL ifadeleri genellikle bir veritabanı yöneticisi veya veritabanı yapısını değiştirmek için uygun ayrıcalıklara ve izinlere sahip bir geliştirici tarafından yürütülür. DML, bir veritabanındaki verileri değiştirmek için kullanılır. DML ifadeleri, bir veritabanına veri eklemek, güncellemek ve silmek için kullanılır.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/f2a38a26-e0e0-4641-a24e-ee52ce67a74e)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/e5b519af-ba17-446b-94bb-1bc9b0c379e0)














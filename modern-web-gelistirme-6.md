#  Modern Web Geliştirme 6

## C# Temelleri

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/54f514e2-374e-431e-bb51-dfdcfef71133)


### C# Giriş

- C# (C-Sharp), Microsoft tarafından geliştirilen ve .NET Framework üzerinde çalışan bir programlama dilidir.
- C# web uygulamaları, masaüstü uygulamaları, mobil uygulamalar, oyunlar ve çok daha fazlasını geliştirmek için kullanılır.
- C# "C-Sharp" olarak telaffuz edilir.
- Microsoft tarafından oluşturulan ve .NET Framework üzerinde çalışan nesne yönelimli bir programlama dilidir.
- C#'ın kökleri C ailesine dayanır ve dil C++ ve Java gibi diğer popüler dillere yakındır.
- İlk sürüm 2002 yılında yayınlandı. En son sürüm olan C# 11, Kasım 2022'de piyasaya sürüldü.
- Mobil uygulamalar,Masaüstü uygulamaları,Web uygulamaları,Web hizmetleri,Web siteleri,Oyunlar,VR,Veritabanı uygulamaları gibi alanlarda aktif kullanılır.

### Neden C# Kullanmalı?
- Dünyanın en popüler programlama dillerinden biridir
- Öğrenmesi kolay ve kullanımı basit
- Büyük bir topluluk desteğine sahip
- C#, programlara net bir yapı kazandıran ve kodun yeniden kullanılmasına olanak tanıyarak geliştirme maliyetlerini düşüren nesne yönelimli bir dildir
- C#, C, C++ ve Java'ya yakın olduğu için programcıların C#'a geçişini veya tam tersini kolaylaştırır

### C# IDE
- C# ile çalışmaya başlamanın en kolay yolu bir IDE kullanmaktır.
- Kodu düzenlemek ve derlemek için bir IDE (Entegre Geliştirme Ortamı) kullanılır.
- https://visualstudio.microsoft.com/vs/community/ adresinden ücretsiz olarak indirebilirsiniz.
- C# ile yazılan uygulamalar .NET Framework'ü kullanır, bu nedenle program, çerçeve ve dil Microsoft tarafından oluşturulduğundan Visual Studio'yu kullanmak mantıklıdır.

### C# Syntax

"Hello World" yazdırmak için aşağıdaki kod kullanılır:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/4cba3bbe-a22f-4523-bd04-17764dc072ea)


- Satır 1: using System, System isim alanındaki sınıfları kullanabileceğimiz anlamına gelir.
- Satır 2: Boş bir satır. C# beyaz boşluğu yok sayar. Ancak, birden fazla satır kodu daha okunabilir hale getirir.
- Satır 3: namespace kodunuzu düzenlemek için kullanılır ve sınıflar ve diğer namespace'ler için bir konteynerdir.
- Satır 4: Küme parantezleri {} bir kod bloğunun başlangıcını ve sonunu işaret eder.
- Satır 5: sınıf, programınıza işlevsellik kazandıran veri ve yöntemler için bir kapsayıcıdır. C#'ta çalışan her kod satırı bir sınıfın içinde olmalıdır. Örneğimizde, sınıfa Program adını verdik.
- Satır 7: Bir C# programında her zaman görünen bir başka şey de Main yöntemidir. Küme parantezleri {} içindeki herhangi bir kod çalıştırılacaktır. Main'den önceki ve sonraki anahtar kelimeleri anlamak zorunda değilsiniz. 
- Satır 9: Console, System isim alanının bir sınıfıdır ve metin çıktısı almak/yazdırmak için kullanılan bir WriteLine() metoduna sahiptir. Örneğimizde "Merhaba Dünya!" çıktısı verecektir.
- Eğer using System satırını atlarsanız, metni yazdırmak/çıkarmak için **System.Console.WriteLine()** yazmanız gerekecektir.
- **Not:** Her C# deyimi noktalı virgül ; ile biter.
- **Not:** C# büyük/küçük harf duyarlıdır: "MyClass" ve "myclass" farklı anlamlara sahiptir.

### C# Yorum Satırları

Yorumlar, C# kodunu açıklamak ve daha okunabilir hale getirmek için kullanılabilir. Alternatif kodu test ederken yürütmeyi önlemek için de kullanılabilir.

#### Tek Satırlı Yorumlar
- Tek satırlı yorumlar iki ileri eğik çizgi (//) ile başlar.
- // ile satır sonu arasındaki herhangi bir metin C# tarafından yok sayılır (yürütülmez).
- Bu örnekte, bir kod satırından önce tek satırlık bir açıklama kullanılmaktadır:

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b8075647-dabf-4e27-9373-2e691d05a6ef)

#### C# Çok Satırlı Yorumlar

- Çok satırlı yorumlar /* ile başlar ve */ ile biter.
- ** ve */ arasındaki herhangi bir metin C# tarafından yok sayılacaktır.
- Bu örnekte kodu açıklamak için çok satırlı bir yorum (yorum bloğu) kullanılmıştır:


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/1b41b18b-127d-49d3-b126-f347aad39b25)

### C# Değişkenleri

Değişkenler, veri değerlerini saklamak için kullanılan kaplardır. C#'ta farklı değişken türleri vardır (farklı anahtar kelimelerle tanımlanır), örneğin:

- **int** - 123 veya -123 gibi ondalıksız tam sayıları (tam sayılar) saklar
- **double** - 19.99 veya -19.99 gibi ondalıklı kayan nokta sayılarını saklar
- **char** - 'a' veya 'B' gibi tek karakterleri saklar. Char değerleri tek tırnak işaretiyle çevrelenir
- **string** - "Merhaba Dünya" gibi metinleri saklar. String değerleri çift tırnak ile çevrelenir
- **bool** - iki durumlu değerleri saklar: doğru veya yanlış

#### Değişken Bildirme (Oluşturma)

- Bir değişken oluşturmak için türünü belirtmeli ve ona bir değer atamalısınız.
- Burada type bir C# türüdür (int veya string gibi) ve variableName değişkenin adıdır (x veya name gibi). Eşittir işareti değişkene değer atamak için kullanılır.


**string türünde name adında bir değişken oluşturun ve ona "Kardel" değerini atama.**
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d5b22f08-b933-4987-8429-430c632565d5)

**int türünde myNum adında bir değişken oluşturun ve ona 61 değerini atama.**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/c751aff6-32c0-41b8-a569-8b8c36ec4d97)

**Ayrıca bir değişkeni değer atamadan da bildirebilir ve değeri daha sonra atayabilirsiniz**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/f54dedc7-3060-45cf-a29c-0f01b8823719)

**Mevcut bir değişkene yeni bir değer atarsanız, bu değerin önceki değerin üzerine yazılacağını unutmayın.**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/39a168f3-b974-4e80-954a-637bc1f94e80)

#### Diğer Tipler

Diğer türlerdeki değişkenlerin nasıl bildirileceğine dair bir gösterim aşağıdaki gibidir!


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/5c7303ad-769e-4243-b391-7ba5cc308e77)

#### Constants

Başkalarının (veya kendinizin) mevcut değerlerin üzerine yazmasını istemiyorsanız, değişken türünün önüne const anahtar sözcüğünü ekleyebilirsiniz.Bu, değişkeni değiştirilemez ve salt okunur anlamına gelen "sabit" olarak bildirecektir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/98b12ebf-e73a-4687-a72c-a144fe0d00e2)

**const** anahtar sözcüğü, bir değişkenin her zaman aynı değeri saklamasını istediğinizde kullanışlıdır, böylece başkaları (veya kendiniz) kodunuzu karıştırmaz. Genellikle sabit olarak anılan bir örnek PI (3.14159...) değeridir.

**Not:** Değer atamadan sabit bir değişken bildiremezsiniz. Bunu yaparsanız bir hata oluşur: Bir const alanı için bir değer sağlanması gerekir.

#### Ekran Değişkenleri

- WriteLine() yöntemi genellikle değişken değerlerini konsol penceresinde görüntülemek için kullanılır.
- Hem metni hem de bir değişkeni birleştirmek için + karakterini kullanmak gerekir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ae9a560e-6874-4d7e-8a60-08dbde1026f0)

**Bir değişkeni başka bir değişkene eklemek için + karakterini de kullanabilirsiniz:**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d530d895-f385-4273-96b1-dd0ffb5c05d5)

**Sayısal değerler için + karakteri matematiksel bir operatör olarak çalışır (burada int (tamsayı) değişkenleri kullandığımıza dikkat edin):**

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b41366d9-4e09-4617-9fed-466b807e41b8)

**_Yukarıdaki örnekten şunu bekleyebilirsiniz:_**
- x, 5 değerini saklar
- y, 6 değerini saklar
Ardından, 5 olan x + y değerini görüntülemek için WriteLine() yöntemini kullanırız.











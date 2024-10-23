## Modern Web Geliştirme 4

## Veri Tabanı Temelleri ( Veri tabanı yönetim sistemleri)

### Neden Veri Tabanı?

Günümüzün rekabetçi iş dünyasında, kurumların başarısı ve sürdürülebilirliği, aldıkları stratejik kararların doğruluğuna bağlıdır. Şirketlerin yanlış kararları düzeltme lüksü olmadığı gibi, bu durum faaliyetlerinin durmasına bile yol açabilir. Bu nedenle, doğru ve güvenilir kararlar almak için işletmeler, işlemlerini kaydedip analiz edebilecekleri veri tabanı sistemlerine yönelmişlerdir.

Başlangıçta, veri tabanları zaman kazandırmak, raporlamaları kolaylaştırmak ve verilere hızlı erişim sağlamak amacıyla kullanılıyordu. Ancak, rekabetin artmasıyla birlikte veri tabanlarının işlevi genişledi; artık veriler analiz edilip, sonuçlar çıkarılarak karar alma süreçlerine katkıda bulunulmaktadır. Bu durum, iş dünyasının karmaşıklığını veri tabanı teknolojileriyle daha basit ve yönetilebilir hale getirmiştir.

### Veri Nedir?

"Veri" ve "bilgi" terimleri sık sık birbirinin yerine kullanılsa da aslında farklı anlamlar taşırlar. Veri, olaylar, yerler, kişiler veya nesneler hakkında elde edilen ham gerçeklerdir. Bu veriler, bilgisayar ortamında işlenmemiş ve anlamlandırılmamış halde bulunur. Veri, genellikle manyetik diskler (örneğin, sabit disk) veya yarı iletken belleklerde (örneğin, RAM) saklanır.

Bilgi ise işlenmiş, anlamlandırılmış ve kullanıcıya fayda sağlayacak hale getirilmiş veridir. Örneğin, bir şirketin çalışanlarının listesi ham bir veriyken, belirli bir departmandaki çalışanların raporlanması bilgiye dönüşmüş halidir.

### Veri tabanı Kavramı

Veri tabanı, belirli kategorilere göre düzenlenmiş verilerin saklandığı bir yapıdır. Bu yapı, veriye hızlı ve güvenli bir şekilde erişim sağlamayı, verinin kim tarafından nasıl kullanılacağını yönetmeyi amaçlar. Ayrıca veri tabanları, verilerin düzenli ve verimli bir şekilde saklanmasını sağlar. Büyük Veri (Big Data) kavramı ise veriyi analiz etmek ve anlamlandırmak üzerine odaklanır. Bu noktada, veri tabanlarının yapıları ve işlevleri genişlemekte, karmaşık veriler anlamlı hale getirilmektedir.

Veri tabanları, banka, hastane, üniversite gibi büyük kuruluşlarda önemli iş süreçlerinin yönetilmesi ve raporlanması için kullanılır. Örneğin, bir banka müşterilerinin hesap bilgileri, bir hastane ise hasta kayıtlarını veri tabanında saklar. Veri tabanları, verilerin merkezi ve tutarlı bir şekilde yönetilmesini sağlar.

###  Neden veri tabanı kullanılır?

Bilgiye hızlı, güvenli ve düzenli bir şekilde erişebilmek için çeşitli veri yönetim yaklaşımları geliştirilmiştir. Geleneksel dosya tabanlı sistemler, her bir veri setini ayrı dosyalarda tutarken, bu sistemlerdeki veriye eşzamanlı erişim ve değişiklik yapma zorlukları nedeniyle yetersiz kalmışlardır. Bu sorunlar, veri tabanı yönetim sistemlerinin geliştirilmesine yol açmıştır. Veri tabanları, verilerin merkezi olarak yönetilmesini, veri tekrarının azaltılmasını ve verilerin daha güvenli bir şekilde saklanmasını sağlar.

### Veri tabanı yaklaşımının avantajları

- Veri paylaşımının gerçekleşmesi,
- Ortak verilerin tekrarlanmasının önlenmesi,
- Verilerin merkezi denetim ve tutarlılığının gözlem altında tutulması,
- Güvenlik ve gizliliğin kullanıcıların istediği düzeyde tutulması,
- Verilerin kolay ve anlaşılır yapıda olmasını sağlayabilmesi
- Yazılım geliştirmeye sağladığı katkı ile, tasarım ve geliştirmenin kolaylaşması
- Yedekleme, onarma, yeniden başlatma gibi işletim sorunlarına çözüm getirebilmektedir [2]. Özellikle yedekleme özelliğini sağlaması ile birlikte veri tabanları; birçok kullanıcının sorunlarına çözüm olmuştur. Çünkü çoğu kullanıcı verilerini saklamakta başarılı olamadığı için, bazı durumlarda verilerini kaybedebilir. Ancak veri tabanlarının yedekleme özelliği var ise, kolayca kaybedilen verilere ulaşılabilir.

### Veri tabanı yönetim sistemi nedir?

Veri tabanlarının oluşturulması, yönetimi, güncellenmesi ve verilerin işlenmesi için kullanılan sistemlere Veri Tabanı Yönetim Sistemi (DBMS) denir. Bu sistemler, verilerin fiziksel olarak nasıl depolanacağını yönetirken, kullanıcılara standart bir SQL (Structured Query Language) arayüzü sunarak veriye erişim ve veri işleme süreçlerini kolaylaştırır.

DBMS, kullanıcıların veri yapısı ve depolama gibi detaylarla uğraşmasına gerek bırakmaz, verilerin güvenli ve verimli bir şekilde saklanmasını sağlar. Ayrıca, sistemdeki kullanıcılar, roller ve erişim yetkileri, veri tabanı yöneticisi tarafından denetim altında tutulur.

### Veri tabanı yönetim sistemi amacı nedir?

Veri tabanı yönetim sisteminin amacı, yazılım geliştirilmesinde kullanılan veri tabanının yönetimini, performans ölçümlerini ve güvenliğini sağlamaktır. Veri tabanı yönetim sistemleri fiziksel hafızayı ve veri tiplerini kullanıcılar adına şekillendirip denetledikten sonra kullanıcılara standart bir SQL ara yüzü sağlayarak; onların veri yapısı, fiziksel hafıza gibi sorunlarınla ilgilenmek yerine veri giriş-çıkışı olanağını sağlayan yazılımlar olarak bilinmektedirler . Her yönetim sisteminde kullanıcılar, roller ve gruplar vardır ve bu verileri tutmak üzere birçok türde nesne ve bu nesnelere erişim onayı veri tabanı yöneticisi tarafından denetim altında tutulmaktadır [2]. Veri tabanı yöneticisi kontrolü altında verilen haklar arttırılabilir, kısıtlanabilir veya silinebilir.

### Veri tabanı yönetim sisteminin sağladığı yararlar

- Programcı kullandığı verilerin yapısını, organizasyonunu ve yönetimini kendisi hazırlamak zorunda kalmaz çünkü veri tabanı bunları kendiliğinden koordine eder ve yönetir.
- Verilerin yanlış kullanım veya kasıtlı bozulması sonucunda bozulmasını engellemek ve önlemek,
- Bir tabloda işlem yapıldığında diğer tabloda da buna bağlı olarak işlemlerin yapılmasını sağlar. Çünkü veri tabanı yönetim sistemi, bu tabloların birbirleriyle ilişkilendirilmesini sağladığı için, herhangi bir tabloda yapılan değişiklik diğer tabloyu etkileyebilir.
Veri tabanı yönetim sistemini kullanmayan kullanıcılar veriye erişim sınırı ile karşı karşıya gelebilir ve birden çok veriye aynı anda erişemezler. Bu sistemi kullananlar kullanıcılar ise verinin tutarlılığını ve bütünlüğünü bozmadan ayanı veri tabanlarına saniyede yüzlerce, binlerce erişim yapabilir.
Veri tek bir merkezde tutulabilir, böylece verinin değişik bilgisayarlarda tekrar tekrar saklanılmasına gerek duyulmaz.

### Veri yabanı yönetim sistemleri

- Access (Microsoft)
- Adabas D (Software AG)
- Cloudscape (Informix)
- Advantage Database Server (Extended Systems)
- Data com (Computer Associates)
- DB2 (IBM)
- Interbase (Inprise)
- MySQL (Freeware)
- Oracle 8I (Oracle)
- PostgreSQL (Freeware)
- Rdb (Oracle)
- Red Brick (Informix)
- SQL Server (Microsoft)


### Veri tabanı modellemesi

- Herhangi bir veri tabanına kayıt edilmiş veya kaydedilecek verilerin; birbirleri ile arasındaki ilişkilerin verilere nasıl erişeceğini tasarlayan yapıya veri tabanı modellemesi denmektedir. Başarılı bir veri tabanı uygulaması için belirli aşamalardan geçilmesi gerekir. Bu aşamalardan en önemlisi kavramsal modellemedir. 
Dünyada üretilen bütün verileri bir veri tabanına kaydetmek mümkün değildir. Bu verilerin kaydı gerçekleşse bile, büyük çoğunluğu işe yaramayacaktır. Bu yüzden veriler içerisinden işe yarar olanları seçilmeli ve bunlar üzerinde kayıtlandırmalar yapılmalıdır.
- Örneğin, “Bir üniversiteye ait veri tabanında öğrencilerin şahsi arabalarının markası ya da kullandıkları cep telefonu markalarının yer alması üniversitenin işine yarayacak mı? ”gibi bir sorunun cevabı aşikardır. Tabiki de bir üniversite veri tabanında böyle bir bilgiye gerek yoktur. Eğer veri tabanını hazırlarken işletmeler kendilerine bu tarz sorular soruyorlarsa, veri tabanının tasarlanmaya başlanarak modelleme yapıldığı anlaşılabilir.
- Veri tabanı hazırlanırken öncelikle veri tabanında hangi verilerin tutulacağı belirlenmelidir. Veri tabanı tasarımında hazırlama aşamasında kullanılan en yaygın yöntem, varlık-ilişki diyagramlarıdır. Örneğin, bir tekstil fabrikası veri tabanını düşündüğümüzde bir çalışanın birden fazla departmanda çalışıp çalışamayacağını belirleyen verilere “yapısal” veriler denir. Yapısal verilerde varlıklar arasındaki ilişkiler ve özellikler (alanlar ve tablolar) önceden belirlenmiştir. Bunların dışında veri tabanına girilemez veya saklanamaz. Son yıllarda yaygınlaşan bilgisayar ve internet teknolojileri ile birlikte veriler doğrudan elektronik ortamlarda bilgisayarlar üzerinde üretilmeye başlandı. Örneğin, internet üzerinden yatırılan kredi kartı borçları veya elektronik alışveriş gibi faaliyetlerde internet üzerinde veri tabanları oluşturulur. Bu veri tabanları “yapısal olmayan” veriler olarak adlandırılır
- Modelleme için güzel bir web sitesi -> https://dbdiagram.io/

### Veri tabanı Türleri

Veri tabanı Türleri üç kısımda incelenmektedir. Bu veri tabanları Hiyerarşik Veri tabanları, İlişkisel Veri tabanları ve Nesnesel Veri Tabanları’ dır.

**Hiyerarşik veri tabanları**

Hiyerarşik Veri Tabanları, veriyi işlemek ve depolamak için geliştirilmiş olan ilk veri tabanı modeli olarak bilinmektedir. Bu modelde, kök düğüm yani root node haricinde kalan bütün düğümler, kendisinden bir üst düğüme bağlanmak zorundadır. Temelinde Binary Search metodu bulunmaktadır. Hiyerarşik veri tabanları, dünya genelinde yaygın bir kullanıma kavuşmamıştır. Anlaşılacağı üzere hiyerarşik veri tabanları, günlük hayatta yaygın olarak kullanılmamaktadır.


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/bac7f702-e045-4e29-b768-044b62e1af0e)

**İlişkisel Veri Tabanları**

Günümüzde bilgisayar ortamlarında tutulan ilişkisel veri tabanlarının mantığı aslında geçmişte kullanılan kayıt defterlerinin mantığına benzemektedir. Eskiden elektronik ortamda verilerin tutulması pek mümkün olmadığı için; çoğu kurum ve kuruluş, kayıtlarını kayıt defterlerinde tutmuş ve bunları arşivlerde saklamışlardır. İlişkisel veri tabanları, verilerin operasyonel olarak tutulduğu bir model biçimidir. Ayrıca bu model, hız ve kolaylık açısından avantaj kazandırmaktadır. İlişkisel veri tabanları ile diyagramlar oluşturulup, aralarındaki ilişkiler daha net bir şekilde görülebilir. Bu diyagramlar SQL Server ortamında oluşturulabileceği gibi; Microsoft Access, Microsoft Visio gibi platformlarda da oluşturulabilir.

**Nesnesel Veri Tabanları**

İlişkisel veri tabanları bünyesinde birçok mantıksal nesne bulundurmaktadır. Bu ilişkisel veri tabanlarında en önemlileri Indeks (Index) ve Tablo (Table) olarak bilinmektedir. Nesnesel veri tabanlarını daha somut bir şekilde açıklamak gerekirse, veri tabanı içerisinde tutulan her bir tablonun verileri birbirinden farklıdır. Bu veriler arasındaki ilişkilerin kurulduğu bir başka tablo daha olabilir. Örneğin, müşteri tablosunda bulunan “müsteri_adi” kolonu, şehir tablosunda da olabilir ve bu iki tablo arasında bir ilişki kurulabilir. Ve buna göre veri tabanlarında “Primary Key (Birincil Anahtar)” ve “Foreing Key”ler oluşturulur. Veri tabanlarının içerisinde nesneleri tutan şemalar ve sistem tabloları bulunmaktadır. Bunların hepsine META-DATA denilir.




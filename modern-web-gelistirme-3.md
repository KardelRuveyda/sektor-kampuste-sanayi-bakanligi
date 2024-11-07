 
#  Modern Web Geliştirme 3

## Git Temelleri

### Versiyon Kontrol Sistemi

Version Control System bir döküman (yazılım projesi, ofis belgesi…) üzerinde yaptığımız degişiklikleri adım adım kaydeden ve isterseniz bunu internet üzerinde depoda (respository) saklamamızı ve yönetmemizi sağlayan bir sistemdir. Git, SVN, BitKeeper, Mercurial sürüm kontrol sistemlerine örnek olarak gösterilir.

### Git

Git açık kaynak kodlu bir versiyon sürüm kontrol sistemidir

### Neden git ?

**_Koyuyla belirttiklerime dikkat! :)_**

- Geliştirme süreçlerini izlemek

- **Projede yapılan değişikliklerin nerede ve ne zaman yapıldığı izlenmek**

- **Yanlış veya hatalı işlem yapıldığında daha önceki düzgün çalışılan versiyona dönmek istenebilir.**

- **Projelerde birden fazla kişi çalıştığını düşünürsek, gelişimin hızlanmasını sağlar.**
- Projede geliştirme yaparken, bulunduğumuz konuma nereden geldiğimizi anlamak için eski ve yeni kodumuz arasında karşılaştırma yapmamızı sağlar.
- Projede hatayla karşılaştığımız durumlarda eski kod kaydına dönmemizi sağlar.
- Açık kaynaklı projeler baz alınarak geliştirilecek yeni projelerde, süreci kolaylaştırmayı sağlar.

**Versiyon Kontrol Sistem Tipleri**

Versiyon kontrol sistemleri, yazılım geliştirme süreçlerinde yapılan değişikliklerin takip edilmesini sağlar ve projelerin yönetimini kolaylaştırır. Lokal versiyon kontrol sistemleri, tüm değişikliklerin yerel makinede saklanmasını sağlar ancak yalnızca tek bir kullanıcı tarafından kullanılabilir. Merkezi versiyon kontrol sistemleri (örneğin, CVS ve SVN), birden fazla geliştiricinin aynı proje üzerinde çalışmasına olanak tanır, ancak merkezi sunucunun arızalanması durumunda projedeki değişiklikler kaybolabilir. Dağıtık versiyon kontrol sistemleri (örneğin, Git), her geliştiricinin tüm proje geçmişine sahip olmasını sağlar, böylece merkezi sunucuya ihtiyaç duymadan bağımsız çalışabilirler ve yedeklilik ile güvenlik avantajı sunar. Dağıtık sistemler, büyük ve dağıtık ekiplerde yüksek verimlilik ve esneklik sağlar.

### Git Kurulum İşlemleri

Git kullanmaya başlamak için öncelikle Git'in resmi sitesinden Git'i indirip kurmanız gerekmektedir. Kurulum işlemi tamamlandıktan sonra, işletim sisteminize göre komut satırına (Mac kullanıcıları için Terminal, Windows kullanıcıları için CMD) erişmeniz gerekir. Ardından, terminal veya komut satırına git --version yazarak Git'in başarılı bir şekilde kurulduğundan ve hangi sürümünün yüklü olduğundan emin olabilirsiniz. Git'in kurulumunun ardından, proje yönetimi ve sürüm kontrolü için çeşitli komutlar kullanmaya başlayabilirsiniz.

Git'i kurduktan sonra, özellikle Windows kullanıcıları için Git Bash adlı bir terminal uygulaması da kurulur. Git Bash, Git komutlarını kullanmak için özel olarak tasarlanmış bir terminal ortamıdır. Git Bash, Unix benzeri komutları çalıştırmak için kullanılır ve bu sayede Linux veya MacOS kullanıcılarının alışık olduğu terminal deneyimini Windows ortamında sağlar. Git Bash, Git'in tüm özelliklerini kullanmanıza olanak tanırken, aynı zamanda dosya ve dizinlerle çalışma gibi işlemleri de kolaylaştırır.

Git Bash’i açtıktan sonra, normal bir terminalde olduğu gibi Git komutlarını yazabilir ve çalıştırabilirsiniz. Örneğin, git --version komutunu kullanarak kurulu olan Git sürümünü öğrenebilir, git init komutuyla bir projeyi başlatabilir veya git status komutuyla çalışma dizininizdeki durumu kontrol edebilirsiniz. Git Bash, aynı zamanda Windows üzerinde Linux ve macOS'tan alışık olduğunuz komut satırı deneyimini sağlar ve Git kullanımını daha verimli hale getirir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/554b6edd-0bad-4a81-9dab-6b2078ab7a08)


### Git Workflow

Genel Git iş akışı şu şekilde çalışır:
Çalışmaya başladığınızda, değişiklikleri Working Directory'de yaparsınız.
Değişiklikleri Staging Area'ya eklersiniz, bu değişiklikleri bir sonraki commit'e dahil etmek için hazırlama adımıdır.
Staging Area'daki değişiklikleri bir commit ile Local Repository'ye kaydedersiniz.
Değişiklikler Local Repository'ye kaydedildikten sonra, projeyi diğer geliştiricilerle paylaşmak veya uzak depoya yüklemek için Remote Repository'e push yapabilirsiniz.
Diğer geliştiricilerin yaptığı değişiklikleri almak ve projeyi güncellemek için Remote Repository'den Local Repository'ye pull yapabilirsiniz.
Bu genel Git iş akışı, projelerin yönetimini ve işbirliğini kolaylaştırmak için kullanılır. Her bir adımın nasıl yapılacağını ve Git komutlarını kullanarak bu iş akışını nasıl uygulayacağınızı öğrenmek, Git'i etkili bir şekilde kullanmanıza yardımcı olur.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ba79892d-4730-46e2-af8f-4cf4e0486881)

### Repository Kavramı

Üzerinde çalışılan projeyle ilgili tüm dosyaları değişiklikleri, dallandırmalar bu repo üzerinde bulundurulur. 
Projemizin zaman makinesi olarak düşünülebilir. İleri bir tarihe gidilebilir. Geri bir tarihe de gidilebilir. Repository Kavramı özetle bu anlama gelir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/3d544572-4280-40b5-b5b4-96ece9586063)

### Working Directory/Staging Area/Local Repository/Remote Repository

Git'in genel çalışma akışı, dört ana bölümden oluşur ve bu bölümler arasındaki geçişler, Git iş akışının temelini oluşturur. 

**Working Directory (Çalışma Dizini)**

Bu, projenizin fiziksel dosyalarının saklandığı ve üzerinde çalıştığınız yerdir.
Yaptığınız değişiklikler bu alanda bulunur.

**Staging Area (Hazırlık Alanı)**

Değişikliklerinizi Working Directory'den Staging Area'ya eklersiniz.
Staging Area, bir sonraki commit (sürüm) için hangi değişikliklerin dahil edileceğini belirlemenizi sağlar.
git add komutu ile değişiklikleri Staging Area'ya eklersiniz.

**Local Repository (Yerel Depo)**

Staging Area'daki değişiklikleri bir commit (sürüm) olarak kaydedebilirsiniz.
Local Repository, tüm projenin geçmiş sürümlerini ve tarihçesini içerir.
Değişiklikleri burada sakladıktan sonra geri alabilir ve geçmiş sürümlere dönebilirsiniz.


**Remote Repository (Uzak Depo)**

Projenin merkezi depo (repository) olarak düşünülür.
Diğer geliştiricilerle işbirliği yapmak için kullanılır.
Projeyi paylaşmak ve senkronize etmek için kullanılır.
Uzak Depo, GitHub, GitLab, Bitbucket gibi platformlarda veya başka bir sunucuda bulunabilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/48f68a9a-02b6-4aa9-a2e6-35a4a6804b0b)


### Commit Kavramı ve Commit Mesajı Önemi

Git için yapılan değişiklikleri kaydettiğimiz bir alandır. Yani yaptığımız değişiklikleri kaydediyoruz ve gönderiyoruz olarak düşünebiliriz. 

**Özgün ve Açıklayıcı Olun**


Commit mesajınız neyi değiştirdiğinizi ve neden değiştirdiğinizi açık bir şekilde ifade etmelidir.


**Özgün Başlık Kullanın**


Commit başlığınız kısa, özgün ve açıklayıcı olmalıdır.
Başlık, bu değişikliği açıklayan bir anahtar kelime veya ifade içermelidir.


**Ayrıntıları Alt Satıra Ekleyin**


Commit başlığından sonra, ayrıntıları açıklamak için ikinci bir satır ekleyin.
Ayrıntılar, neyi değiştirdiğinizi ve nedenini daha fazla açıklamalıdır.


**İş İlgili Referansları Ekleyin:**

İş akışınızı izlemek ve değişikliklerin nedenini anlamak için ilgili **sorun numarası veya talep numarası** gibi referansları eklemek iyi bir uygulamadır.

**Zaman Etiketi Eklemeyin**

Commit mesajınıza tarih veya saat eklemek yerine Git'in bu bilgiyi zaten sakladığını unutmayın.


**İmla ve Dilbilgisine Dikkat Edin**

Mesajınızın imla, dilbilgisi ve yazım kurallarına uygun olduğundan emin olun.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/bf2b2f86-d4bd-4b5a-9393-a51726cd5e05)


### Faydalı Git Komutları: git config


- Kullanıcı adı email işlemleri kaydedilir. 
- Config’den de kullanıcı bilgileri görünmüş olur.
- git config, Git'in yapılandırma ayarlarını belirlemenizi ve yapılandırmalarınızı görüntülemenizi sağlayan bir Git komutudur.
- Git'i daha iyi kişiselleştirmek, kullanıcı bilgilerini tanımlamak, proje özgü ayarları yapmak ve diğer Git ayarlarını kontrol etmek için kullanılır. git config komutu ile aşağıdaki türde yapılandırmaları belirleyebilirsiniz

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/828b5b1c-163f-4557-9709-27f2df408be7)


### Faydalı Git Komutları: git init

- Local Repository oluşturmak için çalışma klasörünün içerisine git init denildiğinde boş bir git repository oluşturulur.
- .git adında bir klasör oluşturulur.  Eğer bu klasör görülmediyse Hidden Items kısmı kapalıdır.
- .git dosyası, bir Git deposunun (repository) kalbidir ve Git'in projeyi yönetmek, versiyon kontrolü yapmak ve geçmiş değişiklikleri izlemek için kullanıldığı bir dizi dosya ve alt klasörden oluşur. Bu dosyalar ve klasörler, projenin tam tarihçesini, dallarını, commit'lerini ve diğer Git verilerini içerir.

**.git dosyası şunları içerir:**

**objects**: Bu klasör, Git'in içindeki nesnelerin (bloklar ve ağaçlar) saklandığı yerdir. Bu nesneler, commit'lerin, ağaçların ve dosyaların sürüm bilgilerini içerir.

**refs**: Bu klasör, daların (branches), etiketlerin (tags) ve diğer başvuruların depolandığı yerdir. Özellikle, refs/heads klasörü, projedeki tüm dalları ve onların son commit'leri içerir.

**HEAD**: Bu dosya, şu an hangi dalın aktif olduğunu gösterir. Yani projenin şu anki konumunu belirler.

**config**: Bu dosya, Git yapılandırma ayarlarını içerir. Kullanıcı bilgileri, uzak depo (remote repository) adresleri ve diğer yapılandırma seçenekleri burada saklanır.

**index**: Bu dosya, Staging Area veya Hazırlık Alanı olarak bilinen alandaki değişikliklerin bir listesini içerir. Yani, bir sonraki commit'te hangi dosyaların dahil edileceğini belirler.

**logs**: Bu klasör, Git'in tarihçe kayıtlarını (log) tuttuğu yerdir. Özellikle, refs/heads altındaki dalların değişiklikleri burada kaydedilir.

.git dosyası, projenin tam tarihçesini ve Git'in yönetimini sağlamak için kritik bir rol oynar. Genellikle bu dosyayı elle düzenlemeniz gerekmez; çünkü Git, bu dosyaları otomatik olarak yönetir. Ancak, bu dosyaları incelemek ve anlamak, Git'i daha derinlemesine anlamanıza yardımcı olabilir.

**Örnek bir .git klasörü**


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fbdf3748-f208-4342-a294-ff5e47336e2f)


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/dedc4ad9-fd80-44c1-bc32-4708c30164d3)


### Faydalı Git Komutları: git status

git status, Git komutlarından biridir ve mevcut çalışma dizinindeki değişiklikleri ve Git deposunun (repository) durumunu incelemenizi sağlar. Bu komut, Git ile çalışırken proje ve dosyalarınızın hangi aşamalarda olduğunu anlamanıza yardımcı olur. git status komutu aşağıdaki bilgileri sağlar:

- **Değiştirilen Dosyalar (Modified Files):** Eğer çalışma dizinindeki dosyalarda değişiklikler varsa, bu dosyalar git status çıktısında listelenir. Bu değişiklikler henüz stajlanmış (Staging Area'ya eklenmemiş) durumdadır.
- **Staging Area'da Bulunan Dosyalar (Staged Files):** Eğer bazı dosyalar Staging Area'ya eklenmişse, yani bir sonraki commit'te dahil edilmeyi bekliyorlarsa, bu dosyalar da git status çıktısında listelenir.
**- Yeni Eklenen Dosyalar (New Files):** Eğer yeni oluşturulmuş dosyalar varsa ve henüz Staging Area'ya eklenmemişlerse, bu dosyalar git status çıktısında "untracked files" (izlenmeyen dosyalar) olarak gösterilir.
**- Silinen Dosyalar (Deleted Files):** Eğer bir dosya silinmişse ve bu silme işlemi henüz commit edilmemişse, bu dosya da git status çıktısında görünür.
- **Hangi Dalın Üzerinde Çalıştığınız (On branch):** Hangi dalın (branch) üzerinde olduğunuz git status çıktısında belirtilir. Bu, projenin hangi sürümünü düzenlediğinizi gösterir.
- **Geçmiş ve Gelecekteki İşaretçiler (Your branch is ahead of 'origin/master' by 3 commits):** Eğer uzak bir depo (remote repository) ile senkronize değilseniz ve örneğin yerel depo daha fazla commit içeriyorsa, bu bilgi git status çıktısında görünür.

git status komutunu düzenli olarak kullanmak, projenizdeki değişiklikleri ve durumu takip etmenize yardımcı olur. Bu, hangi dosyaların Staging Area'ya eklenmesi gerektiğini belirlemenize ve hangi dosyaların commit'e dahil edilmesi gerektiğini anlamanıza yardımcı olur.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/966da4bf-f730-4764-8bf3-2b5ede63ac06)


### Faydalı Git Komutları: git add .

git add . komutu, Git ile çalışırken çalışma dizininde yapılan tüm değişiklikleri Staging Area (Hazırlık Alanı) olarak adlandırılan alana eklemek için kullanılır. Staging Area, bir sonraki commit (sürüm) için hangi değişikliklerin dahil edileceğini belirlediğiniz yerdir. Bu komut, değişiklikleri tüm dosyaları ve alt klasörleri içeren bir şekilde Staging Area'ya ekler.

- **Tüm Değişiklikleri Ekleme:** git add . komutunu çalıştırdığınızda, çalışma dizinindeki tüm değişiklikler (yeni dosyalar, değiştirilen dosyalar ve silinen dosyalar) Staging Area'ya eklenir. Bu, mevcut çalışma dizininde yapılan tüm değişikliklerin bir sonraki commit'e dahil edilmesini sağlar.
- **Hızlı ve Kapsamlı Ekleme:** Bu komut, tüm değişiklikleri toplu bir şekilde Staging Area'ya eklemenizi sağlar. Bu, birden fazla dosya üzerinde çalıştığınızda ve tüm değişiklikleri tek bir commit'te kaydetmek istediğinizde oldukça kullanışlıdır.
-** Commit Öncesi Kontrol: **git status komutunu kullanarak hangi dosyaların Staging Area'da olduğunu ve hangilerinin henüz eklenmediğini kontrol edebilirsiniz. Bu, bir commit yapmadan önce son kontrolü yapmanıza yardımcı olur.

**Not:** git add . komutu, tüm değişiklikleri ekler, ancak dikkatli kullanılmalıdır çünkü yanlışlıkla eklenmemesi gereken dosyaları da dahil edebilir. Değişiklikleri dikkatlice gözden geçirip sadece ilgili dosyaları Staging Area'ya eklemek, daha kontrollü ve temiz bir iş akışı sağlayabilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/85e992a6-421f-439a-8bfc-8c7efa3bbb3a)

### Faydalı Git Komutları: git commit


git commit, Git'in temel komutlarından biridir ve yerel depoya (local repository) yapılan değişiklikleri kaydetmek veya bir sürümü oluşturmak için kullanılır. Commit işlemi, çalışma dizinindeki (working directory) değişiklikleri Staging Area'da hazırlanmış (staged) dosyalar haline getirir ve bu değişiklikleri yerel depoya kaydeder. 

**Değişiklikleri Kaydetme:** git commit, çalışma dizininde yapılan değişiklikleri yerel depoya kalıcı olarak kaydeder. Bu, bir iş veya özellik üzerinde çalışmanızı tamamladığınızda bu değişiklikleri projenin tarihçesine dahil etmenizi sağlar.

**Commit Mesajı Eklemek:** Her commit işlemi için açıklayıcı bir commit mesajı eklemek önemlidir. Commit mesajı, bu değişikliğin neden yapıldığını ve neyi ifade ettiğini anlamak için önemlidir.

**Projeyi Versiyonlamak:** Commitler, projenizin versiyonlarını oluşturur. Her commit, projenin bir önceki sürümünden ne kadar değiştiğini ve neyin eklenip çıkarıldığını gösterir.


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/92673cc8-e807-4f2e-851a-d591ddda0e2b)


- Yukarıdaki örnekte, -m bayrağı ile birlikte commit mesajını doğrudan komut satırından ekledik. Commit mesajını daha detaylı bir şekilde eklemek için ise git commit komutunu çalıştırdığınızda bir metin düzenleyici açılır ve burada commit mesajınızı yazabilirsiniz.
- Commit işlemi, Git'in temel prensiplerinden biridir ve projelerin geçmişini, işbirliği yapmayı ve hata ayıklamayı yönetmek için hayati bir rol oynar. Commitler, projenizin tarihini belgelemek için kullanılır ve gerektiğinde geçmiş sürümlere geri dönmenize olanak tanır. -m, git commit komutuyla birlikte kullanılan bir bayrak (flag) veya seçenektir. -m, commit mesajını komut satırında doğrudan girmenizi sağlar. Yani, -m bayrağı, commit mesajını bir metin dizesi olarak girme işlevi sağlar.

 ### Faydalı Git Komutları: clear

 Git bash’de clear işlemi yapar ve tüm komut sistemi temizlenir. 

 
![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/ae2fc741-1aa9-4e2d-a2aa-a34a14be6ca4)


 ### Faydalı Git Komutları: Projede Değişiklik Yapalım!

- Projede index.html sayfasında değişiklik gerçekleştirdik Çalıştığımız dizinde hangi alanda değişiklik yaptığımızı git status ile görebiliriz.Git status görüldüğü zaman dosyanın düzenlendiği bilgisi verilir. 

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d6ad9b3c-0a40-4426-82bb-16137bc69ca5)

- Öncelikle tek bir dosya olduğu için geçiş bölgesine gönderirken git add index.html diyerek dosya dizininden geçiş bölgesine gönderilir. 

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b014fab9-95ae-41e9-9334-3e4240ced317)

- Yeni bir dosya ekleyelim.
- Varolan dosyada değişiklik yapalım.
- Touch yeni bir dosya eklenmesini sağlar.
- Dosyan düzenlendi. Ancak untracked diye belirlemiş, çünkü bu dosya git’e henüz bildirilmedi. Local repo bilmediği dosya için izlenmemiş untrackked der. Staging areaya göndermek için git add –A dersek yaptığımız tüm değişiklikleri staging area’ya gönderir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/7590efb5-449f-4db4-85e5-6d16a2dfc70d)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/bbc2296a-e177-4fac-8798-2f850456e7a7)

### Faydalı Git Komutları: Bir dosyanın ismini değiştirelim!

- Ls –al derseniz dosyaların isimlerini görmüş olursunuz.
- Mv text.txt readme.txt
- Önceki dosya ismini silinmiş olarak algılar
- Yeni dosya ismini ise untracked olarak algılanır.
- Git add . Veya git add –A diyebilirsiniz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/2d75c466-f776-4f8c-9ff7-8f94934a7a30)

### Faydalı Git Komutları: Geçiş bölgesine gönderilen değişiklikler arası geçiş

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/abee22fa-9cd3-493e-922e-55664d20dd82)

- İndex.html’de değişiklik yapalım. Sonrasında bu yaptığımız değişikliği geçiş bölgesine aldıktan sonra geçiş bölgesinden çıkaralım. 
- Geçiş bölgesinden çıkardıktan sonra çalışma düzenine düşer. Oradan da çıkaralım!

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/f73c7729-44b4-4cd2-b060-70817cf208c1)

### Faydalı Git Komutları: git log

git log, Git deposundaki commit tarihçesini incelemek için kullanılan bir komuttur. Bu komut, projenizin geçmiş commit'lerini, kim tarafından yapıldığını, ne zaman yapıldığını, hangi commit mesajlarına sahip olduğunu ve commit kimliklerini (SHA-1 hash) görüntüler. git log, projenin evrimini izlemek, hata ayıklama yapmak, işbirliği yapmak ve projenin geçmiş sürümleri hakkında bilgi edinmek için çok önemli bir araçtır.

**git log komutunun bazı yaygın kullanımları şunlardır:**

- git log: Tüm commitleri tarih sırasına göre gösterir.
- git log -n: En son n commit'i gösterir. Örneğin, git log -3, en son 3 commit'i gösterir.
- git log --author=<author>: Belirli bir yazarın commit'lerini filtreler.
- git log <branch>: Belirli bir dalın commit tarihçesini görüntüler.
- git log --oneline: Her commit için yalnızca kısa bir kimlik ve commit mesajı gösterir.
git log komutu, projenizin geçmişini anlamak, hata ayıklama yapmak ve işbirliği yapmak için oldukça önemli bir araçtır. Tüm commitleri tarih sırasına göre gösterir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/1dcd859c-7cdd-40f6-9515-731a8b169dc1)

### Faydalı Git Komutları: ZAMAN GERİYE AKSIN!

Commitler içerisinde Birtakım değişiklikler commit’ine geri dönelim. Bunu yapabilmek için git checkout logId dememiz yeterlidir. Bu işlem yapıldığında Head kısmı o commit’e dönmüş olur. 
Zaman makinesinde geriye gelinmiş oldu. Geriye gidebiliyorsak, ileriye de gidebiliriz. Tamamıyla geri gelmek değil de versiyonlar arasında geçiş yapılabilir. 

git checkout, Git'in esnek bir komutu olup, proje çalışma dizinini değiştirmek ve farklı dallar arasında geçiş yapmak için kullanılır. Bu komut, işbirliği ve projenin farklı sürümleri arasında geçiş yapma yeteneği sağlar. git checkout komutu aşağıdaki temel amaçlar için kullanılır:

**Dallar Arasında Geçiş Yapma:**

git checkout <branch> komutu, farklı projelerin dalları arasında geçiş yapmanıza olanak tanır. Örneğin, bir geliştirme dalından ana dala geçiş yapabilirsiniz.

**Belirli Bir Commit'e Geri Dönme:**


git checkout <commit> komutu, belirli bir commit'in durumuna geri dönmeyi sağlar. Bu, projenizin geçmiş sürümlerini incelemek veya bir hatayı düzeltmek için kullanışlıdır.
Dosyaları veya Dalları İşaretleme (tagging):

git checkout komutu, etiketleri (tags) veya dal isimlerini kullanarak belirli bir projenin sürümünü işaretlemek için kullanılabilir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a433db58-ffbe-43ce-b1b2-696b4ed9f195)



### Faydalı Git Komutları: Gidip de dönmek istemezsek?

**İki yol vardır. Revert ve Reset**

git revert, Git'te bir önceki commit'in değişikliklerini geri almak için kullanılan bir komuttur. Bu komut, mevcut bir dal üzerindeki son commit'i geri alır ve bu değişiklikleri yeni bir commit ile kaydeder. git revert işlemi, geçmiş commit'lerin değiştirilmesi yerine, yeni bir commit ekleyerek geçmiş bir hatanın düzeltilmesine veya istenmeyen bir değişikliğin geri alınmasına olanak tanır.

**git revert komutunu kullanmanın temel nedenleri şunlar olabilir:**


- **Hatalı bir commit'i geri almak:** Eğer son commit'inizde bir hata yaptıysanız, bu hatayı düzeltmek için git revert kullanabilirsiniz. Yeni bir commit ile hata düzeltilir ve geçmiş sürüm korunur.
- **Bir değişikliği geri almak:** Eğer bir önceki commit'de eklediğiniz bir değişikliği geri almak isterseniz, git revert bu değişikliği geri almanıza yardımcı olur.
- **İşbirliği durumlarında kullanım:** Ekip içindeki diğer geliştiricilerin çalışmalarını bozmamak için git revert, daha önce paylaşılmış olan bir commit'i düzeltebilmeniz için kullanışlıdır. Bu, geçmişteki bir hata veya eksiklik durumunda kullanışlıdır.

git revert komutu, geçmiş commit'leri korurken hataları düzeltmek veya değişiklikleri geri almak için kullanışlı bir araçtır. Bu sayede geçmiş sürümleri bozmamanız ve işbirliği içinde çalışmanız mümkün olur.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/8d47fa33-16ad-4e7d-b6a4-efc17c94d8d9)


### Faydalı Git Komutları: Sil Baştan Başlamak Gerek Bazen!

**git reset**, Git'te bir önceki commit'leri veya projenizin durumunu değiştirmek için kullanılan bir komuttur. Bu komut, projenin tarihçesini değiştirir ve belirli commit'leri geri alabilir veya birleştirebilir. git reset komutu, farklı modlarıyla gelir ve hangi modun kullanıldığına bağlı olarak farklı işlevlere sahiptir. 

- **Soft Reset (git reset --soft):** Bu mod, belirli bir commit'i geri alır, ancak yapılan değişiklikleri çalışma dizini (working directory) ve Staging Area'da (Hazırlık Alanı) korur. Yani, geri alınan commit sonrası değişiklikleri tekrar inceleme ve yeni bir commit oluşturma fırsatı sunar.
- **Mixed Reset (git reset --mixed):** Bu mod, belirli bir commit'i geri alır ve Staging Area'daki değişiklikleri siler, ancak çalışma dizinindeki değişiklikleri korur. Bu, commit'e gitmeyi unuttuğunuz veya hatalı bir commit'i düzeltmeniz gerektiğinde kullanışlıdır.
- **Hard Reset (git reset --hard):** Bu mod, belirli bir commit'i geri alır ve bu commit sonrası yapılan tüm değişiklikleri tamamen siler. Bu, bir commit'i veya bir dizi commit'i geri almak ve değişiklikleri tamamen kaldırmak istediğinizde kullanılır.

git reset, özellikle projenizin geçmişini yönetirken veya hatalı commit'leri düzeltirken kullanışlıdır. Ancak dikkatli kullanılmalıdır çünkü projedeki değişiklikleri geri alabilir ve bu değişiklikler kaybolabilir. Bu nedenle, bu komutu kullanmadan önce dikkatlice düşünmelisiniz.



![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/0990aee0-8b13-4664-a628-ad92f66648c0)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/28f12cea-5499-490f-a5df-59c70d34b427)


### Faydalı Git Komutları: Git ignore

- Repository üzerinden takip edilmesini istenmeyen dosyalar bu dosyada tutulur.
- .gitignore dosyası tutulmalıdır.
- .gitignore dosyası en başta oluşturulmalıdır. Sonradan oluşturulduğunda hemen algılanmayabilir. O nedenle cacheleri temizlemek gerekir.  


**.gitignore dosyasının kullanımı şunlara hizmet eder:**


- **Üretilen Dosyaları veya Derleme Çıktılarını İzlememek:** Projenizin derleme çıktıları, geçici dosyalar veya projenin çalışması sırasında üretilen dosyalar genellikle .gitignore dosyasına eklenir. Bu, bu tür dosyaların Git tarihçesine dahil edilmemesini sağlar.
- **Dosyaları veya Gizli Bilgileri Korumak:** API anahtarları, şifreler veya başka hassas bilgiler, .gitignore ile korunabilir. Bu sayede bu tür bilgilerin Git tarihçesinde saklanmasının önüne geçilir.
- **Geçici Dosyaları İzlememek:** Geçici dosyalar ve veritabanı yedeklemeleri, Git tarihçesine eklenmemesi gereken dosyalardır. .gitignore, bu tür dosyaları izlemeden korumanıza yardımcı olur.

.gitignore dosyası, projenin daha temiz ve daha yönetilebilir olmasına yardımcı olur. Ayrıca, hassas bilgilerin Git tarihçesine eklenmesini önler ve gereksiz dosyaları paylaşarak projeyi daha hızlı hale getirir. Bu nedenle, Git depolarını oluştururken ve paylaşırken .gitignore dosyası oluşturmak önemlidir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b084ba0a-ddb3-4581-902b-fc163ec3f707)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b11f32e6-1f76-4d24-b3ec-08df6afde74e)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/b7317b8b-f3f4-4c4d-bc57-86f9c7065df7)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/f827be69-4d17-4646-a75b-8cd4093ba012)


### Faydalı Git Komutları: Git Branching

Üzerinde çalışılan projenin farklı geliştirmeler için farklı dallara ayrılmasını sağlar. 
Örneğin bir projede html ile ilgili değişikliklerden bir kişi sorumlu olsun, css ile ilgili gelişmelerden bir kişi sorumlu olsun. Bu kişilerin çalışmalarının engelenmemesi için branch mantığından yararlanılır. Ayrı ayrı branchlerde çalışarak sonrasında hepsi master’a merge işlemini gerçekleştirebilirler. 
Master’ın kendisini de bir dal olarak düşünebilirsiniz. 

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a410d32e-5226-4b15-bc1c-20d7553a5a67)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/aa7e45ff-9562-45bd-b40b-0f7b5596ba0d)


### Faydalı Git Komutları: git clone

git clone komutu, bir uzak depoyu kopyalayarak yerel bir kopyasını oluşturmanıza yardımcı olan bir Git komutudur. Bu komut, ornek-repo adlı uzak depoyu GitHub'dan kopyalayarak, mevcut dizinde bir ornek-repo dizini oluşturur ve bu depoyu bu dizine klonlar.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/a5824090-5256-4c0b-b008-89f7184798f8)


### Faydalı Git Komutları: Projeyi Github‘a atalım!

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/38dd5bc0-dbc2-4a11-9d2d-6c052ef44a7a)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/e9c91d9b-633f-4809-87a0-cb9b25d0380d)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/642aeff9-f0a1-41b0-aa9e-986784aafb72)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/9d05c386-2d8f-4833-8270-66baf99defd7)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/d52258bf-bd5e-445b-9544-c39fbe849d9f)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/17a5e3e2-3c11-4fa9-b214-27b8a07eff35)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/800fe0cd-ad23-4e43-957d-f87a322e6206)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/63ffd0d7-ef2c-4373-b21e-38aee792d612)


### Faydalı olabilecek bir Cheat-Sheet!


![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/218d3889-f6fd-4d90-80ea-c53d910233a4)


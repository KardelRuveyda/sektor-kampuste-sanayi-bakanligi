 
#  Modern Web Geliştirme 3

## Git Temelleri

### Versiyon Kontrol Sistemi

Version Control System bir döküman (yazılım projesi, ofis belgesi…) üzerinde yaptığımız degişiklikleri adım adım kaydeden ve isterseniz bunu internet üzerinde depoda (respository) saklamamızı ve yönetmemizi sağlayan bir sistemdir. Git, SVN, BitKeeper, Mercurial sürüm kontrol sistemlerine örnek olarak gösterilir.

### Git

Git açık kaynak kodlu bir versiyon sürüm kontrol sistemidir

### Neden git ?

- Geliştirme süreçlerini izlemek
- Projede yapılan değişikliklerin nerede ve ne zaman yapıldığı izlenmek 
- Yanlış veya hatalı işlem yapıldığında daha önceki düzgün çalışılan versiyona dönmek istenebilir. 


Projelerde birden fazla kişi çalıştığını düşünürsek, gelişimin hızlanmasını sağlar.
Projede geliştirme yaparken, bulunduğumuz konuma nereden geldiğimizi anlamak için eski ve yeni kodumuz arasında karşılaştırma yapmamızı sağlar.
Projede hatayla karşılaştığımız durumlarda eski kod kaydına dönmemizi sağlar.
Açık kaynaklı projeler baz alınarak geliştirilecek yeni projelerde, süreci kolaylaştırmayı sağlar.

**Versiyon Kontrol Sistem Tipleri**

**1. Local Versiyon Kontrol Sistemleri**

En eski versiyon kontrol sistemi yaklaşımıdır. Çalıştığımız projemiz ve yaptığımız değişiklikler kullanıcı makinası üzerindeki veritabanında tutulur. Her yapılan commit bir versiyon olarak tutulur ve commit değerine hash ataması yapılarak her versiyon birbirinden ayırt edilmektedir. Ayrıca versiyon görüntüleme imkanını sağlar. Ancak bu sistemde sadece bir kullanıcı etkin bir şekilde çalışabilir.

**2. Merkezi Versiyon Kontrol Sistemleri**

Birden fazla kişinin bir proje üzerinde etkin çalışması için ortaya atılmış versiyonlama sistemidir. CVS, SVN birer merkezi versiyon kontrol sistemleridir. Bu sistemde proje ortak bir respository’de tutulur ve birden fazla geliştirici aynı respository üzerinde checkout ve commit işlemlerini gerçekleştirmektedir. Bu yöntemde herkesin projeye katkı sağlamasının yanısıra bazı ciddi sorunları vardır. Tek merkezli sunucu 1 saatliğine arızalanması durumunda, kullanıcılar 1 saat boyunca çalışmalarını veya çalıştıkları projenin sürümlenmiş kopyalarını kaydetmeleri mümkün olmayacaktır.

**3. Dağıtık Versiyon Kontrol Sistemleri**



### Git Kurulum İşlemleri

- https://git-scm.com/downloads adresinden indirmeniz gerekiyor.

  ![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/3a4374b0-c11a-425e-9571-9fbb9c9f4400)

- Kullanıcı hesap denetimi ayarlarınız açık ise karşınıza bir pencere gelecektir. Bu aşama da işlemin tarafımızdan gerçekleştirildiğini onaylamamız gerekiyor. "Evet" seçeneğini seçerek işleme izin vermeniz gerekir.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/82b961d3-5a6c-4dcd-8811-d9a1999db726)

- Kurulumun ilk aşamasında bizi "GNU General Public License" lisansı karşılamaktadır. "Next" butonuna tıklayarak bir sonra ki aşamaya geçiyoruz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/fca09bb2-82fb-4e85-8b14-ef34ac2f4365)

- Bu aşamada Git'in kurulacağı dizini belirtmemiz gerekiyor. Eğer farklı bir dizin seçmeyecek seniz, "Next" butonu ile bir sonra ki aşamaya geçiyoruz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/afcc40bd-012b-4e9d-9100-0c5bf38fc42c)

- Bu aşamada kurmak istediğiniz ekstra bileşenler varsa bu aşamada seçiyoruz. Bu aşamayı da "Next" butonu ile geçiyoruz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/19122356-48a4-4e73-8187-b4f2bd2392bd

- Varsayılan olarak kullandığımız bir editör varsa, burada belirtmemiz gerekiyor. Ben varsayılan olarak Visual Studio Code kullandığımdan "Use Visual Studio Code as Git's default editor" seçeneğini seçtim. Eğer bu seçimi yaptıysanız, sonra ki aşamaya geçelim.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/294b7f89-8170-4c4c-aec5-a19129ab40c2)

- Bu aşamada ise bağlantı sağlayacağımız yöntemi seçmemiz gerekiyor. commit ederken siz Windows, arkadaşınız Linux kullanıyorsa önemli!

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/238b05f1-c51e-4735-9a4f-3170cdb3ac6a)

- Bu aşamada Git Bash'ın kullanacağı terminali belirtiyoruz. İsterseniz MinTTY gibi çok fonksiyonlu bir terminal kullanabilir veya klasik "Komut istemcisini" kullanabilirsiniz.

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/78a50e36-76eb-4dcc-9aed-6f9dae1bdee7)

- Veee, mutlu son :)

![image](https://github.com/KardelRuveyda/sektor-kampuste-sanayi-bakanligi/assets/33912144/7d83b364-cbd9-4f8d-8da7-a6961b2db453)

- Git Bash, Git'i kullanırken Windows işletim sistemi üzerinde bir komut satırı arabirimi sağlayan bir uygulamadır. Windows kullanıcılarına Git komutlarını çalıştırmak, depolarını yönetmek ve Unix benzeri komutları kullanmak için bir çözüm sunar. Git Bash aynı zamanda Git'in özelliklerini kullanmanıza ve Linux veya macOS terminali benzeri bir deneyim elde etmenize olanak tanır.

Git Bash, aşağıdaki önemli özelliklere sahiptir:

Git Komutları: Git Bash, Git komutlarını Windows'ta kullanmanıza izin verir. git init, git clone, git commit, git pull, git push gibi Git komutlarını burada kullanabilirsiniz.

Unix Benzeri Ortam: Git Bash, Unix ve Linux terminalini taklit eden bir komut satırı deneyimi sunar. Bu, Unix benzeri komutları kullanmayı kolaylaştırır.

Shell Desteği: Git Bash, Bash shell üzerine inşa edilmiştir ve birçok Unix komut dosyası (shell script) ve araçlarıyla uyumludur. Bu, özelleştirme ve otomasyon için kullanışlıdır.

Daha Fazla Araç: Git Bash ayrıca temel Git dışındaki araçları da içerebilir. Örneğin, SSH anahtarları oluşturmak ve yönetmek için kullanabileceğiniz ssh-keygen gibi araçlar mevcuttur.

Git Bash, Windows kullanıcılarına Git'i kullanma ve geliştirme projelerini yönetme konusunda güçlü bir araç sunar. Ayrıca Git'in komut satırı arayüzünü tercih edenler için ideal bir seçenektir. Git Bash, Git'i Windows ortamında daha etkili bir şekilde kullanmanıza yardımcı olur.

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
İş İlgili Referansları Ekleyin:

İş akışınızı izlemek ve değişikliklerin nedenini anlamak için ilgili sorun numarası veya talep numarası gibi referansları eklemek iyi bir uygulamadır.

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

Ls –al derseniz dosyaların isimlerini görmüş olursunuz. 

Mv text.txt readme.txt
Önceki dosya ismini silinmiş olarak algılar
Yeni dosya ismini ise untracked olarak algılıyor.
Git add . Veya git add –A diyebilirsiniz.

### Faydalı Git Komutları: Geçiş bölgesine gönderilen değişiklikler arası geçiş

### Faydalı Git Komutları: git log

### Faydalı Git Komutları: ZAMAN GERİYE AKSIN!


### Faydalı Git Komutları: Gidip de dönmek istemezsek?

### Faydalı Git Komutları: Sil Baştan Başlamak Gerek Bazen!

### Faydalı Git Komutları: Git ignore


### Faydalı Git Komutları: Git Branching

### Faydalı Git Komutları: git clone

### Faydalı Git Komutları: Projeyi Github‘a atalım!


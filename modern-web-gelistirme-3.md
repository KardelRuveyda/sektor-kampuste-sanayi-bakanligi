
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

### Working Directory/Staging Area/Local Repository/Remote Repository

### Commit Kavramı ve Commit Mesajı Önemi

### Faydalı Git Komutları: git config

### Faydalı Git Komutları: git init

### Faydalı Git Komutları: git status

### Faydalı Git Komutları: git add .

### Faydalı Git Komutları: git commit

 ### Faydalı Git Komutları: clear

 ### Faydalı Git Komutları: Projede Değişiklik Yapalım!

### Faydalı Git Komutları: Projede İki Değişiklik Birden Yapalım!

### Faydalı Git Komutları: Projede İki Değişiklik Birden Yapalım!

### Faydalı Git Komutları: Bir dosyanın ismini değiştirelim!

### Faydalı Git Komutları: Bir dosyanın ismini değiştirelim!


### Faydalı Git Komutları: Geçiş bölgesine gönderilen değişiklikler arası geçiş

### Faydalı Git Komutları: git log

### Faydalı Git Komutları: ZAMAN GERİYE AKSIN!


### Faydalı Git Komutları: Gidip de dönmek istemezsek?

### Faydalı Git Komutları: Sil Baştan Başlamak Gerek Bazen!

### Faydalı Git Komutları: Git ignore


### Faydalı Git Komutları: Git Branching

### Faydalı Git Komutları: git clone

### Faydalı Git Komutları: Projeyi Github‘a atalım!


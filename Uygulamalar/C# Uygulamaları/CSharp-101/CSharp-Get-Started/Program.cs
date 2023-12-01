#region 1-) Komut Satırına Yazırma Komutları
//Komut Satırına Yazdırma İşlemi
Console.Write("Hello World");
Console.WriteLine("Hello, i am new.I am learning C# Programming Language!");
Console.WriteLine("This is fun!");
Console.WriteLine(2 + 2);

#endregion


#region 2-) Yorum Satırı İşlemleri
//Yorum Satırı İşlemleri
// Yorum satırına almak için // kullanabilirsiniz. 
// Çoklu satırları yorum satına almak için ise  "/*" başlayıp "*/"

/*
Console.WriteLine("Test");
Console.WriteLine("Test 2");
Console.WriteLine("Test 3");
Console.WriteLine("Test 4");
*/


#endregion


#region 3-) C# Variables ( Değişken Tipleri ) 

// integer Veri Tipi ( Bütün sayıları kapsayan bir alandır. Küsüratlı sayılar haricinde tüm sayıları kapsıyor. 
int number = 0;
int age = 28;

Console.WriteLine(number + age);

//Double (Küsratlı sayıların tanımında double değerleri kullanabilirsiniz.)
double doubleValue = 5.99D;

Console.WriteLine(doubleValue);

// Char Veri Tipi : Karakterlerin tanımlanmasında kullanılyor. ( Tek harf vb. alanlarda kullanılır. )
// String değeler "" tanımlanırken char değerleri '' tek tırnak tanımlanır.
char charValue = 'h';
Console.WriteLine(charValue);

//String değerler (text alanları, cümeler, kelimeler gibi alanları tanımlarken string ifadesinden yararlanıyoruz. 
// string olarak tanımlayabileceğiniz gibi "var" tanımlayabilirsiniz 
string name = "Kardel";
var surname = "Çetin";

Console.WriteLine(String.Format("Adı: {0} Soyadı: {1}", name, surname));
Console.WriteLine($"Benim adım : {name}, soyadım ise {surname}");

//Boolean Değerler (True, False) değerlerin tanımlanmasında gerçekleştirilir. 
bool isActive = false;

//Ternary İf Örneği ( ileride de değineceğiz. ) 
isActive = name == "Kardel" ? true : false;
string message = isActive ? $"{name} kullanıcısı aktif bir kullanıcıdır. " : $"{name} kullanıcısı pasif bir kullanıcıdır. ";
Console.WriteLine(message);

//Normal If Kullanımı (İleride Değineceğiz. ) 
if (name == "Kardel")
{
    isActive = true;
}
else
{
    isActive = false;
}

string message2 = "";

if (isActive)
{
    message2 = $"{name} kullanıcısı aktif bir kullanıcıdır. ";
}
else
{
    message2 = $"{name} kullanıcısı pasif bir kullanıcıdır. ";
}
#endregion

#region 4-) Casting İşlemleri 

// Double bir değeri integera cast etmek 
double myValue = 9.78;
int myIntegerValue = (int)myValue;

Console.WriteLine(myValue);
Console.WriteLine(myIntegerValue);


// Convert İşlemleri 
int integerValueCast = 19;
double doubleValueCast = 4.29;
bool myBooleanCast = false;

//Convert.ToString() -> Integer bir değeri Stringe çevirmek istiyorsam bu Convert işlemini kullanabilirim. 
string intToString = Convert.ToString(integerValueCast);
Console.WriteLine(intToString);
// Convert.ToDouble -> Integer bir değer var, bunu double'a çevirmeyi sağlıyor. 
double intTodouble = Convert.ToDouble(integerValueCast);
Console.WriteLine(intTodouble);
//Convert.ToInt32 -> Double bir değeri integere çevirme.
int doubleToInt = Convert.ToInt32(integerValueCast / 2);
Console.WriteLine(doubleToInt);
#endregion

#region 5-) Konsolda User Input İşlemleri 
// Konsola aşağıdaki alan yazdırılır.
Console.WriteLine("Kulllanıcı Adınızı Giriniz: ");

// Konsoldan gelen değer çekilir 
string userName = Console.ReadLine();

// Tekrardan konsola yazdırılır. 
Console.WriteLine(userName);
#endregion

#region 6-) Operatörler 
#region  Operatörler ile ilgili örnekler ( Karşılaştırma Operatörleri)
Console.WriteLine("Lütfen sayı giriniz.");

string integerValueString = Console.ReadLine();
int integerValue = Convert.ToInt32(integerValueString);
List<string> messageList = new List<string>();

if (integerValue > 7)
{
    messageList.Add("Verilen değer yediden büyüktür.");
}

if (integerValue >= 10)
{
    messageList.Add("Verilen değer 10 veya 10'dam büyüktür.");
}

if (integerValue < 9)
{
    messageList.Add("Verilen değer 9'dan küçüktür.");
}

if (integerValue <= 12)
{
    messageList.Add("Verilen değer 12'den küçük veya küçük eşittir.");
}

if (integerValue == 10)
{
    messageList.Add("Verilen değer 10 sayısına eşittir.");
}

if (integerValue != 10)
{
    messageList.Add("Verilen değer 10 değildir.");
}

#endregion


#region Mantıksal Operatörler
if(integerValue >= 8 && integerValue <= 12)
{
    messageList.Add("Bu sayı 8 ile 12 arasındadır.");
}

if(integerValue == 8 || integerValue > 8)
{
    messageList.Add("Bu sayı 8 ya da 8'den büyükttür.");
}

#endregion 
Console.WriteLine(String.Join("\n", messageList));
#endregion 

#region 7-) Strings
var firstName = "Kardel";
var lastName = "Çetin";

var nameJoin = firstName + " " + lastName;
var nameConcat = string.Concat(firstName, lastName);
var stringInterpolation = $"Benim adım {firstName} {lastName}";
var stringJoin = String.Format("Benim adım {0} {1}", firstName, lastName);

Console.WriteLine(nameJoin);
Console.WriteLine(nameConcat);
Console.WriteLine(stringInterpolation);
Console.WriteLine(stringJoin);

#endregion


#region 8-) IF-ELSE
int value = 8;

//Basit bir if bloğu

if (value != 8)
{
    Console.WriteLine("Bu ifade 8 değildir.");
}

//Else-if
if (value == 8)
{
    Console.WriteLine("Bu ifade 8'dir");
}
else if (value == 9)
{
    Console.WriteLine("Bu ifade 9'dur.");
}
else
{
    Console.WriteLine("Bu ifade 8 ve ya 9 değildir.");
}

//Normal bir if else mantığı
string messageIf = "";

if (value == 8)
{
    messageIf = "Buradaki değer 8'dir.";
}
else
{
    messageIf = "Buradaki değer 8 değildir.";
}

//Ternary If tanımlaması 
messageIf = value == 8 ? "Buradaki değer 8'dir." : "Buradaki değer 8 değildir.";

//Daha karmaşık bir terary if
messageIf = value == 8 ? "Buradaki değer 8'dir." : (value < 8 ? "Buradaki değer 8'den küçüktür." : "Buradaki 8'den büyüktür.");

//Karmaşık terary if'i normal blogda yazalım.
if (value == 8)
{
    messageIf = "Buradaki değer 8'dir.";
}
else
{
    if (value < 8)
    {
        messageIf = "Buradaki değer 8'den küçüktür.";
    }
    else
    {
        messageIf = "Buraki değer 8'den büyüktür.";
    }
}


#endregion


#region 9-) Switch Case 


Console.WriteLine("Lütfen Switch Case için sayı giriniz.");
int numberSwitch = Convert.ToInt32(Console.ReadLine());

switch (numberSwitch)
{
    case 10:
        Console.WriteLine("Girdiğiniz sayı 10'dur");
        break;
    case 11:
        Console.WriteLine("Girdiğiniz sayı 11'dir");
        break;
    case 12:
        Console.WriteLine("Girdiğiniz sayı 12'dir.");
        break;
    default:
        Console.WriteLine("Girdiğiniz değer kısıtlarla eşleşmiyor.");
        break;
}

//Switch'i Ifle yazsaydık?

if (numberSwitch == 10)
{
    Console.WriteLine("Girdiğiniz sayı 10'dur.");
}
else if (numberSwitch == 11)
{
    Console.WriteLine("Girdiğiniz sayı 11'dir.");
}
else if (numberSwitch == 12)
{
    Console.WriteLine("Girdiğiniz sayı 12'dir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı diğer kısıtlarla eşleşmiyor. ");
}
#endregion

#region 10-) For Döngüsü

//1000 kere özür dilerim yazdırma

//1000 kere yazdırabilmek için ;
for (int i = 0; i < 1000; i++)
{
    Console.WriteLine("Özür Dilerim.");
}
#endregion

#region 11-) While Döngüsü

int counter = 0;

while (counter < 1000)
{
    Console.WriteLine("Özür dilerim.");
    counter++;
}

#endregion

#region 12-) Foreach

List<int> listIntegers = new List<int>();
listIntegers.Add(1);
listIntegers.Add(2);
listIntegers.Add(3);
foreach (var item in listIntegers)
{
    Console.WriteLine(item);
}

#endregion

#region 13-) Arrays

//Dört elemanlı bir dizi oluşturun ve değerleri sonra ekleyin.
string[] cars = new string[4];

// Dört elemanlı bir dizi oluşturun ve elemanları da ekleyin.
cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda"};

//Boyut belirtmeden dört elemanlı bir dizi oluşturabilirsiniz. 
string[] carsNew = new string[] { "Volvo", "BMW", "Ford", "Mazda", "Nissan" };

//new anahtar sözcüğünü kullanamdan dört elemanlı bir dizi oluşturma 
string[] carsNew2 = { "Volvo", "BMW", "Mazda", "Ford", "Nissan"};
#endregion

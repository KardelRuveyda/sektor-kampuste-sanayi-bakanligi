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


#region Aritmetik Operatörler
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
var stringJoin = String.Join("Benim adım {0} {1}", firstName, lastName);

Console.WriteLine(nameJoin);

#endregion


#region 8-) IF-ELSE
int value = 8;


//Basit bir if bloğu
if(value != 8)
{
    Console.WriteLine("Bu ifade 8 değildir");
}

//Else-if condition

if(value == 8)
{
    Console.Write("Bu ifade 8'dir.");
}else if(value == 9)
{
    Console.Write("Bu ifade 9'dur.");

}
else if (value == 10)
{
    Console.Write("Bu ifade 10'dur.");
}
else
{
    Console.WriteLine("Bu ifade 8,9 veya 10 değildir.");
}


string messageIf = "";

//normal if-else mantığıdır.
if(value == 8)
{
    messageIf = "Buradaki değer 8'dir";
}
else
{
    messageIf = "Buradaki değer 8 değildir.";
}

//ternary if şekklinde yazarsak

messageIf = value == 8 ? "Buradaki değer 8'dir." : "Buradaki değer 8 değildir.";


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
#endregion

#region 10-) For Döngüsü

//1'den 5'e kadar olan sayıları ekrana yazdıran bir döngü yazalım. 

for(int i=1; i <= 5; i++)
{
    Console.WriteLine(i);
}

#endregion

#region 11-) While Döngüsü
//1'den 3'e kadar olan sayıları ekrana yazdıran bir döngü yazalım. 

int x = 1; //Başlangıç değerim

while (x <= 3) //Koşul
{
    Console.WriteLine(x);
    x++; //Her döngü adımında i'yi bir arttır.
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
string[] carsNew2 = { "Volvo", "BMW", "Mazda", "Ford", "Nissan" };

string[] carsNew4 = { "Volvo", "BMW", "Mazda", "Ford", "Nissan"};



#endregion

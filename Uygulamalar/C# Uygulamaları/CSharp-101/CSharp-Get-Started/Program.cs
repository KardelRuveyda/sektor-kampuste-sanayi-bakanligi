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

Console.WriteLine(String.Format("Adı: {0} Soyadı: {1}",name,surname));
Console.WriteLine($"Benim adım : {name}, soyadım ise {surname}");

//Boolean Değerler (True, False) değerlerin tanımlanmasında gerçekleştirilir. 
bool isActive = false;

//Ternary İf Örneği ( ileride de değineceğiz. ) 
isActive = name == "Kardel" ? true : false;
string message = isActive ? $"{name} kullanıcısı aktif bir kullanıcıdır. " : $"{name} kullanıcısı pasif bir kullanıcıdır. ";
Console.WriteLine(message);

//Normal If Kullanımı (İleride Değineceğiz. ) 
if(name == "Kardel")
{
    isActive = true;
}else
{
    isActive = false;
}

string message2 = "";

if (isActive)
{
    message2 = $"{name} kullanıcısı aktif bir kullanıcıdır. ";
}else
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

#region 6-) Aritmetik Operatörler 

#endregion 

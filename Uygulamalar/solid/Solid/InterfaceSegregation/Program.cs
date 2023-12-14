#region Kodun çalıştırıldığı yer
SendMultipleMail();
void SendMultipleMail()
{
    List<DriverInfo> drivers = new List<DriverInfo>();
    drivers.Add(new DriverInfo
    {
        City = "İstanbul",
        EmailAdress = "kardel@gmail.com",
        Telephone = "5305153061"
    });

    var nissan = new Nissan();
    nissan.SendInfoDriverEmails(drivers);
}
#endregion


#region Renault  işlemleri 
public class Renault : BaseCar, ISmsSendable,IMailSendable
{
    public override double GetCostPerKM()
    {
        return 2.5;
    }

    public void SendInfoDriverEmail(DriverInfo info)
    {
        Console.WriteLine("Mail gönderilme işlemi gerçekleşti.");
    }

    public void SendInfoDriverSms(DriverInfo info)
    {
        Console.WriteLine("Sms gönderildi.");
    }
}

#endregion

#region Nissan işlemleri için 

public class Nissan : BaseCar, ISmsSendable, IMailSendable, IMailMultipleSendable
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }

    public void SendInfoDriverEmail(DriverInfo info)
    {
        Console.WriteLine("Email gönderildi.");
    }

    public void SendInfoDriverEmails(List<DriverInfo> infos)
    {
        foreach (var item in  infos)
        {
            Console.WriteLine($"Sürücü bilgisi: {item.EmailAdress}");
        }
    }

    public void SendInfoDriverSms(DriverInfo info)
    {
        Console.WriteLine("Sms gönderildi.");

    }
}

#endregion


#region Yakıt Giderlerini Hesaplayan Bir Class
public class FuelCostCalculator
{
    public double Calculate(BaseCar car)
    {
        return car.RoadKm * car.GetCostPerKM();
    }

}
#endregion

#region Base Car Abstract Class'ı ( Tekrar tekrar kod yazmadan kaçınmak için bir soyut sınıf açtık.)
public abstract class BaseCar
{
    public double RoadKm { get; set; } = 2.2;

    public abstract double GetCostPerKM();
    public void Go()
    {
        Console.WriteLine("Araba gidiyor..");
    }

    public void Stop()
    {
        Console.WriteLine("Araba durdu..");
    }
}

#endregion

#region Interfacelerin Oluşturulması
//SMS interface tanımlaması
public interface ISmsSendable
{
    void SendInfoDriverSms(DriverInfo info);
}

//Mail interface tanımlaması

public interface IMailSendable
{
    void SendInfoDriverEmail(DriverInfo info);
}

//Çoklu mail atımı için interface
public interface IMailMultipleSendable
{
    void SendInfoDriverEmails(List<DriverInfo> infos);
}

#endregion

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
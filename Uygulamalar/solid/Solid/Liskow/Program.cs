#region Kodun Çalıştırılma Kısmı

SendSMSRenault();
void SendSMSRenault()
{
    var renault = new Renault();
    renault.SendInfoDriverSms(new DriverInfo
    {
        City = "Tes",
        EmailAdress = "ruve@gmail.com",
        Telephone = "213123213"
    });
}
#endregion

#region Renault  işlemleri 
public class Renault : BaseCar,ISmsSendable
{
    public override double GetCostPerKM()
    {
        return 2.5;
    }

    public void SendInfoDriverSms(DriverInfo info)
    {
        Console.WriteLine("Sms gönderildi.");
    }
}

#endregion

#region Nissan işlemleri için 

public class Nissan : BaseCar,ISmsSendable,IMailSendable
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }

    public void SendInfoDriverEmail(DriverInfo info)
    {
        Console.WriteLine("Email gönderildi.");
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

#endregion

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
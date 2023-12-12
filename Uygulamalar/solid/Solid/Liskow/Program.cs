#region Kodun çalıştırıldığı yer

SendSMS();
void SendSMS()
{
    var renault = new Renault();
    renault.SendSMS();
}
#endregion

public class Renault : BaseCar,ISmsSendable
{
    public override double GetCostPerKM()
    {
        return 2.3;
    }

    public void SendInfoDriverSms()
    {
        Console.WriteLine("SMS Gönderildi.");
    }
}

public class Nissan : BaseCar,ISmsSendable,IMailSendable
{
    public override double GetCostPerKM()
    {
        return 3.5;
    }

    public void SendInfoDriverSms()
    {
        Console.WriteLine("SMS Gönderildi.");
    }

    public void SendMailInfoDriver()
    {
        Console.WriteLine("Mail Gönderildi.");
    }
}

#region SMS ve Mail Servisleri Interface
public interface ISmsSendable
{
    void SendInfoDriverSms();
}

public interface IMailSendable
{
    void SendMailInfoDriver();
}
#endregion


#region Yakıt Giderlerini Hesaplayan Bir Class 
public class FuelCostCalculator
{
    public double Calculate(BaseCar car)
    {
        //if(car is Renault)
        //{
        //    return car.RoadKm * 5.6;
        //}else if ( car is Nissan)
        //{
        //    return car.RoadKm * 3.5;
        //}
        //else
        //{
        //    return car.RoadKm * 1;
        //}
        return car.RoadKm * car.GetCostPerKM();
    }
}

#endregion


#region Base Car Abstract Class Oluşturalım
public abstract class BaseCar
{
    public double RoadKm { get; set; } = 2.6;

    public abstract double GetCostPerKM();

    public void Go()
    {
        Console.WriteLine("Araba gidiyor.");
    }

    public void Stop()
    {
        Console.WriteLine("Araba durdu.");
    }

    public void SendMail()
    {
        Console.WriteLine("Mail gönderildi.");
    }

    public void SendSMS()
    {
        Console.WriteLine("SMS gönderildi.");
    }
}

public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
#endregion
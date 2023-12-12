#region Kodun çalıştırıldığı yer

SendSMS();
void SendSMS()
{
    var nissan = new Nissan();

    List<DriverInfo> list = new List<DriverInfo>();
    list.Add(new DriverInfo
    {
        EmailAddress = "kardel@gmail.com",
        Telephone = "4234234"
    }); 
    nissan.SendInfoEmailToDrivers(list);
}
#endregion

public class Renault : BaseCar, ISmsSendable,IMailSendable
{
    public override double GetCostPerKM()
    {
        return 2.3;
    }

    public void SendInfoDriverSms(DriverInfo driverInfo)
    {
        Console.WriteLine("SMS Gönderildi.");
    }
    public void SendMailInfoDriver(DriverInfo info)
    {
        Console.WriteLine("Mail Gönderildi.");
    }
}

public class Nissan : BaseCar, ISmsSendable, IMailSendable,IMultipleEmailSendable
{
    public override double GetCostPerKM()
    {
        return 3.5;
    }

    public void SendInfoDriverSms(DriverInfo driverInfo)
    {
        Console.WriteLine("SMS Gönderildi.");
    }

    public void SendInfoEmailToDrivers(List<DriverInfo> mails)
    {
        foreach (var item in mails)
        {
            Console.WriteLine($"Sürücüye mail gönderildi. Sürücü : {item.EmailAddress}");
        }
    }

    public void SendMailInfoDriver(DriverInfo driverInfo)
    {
        Console.WriteLine("Mail Gönderildi.");
    }
}

#region SMS ve Mail Servisleri Interface
public interface ISmsSendable
{
    void SendInfoDriverSms(DriverInfo info);
}

public interface IMailSendable
{
    void SendMailInfoDriver(DriverInfo info);
}

public interface IMultipleEmailSendable
{
    void SendInfoEmailToDrivers(List<DriverInfo> mails);
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
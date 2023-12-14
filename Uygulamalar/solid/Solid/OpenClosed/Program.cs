#region Kodun Çalıştırıldığı Kısım
CalculateTripCost();
void CalculateTripCost()
{
    var calculator = new FuelCostCalculator();
    var costRenault = calculator.Calculate(new Renault());
    var costNissan = calculator.Calculate(new Nissan());
    var costBMW = calculator.Calculate(new BMW());

    Console.WriteLine($"Renault Yaktığı Km Fiyatı: {costRenault}");
    Console.WriteLine($"Nissan Yaktığı Km Fiyatı: {costNissan}");
    Console.WriteLine($"BMW Yaktığı Km Fiyatı: {costBMW}");
}
#endregion

#region Renault  işlemleri 
public class Renault : BaseCar
{
    public override double GetCostPerKM()
    {
        return 2.5;
    }
}

#endregion

#region Nissan işlemleri için 

public class Nissan : BaseCar
{
    public override double GetCostPerKM()
    {
        return 1.5;
    }
}

#endregion

#region BMW
public class BMW : BaseCar
{
    public override double GetCostPerKM()
    {
        return 4.5;
    }
}
#endregion

#region Yakıt Giderlerini Hesaplayan Bir Class
public class FuelCostCalculator{
    public double Calculate(BaseCar car)
    {
        //if(car is Nissan)
        //{
        //    return car.RoadKm * 2.2;
        //}else if(car is Renault)
        //{
        //    return car.RoadKm * 2.8;
        //}else if(car is BMW)
        //{
        //    return car.RoadKm * 2.9;
        //}
        //else
        //{
        //    return 10.5;
        //}
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

    public void SendMail()
    {
        Console.WriteLine("Mail gönderildi.");
    }

    public void SendSms()
    {
        Console.WriteLine("Sms gönderildi.");
    }

    #region Signle Resp. Uyan Yapı
    public void SendInfoDriverMail(DriverInfo info)
    {
        if (!String.IsNullOrEmpty(info.EmailAdress))
        {
            SendMail();
        }
    }

    public void SendInfoDriverSms(DriverInfo info)
    {
        if (!String.IsNullOrEmpty(info.Telephone))
        {
            SendSms();
        }
    }
    #endregion
}

#endregion

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
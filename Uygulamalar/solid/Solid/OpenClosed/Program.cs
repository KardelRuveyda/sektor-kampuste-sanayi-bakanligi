#region  Kodun Çalıştırıldığı Yer
CalculateTripCost();
void CalculateTripCost()
{
    #region Harcanan yakıt parasını hesaplayan fonksiyon

    var calculator = new FuelCostCalculator();
    var cost = calculator.Calculate(new Renault());
    var costRound = Math.Round(cost);

    Console.WriteLine($"Bu aracın yakıt fiyatı : {costRound}");
    #endregion
}

#endregion


public class Renault : BaseCar
{
    public override double GetCostPerKM()
    {
        return 2.3;
    }
}

public class Nissan : BaseCar
{
    public override double GetCostPerKM()
    {
        return 3.5;
    }
}

public class BMW : BaseCar
{
    public override double GetCostPerKM()
    {
        return 6.5;
    }
}

public class Mercedes : BaseCar
{
    public override double GetCostPerKM()
    {
        return 8.5;
    }
}


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

    public void SendInfoDriverSms(DriverInfo info)
    {
        if (!String.IsNullOrEmpty(info.Telephone))
        {
            SendSMS();
        }
    }

    public void SendInfoDriverMail(DriverInfo info)
    {
        if (!String.IsNullOrEmpty(info.EmailAddress))
        {
            SendMail();
        }
    }

}

public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
#endregion
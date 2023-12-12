#region Kodun Çalıştırıldığı Kısım 

Renault renault = new Renault();
renault.SendInfoDriverSms(new DriverInfo
{
    EmailAddress = "ruveyda@gmai.com",
    Telephone = "530556456",
    City = "İstanbul"
});

renault.SendInfoDriverMail(new DriverInfo
{
    EmailAddress = "ramazan@gmai.com",
    Telephone = "54654564",
    City = "Ankara"
});
#endregion


#region Birinci Arabanın Class'ının Oluşturulması
public class Renault
{
    public int RoadKm { get; set; }

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

    #region Single Resp. Uymayan Kısım

    public void SendInfoDriver(DriverInfo info)
    {
        if (!String.IsNullOrEmpty(info.EmailAddress))
        {
            SendMail();
        }

        if (!String.IsNullOrEmpty(info.Telephone))
        {
            SendSMS();
        }
    }
    #endregion

    #region Single Resp. Uyan Kısım 

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

    #endregion
}

public class DriverInfo
{
    public string EmailAddress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
#endregion
#region Kodun Çalıştırıldığı Kısım
Renault renault = new Renault();
//renault.SendInfoDriver(new DriverInfo
//{
//    City = "Trabzon",
//    EmailAdress = "kardel@gmail.com",
//    Telephone = "32432432423"
//});


renault.SendInfoDriverSms(new DriverInfo
{
    City = "Trabzon",
    EmailAdress = "kardel@gmail.com",
    Telephone = "32432432423"
});

renault.SendInfoDriverMail(new DriverInfo
{
    City = "Trabzon",
    EmailAdress = "kardel@gmail.com",
    Telephone = "32432432423"
});

#endregion
public class Renault
{
    public int RoadKm { get; set; }

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

    #region Single Resp. Uymayan bir kod yazalım
    public void SendInfoDriver(DriverInfo info)
    {
        if (!String.IsNullOrEmpty(info.EmailAdress))
        {
            SendMail();
        }

        if (!String.IsNullOrEmpty(info.Telephone))
        {
            SendSms();
        }
    }
    #endregion

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

public class DriverInfo
{
    public string EmailAdress { get; set; }
    public string Telephone { get; set; }
    public string City { get; set; }
}
#region Kodun Çalıştırıldığı Kısım
void RunCars()
{
    //Hata verirse Dependency ile log bassın. 

    new TripIfoLoggerDependency(new TurkeyLoggerDependency()).Log();
    new TripIfoLoggerDependency(new FranceLoggerDependency()).Log();

    //Dependency kullanmasa

    new TripInfoLogger().LogToTurkey("test");
    new TripInfoLogger().LogInfoFrance("test");
}
#endregion



#region Dependency Inversion Kullanılmasa ?

public class TripInfoLogger
{
    public void LogToTurkey(string tripInfo)
    {
        new TurkeyLogger().Log();
    }

    public void LogInfoFrance(string logInfo)
    {
        new FranceLogger().Log();
    }
}


public class TurkeyLogger
{
    public void Log()
    {
        Console.WriteLine("Turkiye için loglama yapıldı.");
    }
}

public class FranceLogger
{
    public void Log()
    {
        Console.WriteLine("Fransa için loglama yapıldı.");
    }
}
#endregion

#region Dependency olursa nasıl yaparım ? 

public class TripIfoLoggerDependency
{
    private ILoggerDependency _logger;

    public TripIfoLoggerDependency(ILoggerDependency logger)
    {
        _logger = logger;
    }

    public void Log()
    {
        _logger.Log();
    }
}

public class TurkeyLoggerDependency : ILoggerDependency
{
    public void Log()
    {
        Console.WriteLine("Türkiye için loglama yapıldı.");
    }
}

public class FranceLoggerDependency : ILoggerDependency
{
    public void Log()
    {
        Console.WriteLine("Fransa için loglama yapıldı.");
    }
}
public interface ILoggerDependency
{
    void Log();
}

#endregion
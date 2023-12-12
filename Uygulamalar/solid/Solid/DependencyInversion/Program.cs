#region Kodun Çalıştırıldığı Yer
#endregion

RunCars();
void RunCars()
{
    new TripInfoLogger().LogToTurkey("Dependency olmadan");
    new TripInfoLoggerDependency(new TurkeyLoggerDependency()).Log("Türkiye için dependency");
    new TripInfoLoggerDependency(new FranceLoggerDependency()).Log("Fransa için dependency");
}


#region Dependency Inversion Kullanılmasa
public class TripInfoLogger
{
    public void LogToTurkey(string logInfo)
    {
        new TurkeyLogger().Log(logInfo);
    }

    public void LogToFrance(string logInfo)
    {
        new FranceLogger().Log(logInfo);
    }
}

public class TurkeyLogger
{
    public void Log(string logInfo)
    {
        Console.WriteLine($"Türkiye Loglama işlemi gerçekleşti.Log info:{logInfo}");
    }
}

public class FranceLogger
{
    public void Log(string logInfo)
    {
        Console.WriteLine($"Fransa Loglama işlemi gerçekleşti.Log info:{logInfo}");
    }
}
#endregion


#region Dependency Inversion Kullanılsa 
public class TripInfoLoggerDependency
{
    private ILoggerDependency _logger;

    public TripInfoLoggerDependency(ILoggerDependency logger)
    {
        _logger = logger;
    }

    public void Log(string logInfo)
    {
        _logger.Log("Dependency");
    }
}

public class TurkeyLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Türkiye:{logStr}");
    }
}

public class FranceLoggerDependency : ILoggerDependency
{
    public void Log(string logStr)
    {
        Console.WriteLine($"Loglama işlemi Fransa:{logStr}");
    }
}
public interface ILoggerDependency
{
    void Log(string logStr);
}
#endregion
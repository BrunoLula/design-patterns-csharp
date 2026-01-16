using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton;

public sealed class AppSettings
{
    private static readonly Lazy<AppSettings> _instance =
        new Lazy<AppSettings>(() => new AppSettings());
    public static AppSettings Instance => _instance.Value;
    public string Environment { get; set; }
    public string ConnectionString { get; set; }
    public bool EnableCache { get; set; }
    private AppSettings()
    {
        Environment = "Development";
        ConnectionString = "Server=localhost;Database=AppDb;";
        EnableCache = true;

    }

    public void PrintSettings()
    {
        Console.WriteLine("=== Application Settings ===");
        Console.WriteLine($"Environment: {Environment}");
        Console.WriteLine($"ConnectionString: {ConnectionString}");
        Console.WriteLine($"EnableCache: {EnableCache}");
    }
    
}

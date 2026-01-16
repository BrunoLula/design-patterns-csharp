using Singleton;

class Program
{
    static void Main()
    {
        var settings1 = AppSettings.Instance;
        var settings2 = AppSettings.Instance;

        settings1.PrintSettings();

        Console.WriteLine($"Mesma instância? {ReferenceEquals(settings1, settings2)}");
    }
}

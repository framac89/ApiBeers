using Microsoft.Extensions.Configuration;
using System.IO;
public static class AppConfig
{
    public static IConfiguration GetConfiguration()
    {
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
    }
}

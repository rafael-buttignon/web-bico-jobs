using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ProjectFatec.Api
{
    public class Program
    {
        static string envName;
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            envName = string.IsNullOrEmpty(config["configEnvName"]) ? "development" : config["configEnvName"];

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((x, config) =>
                {
                    config.AddJsonFile("appsettings.json").AddJsonFile($"appsettings.{envName}.json");
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

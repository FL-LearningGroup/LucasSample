using System;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Diagnostics;

namespace NetLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.Development.json");
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                .AddConfiguration(configurationBuilder.Build())
                .AddConsole();
            });

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Example log message");

            Debug.WriteLine("Debug message");

            do
            {
                Console.WriteLine("Please entry 'Q'or q character to end process...");
            } while ("q" == Console.ReadKey().ToString().ToLower());
        }
    }
}

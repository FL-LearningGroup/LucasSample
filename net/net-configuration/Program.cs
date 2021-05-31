using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace NetConfiguration
{
    
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("template.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configurationRoot = configurationBuilder.Build();

            TransientFaultHandlingOptions options = new();
            configurationRoot.GetSection(nameof(TransientFaultHandlingOptions)).Bind(options);
            Console.WriteLine($"TransientFaultHandlingOptions.Enabled={options.Enabled}");
            Console.WriteLine($"TransientFaultHandlingOptions.AutoRetryDelay={options.AutoRetryDelay}");

            // Test reloadOnchange function with modified template file.
            // Waitting that the file completed modified.
            do
            {
              Console.WriteLine("Please entry s character to skip loop...");
            } while ("s" == Console.ReadKey().ToString().ToLower());
            Console.WriteLine();

            configurationRoot.GetSection(nameof(TransientFaultHandlingOptions)).Bind(options);
            Console.WriteLine($"TransientFaultHandlingOptions.Enabled={options.Enabled}");
            Console.WriteLine($"TransientFaultHandlingOptions.AutoRetryDelay={options.AutoRetryDelay}");

            Console.WriteLine("Please entry any character to end process...");
            Console.ReadKey();
        }
    }
}

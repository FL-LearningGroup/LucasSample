using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace NetGenericHost
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            Console.WriteLine("Please entry any chart to end process....");
            Console.ReadKey();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) => {
                    services.AddHostedService<ExampleHostedService>();
                })
                .ConfigureServices((_, services) => {
                    services.AddHostedService<ExampleHostedServiceTwo>();
                });
        }
    }
}

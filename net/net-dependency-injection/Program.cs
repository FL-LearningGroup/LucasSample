using System;
using Microsoft.Extensions.DependencyInjection;

namespace NetDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped();
            Console.ReadKey();
        }
    }
}

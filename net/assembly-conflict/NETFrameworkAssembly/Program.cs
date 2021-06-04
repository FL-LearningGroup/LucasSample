using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace NETFrameworkAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            var weakAssembly01 = Assembly.Load(@"D:\Lucas\git\LucasSample\net\assembly-conflict\WeakNameAssembly01\bin\Debug\netstandard2.1\WeakNameAssembly.dll");
            Console.ReadKey();
        }
    }
}

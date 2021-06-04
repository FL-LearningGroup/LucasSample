using System;

namespace _4Charter
{
    //The employee inherit System.Object
    class Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            Console.WriteLine("HashCode: " + e.GetHashCode());

            Console.ReadKey();
        }
    }
}

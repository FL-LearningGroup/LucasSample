using System;
using System.Threading;

namespace Net._21Chapter
{
    public class Ref01: IDisposable
    {
        ~Ref01()
        {
            Console.WriteLine("Call Finalize method");
            this.Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("Call Dispose method");
        }
    }

    public class Call01
    {
        public void Test()
        {
            Console.WriteLine("Call Test method");

            Ref01 t = new Ref01();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Call01 call = new Call01();
            call.Test();

            GC.Collect();
            Console.ReadLine();
        }

    }
}

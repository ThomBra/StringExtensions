using ThomBraExtensions;
using System;

namespace TestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World".GetAscii());
            foreach(int x in "Hello World".GetAscii())
            {
                Console.WriteLine(x);
            }
        }
    }
}

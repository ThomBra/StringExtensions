using ThomBraExtensions;
using System;

namespace TestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!".ReverseString());

            Console.WriteLine("Hello World!".CountWords());
            Console.WriteLine("Hello!   World!".CountWords());
            Console.WriteLine("Hello, World!".CountWords());
        }
    }
}

using ThomBraExtensions;
using System;

namespace TestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World".GetAscii());
            //foreach(int x in "Hello World".GetAscii())
            //{
            //    Console.WriteLine(x);
            //}
            //Testing .IsPalindrome-Method
            string palStr = "Lagertonnennotregal";
            Console.WriteLine("The word {0} is a palindrome is: {1}", palStr, palStr.IsPallindrome());
        }
    }
}

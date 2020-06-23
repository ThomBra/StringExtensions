using ThomBraExtensions;
using System;

namespace TestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing .IsPalindrome-Method
            //string palStr = "Lagertonnennotregal";
            //Console.WriteLine("The word {0} is a palindrome is: {1}", palStr, palStr.IsPallindrome());

            //Testing .ToMorseCode-Method
            string morseSourceText = "Hello World!";
            Console.WriteLine("Morse-Code: {0}", morseSourceText.ToMorseCode());
        }
    }
}

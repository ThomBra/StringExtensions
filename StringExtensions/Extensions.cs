using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ThomBraExtensions
{
    public static class Extensions
    {
        public static string ReverseString(this String str)
        {
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }
            return s;
        }

        public static int CountWords(this String str)
        {
            string sTemp = Regex.Replace(str, "( ){2,}", " ");
            return sTemp.Split(new char[] { ' ' }).Length; //, ',', '.', '?', '!' 

        }

        public static string Anagram(this String str)
        {
            //New comment
            return new string(str.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray()).ToUpper();
        }

        public static int[] GetAscii(this String str)
        {
            int[] asciiArr = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                asciiArr[i] = (int)str[i];
            }
            return asciiArr;
        }

        public static bool IsPallindrome(this String str)
        {
            if (str.ToLower().Equals(str.ToLower().ReverseString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string ToMorseCode(this String str)
        {
            StringBuilder morseStringBuilder = new StringBuilder();

            Dictionary<char, string> morseCharacters = new Dictionary<char, string>()
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {'.',".-.-.-"},
                {',',"--.--"},
                {'?',"..--.."},
                {':',"---..."},
                {';',"-.-.-."},
                {' ',"-...-"},
                {'/',"-..-."},
                {'"',".-..-."},
            };

            string tempMorseStr = String.Empty;
            foreach (Char c in str.ToLower())
            {                
                //if there is a corresponding character-Key in dictionary
                if (morseCharacters.TryGetValue(c, out tempMorseStr))
                {
                    morseStringBuilder.Append(tempMorseStr);
                }
                // if no corresponding key then concat unchanged input character
                else
                {
                    morseStringBuilder.Append(c);
                }
            }
            return morseStringBuilder.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static string ToMorseCode(this String str, bool translateSpace = true)
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
                {'"',".-..-."}
            };

            string tempMorseStr = String.Empty;
            foreach (Char c in str.ToLower())
            {                
                //if there is a corresponding character-Key in dictionary
                if (morseCharacters.TryGetValue(c, out tempMorseStr))
                {
                    if (c != ' ')
                    {
                        morseStringBuilder.Append(tempMorseStr);
                    }
                    else
                    {
                        if (translateSpace)
                        {
                            morseStringBuilder.Append(tempMorseStr);
                        }
                        else
                        {
                            morseStringBuilder.Append(' ');
                        }
                    }
                }
                // if no corresponding key then concat unchanged input character
                else
                {
                    morseStringBuilder.Append(c);
                }
            }
            return morseStringBuilder.ToString();
        }

        public static void ToMorseCodeSound(this String str)
        {
            int freq = 500;
            int timeUnitMs = 100;
            Stopwatch sw = new Stopwatch();

            foreach (char c in str.ToMorseCode(false))
            {
                if (c == '.')
                {
                    Console.Beep(freq, timeUnitMs);
                }
                else if(c == '-')
                {
                    Console.Beep(freq, timeUnitMs * 3);
                }
                //Pause between two symbols (. or -) (1* timeUnitMs)
                sw.Start();
                while (sw.ElapsedMilliseconds < timeUnitMs) { }
                sw.Stop();
                sw.Reset();

                //Pause between two words (7* timeUnitMs)
                if (c == ' ')
                {                       
                    sw.Start();
                    while (sw.ElapsedMilliseconds < timeUnitMs * 7) { }
                    sw.Stop();
                    sw.Reset();
                }
            }
        }
    }
}

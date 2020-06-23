using System;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public static string Anagram(this string str)
        {
            //New comment
            return new string(str.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray()).ToUpper();
        }
    }
}

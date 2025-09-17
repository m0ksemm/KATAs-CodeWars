using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWarsKATAs.Solutions
{
    public class ShorterConcat
    {
        public static string ShorterReverseLonger(string a, string b)
        {
            if (string.IsNullOrEmpty(a))
                a = "";
            if (string.IsNullOrEmpty(b))
                b = "";
            if (a.Length < b.Length)
            {
                char[] charArray = b.ToCharArray();
                Array.Reverse(charArray);
                return a + new string(charArray) + a;
            }
            else
            {
                char[] charArray = a.ToCharArray();
                Array.Reverse(charArray);

                return b + new string(charArray) + b;
            }
        }

        //public static string ShorterReverseLonger(string a, string b)
        //{
        //    a ??= "";
        //    b ??= "";
        //    return b.Length > a.Length ? a + string.Concat(b.Reverse()) + a : b + string.Concat(a.Reverse()) + b;
        //}
    }
}

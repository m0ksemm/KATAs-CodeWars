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
            if (b.Length < a.Length) 
            {
                char[] charArray = a.ToCharArray();
                Array.Reverse(charArray);

                return b + new string(charArray) + b; 
            }
            else
            {
                char[] charArray = b.ToCharArray();
                Array.Reverse(charArray);
                return a + new string(charArray) + a;
            }
             
        }
    }
}

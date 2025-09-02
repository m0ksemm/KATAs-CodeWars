using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class RealStringLength
    {
        public static int GetRealLength(String str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                // If this is a high surrogate and next char is a low surrogate -> one codepoint
                if (char.IsHighSurrogate(c) && i + 1 < str.Length && char.IsLowSurrogate(str[i + 1]))
                {
                    count++;
                    i++; 
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
    }
}

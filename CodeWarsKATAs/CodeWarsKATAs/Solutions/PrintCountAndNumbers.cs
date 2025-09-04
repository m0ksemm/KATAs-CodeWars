using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class PrintCountAndNumbers
    {
        public static string CountMe(string data)
        {
            if (string.IsNullOrEmpty(data)) 
                return "";

            foreach (var item in data) 
            {
                if (char.IsLetter(item))
                    return "";
            }

            string result = "";
            int count = 0;
            for (int i = 0; i < data.Length; i++) 
            {
                count = 0;
                int j = i;
                do
                {
                    count++;
                    j++;
                }
                while (j < data.Length && data[i] == data[j]);
                result += count.ToString() + data[i];
                i = j - 1;
            }

            return result;
        }

        public static string CountMe2(string data)
        {
            return data.Any(char.IsLetter) ? "" : Regex.Replace(data, @"(.)\1*", m => $"{m.Length}{m.Value[0]}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class RemoveFirstAndLastCharacter2
    {
        public static string? Array2(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Split(",").Length < 3)
                return null;
            
            string result = s.Replace(" ", "");
            string[] arr = result.Split(",");
            string[] arr2 = arr[1..(arr.Length - 1)];


            return String.Join(" ", arr2);

        }

        public static string? Array(string s) => (string.IsNullOrEmpty(s) || s.Split(",").Length < 3) ? null 
            : String.Join(" ", s.Replace(" ", "").Split(",")[1..^1]);
    }
}

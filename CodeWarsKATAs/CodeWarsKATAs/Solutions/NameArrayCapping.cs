using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class NameArrayCapping
    {
        public static string[] CapMe(string[] strings) 
        {
            List<string> list = new List<string>();
            for (int i = 0; i < strings.Length; i++) 
            {
                string result = char.ToUpper(strings[i][0]).ToString();
                for (int j = 1; j < strings[i].Length; j++) 
                {
                    result += char.ToLower(strings[i][j]);
                }
                list.Add(result);
            }


            return list.ToArray();
        }

        public static string[] CapMe2(string[] strings) => strings.Select(i => char.ToUpper(i[0]) + i.Substring(1).ToLower()).ToArray();
        public static string[] CapMe3(string[] strings) => strings.Select(s => char.ToUpper(s[0]) + s[1..].ToLower()).ToArray();

    }
}

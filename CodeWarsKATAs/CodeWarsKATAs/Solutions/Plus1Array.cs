using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class Plus1Array
    {
        public static int[] UpArray(int[] num)
        {
            string s = String.Join("", num);
            int number = int.Parse(s) + 1;
            string s2 = number.ToString();
            int[] array = new int[s2.Length];
            foreach (string st in s2)
            {

            }
            return array;
        }
    }
}

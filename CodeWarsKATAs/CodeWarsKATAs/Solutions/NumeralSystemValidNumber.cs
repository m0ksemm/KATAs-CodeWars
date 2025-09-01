using System;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class NumeralSystemValidNumber
    {

        private const string digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static bool ValidateBase2(string num, int base_)
        {
            return digits.IndexOf(num.Max()) < base_;
        }



        public static bool ValidateBase(string num, int base_)
        {
            int[] arr = new int[num.Length];

            for ( int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetter(num[i]))
                {
                    arr[i] = Convert.ToInt32(num[i]) - 55;
                }
                else arr[i] = int.Parse(num[i].ToString());
            }

            foreach (int i in arr)
            {
                if (i >= base_) 
                    return false;
            }
            return true;
        }
    }
}

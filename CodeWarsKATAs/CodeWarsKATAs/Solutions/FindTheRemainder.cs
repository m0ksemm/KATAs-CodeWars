using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class FindTheRemainder
    {
        public static int Remainder(int a, int b)  => a > b ? b == 0 ? throw new DivideByZeroException() : a % b : a == 0 ? throw new DivideByZeroException() : b % a;
        //{
        //    if (a > b)
        //        if (b == 0)
        //            throw new DivideByZeroException();
        //        else return a % b;
        //    else if (a == 0)
        //        throw new DivideByZeroException();
        //    else return b % a;
        //}


        //    public static int Remainder(int a, int b) =>
        //a > b ? a % b : b % a;
        //public static int Remainder(int a, int b) => Math.Max(a, b) % Math.Min(a, b);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class SheepCounter
    {
        public static int CountSheeps(bool[] sheeps) => sheeps!= null ? sheeps.Where(s => s == true).Count() : 0;
        //{
        //    //TODO
        //}
    }
}

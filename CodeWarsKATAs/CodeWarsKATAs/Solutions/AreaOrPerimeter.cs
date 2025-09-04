using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class AreaOrPerimeter
    {
        public static int MathCheck(int l, int w) => l == w ? l * w : (l + w) * 2;
    }
}

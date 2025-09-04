using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class Thinkful_NumberDrills
    {
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            return Convert.ToDouble(blueStart - bluePulled) / ((blueStart - bluePulled) + (redStart - redPulled)); 
        }
    }
}

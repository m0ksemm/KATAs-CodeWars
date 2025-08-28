using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class MeanSquareError
    {
        public static double Solution(int[] firstArray, int[] secondArray) => firstArray.Zip(secondArray, (x, y) => (x-y)*(x-y)).Average();



        public static double Solution2(int[] firstArray, int[] secondArray)
        {
            double sum = 0;
            for (int i = 0; i < firstArray.Length; i++) 
            {
                sum += (firstArray[i] - secondArray[i]) * (firstArray[i] - secondArray[i]);
            }
            return sum / firstArray.Length;
        }
    }
}

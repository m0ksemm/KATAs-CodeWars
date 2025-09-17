using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class MagicSquareValidator
    {
        public static bool IsMagical(int[] square)
        {
            if (square.Length != 9) return false;

            if (square.Distinct().Count() != 9) return false;
            if (square.Any(x => x < 1 || x > 9)) return false;

            if (square[0] + square[1] + square[2] != 15 ||
                square[3] + square[4] + square[5] != 15 ||
                square[6] + square[7] + square[8] != 15)
                return false;
            else if (square[0] + square[3] + square[6] != 15 ||
                    square[1] + square[4] + square[7] != 15 ||
                    square[2] + square[5] + square[8] != 15)
                return false;
            else if (square[0] + square[4] + square[8] != 15 ||
                    square[2] + square[4] + square[6] != 15)
                return false;
            return true;
        }
    }
}

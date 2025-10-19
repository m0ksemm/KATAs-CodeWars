using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class RankVector
    {
        public static int[] Ranks2(int[] ranks)
        {
            int [] result = new int[ranks.Length];

            int [] sorted = ranks.OrderByDescending(rank => rank).ToArray();


            for (int i = 0; i < ranks.Length; i++)
            {
                result[i] = Array.IndexOf(sorted, ranks[i]) + 1;
            }

            return result;
        }

        public static int[] Ranks(int[] ranks)
        {
            var sorted = ranks.OrderByDescending(rank => rank).ToList();
            return ranks.Select(x => sorted.IndexOf(x) + 1).ToArray();
        }
    }
}

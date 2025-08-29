using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0)
                return new int[0];

            int[] result = new int[array.Length * array.Length];

            int i = 0;
            int j = 0;
            int z = 4;
            int n = 0;

            for (int k = 0; k < result.Length; k++) 
            {
                if (z % 4 == 0) 
                {
                    if (j < array.Length - n) 
                        result[k] = array[i][j++];
                    else 
                    {
                        j--; i++; z--; k--;
                    }
                }
                else if (z % 4 == 3)
                {
                    if (i < array.Length - n)
                        result[k] = array[i++][j];
                    else 
                    {
                        i--;j--; z--; k--;
                    }
                }
                else if (z % 4 == 2)
                {
                    if (j  >= n) 
                        result[k] = array[i][j--];
                    else
                    {
                        j++;i--; z--;  k--; n++;
                    }
                } 
                else if (z % 4 == 1)
                {
                    if (i >= n) 
                        result[k] = array[i--][j];
                    else 
                    {
                        i++; j++; z = 4; k--;
                    }
                }
            }

            return result;
        }


        public static int[] SnailVariant2(int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0)
                return new int[0];

            List<int> result = new List<int>();

            int top = 0;
            int bottom = array.Length - 1;
            int left = 0;
            int right = array[0].Length - 1;

            while (top <= bottom && left <= right)
            {
                // Traverse from Left → Right
                for (int i = left; i <= right; i++)
                    result.Add(array[top][i]);
                top++;

                // Traverse from Top → Bottom
                for (int i = top; i <= bottom; i++)
                    result.Add(array[i][right]);
                right--;

                if (top <= bottom)
                {
                    // Traverse from Right → Left
                    for (int i = right; i >= left; i--)
                        result.Add(array[bottom][i]);
                    bottom--;
                }

                if (left <= right)
                {
                    // Traverse from Bottom → Top
                    for (int i = bottom; i >= top; i--)
                        result.Add(array[i][left]);
                    left++;
                }
            }

            return result.ToArray();
        }




        public static int[] SnailSolution(int[][] array)
        {
            int l = array[0].Length;
            int[] sorted = new int[l * l];
            SnailRecursive(array, -1, 0, 1, 0, l, 0, sorted);
            return sorted;
        }

        public static void SnailRecursive(int[][] array, int x, int y, int dx, int dy, int l, int i, int[] sorted)
        {
            if (l == 0)
                return;
            for (int j = 0; j < l; j++)
            {
                x += dx;
                y += dy;
                sorted[i++] = array[y][x];
            }
            SnailRecursive(array, x, y, -dy, dx, dy == 0 ? l - 1 : l, i, sorted);
        }
    }
}

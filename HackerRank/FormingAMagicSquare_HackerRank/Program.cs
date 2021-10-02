using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormingAMagicSquare_HackerRank
{
    class Program
    {
        static int FormingMagicSquare(int[][] s)
        {
            int total = 0;
            int[][] inventory = { new int[] { 2,9,4,7,5,3,6,1,8},
                                  new int[] { 4,9,2,3,5,7,8,1,6},
                                  new int[] { 2,7,6,9,5,1,4,3,8},
                                  new int[] { 6,7,2,1,5,9,8,3,4},
                                  new int[] { 6,1,8,7,5,3,2,9,4},
                                  new int[] { 8,1,6,3,5,7,4,9,2},
                                  new int[] { 8,3,4,1,5,9,6,7,2},
                                  new int[] { 4,3,8,9,5,1,2,7,6}
                                };
            int min = int.MaxValue;
            for (int i = 0; i < inventory.Length; i++)
            {
                total = 0;
                for (int j = 0; j<inventory[i].Length; j++)
                {
                    total += Math.Abs(s[j / 3][j % 3] - inventory[i][j]);
                }
                if (total < min)
                {
                    min = total;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            int output = FormingMagicSquare(new int[][] { new int[]{ 4, 8, 2 }, new int[]{ 4, 5, 7 }, new int[]{ 6, 1, 6 } });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountApplesAndOranges_HackerRank
{
    class Program
    {
        static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int applesqty = 0, orangesqty = 0;
            foreach(var item in apples)
            {
                if (a+item>=s && a + item <= t)
                {
                    applesqty++;
                }
            }
            foreach (var item in oranges)
            {
                if (b + item >= s && b + item <= t)
                {
                    orangesqty++;
                }
            }
            Console.WriteLine(applesqty);
            Console.WriteLine(orangesqty);
        }
        static void Main(string[] args)
        {
            int[] apples = { -2, 2, 1 }, oranges = { 5, -6 };
            CountApplesAndOranges(7, 11, 5, 15,apples,oranges);
        }
    }
}

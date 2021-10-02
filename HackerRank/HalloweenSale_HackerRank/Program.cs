namespace HalloweenSale_HackerRank
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {
        /*
         * Complete the 'howManyGames' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER p
         *  2. INTEGER d
         *  3. INTEGER m
         *  4. INTEGER s
         */

        public static int HowManyGames(int p, int d, int m, int s)
        {
            // Return the number of games you can buy
            var gamesCanBuy = 0;
            for (int i = p; s >= i && s >= m; i -= d)
            {
                if (i <= m)
                {
                    i = m;
                }
                s -= i;
                gamesCanBuy++;
            }
            return gamesCanBuy;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Result.HowManyGames(20, 3, 6, 85));
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int p = Convert.ToInt32(firstMultipleInput[0]);
            int d = Convert.ToInt32(firstMultipleInput[1]);
            int m = Convert.ToInt32(firstMultipleInput[2]);
            int s = Convert.ToInt32(firstMultipleInput[3]);
            int answer = Result.HowManyGames(p, d, m, s);
            Console.WriteLine(answer);
        }
    }
}

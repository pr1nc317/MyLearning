using System;
using System.Collections.Generic;

namespace DrawingBook_HackerRank
{
    class Program
    {
        public static int PageCount(int n, int p)
        {
            int turnsToReachEnd = n / 2;
            int targetfwdturn = p / 2;
            int targetbckturn = turnsToReachEnd - targetfwdturn;
            return Math.Min(targetfwdturn, targetbckturn);
        }
        static void Main(string[] args)
        {
            int output = PageCount(8, 4);

            // Just trying to reference other project's method
            BetweenTwoSets_HackerRank.Program.getTotalX(new List<int>() { 1, 2 },new List<int>() { 2, 3 });
        }
    }
}
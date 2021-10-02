namespace TheHurdleRace_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Result
    {

        /*
         * Complete the 'hurdleRace' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY height
         */

        public static int HurdleRace(int k, List<int> height)
        {
            if (k>=height.Max()) return 0;
            else
            {
                return height.Max() - k;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();
            int result = Result.HurdleRace(k, height);
        }
    }
}

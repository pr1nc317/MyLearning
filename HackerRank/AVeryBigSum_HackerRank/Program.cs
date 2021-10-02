namespace AVeryBigSum_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        class Result
        {

            /*
             * Complete the 'aVeryBigSum' function below.
             *
             * The function is expected to return a LONG_INTEGER.
             * The function accepts LONG_INTEGER_ARRAY ar as parameter.
             */

            public static long aVeryBigSum(List<long> ar)
            {
                long result = 0;

                //FIRST WAY - LINQ
                //return ar.Sum();

                //SECOND WAY - ITERATION
                ar.ForEach(x => result += x);
                return result;
            }

        }

        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();
            long result = Result.aVeryBigSum(ar);
        }
    }
}

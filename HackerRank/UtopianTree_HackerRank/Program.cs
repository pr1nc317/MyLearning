namespace UtopianTree_HackerRank
{
    using System;

    class Result
    {

        /*
         * Complete the 'utopianTree' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int UtopianTree(int n)
        {
            int result = 1;
            if (n == 0) return result;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1) result *= 2;
                else result += 1;
                Console.WriteLine(result);
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int t = Convert.ToInt32(Console.ReadLine().Trim());
            //for (int tItr = 0; tItr < t; tItr++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine().Trim());
            //    int result = Result.UtopianTree(n);
            //    Console.WriteLine(result);
            //}
            Console.WriteLine(Result.UtopianTree(5));
        }
    }
}

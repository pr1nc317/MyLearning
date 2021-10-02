namespace ViralAdvertising_HackerRank
{
    using System;

    class Result
    {

        /*
         * Complete the 'viralAdvertising' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER n as parameter.
         */

        public static int ViralAdvertising(int n)
        {
            int people = 5, result = 0;
            for (int i = 1; i <= n; i++)
            {
                people /= 2;
                result += people;
                people *= 3;
            }
            return result;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int result = Result.ViralAdvertising(n);
        }
    }
}

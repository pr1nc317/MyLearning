namespace AngryProfessor_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Result
    {

        /*
         * Complete the 'angryProfessor' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY a
         */

        public static string AngryProfessor(int k, List<int> a)
        {
            return a.Where(x => x <= 0).Count() >= k? "NO" : "YES" ;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
                int n = Convert.ToInt32(firstMultipleInput[0]);
                int k = Convert.ToInt32(firstMultipleInput[1]);
                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
                string result = Result.AngryProfessor(k, a);
                Console.WriteLine(result);
            }
        }
    }
}

namespace BeautifulDaysattheMovies_HackerRank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Result
    {

        /*
         * Complete the 'beautifulDays' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER i
         *  2. INTEGER j
         *  3. INTEGER k
         */

        public static int BeautifulDays(int i, int j, int k)
        {
            //SOLUTION 1 - one liner LINQ
            return Enumerable.Range(i,j-i+1).Select(x=> Math.Abs(x-int.Parse(new string(x.ToString().Reverse().ToArray())))%k)
                .Where(x=> x==0).Count();

            //SOLUTION 2 - For Loop
            //int counter = 0;
            //for (int a = i; a<=j; a++)
            //{
            //    var aRev = int.Parse(new string(a.ToString().Reverse().ToArray()));
            //    if (Math.Abs(a - aRev)%k == 0)
            //    {
            //        counter++;
            //    }
            //}
            //return counter;

            //Convert.ToInt32 is slower than int.Parse because the latter does a null check and throws ArgumentNullException whereas the
            //former does not check null arguments.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int i = Convert.ToInt32(firstMultipleInput[0]);
            int j = Convert.ToInt32(firstMultipleInput[1]);
            int k = Convert.ToInt32(firstMultipleInput[2]);
            int result = Result.BeautifulDays(i, j, k);
            Console.WriteLine(result);
        }
    }
}

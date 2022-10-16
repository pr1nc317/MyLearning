namespace Divisible_by_60
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int DivisibleBy60(List<int> A)
        {
            //For a number to be divisible by 60, it must be divisible by individual prime numbers raised to their highest powers
            //60 = 2 * 2 * 3 * 5 --> i.e., 4 * 3 * 5
            //For a number to be divisble by 4, the last 2 digits must be divisible by 4
            //For a number to be divisible by 5, last digit should be either 0 or 5
            //For a number to be divisible by 4 and 5, (i.e. 20) last digit should be 0 and second last should digit be even number
            //For a number to be divisible by 3, sum of all digits should be divisible by 3
            //So, for our final answer, a number is divisible by 60 if the array contains a 0, an even digit and all the digit when summed is divisible by 3
            if (A.Count == 1 && A.Contains(0))
            {
                return 1;
            }
            if (A.Contains(0))
            {
                if (A.Sum() % 3 == 0)
                {
                    if (A.Where(x => x==0).Count() > 1)
                    {
                        return 1;
                    }
                    else if (A.Where(x => x != 0 && x % 2 == 0).Count() >= 1)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleBy60(new List<int> { 9, 0}));
        }
    }
}

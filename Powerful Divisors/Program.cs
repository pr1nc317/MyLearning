namespace Powerful_Divisors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> PowerfulDivisors(List<int> A)
        {
            int max = A.Max();
            // create factors array
            int[] factors = new int[max + 1];
            for (int i = 1; i <= max; i++)
            {
                for (int j = i; j <= max; j += i)
                {
                    factors[j]++;
                }
            }

            // check whether factors[i] is power of 2
            for (int i = 1; i <= max; i++)
            {
                int power = (int) (Math.Log(factors[i]) / Math.Log(2));
                if ((int)Math.Pow(2, power) == factors[i])
                {
                    factors[i] = 1;
                }
                else factors[i] = 0;
            }

            // set factors[i] as sum of its predecessors
            for (int i = 1; i < factors.Length; i++)
            {
                factors[i] += factors[i-1];   
            }

            for (int i = 0; i < A.Count; i++)
            {
                A[i] = factors[A[i]];
            }

            return A;
        }
        static void Main(string[] args)
        {
            //PowerfulDivisors(new List<int> { 42, 99, 15, 10 }).ForEach(x => Console.WriteLine(x));
            PowerfulDivisors(new List<int> { 10, 5 }).ForEach(x => Console.WriteLine(x));
        }
    }
}

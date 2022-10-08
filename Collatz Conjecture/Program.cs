namespace Collatz_Conjecture
{
    using System;

    class Program
    {
        public static long Solve(int A, int B)
        {
            int counter = 1;
            long res = A;
            while (counter < B)
            {
                counter++;
                if (res % 2 == 0)
                {
                    res /= 2;
                }
                else
                {
                    res *= 3;
                    res++;
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(141237625, 100000));
        }
    }
}

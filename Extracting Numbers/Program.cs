namespace Extracting_Numbers
{
    using System;

    class Program
    {
        public static long Solve(string A)
        {
            long sum = 0; long k = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 57 && A[i] >= 48)
                {
                    k = k * 10 + A[i]-48;
                }
                else
                {
                    sum += k;
                    k = 0;
                }
            }
            if (k != 0)
            {
                sum += k;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("123def3"));
        }
    }
}

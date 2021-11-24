namespace Verify_Prime
{
    using System;

    class Program
    {
        public static int IsPrime(int A)
        {
            int start;
            if (A == 1) return 0;
            for (start = 2; start <= Math.Sqrt(A); start++)
            {
                if (A % start == 0)
                {
                    return 0;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(9));
        }
    }
}
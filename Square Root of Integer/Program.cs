namespace Square_Root_of_Integer
{
    using System;

    class Program
    {
        public static int Sqrt(int A)
        {
            long start = 0;
            long end = A;
            while (start <= end)
            {
                long mid = (start + end) / 2;
                if (mid * mid == A) return (int)mid;
                else if (mid * mid > A)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            return (int)end;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sqrt(2147483647));
        }
    }
}

namespace Trailing_Zeroes
{
    using System;

    class Program
    {
        public static int Solve(int A)
        {
            int count = 0;
            while (A % 2 == 0)
            {
                A >>= 1;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(8));
        }
    }
}

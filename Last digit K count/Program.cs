namespace Last_digit_K_count
{
    using System;

    class Program
    {
        public static int Solve(int A, int B, int C)
        {
            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (A + i > B)
                {
                    return count;
                }
                if ((A + i) % 10 == C)
                {
                    count++;
                    A = A + i;
                    break;
                }
            }
            count += (B - A) / 10;
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(11, 11, 1));
        }
    }
}

namespace Bit_Flipping
{
    using System;

    class Program
    {
        public static int Solve(int A)
        {
            int ans = 0;
            int count = 0;
            while (A != 0)
            {
                int lsb = (A & 1);
                int temp = lsb ^ 1;
                temp <<= count;
                A >>= 1;
                count++;
                ans |= temp;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(5));
        }
    }
}

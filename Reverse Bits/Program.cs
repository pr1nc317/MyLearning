namespace Reverse_Bits
{
    using System;

    class Program
    {
        public static long Solve(long A)
        {
            //int pow = 31;
            //long ans = 0;
            //while (A != 0)
            //{
            //    if (A % 2 != 0)
            //    {
            //        ans += (long)Math.Pow(2, pow);
            //    }
            //    A >>= 1;
            //    pow--;
            //}
            //return ans;

            long ans = 0;
            for (int i = 0; i < 32; i++)
            {
                ans <<= 1;
                if ((A & (1 << i)) != 0)
                {
                    ans |= 1;
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(4));
        }
    }
}

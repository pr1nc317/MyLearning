namespace Sum_of_7_s_Multiple
{
    using System;

    class Program
    {
        public static long Solve(int A, int B)
        {
            int start = 0; int end = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % 7 == 0)
                {
                    start = i;
                    break;
                }
            }
            for (int i = B; i >= A; i--)
            {
                if (i % 7 == 0)
                {
                    end = i;
                    break;
                }
            }
            long multiplier = 1 + ((end - start) / 7);
            long ans = multiplier * (start + end) / 2;
            return ans;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Solve(6, 29));
            //Console.WriteLine(Solve(535238952, 936975509));
            //Console.WriteLine(Solve(46406, 46408));
            Console.WriteLine(Solve(8, 10));
        }
    }
}

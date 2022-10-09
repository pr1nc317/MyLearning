namespace _70_Climbing_Stairs
{
    using System;

    class Program
    {
        static int ClimbStairs(int n)
        {
            // Fibonacci Sequence
            int last = 1; int lastButOne = 0; int ans = 0;
            for (int i = 1; i <= n; i++)
            {
                ans = last + lastButOne;
                lastButOne = last;
                last = ans;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(5));
        }
    }
}

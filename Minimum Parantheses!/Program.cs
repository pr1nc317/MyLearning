namespace Minimum_Parantheses_
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            int i = 0; int count = 0;
            int ans = 0;
            while (i < A.Length)
            {
                if (count < 0 && A[i] == '(')
                {
                    ans += Math.Abs(count);
                    count = 0;
                }
                if (A[i] == '(')
                {
                    count++;
                }
                else count--;
                i++;
            }
            return ans + Math.Abs(count);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("())"));
        }
    }
}

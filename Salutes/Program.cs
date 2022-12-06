namespace Salutes
{
    using System;

    class Program
    {
        public static long CountSalutes(string A)
        {
            int rCount = 0;
            long ans = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '>')
                {
                    rCount++;
                }
                else
                {
                    ans += rCount;
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountSalutes("><><"));
        }
    }
}

namespace Round_Table
{
    using System;

    class Program
    {
        public static int Solve(int A)
        {
            int mod = 1000000007;
            var ans = 1L;
            for (int i = 1; i <= A; i++)
            {
                ans = (ans * i) % mod;
            }
            return (int)((ans * 2) % mod);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(1000));
        }
    }
}

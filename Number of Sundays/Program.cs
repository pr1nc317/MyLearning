namespace Number_of_Sundays
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(string A, int B)
        {
            var dict = new Dictionary<string, int>
            {
                { "Sunday", 1 }, { "Monday", 7 }, { "Tuesday", 6 }, { "Wednesday", 5 }, { "Thursday", 4 }, { "Friday", 3 }, { "Saturday", 2 }
            };
            int ans = 0;
            if (dict[A] > B)
            {
                return ans;
            }
            else
            {
                ans++;
                ans += (B - dict[A]) / 7;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("Sunday", 7));
        }
    }
}

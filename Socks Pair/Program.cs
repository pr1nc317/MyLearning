namespace Socks_Pair
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A)
        {
            var dict = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item] = 1;
                }
                else dict[item]++;
            }
            var sum = dict.Values.Select(x => x / 2).Sum();
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 2, 2, 2, 2 }));
        }
    }
}

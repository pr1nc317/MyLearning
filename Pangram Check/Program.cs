namespace Pangram_Check
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<string> A)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (var item in A)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    set.Add(item[i]);
                }
            }
            return set.Count == 26 ? 1 : 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<string> { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" }));
        }
    }
}

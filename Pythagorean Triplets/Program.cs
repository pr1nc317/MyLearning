namespace Pythagorean_Triplets
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(int A)
        {
            var dict = new Dictionary<int, int>();
            var count = 0;
            var squares = new List<int>();
            for (int i = 1; i <= A; i++)
            {
                var sq = i * i;
                squares.Add(sq);
                dict[sq] = i;
            }
            foreach (var a in squares)
            {
                foreach (var b in squares)
                {
                    if (a < b)
                    {
                        break;
                    }
                    if (dict.ContainsKey(a + b))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(976));
        }
    }
}

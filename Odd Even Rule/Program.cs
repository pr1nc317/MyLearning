namespace Odd_Even_Rule
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A, int B, int C)
        {
            if (B % 2 == 0)
            {
                return A.Where(x => x % 2 != 0).Count() * C;
            }
            else return A.Where(x => x % 2 == 0).Count() * C;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1,2,3}, 31, 100));
        }
    }
}

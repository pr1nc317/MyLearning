namespace Pascal_Triangle
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<List<int>> Solve(int A)
        {
            // Using the logic of nCr, we can find first element is nothing but nC0, then nC1 .... nCn
            // And nCr = (nCr-1 * (n - r + 1))/r

            var list = new List<List<int>>();

            for (int i = 0; i < A; i++)
            {
                var tempList = PascalTriangle(i);
                list.Add(tempList);
            }
            return list;
        }

        public static List<int> PascalTriangle(int A)
        {
            int prev = 1;
            var tempList = new List<int> { prev };
            for (int i = 1; i <= A; i++)
            {
                prev = (prev * (A - i + 1)) / i;
                tempList.Add(prev);
            }
            return tempList;
        }

        static void Main(string[] args)
        {
            Solve(4).ForEach(x => { x.ForEach(y => Console.Write(" " + y)); Console.WriteLine(); });
        }
    }
}

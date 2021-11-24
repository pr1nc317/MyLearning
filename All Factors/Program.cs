namespace All_Factors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> AllFactors(int A)
        {
            HashSet<int> ans = new HashSet<int>();
            int start;
            int end = A;
            for (start = 1; start < end; start++)
            {
                if (A % start == 0)
                {
                    ans.Add(start);
                    end = A / start;
                    ans.Add(end);
                }
            }
            var ans1 = ans.ToList();
            ans1.Sort();
            return ans1;
        }

        static void Main(string[] args)
        {
            AllFactors(82944).ForEach(x=>Console.WriteLine(x));
        }
    }
}

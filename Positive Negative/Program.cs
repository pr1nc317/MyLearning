namespace Positive_Negative
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Solve(List<int> A)
        {
            var ans = new List<int>();
            int neg = 0; int pos = 0;
            foreach (var item in A)
            {
                if (item < 0) neg++;
                else if (item > 0) pos++;
            }
            ans.Add(pos); ans.Add(neg);
            return ans;
        }
        static void Main(string[] args)
        {
            Solve(new List<int> { 1,2,0,-1}).ForEach(x => Console.WriteLine(x));
        }
    }
}

using System.Collections.Generic;

namespace BetweenTwoSets_HackerRank
{
    public class Program
    {
        public static int getTotalX(List<int> a, List<int> b)
        {
            int finalCount = 0;
            List<int> li = new List<int>();
            a.Sort(); b.Sort();
            for (int i = a[a.Count - 1]; i <= b[0]; i++)
            {
                int count = 0;
                foreach (var item in a)
                {
                    if (i % item == 0)
                    {
                        count++;
                    }
                }
                if (count==a.Count)
                {
                    li.Add(i);
                }
            }
            for (int i = 0; i < li.Count; i++)
            {
                int count = 0;
                foreach (var item in b)
                {
                    if (item % li[i] == 0)
                    {
                        count++;
                    }
                }
                if (count == b.Count)
                {
                    finalCount++;
                }
            }
            return finalCount;
        }

        static void Main(string[] args)
        {
            int output = getTotalX(new List<int>() { 4, 2 }, new List<int>() { 16, 32, 96 });
        }
    }
}

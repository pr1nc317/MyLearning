namespace Merge_Two_Sorted_Lists_II
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static void Merge(List<int> a, List<int> b)
        {
            int i = 0, j = 0;
            while (i < a.Count && j < b.Count)
            {
                if (a[i] <= b[j])
                {
                    i++;
                }
                else
                {
                    a.Insert(i, b[j]);
                    j++; i++;
                }
            }
            while (j < b.Count)
            { 
                a.Add(b[j]);
                j++; 
            }
        }

        static void Main(string[] args)
        {
            Merge(new List<int> { 2 }, new List<int> { 3, 5 });
        }
    }
}

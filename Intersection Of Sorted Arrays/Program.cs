namespace Intersection_Of_Sorted_Arrays
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static List<int> Intersect(List<int> A, List<int> B)
        {
            int i = 0, j = 0;
            var ans = new List<int>();
            while (i < A.Count && j < B.Count)
            {
                if (A[i] == B[j])
                {
                    ans.Add(A[i]);
                    i++; j++;
                }
                else if (A[i] < B[j]) { i++; }
                else if (A[i] > B[j]) { j++; }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Intersect(new List<int> { 1, 2, 3, 3, 4, 6 }, new List<int> { 3, 3, 5 }).ForEach(x => Console.WriteLine(x));
        }
    }
}

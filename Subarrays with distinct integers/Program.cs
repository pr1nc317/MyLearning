namespace Subarrays_with_distinct_integers
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {

        public static int Solve(List<int> A, int B)
        {
            return AtMostKDistinctSubArrays(A, B) - AtMostKDistinctSubArrays(A, B - 1);
        }

        public static int AtMostKDistinctSubArrays(List<int> A, int B)
        {
            int i = 0, j = 0;
            int count = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            while (i < A.Count)
            {
                if (dict.ContainsKey(A[i]))
                    dict[A[i]]++;
                else dict[A[i]] = 1;
                while (dict.Keys.Count > B)
                {
                    if (dict.ContainsKey(A[j]))
                        dict[A[j]]--;
                        if (dict[A[j]] == 0)
                            dict.Remove(A[j]);
                    j++;
                }
                count += i - j + 1;
                i++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1, 2, 1, 2, 3 }, 2));
            Console.WriteLine(Solve(new List<int> { 1, 2, 1, 3, 4 }, 3));
        }
    }
}

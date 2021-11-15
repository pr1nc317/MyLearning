namespace Wave_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Solution
    {
        public static List<int> Wave(List<int> A)
        {
            A.Sort();
            var ans = new List<int>();
            int i, j;
            for (i = 0, j = 1; j < A.Count; i += 2, j += 2)
            {
                ans.Add(A[j]);
                ans.Add(A[i]);
            }
            if (i < A.Count) ans.Add(A[i]);
            return ans;
        }

        public static void Main()
        {
            Wave(new List<int> { 1, 2, 3, 4, 5, 6, 7 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
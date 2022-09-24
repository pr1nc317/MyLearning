namespace _1337_The_K_Weakest_Rows_in_a_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static int[] KWeakestRows(int[][] mat, int k)
        {
            int[] ans = new int[k];
            List<int> temp = new List<int>();
            for (int i = 0; i < mat.Length; i++)
            {
                int ind = Array.FindIndex(mat[i], x => x == 0);
                if (ind >= 0) temp.Add(ind);
                else temp.Add(mat[i].Length);
            }
            int index = 0;
            while (index < k)
            {
                int weakest = temp.IndexOf(temp.Min());
                ans[index] = weakest;
                temp[weakest] = int.MaxValue;
                index++;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            KWeakestRows(new int[][] { new int[] { 1, 1, 0, 0, 0 },
                                       new int[] { 1, 1, 1, 1, 0 },
                                       new int[] { 1, 0, 0, 0, 0 },
                                       new int[] { 1, 1, 0, 0, 0 },
                                       new int[] { 1, 1, 1, 1, 1 }
                                                }, 3).ToList().ForEach(x => Console.WriteLine(x));
            KWeakestRows(new int[][] { new int[] { 1,0,0,0 },
                                       new int[] { 1,1,1,1 },
                                       new int[] { 1,0,0,0 },
                                       new int[] { 1,0,0,0 }
                                                }, 2).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
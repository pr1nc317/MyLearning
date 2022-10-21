namespace Sorted_Permutation_Rank
{
    using System;
    using System.Linq;

    class Program
    {
        public static int FindRank(string A)
        {
            #region Without LINQ
            //int length = A.Length;
            //int[] fact = new int[52];
            //fact[0] = 1;
            //for (int i = 1; i < 52; i++)
            //{
            //    fact[i] = (i * fact[i - 1]) % 1000003;
            //}
            //int[] chars = new int[256];
            //foreach (var item in A)
            //{
            //    chars[item - 65] = 1;
            //}
            //int ans = 0;
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < A[i] - 65; j++)
            //    {
            //        if (chars[j] == 1)
            //        {
            //            ans = (ans + fact[length - i - 1]) % 1000003;
            //        }
            //    }
            //    chars[A[i] - 65] = 0;
            //}
            //return ans + 1;
            #endregion

            #region With LINQ
            int length = A.Length;
            int[] fact = new int[52];
            fact[0] = 0;
            fact[1] = 1;
            for (int i = 2; i < 52; i++)
            {
                fact[i] = (i * fact[i - 1]) % 1000003;
            }
            int ans = 0;
            var sorted = A.OrderBy(x => x).ToList();
            for (int i = 0; i < length; i++)
            {
                int ind = sorted.IndexOf(A[i]);
                if (ind > 0)
                {
                    ans = (ans + (ind * fact[sorted.Count - 1]) % 1000003) % 1000003;
                }
                sorted.Remove(A[i]);
            }
            return ans + 1;
            #endregion
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindRank("acb"));
        }
    }
}

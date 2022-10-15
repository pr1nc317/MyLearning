namespace Product_of_All
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Solve(List<int> A)
        {
            #region O(n) space and time
            //int mod = 1000000007;
            //var ans = new List<int>();
            //long[] prefix = new long[A.Count];
            //prefix[0] = A[0] % mod;
            //long[] suffix = new long[A.Count];
            //suffix[suffix.Length - 1] = A[A.Count - 1] % mod;
            //for (int i = 1; i < prefix.Length; i++)
            //{
            //    prefix[i] = (prefix[i - 1] * A[i]) % mod;
            //}
            //for (int i = suffix.Length - 2; i >= 0; i--)
            //{
            //    suffix[i] = (suffix[i + 1] * A[i]) % mod;
            //}
            //for (int i = 0; i < A.Count; i++)
            //{
            //    if (i == 0)
            //    {
            //        ans.Add((int)(suffix[i + 1] % mod)); continue;
            //    }
            //    if (i == A.Count - 1)
            //    {
            //        ans.Add((int)(prefix[i - 1] % mod)); continue;
            //    }
            //    ans.Add((int) ((prefix[i - 1] * suffix[i + 1]) % mod));
            //}
            //return ans;
            #endregion
            #region O(n) time O(1) space
            int mod = 1000000007;
            var ans = new List<int>();
            long prefix = 1; long postfix = 1;
            ans.Add((int)prefix);
            // Calculating prefix array in place
            for (int i = 1; i < A.Count; i++)
            {
                prefix = (prefix * A[i - 1]) % mod;
                ans.Add((int)prefix);
            }
            // Calculating Answer (i.e. postfix * prefix) in place
            for (int i = A.Count - 1; i >= 0; i--)
            {
                ans[i] = (int)((postfix * ans[i]) % mod);
                postfix = (postfix * A[i]) % mod;
            }
            return ans;
            #endregion
        }
        static void Main(string[] args)
        {
            //Solve(new List<int> { 1, 2, 3, 4 }).ForEach(x => Console.Write(x + " "));
            Solve(new List<int> { 1, 756, 459, 533, 219, 48, 679, 680, 935, 384, 520, 831, 35, 54, 530, 672, 8, 384, 67, 418, 687, 589, 931, 847, 527, 92, 654, 416, 702, 911, 763, 263, 48, 737, 329, 633, 757, 992, 366, 248, 983, 723, 754, 652, 73, 632, 885, 273, 437, 767, 478, 238, 275, 360, 167, 487, 898, 910, 61, 905, 505, 517, 320, 987, 494, 267, 91, 948, 74, 501, 385, 278, 914, 530, 465, 941, 51, 762, 771, 828, 126, 16, 689, 869, 630, 737, 726, 1000, 889, 234, 307, 352, 514, 592, 846, 413, 842, 270, 416 }).ForEach(x=>Console.Write(x + " "));
        }
    }
}
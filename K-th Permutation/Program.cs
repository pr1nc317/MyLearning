namespace K_th_Permutation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> FindPerm(int A, long B)
        {
            #region works if A <= 9
            //var ans = new List<int>();
            //// Step 1 - formaulate factorial array
            //var fact = new int[10];
            //fact[0] = 1;
            //for (int i = 1; i < 10; i++)
            //{
            //    fact[i] = fact[i - 1] * i;
            //}
            //// Step 2 - formualte digits array
            //var digits = new List<int>();
            //for (int i = 1; i <= A; i++)
            //{
            //    digits.Add(i);
            //}
            //while (digits.Count > 1)
            //{
            //    // Step 3 - calculate index to be picked from digits list --> B/(A-1)!
            //    var index = B % fact[A - 1] == 0 ? B / fact[A - 1] - 1 : B / fact[A - 1];
            //    // Step 4 - add digits[index] to answer as most significant digit
            //    ans.Add(digits[(int)index]);
            //    // Step 5 - remove digits[index] from digits list
            //    digits.Remove(digits[(int)index]);
            //    // Step 6 - update B and A
            //    B -= (index * fact[A - 1]);
            //    A--;
            //}
            //ans.Add(digits[0]);
            //return ans;
            #endregion

            long[] fact = new long[21];
            fact[0] = 1;
            for (int i = 1; i <= 20; i++)
            {
                fact[i] = i * fact[i - 1];
            }
            List<int> ans = new List<int>();
            for (int i = 1; i <= A; i++)
            {
                ans.Add(0);
            }
            int curr = 0;
            for (int i = 0; i < A - 20; i++)
            {
                ans[i] = i + 1;
                curr = i;
            }
            List<int> l1 = new List<int>();
            for (int i = Math.Max(A - 20, 1); i <= A; i++)
            {
                l1.Add(i);
            }
            B--;
            for (int i = Math.Min(20, A - 1); i >= 0; i--)
            {
                int idx = (int)(B / fact[i]);
                B -= idx * fact[i];
                ans[curr++] = l1[idx];
                l1.Remove(l1[idx]);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            FindPerm(11,28).ForEach(x=>Console.WriteLine(x));
        }
    }
}

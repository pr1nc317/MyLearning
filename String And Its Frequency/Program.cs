namespace String_And_Its_Frequency
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static string Solve(string A)
        {
            #region Approach 1 - using dictionary to store char and its count
            //Dictionary<char, int> dict = new Dictionary<char, int>();
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (dict.ContainsKey(A[i]))
            //    {
            //        dict[A[i]]++;
            //    }
            //    else
            //    {
            //        dict.Add(A[i], 1);
            //    }
            //}
            //string ans = string.Empty;
            //foreach (var item in dict)
            //{
            //    ans += item.Key.ToString() + item.Value;
            //}
            //return ans;
            #endregion

            #region Approach 2 - using array
            var arr = new int[26];
            foreach (var item in A)
            {
                arr[item - 'a']++;
            }
            string res = string.Empty;
            foreach (var item in A)
            {
                if (arr[item - 'a'] > 0)
                {
                    res += item.ToString() + arr[item - 'a'];
                    arr[item - 'a'] = 0;
                }
            }
            return res;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("abbhuabcfghh"));
        }
    }
}

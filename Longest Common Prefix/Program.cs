namespace Longest_Common_Prefix
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static string LongestCommonPrefix(List<string> A)
        {
            string minLenStr = string.Empty;
            int minLen = int.MaxValue;
            foreach (var item in A)
            {
                if (item.Length < minLen)
                {
                    minLen = item.Length;
                    minLenStr = item;
                }
            }
            string res = string.Empty;
            int i = 0; int j = 0;
            for (i = 0; i < minLenStr.Length; i++)
            {
                for (j = 0; j < A.Count; j++)
                {
                    if (minLenStr[i] != A[j][i])
                    {
                        break;
                    }
                }
                if (j != A.Count) break;
                res += minLenStr[i];
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(new List<string> { "abcdefgh", "aefghijk", "abcefgh" }));
            Console.WriteLine(LongestCommonPrefix(new List<string> { "abab", "ab", "abcd" }));
        }
    }
}

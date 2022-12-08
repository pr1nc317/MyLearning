namespace Longest_Palindromic_Substring
{
    using System;

    class Program
    {
        public static string LongestPalindrome(string A)
        {
            #region Approach 1 - using DP - O(N^2) space and time
            //int n = A.Length;

            //// lets create a DP table for each character which is a palindrome
            //bool[,] dp = new bool[n, n];

            //// every string of length 1 is a palindrome
            //int maxLength = 1; // maintaining maxlength of a substring which is also a palindrome
            //for (int i = 0; i < n; i++)
            //{
            //    dp[i, i] = true;
            //}

            //// check for substrings of length = 2 which are palindromes and maintatin the starting index
            //int start = 0;
            //for (int i = 0; i < n - 1; i++)
            //{
            //    if (A[i] == A[i + 1])
            //    {
            //        dp[i, i + 1] = true;
            //        start = i;
            //        maxLength = 2;
            //    }
            //}

            //// check for substrings of length >= 3 which are substrings and palindromes
            //for (int k = 3; k <= n; k++)
            //{
            //    // starting index will be fixed
            //    for (int i = 0; i < n - k + 1; i++)
            //    {
            //        // last index will be:
            //        int j = i + k - 1;

            //        // check for palindromic substring A[i,j]
            //        if (A[i] == A[j] && dp[i + 1, j - 1] == true)
            //        {
            //            dp[i, j] = true;

            //            // update maxlength
            //            if (k > maxLength)
            //            {
            //                maxLength = k;
            //                start = i;
            //            }
            //        }
            //    }
            //}
            //return A.Substring(start, maxLength);
            #endregion


            #region Approach 2 - O(N^2) time and O(1) space
            //int start = 0;
            //int end = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int odd = Expand(A, i, i);
            //    int even = Expand(A, i, i + 1);

            //    int len = Math.Max(odd, even);

            //    if (len > end - start + 1)
            //    {
            //        start = i - ((len - 1) / 2);
            //        end = i + (len / 2);
            //    }
            //}
            //return A.Substring(start, end - start + 1);
            #endregion

            #region Approach 3 - Using Manacher's Algorithm - O(N) space and time
            string newStr = "#";
            for (int i = 0; i < A.Length; i++)
            {
                newStr += A[i] + "#";
            }
            
            int right = 0; int center = 0;
            int longestCenter = 0; int longestLength = 0;
            int[] p = new int[2 * A.Length + 1];
            for (int i = 0; i < newStr.Length; i++)
            {
                int mirror = 2 * center - i;
                if (right > i)
                {
                    p[i] = Math.Min(p[mirror], right - i);
                }

                int a = i + (p[i] + 1);
                int b = i - (p[i] + 1);

                while (b >= 0 && a < newStr.Length && newStr[a] == newStr[b])
                {
                    a++;
                    b--;
                    p[i]++;
                }

                if (i + p[i] > right)
                {
                    center = i;
                    right = i + p[i];
                }

                if (p[i] > longestLength)
                {
                    longestLength = p[i];
                    longestCenter = i;
                }
            }
            return newStr.Substring(longestCenter - longestLength, 2 * longestLength + 1).Replace("#", "");
            #endregion
        }

        public static int Expand(string A, int i, int j)
        {
            while (i >= 0 && j < A.Length && A[i] == A[j])
            {
                i--;
                j++;
            }
            return j - i - 1;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(LongestPalindrome("aaaabaaa"));
            Console.WriteLine(LongestPalindrome("abb"));
        }
    }
}

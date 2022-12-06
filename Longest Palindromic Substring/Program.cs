namespace Longest_Palindromic_Substring
{
    using System;

    class Program
    {
        public static string LongestPalindrome(string A)
        {
            #region Approach 1 - using DP
            int n = A.Length;

            // lets create a DP table for each character which is a palindrome
            bool[,] dp = new bool[n, n];

            // every string of length 1 is a palindrome
            int maxLength = 1; // maintaining maxlength of a substring which is also a palindrome
            for (int i = 0; i < n; i++)
            {
                dp[i, i] = true;
            }

            // check for substrings of length = 2 which are palindromes and maintatin the starting index
            int start = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    dp[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // check for substrings of length >= 3 which are substrings and palindromes
            for (int k = 3; k <= n; k++)
            {
                // starting index will be fixed
                for (int i = 0; i < n - k + 1; i++)
                {
                    // last index will be:
                    int j = i + k - 1;

                    // check for palindromic substring A[i,j]
                    if (A[i] == A[j] && dp[i + 1, j - 1] == true)
                    {
                        dp[i, j] = true;

                        // update maxlength
                        if (k > maxLength)
                        {
                            maxLength = k;
                            start = i;
                        }
                    }
                }
            }
            return A.Substring(start, maxLength);
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestPalindrome("aaaabaaa"));
        }
    }
}

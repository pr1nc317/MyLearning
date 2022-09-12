namespace _1839_LongestSubstringOfAllVowelsinOrder
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        #region RegEx
        //static int LongestBeautifulSubstring(string word)
        //{
        //    Console.WriteLine(word.Length);
        //    string pattern = @"(a+e+i+o+u+)";
        //    int len = 0;
        //    Regex regex = new Regex(pattern);
        //    if (!((word.Contains("a")) || (word.Contains("e")) || (word.Contains("i")) || (word.Contains("o")) || (word.Contains("u")))) return 0;
        //    var matches = regex.Matches(word);
        //    foreach (var item in matches)
        //    {
        //        if (item.ToString().Length > len) len = item.ToString().Length;
        //    }
        //    return len;
        //}
        #endregion

        #region If blocks
        static int LongestBeautifulSubstring(string word)
        {
            int len = 1;
            int count = 1;
            int maxLen = 0;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i - 1] == word[i]) len++;
                else if (word[i - 1] < word[i]) { len++; count++; }
                else { len = 1; count = 1; }

                if (count == 5)
                {
                    maxLen = Math.Max(len, maxLen);
                }
            }
            return maxLen;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine(LongestBeautifulSubstring("aeiou"));
        }
    }
}

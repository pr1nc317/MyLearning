namespace _3_Longest_Substring_Without_Repeating_Characters
{
    using System;
    using System.Text;

    class Program
    {
        static int LengthOfLongestSubstring(string s)
        {
            string temp = "";
            int count = 0; int maxLength = 0; int tempLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (temp.Contains(s[i]))
                {
                    int index = temp.IndexOf(s[i]) + tempLength;
                    temp = s.Substring(index + 1, i - index);
                    tempLength = index + 1;
                    count = i - index;
                }
                else
                {
                    count++;
                    temp += s[i];
                }
                if (maxLength < count) maxLength = count;
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("abbacbefbgh"));
            Console.WriteLine(LengthOfLongestSubstring("dvdfvrtet"));
            Console.WriteLine(LengthOfLongestSubstring("abadefbabc"));
            Console.WriteLine(LengthOfLongestSubstring("bbbbbbbb"));
            Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
        }
    }
}

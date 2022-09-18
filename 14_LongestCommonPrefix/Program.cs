namespace _14_LongestCommonPrefix
{
    using System;
    using System.Linq;

    class Program
    {
        static string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            bool match = true; int index = 0;
            string ans = "";
            while (match)
            {
                if (index < strs[0].Length && strs[0][index].Equals(strs[strs.Length - 1][index]))
                {
                    ans += strs[0][index];
                }
                else match = false;
                index++;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "abcd", "abdc", ""}));
        }
    }
}

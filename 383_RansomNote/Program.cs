namespace _383_RansomNote
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static bool CanConstruct(string ransomNote, string magazine)
        {
            bool ans = true;
            var list = new List<char>();
            for (int i = 0; i < magazine.Length; i++)
            {
                list.Add(magazine[i]);
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (list.Contains(ransomNote[i]))
                {
                    list[list.IndexOf(ransomNote[i])] = '_';
                    continue;
                }
                return false;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("abbb", "adcbgb"));
        }
    }
}

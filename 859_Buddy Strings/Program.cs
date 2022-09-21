namespace _859_Buddy_Strings
{
    using System;

    class Program
    {
        static bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length) return false;
            int errCount = 0; bool repeatingChar = false;
            int firstErrorIndex = 0; int secondErrorIndex = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!goal.Contains(s[i])) return false;
                if (i > 0)
                {
                    if (s.IndexOf(s[i]) < i)
                    {
                        repeatingChar = true;
                    }
                }
                if (s[i] != goal[i])
                {
                    errCount++;
                    _ = errCount == 1 ? firstErrorIndex = i : secondErrorIndex = i;
                }
                if (errCount > 2) return false;
            }
            if (errCount == 1) return false;
            else if (errCount == 0)
            {
                if (repeatingChar)
                {
                    return true;
                }
                else return false;
            }
            else
            {
                if (s[firstErrorIndex] == goal[secondErrorIndex] && s[secondErrorIndex] == goal[firstErrorIndex]) return true;
                else return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BuddyStrings("abab", "abab"));
        }
    }
}

namespace Frequency_Of_Characters
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Solve(string A)
        {
            var freq = new List<int>();
            for (int i = 0; i < 26; i++)
            {
                freq.Add(0);
            }
            foreach (var item in A)
            {
                freq[item - 'a']++;
            }
            return freq;
        }

        static void Main(string[] args)
        {
            Solve("abcdefghijklmnopqrstuvwxyz").ForEach(x => Console.Write(x + " "));
            Solve("interviewbit").ForEach(x => Console.Write(x + " "));
        }
    }
}

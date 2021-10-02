using System.Collections.Generic;

namespace BirthdayChocolate_HackerRank
{
    class Program
    {
        static int Birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i <= (s.Count - m); i++)
            {
                int sum = s[i], numcount = 1, increment = i;
                while (numcount < m & sum < d)
                {
                    increment++;
                    numcount++;
                    sum += s[increment];
                }
                if (numcount == m && sum == d)
                {
                    count++;
                }
                sum = numcount = 0;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int output = Birthday(new List<int>() { 1, 2, 1, 3, 2 }, 3, 2);
        }
    }
}
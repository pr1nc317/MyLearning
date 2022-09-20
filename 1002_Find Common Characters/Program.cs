namespace _1002_Find_Common_Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static IList<string> CommonChars(string[] words)
        {
            string shortest = words.Aggregate((x, y) => x.Length < y.Length ? x : y);
            int shortestIndex = Array.FindIndex(words, x => x == shortest);
            if (shortestIndex != 0)
            {
                var temp = words[0];
                words[0] = shortest;
                words[shortestIndex] = temp;
            }
            var ans = new List<string>();
            bool flag = false;
            for (int i = 0; i < shortest.Length; i++)
            {
                flag = false;
                for (int j = 1; j < words.Length; j++)
                {
                    if (words[j].Contains(shortest[i]))
                    {
                        flag = true;
                        int index = words[j].IndexOf(shortest[i]);
                        words[j] = words[j].Remove(index, 1);
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    ans.Add(shortest[i].ToString());
                }
            }
            return ans;
        }

        static void Main(string[] args)
        {
            CommonChars(new string[] { "cool", "lock", "cook" }).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}

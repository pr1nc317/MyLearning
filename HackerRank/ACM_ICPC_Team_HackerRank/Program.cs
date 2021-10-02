namespace ACM_ICPC_Team_HackerRank
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {
        /*
         * Complete the 'acmTeam' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts STRING_ARRAY topic as parameter.
         */

        public static List<int> AcmTeam(List<string> topic)
        {
            var result = new List<int>();
            int maximum = 0, numberOfTeams = 0;
            int totalTopicsCount = 0;
            for (int i = 0; i < topic.Count - 1; i++)
            {
                for (int j = i + 1; j < topic.Count; j++)
                {
                    totalTopicsCount =  Count(topic[i], topic[j]);
                    if(totalTopicsCount > maximum)
                    {
                        numberOfTeams = 1;
                        maximum = totalTopicsCount;
                    }
                    else if(totalTopicsCount == maximum)
                    {
                        numberOfTeams++;
                    }
                }
            }
            result.Add(maximum);
            result.Add(numberOfTeams);
            return result;
        }

        public static int Count(string a, string b)
        {
            int count = 0;
            for (int i = 0; i<a.Length; i++)
            {
                if(a[i] == '1' || b[i] == '1')
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //var lines = File.ReadAllLines(Environment.CurrentDirectory + @"/TextFile1.txt").ToList();
            //Console.WriteLine(Result.AcmTeam(lines));
            Console.WriteLine(Result.AcmTeam(new List<string> { "11101", "10101", "11001", "10111", "10000", "01110" }));
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int m = Convert.ToInt32(firstMultipleInput[1]);
            List<string> topic = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic.Add(topicItem);
            }
            List<int> result = Result.AcmTeam(topic);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}

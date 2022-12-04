namespace Justified_Text
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<string> FullJustify(List<string> A, int B)
        {
            var ans = new List<string>();
            int j = 0;
            bool isLastLine = false;
            for (int i = 0; i < A.Count; )
            {
                int wordlen = A[i].Length;
                while (wordlen <= B)
                {
                    i++;
                    if (i < A.Count)
                        wordlen += A[i].Length + 1;
                    else
                    {
                        isLastLine = true;
                        break;
                    }
                }
                string temp = string.Empty;
                while (j < i)
                {
                    if (j != i - 1) temp += A[j] + " ";
                    else temp += A[j];
                    j++;
                }
                if (isLastLine)
                {
                    while (temp.Length != B)
                    {
                        temp += " ";
                    }
                    ans.Add(temp);
                    return ans;
                }
                else
                {
                    if (temp.Length != B)
                        temp = AddSpaces(temp, B);
                    ans.Add(temp);
                }
            }
            return ans;
        }

        public static string AddSpaces(string temp, int totalLength)
        {
            var arr = temp.Split(" ");
            int tempLen = temp.Length;
            int spacesToAdd = totalLength - tempLen;
            if (arr.Length == 1)
            {
                while (arr[0].Length != totalLength)
                {
                    arr[0] += " ";
                }
                return arr[0];
            }
            if (arr.Length > 1)
            {
                while (spacesToAdd > 0)
                {
                    for (int i = 0; i < arr.Length - 1 && spacesToAdd > 0; i++)
                    {
                        arr[i] += " ";
                        spacesToAdd--;
                    }
                }
            }
            return string.Join(" ", arr);
        }

        static void Main(string[] args)
        {
            //FullJustify(new List<string> { "This", "is", "an", "example", "of", "text", "justification." }, 16).ForEach(x => Console.WriteLine(x));
            //FullJustify(new List<string> { "An", "apple", "a", "day", "keeps", "a", "doctor", "away" }, 8).ForEach(x => Console.WriteLine(x));
            //FullJustify(new List<string> { "We", "are", "practicing", "coding", "on", "the", "web", "at", "night" }, 16).ForEach(x => Console.WriteLine(x));
            //FullJustify(new List<string> { "Slow", "and", "steady", "wins", "the", "race." }, 9).ForEach(x => Console.WriteLine(x));
            //FullJustify(new List<string> { "glu", "muskzjyen", "ahxkp", "t", "djmgzzyh", "jzudvh", "raji", "vmipiz", "sg", "rv", "mekoexzfmq", "fsrihvdnt", "yvnppem", "gidia", "fxjlzekp", "uvdaj", "ua", "pzagn", "bjffryz", "nkdd", "osrownxj", "fvluvpdj", "kkrpr", "khp", "eef", "aogrl", "gqfwfnaen", "qhujt", "vabjsmj", "ji", "f", "opihimudj", "awi", "jyjlyfavbg", "tqxupaaknt", "dvqxay", "ny", "ezxsvmqk", "ncsckq", "nzlce", "cxzdirg", "dnmaxql", "bhrgyuyc", "qtqt", "yka", "wkjriv", "xyfoxfcqzb", "fttsfs", "m" }, 144).ForEach(x => Console.WriteLine(x));
            FullJustify(new List<string> { "zoea", "cmdw", "l", "bxcyofzw", "jwzr", "kwjpyevjxq", "queigj", "xf", "abighmqbtf", "txjysly", "fqcxvxokgm", "uc", "fefqtpkd", "ctbv", "pmgrbggjq", "henz", "zubxjlxodp", "yhxhl", "rii", "rxribedfv", "tywrhilgsb", "xz" }, 36).ForEach(x => Console.WriteLine(x));
        }
    }
}
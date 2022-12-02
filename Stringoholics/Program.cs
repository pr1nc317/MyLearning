namespace Stringoholics
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        //https://www.youtube.com/watch?v=sgPtsR6UnKs&ab_channel=BroCoders
        public static int Solve(List<string> A)
        {
            // Use KMP to create rotation array
            int mod = 1000000007;
            long[] arr = new long[A.Count];
            for (int i = 0; i < A.Count; i++)
            {
                int[] lps = new int[A[i].Length];
                lps[0] = 0;
                int j = 1;
                int len = 0;
                while (j < A[i].Length)
                {
                    if (A[i][j] == A[i][len])
                    {
                        len++;
                        lps[j] = len;
                        j++;
                    }
                    else
                    {
                        if (len != 0)
                        {
                            len = lps[len - 1];
                        }
                        else
                        {
                            lps[j] = len;
                            j++;
                        }
                    }
                }
                long length = A[i].Length - lps[lps.Length - 1];
                long finalLength = A[i].Length;
                if (finalLength % length == 0)
                {
                    finalLength = length;
                }
                long op = 1;
                long sum = 1;
                while (true)
                {
                    if (sum % finalLength == 0)
                        break;
                    else
                    {
                        op++; sum += op;
                    }
                }
                arr[i] = op;
            }
            // Find out LCM using prime factorization
            Dictionary<long, long> dict = new Dictionary<long, long>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j * j <= arr[i]; j++)
                {
                    int count = 0;
                    while (arr[i] % j == 0)
                    {
                        count++;
                        arr[i] /= j;
                    }
                    if (count > 0)
                    {
                        if (!dict.ContainsKey(j))
                            dict.Add(j, count);
                        else
                            dict[j] = Math.Max(dict[j], count);
                    }
                }
                if (arr[i] > 1)
                {
                    if (!dict.ContainsKey(arr[i]))
                        dict.Add(arr[i], 1);
                    else
                        dict[arr[i]] = Math.Max(dict[arr[i]], 1);
                }
            }
            long lcm = 1;
            foreach (var item in dict)
            {
                lcm = (lcm * Power(item.Key, item.Value, mod)) % mod;
            }
            return (int)lcm;
        }

        public static long Power(long a, long b, int mod)
        {
            long x = 1;
            if (b == 0) return 1;
            if (b == 1) return a;
            if (b % 2 == 1) x = a % mod;
            long temp = Power(a, b / 2, mod);
            return (x * ((temp * temp) % mod)) % mod;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Solve(new List<string> { "a", "ababa", "aba" }));
            //Console.WriteLine(Solve(new List<string> { "a", "aa" }));
            Console.WriteLine(Solve(new List<string> { "ababbbbb", "ba", "bbaaba", "baaa", "babbaaaaaa", "babbbbaba" }));

            Console.WriteLine(Solve(new List<string> { "baaaaaaabbaaababbababbabbabaaabaaaabaa", "bbaabbaabaabbb", "aaabaaabaababbabbbbbbabbbbbaaaaaaaaaaaababbababababaaaaabbabaabaabbbbbaaababbbbbbabbabbbbaab", "abbbaabbababbbbababbbaababaaabaaabbbbaabbabaaaabababaaaaaaaabaaaabbbabbbaaa", "aabaabbaaaaaaaaaaaaabbababbabbabbbbbbabbabbbbbbabbaaaaaab", "baabbbbabababbaaabbbbaaaaaaababaabbabaaaababbabbaabbabbbaabbabbaaaabbbbbaabbaababaabbb", "bbaabbbabaabbbaaaabbbaabbabaabbbabaaababbaaaabbababaaaababaaababaababbbbbabbbababbbbb", "bbababaaaaababababbabaaabbbababaabbaabaaba", "bbbaabaaaaaabaabbaabaaaaababaaabaababbabaabbab", "babaabababbbbabaabaaababbabbbaaaabbbbbabbbaabbbbbbbbabbaaabbabbbaaab", "aabbabbaaabbaaabbabbbaaaabaab", "abababbbbbaabaabbabbbabbaba", "abaaababababaabbabaabbbbbaababaaaaabbaabbaaabbbbbabababbbaabbabbbbaaaaabbabaabb", "bbbabbbababaaabbaaaaaabbabbaabbbabbbababbbbbaabaababbbabaaaabbbbab", "aaabbaa", "abbabaaabbbbabbaaaabbbbbbabaabaaaaaaaaaabbbbaaaaaab", "bbbabaabbabaababbabaaaaaaabaaaabbbbabbbaba", "aba", "ababbabbabaabbaaabbbaaabbbbbaa", "bbaaaabbaaa", "bbbbbbaabababaabaabbbabbaaabaaabbbabaabaaaaaaabbaaabaa", "bababbaabbbaabbaaaaaabbbbbabaabbaabbabababbaaaaaababababbaabaaababaaaababababbababaaaba", "baaaaabbbbbbababbbbaaaabbabbbbbbabbaaabbbbbbabbbaaaaaabbabbaaabababbaabbbabbbabbabbbbbab", "bbababbaaaaabaabbbababbbbaaab", "aabaaab", "abbbab", "aaabbbaaabbbabaababaabbbabbbbaabaaabbaababaa", "aaabbabbabbbaaaaabaababaaaabbaabababba", "b", "babbabbbbbbbabbbbbabbbbaaaaabbbaaaaabbaabbabababaaaaabaabaaaabbabbaaaaabba", "babaaaaaab", "abbabbbababaaaaabababbaabaaaaaba", "aaaabbbbabbaabaaaabbabbaabaaaabaababaaabbbbb", "bbbabbaaababbababbabaabaaa", "aabbbaabbbaabbaaabbaabbbbbbbbbabbbabababaababaaabaabbbbaaababbbbbaabbaabbabaaaabab", "babbbbabbbaaaaabbaabbaaaaaababbbababaaabaababbaaaabbaabaaabbbaabbbaababbbbaaaaaaaaaaabaabbbbb", "abbbbabaaabaaaabaabaabaabbbbaabbbaaaabbaaaaaaabbaababbabbbababa", "baababaabaaababbaaaaaabbabaaabbbbb", "baababaaa", "bbabbababaaabaaabbbbabbaabbabbaabbaabba", "aabbaabababbbaaaababbbaaaaabbbabbaaaabababbbbbbbaabbbbbbbaaabbaabaabaaaabbbbababbbaaaabbabab", "abbaaaaabaaaabbbbaabaababbaabbbbbabbbabaabaaabbabbbabaaabbbaaabbababbabbbaaabbabbbbabbbbaabba", "aaababbbaabaabaaabbbbbaaababaaaababbbaaabaabbaabbbabaababaabaaab", "baaababbbaababbabaabbbbbbaababaaababbbaabaaabbaabababaaabaabbabbbbabaaba", "babaabbabaabaaaaaabbbbabbbbabbaababbbaaaaaaaa", "abaaa", "babaaaababbbbababbbbb", "abbaaaaaabbbabbaabbbbaaabbbaaabababaabaabbbbabbaababbaba", "aababaaabaaaabbaaaabababbbabbbabbbabbabaabbaaaabbbabaaabaaabbaabbaababbaaabbbb", "aaababbbbbbabbaabbaabbbabababaabbbaba", "bbaabbabbbabbaaaaaababbbaaaaaabbbababb", "baaababaababbaaa", "babbaaababbabbbbbbbbabbbbabbabababaabaaaa", "ababababababaabbbabbbbaabaabaababbbabbbbaabbaaababbaabaa", "abbbabaaaabaaaaabbaaababaaaaaabbbbaaaaabbbbbbbbbbbbbababaabaaababbaaaabbbaaabbbaaabaaa", "aaaabbababbabbbaabaabbabbabaabbabababbbbaaaabbabbbaaaabaaaabbbbbbababbaabaabbaaabaaa", "aabaaaabbbbaabbbbbbbbabaabbbabbabaabaababaaabbbbbaaaababb", "abbbbbabaaababbabbababbabaaabbabababaaabbaabaaabbaabbabaababaaaaaabababaaabaababbaa", "abbabbbbabaaababbabaaaaaaabbbbababababbabbababaabbabbabbbab", "bbbbabbab", "babbbbabbbabababbbbababaababbbbabaaababbabaaaaabbbbaaababbbbaabbabbbaaaabbabbabba", "babaaabbbbbbababaabbaaababbbabbabaabbaaabbbaaabbababb", "abbbaabaaaaaabaaaaabaabbbaabbab", "bbaabbabaabaaaaaaababbbabaaaabbbabbbbb", "baabaabaaabababbbbbbbbabbaabbabaabbabaababbbabbbaababbbbbbaabbabbbbaabaabbababa", "bbbbbaaababbbbaababbbbbaabbbaaaabbbabbbababababaaabbbbabababbabbbabababaaaaaab", "abaaabaabbaabbbaabbbaaaaaabababbabbaababbba", "abaabbbbbbaaababbbabaaaabaaabaabbaaaababbabbbaaabaaaaaaaaaaaabbabbabbabaaabbabaabaaaaaaabaabbabbbaa", "abababaaaaaaaaaabab", "abbabbbbbbbbbaabbbbabaaaaaababbabbaaabbbbbaabbbaaaabaabbaaaabababbb", "baaabaaabbbbbb", "aaabaabbabaaabbbaababaaabbbbbaabaaabbbabba", "bbbbabaaaabaaabbbabaababaabbbbbababbbabbaaaabbbababaabbabbaaabbbbaaaaabbabbbbbaabbabaaaa", "aabbbbaabaabbbabbbaabababbbbbbabbbabaabaabbbbbaabaaabbbaaabbbbaaaabbaabaaaabaabbbbbaaaabababab", "abbbaaaaababbbaaabbabaaaabbabaabbbbbbbabaaa", "babbbbbbbb" }));
        }
    }
}
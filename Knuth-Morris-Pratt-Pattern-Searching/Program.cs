namespace Knuth_Morris_Pratt_Pattern_Searching
{
    using System;

    class Program
    {
        //https://www.youtube.com/watch?v=V5-7GzOfADQ&list=PLDN4rrl48XKpZkf03iYFl-O29szjTrs_O&index=76&ab_channel=AbdulBari
        static void KnuthMorrisPratt(string txt, string pat)
        {
            int M = pat.Length;
            int N = txt.Length;
            // lps array - lps indicates longest proper prefix which is also suffix
            int[] lps = new int[M];
            CreateLPSArray(lps, pat);
            int i = 0; // for txt
            int j = 0; // for pat
            while ((N - i) >= (M - j))
            {
                if (pat[j] == txt[i])
                {
                    i++;
                    j++;
                }
                if (j == M)
                {
                    Console.WriteLine("Pattern found at index: {0}", i - j);
                    j = lps[j - 1];
                }
                else if (i < N && pat[j] != txt[i])
                {
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        static void CreateLPSArray(int[] lps, string pat)
        {
            lps[0] = 0;
            int i = 1;
            int len = 0;
            while (i < pat.Length)
            {
                if (pat[i] == pat[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            //KnuthMorrisPratt("AAAAABAAABA", "AAAA");
            KnuthMorrisPratt("ABABDABACDABABCABAB", "ABABCABAB");
        }
    }
}

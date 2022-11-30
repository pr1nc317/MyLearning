namespace Rabin_Karp_Pattern_Searching
{
    using System;

    class Program
    {
        // https://www.youtube.com/watch?v=qQ8vS2btsxI&list=PLDN4rrl48XKpZkf03iYFl-O29szjTrs_O&index=75
        static void RabinKarp(string pat, string txt)
        {
            #region GFG implementation
            //// any prime number can be used as a modulus factor
            //int mod = 101;
            //int m = pat.Length;
            //int n = txt.Length;
            //// hash for pattern
            //int p = 0;
            //// hash for text
            //int t = 0;
            //// hasing factor
            //int h = 1;
            //// base value for hashing
            //int d = 256;
            //// hashing factor should be d^(m-1)%mod
            //int i, j;
            //for (i = 1; i <= m-1; i++)
            //{
            //    h = (h * d) % mod;
            //}
            //// calculate hash value of pattern and first window of text
            //for (i = 0; i < m; i++)
            //{
            //    p = (d *p + pat[i]) % mod;
            //    t = (d * t + txt[i]) % mod;
            //}
            //// traverse the text
            //for (i = 0; i <= n - m; i++)
            //{
            //    // if hashes of pattern and text are equal, check whether each index of pattern matches the text
            //    if (p == t)
            //    {
            //        for (j = 0; j < m; j++)
            //        {
            //            if (txt[j+i] != pat[j])
            //            {
            //                break;
            //            }
            //        }

            //        if (j == m)
            //        {
            //            Console.WriteLine("Pattern found at index: {0}", i);
            //        }
            //    }
            //    // calculate text hash after sliding the window to include next character and remove the leading character
            //    if (i < n - m)
            //    {
            //        t = (d * (t - txt[i] * h) + txt[i + m]) % mod;

            //        if (t < 0) t = t + mod;
            //    }
            //}
            #endregion

            #region self implementation
            // any prime number can be used as a modulus factor
            int mod = 101;
            int m = pat.Length;
            int n = txt.Length;
            // hash for pattern
            int p = 0;
            // hash for text
            int t = 0;
            // base value for hashing
            int d = 10;
            int i, j;
            // calculate hash value of pattern and first window of text
            for (i = 0; i < m; i++)
            {
                p = ((int)Math.Pow(d, m - 1 - i) * pat[i] + p) % mod;
                t = ((int)Math.Pow(d, m - 1 - i) * txt[i] + t) % mod;
            }
            // traverse the text
            for (i = 0; i <= n - m; i++)
            {
                // if hashes of pattern and text are equal, check whether each index of pattern matches the text
                if (p == t)
                {
                    for (j = 0; j < m; j++)
                    {
                        if (txt[j + i] != pat[j])
                        {
                            break;
                        }
                    }

                    if (j == m)
                    {
                        Console.WriteLine("Pattern found at index: {0}", i);
                    }
                }
                // calculate text hash after sliding the window to include next character and remove the leading character
                if (i < n - m)
                {
                    t = (d * (t - txt[i] * (int)Math.Pow(d, m-1)) + txt[i + m]) % mod;

                    if (t < 0) t = t + mod;
                }
            }
            #endregion
        }

        static void Main(string[] args)
        {
            string pattern = "abc"; string text = "bcabcbbegbscabcd";
            RabinKarp(pattern, text);
        }
    }
}

namespace Implement_StrStr
{
    using System;

    class Program
    {
        public static int StrStr(string A, string B)
        {
            int M = B.Length;
            int N = A.Length;
            // lps array - lps indicates longest proper prefix which is also suffix
            int[] lps = new int[M];
            CreateLPSArray(lps, B);
            int i = 0; // for txt
            int j = 0; // for pat
            bool flag = false;
            while ((N - i) >= (M - j))
            {
                if (B[j] == A[i])
                {
                    i++;
                    j++;
                }
                if (j == M)
                {
                    flag = true;
                    break;
                    j = lps[j - 1];
                }
                else if (i < N && B[j] != A[i])
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
            return flag ? i - j : -1;
        }

        static void CreateLPSArray(int[] lps, string B)
        {
            lps[0] = 0;
            int i = 1;
            int len = 0;
            while (i < B.Length)
            {
                if (B[i] == B[len])
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
            //Console.WriteLine(StrStr("strstr", "str"));
            //Console.WriteLine(StrStr("bighit", "bit"));
            Console.WriteLine(StrStr("bbbbbbbbab", "baba"));
        }
    }
}

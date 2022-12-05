namespace Minimum_Appends_for_Palindrome_
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            var arr = A.ToCharArray();
            Array.Reverse(arr);
            string str = new string(arr) + "$" + A;
            int[] lps = new int[str.Length];
            int len = 0;
            int i = 1;
            while (i < str.Length)
            {
                if (str[i] == str[len])
                {
                    len++;
                    lps[i] = len;
                    i++;
                }
                else
                {
                    if (len == 0)
                    {
                        lps[i] = 0;
                        i++;
                    }
                    else
                    {
                        len = lps[len - 1];
                    }
                }
            }
            return A.Length - lps[lps.Length - 1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("aaede"));
        }
    }
}

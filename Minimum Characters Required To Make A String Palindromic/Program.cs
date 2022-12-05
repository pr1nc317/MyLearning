namespace Minimum_Characters_Required_To_Make_A_String_Palindromic
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            var arr = A.ToCharArray();
            Array.Reverse(arr);
            var str = A + "$" + new string(arr);
            
            //KMP on str
            int i = 1;
            int len = 0;
            int[] lps = new int[str.Length];
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
            Console.WriteLine(Solve("ABC"));
            Console.WriteLine(Solve("AACECAAAA"));
            Console.WriteLine(Solve("babb"));
            Console.WriteLine(Solve("bbabc"));
            Console.WriteLine(Solve("hqghumeaylnlfdxfi"));
            Console.WriteLine(Solve("eylfpbnpljvrvipyamyehwqnq"));
            Console.WriteLine(Solve("aabcbaaa"));
            Console.WriteLine(Solve("abcdba"));
        }
    }
}

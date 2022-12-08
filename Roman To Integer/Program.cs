namespace Roman_To_Integer
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int RomanToInt(string A)
        {
            var dict = new Dictionary<char, int>
            { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            int num = 0; int lastnum = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (dict[A[i]] < lastnum) num -= dict[A[i]];
                else num += dict[A[i]];
                lastnum = dict[A[i]];
            }
            return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMLVI"));
        }
    }
}
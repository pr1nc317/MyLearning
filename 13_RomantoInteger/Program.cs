namespace _13_RomantoInteger
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            int integer = dict[s[s.Length - 1]];
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (dict[s[i]] < dict[s[i + 1]]) integer -= dict[s[i]];
                else integer += dict[s[i]];
            }
            return integer;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MMMCMXCIX"));
        }
    }
}

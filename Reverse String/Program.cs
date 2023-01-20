namespace Reverse_String
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static string ReverseString(string A)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in A)
            {
                st.Push(c);
            }
            string ans = string.Empty;
            while (st.Count > 0)
            {
                ans += st.Pop();
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("abc"));
        }
    }
}

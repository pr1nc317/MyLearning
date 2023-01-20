namespace Balanced_Parantheses_
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Solve(string A)
        {
            Stack<char> st = new Stack<char>();
            foreach (char c in A)
            {
                if (c == '(')
                {
                    st.Push(')');
                }
                else
                {
                    if (st.Count == 0) return 0;
                    else st.Pop();
                }
            }
            return st.Count == 0 ? 1 : 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("(()())"));
            Console.WriteLine(Solve("(()"));
        }
    }
}

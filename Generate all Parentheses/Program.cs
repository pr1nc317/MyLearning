namespace Generate_all_Parentheses
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int IsValid(string A)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '(' || A[i] == '{' || A[i] == '[')
                {
                    st.Push(A[i]);
                }
                else
                {
                    if (st.Count > 0)
                    {
                        var pop = st.Pop();
                        if (IsValidPair(pop, A[i]))
                            continue;
                        else return 0;
                    }
                    else return 0;
                }
            }
            return st.Count == 0 ? 1 : 0;
        }

        public static bool IsValidPair(char a, char b)
        {
            if (a == '(' && b == ')') return true;
            if (a == '{' && b == '}') return true;
            if (a == '[' && b == ']') return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("(())"));
            Console.WriteLine(IsValid("([)]"));
            Console.WriteLine(IsValid("([]()"));
            Console.WriteLine(IsValid("([]()){([])}"));
        }
    }
}

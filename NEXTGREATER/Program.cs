namespace NEXTGREATER
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        public static List<int> NextGreater(List<int> A)
        {
            var ans = new int[A.Count];
            Stack<int> stack = new Stack<int>();
            for (int i = A.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= A[i])
                {
                    stack.Pop();
                }
                if (stack.Count == 0) ans[i] = -1;
                else ans[i] = stack.Peek();
                stack.Push(A[i]);
            }
            return ans.ToList();
        }

        static void Main(string[] args)
        {
            NextGreater(new List<int> { 4, 5, 2, 10 }).ForEach(x => Console.WriteLine(x));
            NextGreater(new List<int> { 3, 2, 1 }).ForEach(x => Console.WriteLine(x));
        }
    }
}
namespace Nearest_Smaller_Element
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static List<int> PrevSmaller(List<int> A)
        {
            Stack<int> stack = new Stack<int>();
            var res = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count > 0 && A[i] <= stack.Peek())
                {
                    stack.Pop();
                }
                if (stack.Count == 0) res.Add(-1);
                else res.Add(stack.Peek());
                stack.Push(A[i]);
            }
            return res;
        }

        static void Main(string[] args)
        {
            PrevSmaller(new List<int> { 3, 2, 1 }).ForEach(x => Console.WriteLine(x));
            PrevSmaller(new List<int> { 4, 5, 2, 10, 8 }).ForEach(x => Console.WriteLine(x));
        }
    }
}

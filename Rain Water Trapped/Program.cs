namespace Rain_Water_Trapped
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Trap(List<int> A)
        {
            int res = 0;
            var stack = new Stack<int>();
            for (int i = 0; i < A.Count; i++)
            {
                while (stack.Count > 0 && A[i] > A[stack.Peek()])
                {
                    var popped = stack.Pop();
                    if (stack.Count == 0) break;
                    res += (Math.Min(A[stack.Peek()], A[i]) - A[popped]) * (i - stack.Peek() - 1);
                }
                stack.Push(i);
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Trap(new List<int> { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));  // 6
            Console.WriteLine(Trap(new List<int> { 3, 0, 2, 0, 4 }));  // 7
            Console.WriteLine(Trap(new List<int> { 1, 0, 0, 3, 1, 0, 1, 4 }));  // 9
            Console.WriteLine(Trap(new List<int> { 1, 2, 3, 2, 1 }));  // 0
        }
    }
}

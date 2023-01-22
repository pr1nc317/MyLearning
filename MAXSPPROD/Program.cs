namespace MAXSPPROD
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int MaxSpecialProduct(List<int> A)
        {
            var nextGreaterIndexInRight = NextGreaterIndexInRight(A);
            var nextGreaterIndexInLeft = NextGreaterIndexInLeft(A);
            long ans = -1;
            for (int i = 0; i < A.Count; i++)
            {
                ans = Math.Max(ans, nextGreaterIndexInLeft[i] * 1L * nextGreaterIndexInRight[i]);
            }
            return (int)(ans % 1000000007);
        }

        public static int[] NextGreaterIndexInRight(List<int> A)
        {
            int[] res = new int[A.Count];
            Stack<int> stack = new Stack<int>();
            for (int i = A.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && A[i] >= A[stack.Peek()])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                    res[i] = 0;
                else res[i] = stack.Peek();
                stack.Push(i);
            }
            return res;
        }

        public static int[] NextGreaterIndexInLeft(List<int> A)
        {
            int[] res = new int[A.Count];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= A.Count - 1; i++)
            {
                while (stack.Count > 0 && A[i] >= A[stack.Peek()])
                {
                    stack.Pop();
                }
                if (stack.Count == 0)
                    res[i] = 0;
                else res[i] = stack.Peek();
                stack.Push(i);
            }
            return res;
        }

        static void Main(string[] args)
        {
            var ans = NextGreaterIndexInLeft(new List<int> { 332896250, 35162660, 497001273, 540482880, 41006712, 208758167, 127719043, 161483505, 63512730, 180062613 });
            foreach (int i in ans) { Console.WriteLine(i); } // 0 0 0 0 3
            var ans1 = NextGreaterIndexInRight(new List<int> { 332896250, 35162660, 497001273, 540482880, 41006712, 208758167, 127719043, 161483505, 63512730, 180062613 });
            foreach (int i in ans1) { Console.WriteLine(i); }
            //Console.WriteLine(MaxSpecialProduct(new List<int> { 6, 8, 0, 1, 4, 2, 5, 9 }));
        }
    }
}

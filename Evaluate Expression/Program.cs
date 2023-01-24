namespace Evaluate_Expression
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    internal class Program
    {
        public static int EvalRPN(List<string> A)
        {
            Stack<string> stack = new Stack<string>();
            if (A.Count == 1) return Convert.ToInt32(A[0]);
            for (int i = 0; i < A.Count; i++)
            {
                while (A[i] != "+" && A[i] != "-" && A[i] != "*" && A[i] != "/")
                {
                    stack.Push(A[i]);
                    i++;
                    continue;
                }
                var num2 = Convert.ToInt32(stack.Pop());
                var num1 = Convert.ToInt32(stack.Pop());
                int res = 0;
                switch (A[i])
                {
                    case "+":
                        res = num1 + num2;
                        break;
                    case "-":
                        res = num1 - num2;
                        break;
                    case "*":
                        res = num1 * num2;
                        break;
                    case "/":
                        res = num1 / num2;
                        break;
                }
                stack.Push(res.ToString());
            }
            return Convert.ToInt32(stack.Peek());
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(EvalRPN(new List<string> { "2", "1", "+", "3", "*" }));
            //Console.WriteLine(EvalRPN(new List<string> { "4", "13", "5", "/", "+" }));
            //Console.WriteLine(EvalRPN(new List<string> { "17", "13", "5", "5", "*", "5", "+", "-", "/" }));
            Console.WriteLine(EvalRPN(new List<string> { "17" }));
        }
    }
}

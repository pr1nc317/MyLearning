namespace Min_Stack
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        #region Approach 1 - Using modified Node class to store minValue and nodeValue
        public class Node
        {
            public int val;
            public int min;
            public Node(int x, int minimum) { val = x; min = minimum; }
        }

        public static Stack<Node> stack = new Stack<Node>();

        public static void Push(int x)
        {
            if (stack.Count == 0)
            {
                stack.Push(new Node(x, x));
                return;
            }
            int y = Math.Min(stack.Peek().min, x);
            stack.Push(new Node(x, y));
        }

        public static void Pop()
        {
            if (stack.Count == 0) return;
            stack.Pop();
        }

        public static int Top()
        {
            if (stack.Count == 0) return -1;
            return stack.Peek().val;
        }

        public static int GetMin()
        {
            if (stack.Count == 0) return -1;
            return stack.Peek().min;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Min : " + GetMin());
            Console.WriteLine("Top : " + Top());
            Push(1); Console.WriteLine("Top : " + Top());
            Push(2); Console.WriteLine("Top : " + Top());
            Push(3); Console.WriteLine("Top : " + Top());
            Push(4); Console.WriteLine("Top : " + Top());
            Push(5); Console.WriteLine("Top : " + Top());
            Console.WriteLine("Min : " + GetMin());
            Push(0); Console.WriteLine("Min : " + GetMin());
            Pop(); Console.WriteLine("Min : " + GetMin());
            Console.WriteLine("Top : " + Top());
            Pop(); Console.WriteLine("Top : " + Top());
            Pop(); Console.WriteLine("Top : " + Top());
        }
    }
}

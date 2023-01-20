namespace Redundant_Braces
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        public static int Braces(string A)
        {
            /*
             * We iterate through the given expression and for each character in the expression
             * if the character is an open parenthesis ‘(‘ or any of the operators or operands, we push it to the stack.
             * If the character is close parenthesis ‘)’, then pop characters from the stack till matching open parenthesis ‘(‘ is found.
             * Now for redundancy two conditions will arise while popping.
             * If immediate pop hits an open parenthesis ‘(‘, then we have found a duplicate parenthesis. 
             * For example, (((a+b))+c) has duplicate brackets around a+b. When we reach the second “)” after a+b, 
             * we have “((” in the stack. Since the top of the stack is an opening bracket, we conclude that there are duplicate brackets. 
             * If immediate pop doesn’t hit any opertor (‘*’, ‘+’, ‘/’, ‘-‘) then it indicates the presence of unwanted brackets 
             * surrounded by expression. For instance, (a)+b contains unwanted () around a thus it is redundant.  
             */
            Stack<char> stack = new Stack<char>();
            StringBuilder temp = new StringBuilder();
            int i = 0;
            while (i < A.Length)
            {
                while (i < A.Length && A[i] != ')')
                {
                    stack.Push(A[i]);
                    i++;
                }
                // when A[i] == ')' pop until open bracket is reached
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    temp.Insert(0, stack.Pop());
                }
                if (stack.Count > 0)
                    stack.Pop();
                if (temp.Length == 0 || !StringContainsOperator(temp.ToString()))
                    return 1;
                temp.Clear();
                i++;
            }
            return 0;
        }

        public static bool StringContainsOperator(string A)
        {
            if (A.Contains("+") || A.Contains("-") || A.Contains("*") || A.Contains("/"))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Braces("((a+b))"));
            Console.WriteLine(Braces("(a+(a+b))"));
            Console.WriteLine(Braces("((a*b)+(c+d))"));
            Console.WriteLine(Braces("((a*b)+(c+d)*(d-e)*f*g)"));
            Console.WriteLine(Braces("(((a*b))+c+d*d-e*f*g)"));
            Console.WriteLine(Braces("a*b+c+d*d-e*f*g"));
        }
    }
}

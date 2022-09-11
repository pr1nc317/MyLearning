namespace _20_ValidParentheses
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        /*
         DESCRIPTION:
            Write a function that takes a string of parentheses, and determines if the order of the parentheses is valid. 
            The function should return true if the string is valid, and false if it's invalid.

            Examples
            "()"              =>  true
            ")(()))"          =>  false
            "("               =>  false
            "(())((()())())"  =>  true
            Constraints
            0 <= input.length <= 100
        ([])
        */

        static bool IsValid(string input)
        {
            #region One Type of Bracket
            //string input = "(())((()())())";
            //var arr= input.ToCharArray();
            //int count = 0;
            //foreach (var item in arr)
            //{
            //    if (item.ToString().Equals("(")) count++;
            //    else count--;
            //}
            //if (count == 0) return true;
            //else return false;
            #endregion

            #region Multiple Brackets
            List<string> list = new List<string>();
            string opp = null;
            string lastInput = null;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().Equals(")")) opp = "(";
                if (input[i].ToString().Equals("}")) opp = "{";
                if (input[i].ToString().Equals("]")) opp = "[";
                if (input[i].ToString().Equals(")") || input[i].ToString().Equals("}") || input[i].ToString().Equals("]"))
                {
                    if (lastInput != opp)
                        return false;
                    int index = list.LastIndexOf(opp);
                    if (index == -1) return false;
                    list.RemoveAt(index);
                    lastInput = list.Count == 0 ? null : list[list.Count - 1];
                }
                else
                {
                    list.Add(input[i].ToString());
                    lastInput = input[i].ToString();
                }
            }
            if (list.Count == 0) return true;
            else return false;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("{[}]"));
        }
    }
}

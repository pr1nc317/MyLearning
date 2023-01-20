namespace Simplify_Directory_Path
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        public static string SimplifyPath(string A)
        {
            #region Personal Approach but TLE
            //Stack<string> st = new Stack<string>();
            //int i = 0;
            //while (i < A.Length && !IsValidChar(A[i]))
            //    i++;
            //if (i == A.Length) return "/";
            //StringBuilder temp = new StringBuilder("/" + A[i]); i++;
            //while (i < A.Length)
            //{
            //    while (i < A.Length && A[i] != '/')
            //    {
            //        temp.Append(A[i]);
            //        i++;
            //    }
            //    if (temp.Length > 0)
            //    {
            //        if (temp.ToString() == "..")
            //        {
            //            if (st.Count > 0)
            //                st.Pop();
            //        }
            //        else if (temp.ToString() == ".")
            //        {

            //        }
            //        else 
            //        {
            //            if (temp[0] == '/')
            //                st.Push(temp.ToString());
            //            else st.Push("/" + temp.ToString());
            //        }
            //    }
            //    i++;
            //    temp.Clear();
            //}
            //StringBuilder strb = new StringBuilder();
            //while (st.Count > 0)
            //{
            //    strb.Insert(0, st.Pop());
            //}
            //return strb.ToString();
            #endregion

            #region IB Solution
            var list = A.Split("/", StringSplitOptions.RemoveEmptyEntries);
            LinkedList<string> path = new LinkedList<string>();
            foreach (var item in list)
            {
                if (item == ".") continue;
                if (item == "..")
                {
                    if (path.Count > 0) path.RemoveLast(); continue;
                }
                path.AddLast(item);
            }
            return "/" + String.Join("/", path.ToArray());
            #endregion
        }

        public static bool IsValidChar(char A)
        {
            if ((A - 97 >= 0 && A - 97 <= 25) || (A - 65 >= 0 && A - 65 <= 25))
                return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SimplifyPath("/home//foo"));
        }
    }
}

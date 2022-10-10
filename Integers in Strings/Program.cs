namespace Integers_in_Strings
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Solve(string A)
        {
            #region Easy Solution using split function
            //var split = A.Split(',');
            //var ans = new List<int>();
            //foreach (var item in split)
            //{
            //    ans.Add(Convert.ToInt32(item));
            //}
            //return ans;
            #endregion
            #region Without using inbuilt function
            var ans = new List<int>();
            int num = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != ',')
                {
                    num = num * 10 + Convert.ToInt32(A[i].ToString());
                }
                else
                {
                    ans.Add(num);
                    num = 0;
                }
            }
            ans.Add(num);
            return ans;
            #endregion
        }
        static void Main(string[] args)
        {
            Solve("1,2,3,99").ForEach(x => Console.WriteLine(x));
        }
    }
}

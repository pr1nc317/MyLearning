namespace Occurence_of_Each_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> FindOccurences(List<int> A)
        {
            #region Solution 1

            //A.Sort();
            //var list = new List<int>();
            //int count = 0;
            //int i, j;
            //for (i = 0, j = 0; j < A.Count; j++)
            //{
            //    if (A[i] == A[j])
            //    {
            //        count++;
            //        continue;
            //    }
            //    list.Add(count);
            //    count = 1;
            //    i = j;
            //}
            //list.Add(count);
            //return list;

            #endregion

            #region Solution 2

            A.Sort();
            var list = new List<int> { 1 };
            for (int i = 1; i < A.Count; i++)
            {
                if (A[i] != A[i-1])
                {
                    list.Add(1);
                }
                else
                {
                    list[list.Count - 1]++;
                }
            }
            return list;

            #endregion
        }

        static void Main(string[] args)
        {
            FindOccurences(new List<int> { 3,1,2,3}).ForEach(x => Console.Write(x + " "));
        }
    }
}
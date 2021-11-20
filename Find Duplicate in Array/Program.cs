namespace Find_Duplicate_in_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int RepeatedNumber(List<int> A)
        {
            #region Solution 1 - Using Dictionary
            //int n = A.Count;
            //var dict = new Dictionary<int, bool>();
            //for (int i = 0; i < n; i++)
            //{
            //    if (dict.ContainsKey(A[i]))
            //        return A[i];
            //    dict.Add(A[i], false);
            //}
            //return -1;
            #endregion

            #region Using bool array
            bool[] flagArray = new bool[A.Count];
            for (int i = 0; i < A.Count; i++)
            {
                if (flagArray[A[i] - 1])
                {
                    return A[i];
                }
                flagArray[A[i] - 1] = true;
            }
            return -1;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedNumber(new List<int> { 2, 4, 3, 1, 0 }));
        }
    }
}

namespace Move_Zeroes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> MoveZeroes(List<int> A)
        {
            #region Solution 1 - LINQ
            //int numberOfZeros = A.Count(x => x == 0);
            //A.RemoveAll(x => x == 0);
            //A.AddRange(Enumerable.Repeat(0, numberOfZeros));
            //return A;
            #endregion

            #region Solution 2 - A little faster than Solution 1
            int i = 0, j = 0;
            while (j < A.Count)
            {
                if (A[j] != 0)
                {
                    var t = A[i];
                    A[i] = A[j];
                    A[j] = t;
                    i++;
                }

                j++;
            }
            return A;
            #endregion
        }

        static void Main(string[] args)
        {
            MoveZeroes(new List<int> { 0,1,2,0,0,3,5,77,4,0}).ForEach(x=>Console.WriteLine(x));
        }
    }
}

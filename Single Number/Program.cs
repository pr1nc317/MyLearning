namespace Single_Number
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int SingleNumber(List<int> A)
        {
            int temp = A[0];
            for (int i = 1; i < A.Count; i++)
            {
                if (i % 2 == 0)
                    temp -= A[i];
                else temp += A[i];
            }
            return Math.Abs(temp);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber(new List<int> { 1, 2, 2, 3, 1 }));
            Console.WriteLine(SingleNumber(new List<int> { 1, 2, 2 }));
            Console.WriteLine(SingleNumber(new List<int> { 1 }));
        }
    }
}

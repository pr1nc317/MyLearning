namespace Next_Permutation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> NextPermutation(List<int> A)
        {
            int i, j;

            // First find the smallest number from end of the list
            for (i = A.Count - 2; i >= 0; i--)
            {
                if (A[i] < A[i + 1])
                    break;
            }

            // If smallest number is not find, return the reverse or sort of the given list
            if (i == -1)
            {
                A.Sort();
                return A;
            }

            // Now find a number larger than the smallest number which we found above again from the end of the list
            for (j = A.Count - 1; j > 0; j--)
            {
                if (A[j] > A[i])
                    break;
            }

            // Swap these 2 numbers
            int temp = A[j];
            A[j] = A[i];
            A[i] = temp;

            // Sort the in between numbers and the return the list
            var tempList = A.GetRange(i + 1, A.Count - (i + 1));
            A.RemoveRange(i + 1, A.Count - (i + 1));
            tempList.Sort();
            A.AddRange(tempList);
            return A;
        }

        static void Main(string[] args)
        {
            NextPermutation(new List<int> { 1, 1, 1, 2, 3, 5, 9, 8, 7, 6 }).ForEach(x => Console.WriteLine(x));
        }
    }
}

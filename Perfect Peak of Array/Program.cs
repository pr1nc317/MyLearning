namespace Perfect_Peak_of_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int PerfectPeak(List<int> A)
        {
            int n = A.Count;
            int[] left = new int[n];
            int[] right = new int[n];
            left[0] = A[0];
            right[n - 1] = A[n - 1];

            // Calculate max of i and i+1 index from the start of the list A and store it in left array
            for (int i = 1; i < A.Count; i++)
            {
                left[i] = Math.Max(A[i], left[i - 1]);
            }

            // Calculate max of i and i-1 index from the end of the list A and store it in right array
            for (int i = n-2; i >= 0; i--)
            {
                right[i] = Math.Min(A[i], right[i + 1]);
            }

            // Check if there is any element at any index which is greater than left array but smaller than right array
            for (int i = 1; i < n -1; i++)
            {
                if (A[i] > left[i-1] && A[i] < right[i+1]) return 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PerfectPeak(new List<int> { 5706, 26963, 24465, 29359, 16828, 26501, 28146, 18468, 9962, 2996, 492, 11479, 23282, 19170, 15725, 6335 }));
        }
    }
}
namespace MergeSort
{
    using System;

    class Program
    {
        public static void MergeSort(int[] array)
        {
            int n = array.Length;

            // Base condition to return from recursion
            if (n == 1) return;

            // Creating sub-arrays
            int[] left = new int[n / 2];
            int[] right = new int[n - n / 2];
            for (int i = 0; i < n / 2; i++)
            {
                left[i] = array[i];
            }
            for (int i = n / 2; i <= n - 1; i++)
            {
                right[i - n / 2] = array[i];
            }

            // Recursive Calls
            MergeSort(left);
            MergeSort(right);

            // Joining the results
            Merging(left, right, array);
        }

        static void Merging(int[] left, int[] right, int[] finalArray)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    finalArray[k] = left[i];
                    i++;
                }
                else
                {
                    finalArray[k] = right[j];
                    j++;
                }
                k++;
            }
            while (j < right.Length)
            {
                finalArray[k] = right[j];
                j++;
                k++;
            }
            while (i < left.Length)
            {
                finalArray[k] = left[i];
                i++;
                k++;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 12, 33, 3, 1, 71, 17, 3, 19 };
            MergeSort(array);
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

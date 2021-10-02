namespace QuickSort
{
    using System;

    class Program
    {
        static void QuickSort(int[] array, int start, int end)
        {
            if (start >= end) return;
            int pivotIndex = Partitioning(array, start, end);
            QuickSort(array, start, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, end);
        }

        static int Partitioning(int[] array, int start, int end)
        {
            int pivotIndex = start;
            int pivot = array[end];
            for (int i = start; i <= end - 1; i++)
            {
                if (array[i] <= pivot)
                {
                    int temp = array[i];
                    array[i] = array[pivotIndex];
                    array[pivotIndex] = temp;
                    pivotIndex++;
                }
            }
            int temp1 = array[pivotIndex];
            array[pivotIndex] = array[end];
            array[end] = temp1;
            return pivotIndex;
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 12, 33, 3, 1, 71, 17, 3, 19 };
            QuickSort(array, 0, array.Length - 1);
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

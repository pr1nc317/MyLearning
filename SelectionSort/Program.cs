namespace SelectionSort
{
    using System;

    class Program
    {
        public static void SelectionSort(int[] array)
        {
            for (int iteration = 0; iteration <= array.Length - 2; iteration++)
            {
                int minIndex = FindMin(iteration, array);
                Swap(array, iteration, minIndex);
            }
        }

        static int FindMin(int pivot, int[] array)
        {
            for (int i = pivot + 1; i <= array.Length - 1; i++)
            {
                if (array[i] < array[pivot])
                {
                    pivot = i;
                }
            }
            return pivot;
        }

        static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 12, 33, 3, 1, 71, 17, 3, 19 };
            SelectionSort(array);
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

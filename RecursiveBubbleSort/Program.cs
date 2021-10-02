namespace RecursiveBubbleSort
{
    using System;

    class Program
    {
        public static void BubbleSort(int[] array, int n)
        {
            int i = 0;
            int temp;

            // To return from recursion mechanism
            if (n == 1)
            {
                return;
            }

            // 1st improvement
            // Below line is commented to prevent unnecessary while loops because in every pass we will have a sorted array at the end of the array
            // while (i <= array.Length - 2)
            while (i <= n-2)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
                i++;
            }

            BubbleSort(array, n - 1);            
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 12, 33, 3, 1, 71, 17, 3, 19 };
            BubbleSort(array, array.Length);
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

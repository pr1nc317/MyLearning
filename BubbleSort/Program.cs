namespace BubbleSort
{
    using System;

    class Program
    {
        public static void BubbleSort(int[] array)
        {
            int i;
            int temp;
            for (int iteration = 0; iteration <= array.Length-2; iteration++)
            {
                bool ifSwapped = false;
                i = 0;

                // 1st improvement
                // Below line is commented to prevent unnecessary while loops because in every pass we will have a sorted array at the end of the array
                // while (i <= array.Length - 2)
                while (i <= array.Length - 2 - iteration)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                        ifSwapped = true;
                    }
                    i++;
                }

                // 2nd improvement
                // Breaks out of the loop if array is already sorted (helps improving the time complexity)
                if (!ifSwapped)
                    break;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 12, 33, 3, 1, 71, 17, 3, 19};
            BubbleSort(array);
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

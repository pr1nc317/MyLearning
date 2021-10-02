namespace InsertionSort
{
    using System;

    class Program
    {
        public static void InsertionSort(int[] array)
        {
            for (int i = 0; i <= array.Length-2; i++)
            {
                int j = i + 1;
                int value = array[i + 1];
                while (j > 0 && array[j - 1] > value)
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = value;
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 5, 12, 33, 3, 1, 71, 17, 3, 19 };
            InsertionSort(array);
            foreach (var item in array)
            {
                Console.Write(item + "\t");
            }
        }
    }
}

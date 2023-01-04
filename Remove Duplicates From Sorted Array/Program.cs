namespace Remove_Duplicates_From_Sorted_Array
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int RemoveDuplicates(List<int> a)
        {
            int i = 0, j = 1;
            for (; j < a.Count; j++)
            {
                if (!a[j].Equals(a[i]))
                {
                    a[++i] = a[j];
                }
            }
            while (a.Count > i + 1)
            {
                a.RemoveAt(a.Count - 1);
            }
            return a.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }));
        }
    }
}

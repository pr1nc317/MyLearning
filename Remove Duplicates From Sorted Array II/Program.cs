namespace Remove_Duplicates_From_Sorted_Array_II
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int RemoveDuplicates(List<int> a)
        {
            int i = 0, j = 1;
            int dupCount = 1;
            for (; j < a.Count; j++)
            {
                if (a[j].Equals(a[i]))
                {
                    if (j - i > 1 && dupCount == 1)
                    {
                        a[i + 1] = a[j];
                    }
                    dupCount++;
                }
                else
                {
                    if (dupCount >= 2) i += 2;
                    else i++;
                    a[i] = a[j];
                    dupCount = 1;
                }
            }
            if (dupCount > 1)
                i++;
            while (a.Count > i + 1)
            {
                a.RemoveAt(a.Count - 1);
            }
            return a.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates(new List<int> { 1, 1, 1, 1, 1, 2, 2, 2, 3, 3, 3 }));
            Console.WriteLine(RemoveDuplicates(new List<int> { 1, 1, 2, 2, 3, 3 }));
            Console.WriteLine(RemoveDuplicates(new List<int> { 1, 2, 3 }));
            Console.WriteLine(RemoveDuplicates(new List<int> { 1000, 1000, 1000, 1000, 1001, 1002, 1003, 1003, 1004, 1010 }));
        }
    }
}

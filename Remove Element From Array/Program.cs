namespace Remove_Element_From_Array
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int RemoveElement(List<int> a, int b)
        {
            int i = 0;
            for (int j = 0; j < a.Count; j++)
            {
                if (a[j] != b)
                {
                    a[i] = a[j];
                    i++;
                }
            }
            while (a.Count > i)
            {
                a.RemoveAt(a.Count - 1);
            }
            return a.Count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveElement(new List<int> { 4, 1, 1, 2, 1, 3 }, 1));
        }
    }
}

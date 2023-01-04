namespace Sort_By_Color
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static void SortColors(List<int> a)
        {
            int i = 0, j = a.Count - 1;
            for (; i < j;)
            {
                if (a[i] == 2)
                {
                    a.RemoveAt(i);
                    a.Add(2);
                    j--;
                }
                else i++;
                if (a[j] == 0)
                {
                    a.RemoveAt(j);
                    a.Insert(0, 0);
                    i++;
                }
                else j--;
            }
        }

        static void Main(string[] args)
        {
            SortColors(new List<int> { 2, 1, 2, 1, 2 });
        }
    }
}

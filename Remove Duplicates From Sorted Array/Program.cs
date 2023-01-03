namespace Remove_Duplicates_From_Sorted_Array
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int RemoveDuplicates(List<int> a)
        {
            int i = 0, j = 1;
            int ans = 0;
            while (i < a.Count && j < a.Count)
            {
                if (a[j] == a[i])
                {
                    j++;
                    ans++;
                }
                else
                {
                    if (j - i > 1)
                    {
                        a.RemoveRange(i + 1, j - i - 1);
                        i++;
                        j = i + 1;
                    }
                    else
                    {
                        i++;
                        j++;
                    }
                }
            }
            if (j - i > 1)
            {
                a.RemoveRange(i + 1, j - i - 1);
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicates(new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 }));
        }
    }
}

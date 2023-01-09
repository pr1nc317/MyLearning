namespace Max_Continuous_Series_Of_1s
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static List<int> Maxone(List<int> A, int B)
        {
            int i = 0, j = 0;
            int flip = 0; int maxDiff = int.MinValue;
            int resI = 0, resJ = 0;
            var ans = new List<int>();
            while (i < A.Count)
            {
                if (A[i] == 0)
                    flip++;
                while (flip > B)
                {
                    if (A[j] == 0)
                        flip--;
                    j++;
                }
                if (i - j + 1 > maxDiff)
                {
                    maxDiff = i - j + 1;
                    resI = i; resJ = j;
                }
                i++;
            }
            for (j = resJ; j <= resI; j++)
            {
                ans.Add(j);
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Maxone(new List<int> { 1, 1, 0, 1, 1, 0, 0, 1, 1, 1 }, 1).ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Maxone(new List<int> { 1, 0, 0, 0, 1, 0, 1 }, 2).ForEach(x => Console.WriteLine(x));
        }
    }
}

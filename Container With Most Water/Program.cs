namespace Container_With_Most_Water
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int MaxArea(List<int> A)
        {
            int i = 0, j = A.Count - 1;
            int maxArea = 0;
            while (i < j)
            {
                int area = (j - i) * Math.Min(A[i], A[j]);
                if (area > maxArea)
                {
                    maxArea = area;
                }
                if (A[i] < A[j]) i++;
                else j--;
            }
            return maxArea;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaxArea(new List<int> { 1, 5, 4, 3 }));
            Console.WriteLine(MaxArea(new List<int> { 8, 5, 9, 1, 10, 2, 6 }));
        }
    }
}

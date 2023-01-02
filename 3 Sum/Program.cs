namespace _3_Sum
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int ThreeSumClosest(List<int> A, int B)
        {
            /*
             * Sort the input list. Fix 1 number. Then loop across the rest of the collection using 2 pointer technique 
             * and find the two numbers which when added with the first (fixed) number is closest to B. Return their sum.
             */
            A.Sort();
            long minDiff = long.MaxValue;
            for (int i = 0; i < A.Count - 2; i++)
            {
                int first = A[i];
                int k = A.Count - 1;
                int j = i + 1;
                for (; j < A.Count - 1;)
                {
                    for (; k > j;)
                    {
                        int sum = first + A[j] + A[k];
                        long diff = B - sum;
                        if (diff == 0) return sum;
                        if (Math.Abs(diff) < Math.Abs(minDiff))
                            minDiff = diff;
                        if (sum < B) j++;
                        else if (sum > B) k--;
                    }
                    if (j == k)
                        break;
                }
            }
            return B - (int)minDiff;
        }

        static void Main(string[] args)
        {
            //2:
            Console.WriteLine(ThreeSumClosest(new List<int> { -1, 2, 1, -4 }, 1));
            //6:
            Console.WriteLine(ThreeSumClosest(new List<int> { 3, 2, 1 }, 6));
            //-1:
            Console.WriteLine(ThreeSumClosest(new List<int> { -5, 1, 4, -7, 10, -7, 0, 7, 3, 0, -2, -5, -3, -6, 4, -7, -8, 0, 4, 9, 4, 1, -8, -6, -6, 0, -9, 5, 3, -9, -5, -9, 6, 3, 8, -10, 1, -2, 2, 1, -9, 2, -3, 9, 9, -10, 0, -9, -2, 7, 0, -4, -3, 1, 6, -3 }, -1));
            //5:
            Console.WriteLine(ThreeSumClosest(new List<int> { 5, -2, -1, -10, 10 }, 5));
        }
    }
}

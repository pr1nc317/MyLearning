namespace Maximum_Consecutive_Gap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int MaximumGap(List<int> A)
        {
            int n = A.Count;
            int maxGap = 0;

            // calculate max and min
            int max = A.Max();
            int min = A.Min();

            // find interval
            int interval = (int)Math.Ceiling((double)(max - min) / (n - 1));

            // create buckets and fill them
            int[] bucketMax = new int[n - 1];
            int[] bucketMin = new int[n - 1];
            Array.Fill(bucketMax, int.MinValue);
            Array.Fill(bucketMin, int.MaxValue);

            for (int i = 0; i < n; i++)
            {
                if (A[i] == max || A[i] == min) continue;
                int index = (A[i] - min) / interval;
                bucketMax[index] = Math.Max(A[i], bucketMax[index]);
                bucketMin[index] = Math.Min(A[i], bucketMin[index]);
            }

            // traverse through bucket and find the maximum gap by subtracting minimum of a bucket by maximum of previous bucket
            int prev = min; // for processing minumum of first bucket
            for (int i = 0; i < bucketMax.Length; i++)
            {
                if (bucketMax[i] == int.MinValue && bucketMin[i] == int.MaxValue) continue;
                maxGap = Math.Max(bucketMin[i] - prev, maxGap);
                prev = bucketMax[i];
            }
            maxGap = Math.Max(max - prev, maxGap); // for processing maximum of last bucket
            return maxGap;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaximumGap(new List<int> { 3, 6, 11 }));
        }
    }
}

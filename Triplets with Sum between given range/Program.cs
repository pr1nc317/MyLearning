namespace Triplets_with_Sum_between_given_range
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<string> A)
        {
            #region Solution 1
            //int n = A.Count;
            //double[] arr = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = Convert.ToDouble(A[i]);
            //}

            //double a = arr[0], b = arr[1], c = arr[2];
            
            //for (int i = 3; i < n; i++)
            //{
            //    if (a + b + c > 1 && a + b + c < 2)
            //        return 1;
            //    else if (a+b+c > 2)
            //    {
            //        if (a > b && a > c)
            //            a = arr[i];
            //        else if (b > a && b > c)
            //            b = arr[i];
            //        else
            //            c = arr[i];
            //    }
            //    else
            //    {
            //        if (a < b && a < c)
            //            a = arr[i];
            //        else if (b < a && b < c)
            //            b = arr[i];
            //        else
            //            c = arr[i];
            //    }
            //}

            //if (a + b + c > 1 && a + b + c < 2)
            //    return 1;
            //else return 0;
            #endregion

            #region Solution 2
            List<double> parsedval = new List<double>();
            for (int i = 0; i < A.Count; i++)
            {
                parsedval.Add(Convert.ToDouble(A[i]));
            }
            List<double> firstBucket = new List<double>();
            List<double> secondBucket = new List<double>();
            List<double> thirdBucket = new List<double>();
            for (int i = 0; i < parsedval.Count; i++)
            {
                if (parsedval[i] < (double)2 / 3)
                {
                    firstBucket.Add(parsedval[i]);
                }
                else
                if (parsedval[i] >= (double)2 / 3 && parsedval[i] <= 1)
                {
                    secondBucket.Add(parsedval[i]);
                }
                else if (parsedval[i] > 1 && parsedval[i] < 2)
                {
                    thirdBucket.Add(parsedval[i]);
                }
            }
            firstBucket.Sort();
            secondBucket.Sort();
            thirdBucket.Sort();

            if (firstBucket.Count >= 3 && (firstBucket[firstBucket.Count - 1] + firstBucket[firstBucket.Count - 2] + firstBucket[firstBucket.Count - 3] >= 1))
            {
                return 1;
            }
            if (firstBucket.Count >= 2 && thirdBucket.Count >= 1 && (firstBucket[0] + firstBucket[0] + thirdBucket[0] <= 2))
            {
                return 1;
            }
            if (firstBucket.Count >= 1 && secondBucket.Count >= 2 && (firstBucket[0] + secondBucket[0] + secondBucket[1] <= 2))
            {
                return 1;
            }
            if (firstBucket.Count >= 1 && secondBucket.Count >= 1 && thirdBucket.Count >= 1 && (firstBucket[0] + secondBucket[0] + thirdBucket[0] <= 2))
            {
                return 1;
            }
            if (firstBucket.Count >= 2 && secondBucket.Count >= 1 && (firstBucket[firstBucket.Count - 1] + firstBucket[firstBucket.Count - 2] + secondBucket[0] < 2) && (firstBucket[firstBucket.Count - 1] + firstBucket[firstBucket.Count - 2] + secondBucket[0] > 1))
            {
                return 1;
            }
            if (firstBucket.Count >= 2 && secondBucket.Count >= 1 && (firstBucket[0] + firstBucket[1] + secondBucket[secondBucket.Count - 1] > 1) && (firstBucket[0] + firstBucket[1] + secondBucket[secondBucket.Count - 1] < 2))
            {
                return 1;
            }
            return 0;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<string> { "0.1", "0.3", "0.2", "1.2", "0.4" }));
        }
    }
}

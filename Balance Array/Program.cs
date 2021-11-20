namespace Balance_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A)
        {
            #region SOlution 1
            //int n = A.Count;
            //int sumEven = 0; int sumOdd = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (i%2==0)
            //    {
            //        sumEven += A[i];
            //    }
            //    else
            //    {
            //        sumOdd += A[i];
            //    }
            //}

            //int kEven = 0, kOdd = 0, ans = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (i%2==0)
            //    {
            //        if (sumEven - A[i] - kEven + kOdd == sumOdd - kOdd + kEven)
            //            ans++;
            //        kEven += A[i];
            //    }
            //    else
            //    {
            //        if (sumOdd - A[i] - kOdd + kEven == sumEven - kEven + kOdd)
            //            ans++;
            //        kOdd += A[i];
            //    }
            //}
            //return ans;
            #endregion

            #region Solution 2
            int n = A.Count;
            int sum1 = 0, sum2 = 0;

            // sum even and odd elements
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 += A[i];
                }
                else
                {
                    sum2 += A[i];
                }
            }

            int result = 0;
            int prev1 = 0, prev2 = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int even = prev1 + (sum2 - prev2);
                    int odd = prev2 + (sum1 - prev1 - A[i]);

                    if (odd == even)
                    {
                        result++;
                    }

                    prev1 += A[i];
                }
                else
                {
                    int even = prev1 + (sum2 - prev2 - A[i]);
                    int odd = prev2 + (sum1 - prev1);

                    if (odd == even)
                    {
                        result++;
                    }

                    prev2 += A[i];
                }
            }
            return result;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1,2,1,1}));
        }
    }
}

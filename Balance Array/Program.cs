namespace Balance_Array
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A)
        {
            int n = A.Count;
            int sumEven = 0; int sumOdd = 0;
            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    sumEven += A[i];
                }
                else
                {
                    sumOdd += A[i];
                }
            }

            int kEven = 0, kOdd = 0, ans = 0;

            for (int i = 0; i < n; i++)
            {
                if (i%2==0)
                {
                    if (sumEven - A[i] - kEven + kOdd == sumOdd - kOdd + kEven)
                        ans++;
                    kEven += A[i];
                }
                else
                {
                    if (sumOdd - A[i] - kOdd + kEven == sumEven - kEven + kOdd)
                        ans++;
                    kOdd += A[i];
                }
            }

            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1,2,1,1}));
        }
    }
}

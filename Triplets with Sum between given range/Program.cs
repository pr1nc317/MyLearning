namespace Triplets_with_Sum_between_given_range
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<string> A)
        {
            int n = A.Count;
            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToDouble(A[i]);
            }

            double a = arr[0], b = arr[1], c = arr[2];
            
            for (int i = 3; i < n; i++)
            {
                if (a + b + c > 1 && a + b + c < 2)
                    return 1;
                else if (a+b+c > 2)
                {
                    if (a > b && a > c)
                        a = arr[i];
                    else if (b > a && b > c)
                        b = arr[i];
                    else
                        c = arr[i];
                }
                else
                {
                    if (a < b && a < c)
                        a = arr[i];
                    else if (b < a && b < c)
                        b = arr[i];
                    else
                        c = arr[i];
                }
            }

            if (a + b + c > 1 && a + b + c < 2)
                return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<string> { "0.1", "0.3", "0.2", "1.2", "0.4" }));
        }
    }
}

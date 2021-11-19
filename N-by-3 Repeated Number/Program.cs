namespace N_by_3_Repeated_Number
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int NBy3RepeatedNumber(List<int> A)
        {
            int first = int.MaxValue; int second = int.MaxValue;
            int count1 = 0; int count2 = 0;
            int n = A.Count;

            for (int i = 1; i < n; i++)
            {
                if (first == A[i])
                    count1++;
                else if (second == A[i])
                    count2++;
                else if (count1 == 0)
                {
                    first = A[i]; count1++;
                }
                else if (count2 == 0)
                {
                    second = A[i]; count2++;
                }
                else
                {
                    count1--; count2--;
                }
            }
            
            count1 = 0; count2 = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (A[i] == first) count1++;
                else if (A[i] == second) count2++;
            }

            if (count1 > n / 3) return first;
            if (count2 > n / 3) return second;
            
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NBy3RepeatedNumber(new List<int> { 1,2,3,1,1, 2,2,3,3,3}));
        }
    }
}

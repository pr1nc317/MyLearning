namespace Hotel_Bookings_Possible
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Hotel(List<int> A, List<int> B, int C)
        {
            A.Sort();
            B.Sort();

            for (int i = 0; i < A.Count; i++)
            {
                if (i+C < A.Count && A[i+C] < B[i])
                {
                    return 0;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(
                Hotel
                (
                new List<int> { 9, 47, 17, 39, 35, 35, 20, 18, 15, 34, 11, 2, 45, 46, 15, 33, 47, 47, 10, 11, 27 }, 
                new List<int> { 32, 82, 39, 86, 81, 58, 64, 53, 40, 76, 40, 46, 63, 88, 56, 52, 50, 72, 22, 19, 38 }, 
                16
                ));
        }
    }
}

namespace Power_Of_Two_Integers
{
    using System;

    class Program
    {
        public static int PowerOfTwoIntegers(int A)
        {
            #region Solution 1
            //var sqrt = Math.Sqrt(A);
            //if (A == 1) return 1;
            //if (A == 0) return 0;
            //for (int i = 2; i <= sqrt; i++)
            //{
            //    int j = 2;
            //    var pow = Math.Pow(i, j);
            //    while (pow <= A && pow > 0)
            //    {
            //        if (pow == A) return 1;
            //        j++;
            //        pow = Math.Pow(i, j);
            //    }
            //}
            //return 0;
            #endregion

            #region Solution 2
            //var sqrt = Math.Sqrt(A);
            //if (A == 1) return 1;
            //if (A == 0) return 0;
            //for (int i = 2; i <= sqrt; i++)
            //{
            //    int j = 2;
            //    var pow = i * i;
            //    while (pow <= A && pow > 0)
            //    {
            //        if (pow == A) return 1;
            //        j++;
            //        pow = pow * i;
            //    }
            //}
            //return 0;
            #endregion

            #region Solution 3 - using log
            /*
            Consider a no. N which needs to be expressed in the form (a^b).
            N = ab
            Taking log both sides:
            log (N) = b.log (a)
            b = log(N)/log(a)
            */
            var sqrt = Math.Sqrt(A);
            int i;
            for (i = 2; i <= sqrt; i++)
            {
                var pow = Math.Log(A) / Math.Log(i);
                if (pow - Math.Floor(pow) < 0.00000001)
                    return 1;
            }
            return 0;

            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PowerOfTwoIntegers(536870912));
        }
    }
}

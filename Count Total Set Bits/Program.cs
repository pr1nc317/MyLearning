namespace Count_Total_Set_Bits
{
    using System;

    class Program
    {
        static int mod = 1000000007;
        public static long Solve(int A)
        {
            /*
             * Step 1 - find the highest power of 2 such that it is less than A. Lets call it x.
             * Step 2 - 2^(x-1) * x will give us the total number of set bits for the range 0 till 2^x - 1.
             * Step 3 - For the rest of the range, i.e. from 2^x till A, we can count the total number left by doing A - 2^x + 1 which will 
             * give us the count of MSBs (all of which will be 1).
             * Step 4 - Now since we have calculated their MSBs, the rest of the range becomes 0, 1, 2 ... So, we need to call the function recursively
             * till the input becomes 0.
             */
            if (A == 0)
                return 0;
            int powerOf2 = HighestPowerOf2(A);
            long setBitsTill2RaiseToPowerOf2 = ((((long)(1 << (powerOf2 - 1))) * powerOf2) % mod);
            long restSetBitsMSBs = A - (1 << powerOf2) + 1;
            return (((setBitsTill2RaiseToPowerOf2 + restSetBitsMSBs + Solve(A - (1 << powerOf2))) % mod) % mod);
        }

        public static int HighestPowerOf2(int A)
        {
            int x = 0;
            while ((1 << x) <= A)
            {
                x++;
            }
            return x - 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(1000000000)); //314447109
        }
    }
}

namespace Swap_Bits
{
    using System;

    class Program
    {
        public static int Solve(int A, int B, int C)
        {
            int bitAtPlaceB = (A & (1 << (B - 1))) == 0 ? 0 : 1;
            int bitAtPlaceC = (A & (1 << (C - 1))) == 0 ? 0 : 1;
            if (bitAtPlaceB == bitAtPlaceC)
                return A;
            if (bitAtPlaceB == 1)
            {
                return (A ^ (1 << (B - 1))) | (1 << (C - 1));
            }
            else
            {
                return (A | (1 << (B - 1))) ^ (1 << (C - 1));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(9, 1, 2));
            Console.WriteLine(Solve(1, 1, 3));
            Console.WriteLine(Solve(4, 1, 3));
            Console.WriteLine(Solve(4, 1, 2));
        }
    }
}

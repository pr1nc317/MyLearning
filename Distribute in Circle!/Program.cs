namespace Distribute_in_Circle_
{
    using System;

    class Program
    {
        public static int Solve(int A, int B, int C)
        {
            return (A + C - 1) % B;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(8,5,2));
        }
    }
}

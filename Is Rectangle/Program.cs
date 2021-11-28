namespace Is_Rectangle
{
    using System;

    class Program
    {
        public static int Solve(int A, int B, int C, int D)
        {
            if (A == B && C == D)
                return 1;
            else if (A == C & B == D)
                return 1;
            else if (A == D & B == C)
                return 1;
            else
                return 0;
        }

        static void Main(string[] args)
        {            
            Console.WriteLine(Solve(1,1,4,4));
        }
    }
}

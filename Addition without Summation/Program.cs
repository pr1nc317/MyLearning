namespace Addition_without_Summation
{
    using System;

    class Program
    {
        public static int AddNumbers(int A, int B)
        {
            // 1. calculate carry with & bit operator
            // 2. calculate xor (^) and assign it to A
            // 3. left shift carry by 1 and assign it to B
            // loop above steps until B becomes 0, return A

            while (B != 0)
            {
                var carry = A & B;
                A = A ^ B;
                B = carry << 1;
            }
            return A;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(9, 199));
        }
    }
}

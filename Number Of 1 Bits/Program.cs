namespace Number_Of_1_Bits
{
    using System;

    class Program
    {
        public static int NumSetBits(uint A)
        {
            int count = 0;
            while (A != 0)
            {
                A &= A - 1;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NumSetBits(11));
        }
    }
}

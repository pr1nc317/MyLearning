namespace Total_Moves_For_Bishop_
{
    using System;

    class Program
    {
        public static int Solve(int A, int B)
        {
            int count = 0;
            int row = A, col = B;
            int top = 8, right = 8, bottom = 1, left = 1;

            // Top Left
            while (row < top && col > left)
            {
                row++; col--;
                count++;
            }

            // Top Right
            row = A; col = B;
            while (row < top && col < right)
            {
                row++; col++;
                count++;
            }

            // Bottom Right
            row = A; col = B;
            while (row > bottom && col < right)
            {
                row--; col++;
                count++;
            }

            // Bottom Left
            row = A; col = B;
            while (row > bottom && col > left)
            {
                row--; col--;
                count++;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(4,4));
        }
    }
}

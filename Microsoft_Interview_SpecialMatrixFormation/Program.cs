using System;

namespace Microsoft_Interview_SpecialMatrixFormation
{
    class Program
    {
        /// <summary>
        /// This method creates a special matrix by taking an integer as a parameter. Run the program to know the sequence and design of the matrix.
        /// </summary>
        static void CreateMatrix(int n)
        {
            int[,] array = new int[2 * n - 1, 2 * n - 1];
            int row = 0, col = 0, len = 2 * n - 1, limit = 2 * n - 1, number = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < limit; j++, row++)
                {
                    array[row, col] = number;
                    array[col, row] = number;
                    array[len - 1, row] = number;
                    array[row, len - 1] = number;
                }
                len--;
                limit -= 2;
                row = i + 1;
                col++;
                number--;
            }

            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which will govern the size of the Matrix: ");
            CreateMatrix(Convert.ToInt32(Console.ReadLine()));
        }
    }
}

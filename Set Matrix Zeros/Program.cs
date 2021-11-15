namespace Set_Matrix_Zeros
{
    using System;

    class Program
    {
        public static int[,] SetZeroes(int[,] A)
        {
            bool topRow = false; bool topColumn = false;
            int M = A.GetLength(0);
            int N = A.GetLength(1);
            // Set boolean true if any first row or first column has a 0
            for (int i = 0; i < N; i++)
                if (A[0, i] == 0)
                    topRow = true;

            for (int i = 0; i < M; i++)
                if (A[i, 0] == 0)
                    topColumn = true;

            // Set first element of a particular i-th row or j-th column as 0 if there is a zero anywhere in that row or column
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    if (A[i, j] == 0)
                    { 
                        A[i, 0] = 0; 
                        A[0, j] = 0; 
                    }

            // Traverse from row 1 till end and column 1 till end and if first element in that row or column has a 0, then fill all the row or column with 0
            for (int i = 1; i < M; i++)
                for (int j = 1; j < N; j++)
                    if (A[i, 0] == 0 || A[0, j] == 0)
                        A[i, j] = 0;

            // Check for boolean flags --> if true, then fill the first row and column as 0
            for (int i = 0; i < M; i++)
                if (topColumn == true)
                    A[i, 0] = 0;

            for (int i = 0; i < N; i++)
                if (topRow == true)
                    A[0, i] = 0;

            return A;
        }

        static void Main(string[] args)
        {
            int[,] A = new int[,] { { 1, 1 }, { 1, 0 } };
            SetZeroes(A);
        }
    }
}

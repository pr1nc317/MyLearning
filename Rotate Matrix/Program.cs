namespace Rotate_Matrix
{
    using System.Collections.Generic;

    class Program
    {
        public static void Rotate(List<List<int>> A)
        {
            // First Transpose, then Swap Elements
            // Transpose
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i; j < A.Count; j++)
                {
                    int temp = A[i][j];
                    A[i][j] = A[j][i];
                    A[j][i] = temp;
                }
            }

            // Now Swap Elements
            for(int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A.Count/2; j++)
                {
                    int temp = A[i][j];
                    A[i][j] = A[i][A.Count - 1 - j];
                    A[i][A.Count - 1 - j] = temp;
                }
            }
        }

        static void Main(string[] args)
        {
            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 4, 5, 6 };
            var list3 = new List<int> { 7, 8, 9 };
            var list = new List<List<int>>
            {
                list1,
                list2,
                list3
            };
            Rotate(list);
        }
    }
}

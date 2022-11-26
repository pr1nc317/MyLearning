namespace Compare_Version_Numbers
{
    using System;

    class Program
    {
        public static int CompareVersion(string A, string B)
        {
            A = A.Replace(".0", ".");
            B = B.Replace(".0", ".");
            A = RemoveLeadingZeroesAndTrailingPoints(A);
            B = RemoveLeadingZeroesAndTrailingPoints(B);
            A = RemoveContinuousPoints(A);
            B = RemoveContinuousPoints(B);
            if (A == B)
                return 0;
            var arrA = A.Split(".");
            var arrB = B.Split(".");
            int i = 0; int j = 0;
            while (i < arrA.Length && j < arrB.Length)
            {
                if (arrA[i].Length > arrB[j].Length)
                    return 1;
                if (arrA[i].Length < arrB[j].Length)
                    return -1;
                else
                {
                    int x = CompareTwoStringsOfEqualLengths(arrA[i], arrB[j]);
                    if (x != 0) return x;
                }
                i++; j++;
            }
            if (i < arrA.Length) return 1;
            else return -1;
        }

        public static int CompareTwoStringsOfEqualLengths(string A, string B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > B[i]) return 1;
                else if (A[i] < B[i]) return -1;
            }
            return 0;
        }

        public static string RemoveLeadingZeroesAndTrailingPoints(string str)
        {
            if (str.StartsWith('0'))
            {
                while (str.StartsWith('0'))
                {
                    str = str.Substring(1);
                }
            }
            if (str.EndsWith('.'))
            {
                while (str.EndsWith('.'))
                {
                    str = str.Remove(str.Length - 1);
                }
            }
            return str;
        }

        public static string RemoveContinuousPoints(string str)
        {
            while (str.Contains(".."))
            {
                str = str.Replace("..", ".");
            }
            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CompareVersion("13.0", "13.0.8"));
        }
    }
}

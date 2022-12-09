namespace Multiply_Strings
{
    using System;

    class Program
    {
        public static string Multiply(string A, string B)
        {
            if (B.Length > A.Length)
            {
                var temp = B;
                B = A;
                A = temp;
            }
            int m = A.Length;
            int n = B.Length;
            int[] arr = new int[m + n];
            for (int j = n - 1; j >= 0; j--)
            {
                int startIndex = n - 1 - j;
                int mul_carry = 0;
                int add_carry = 0;
                for (int i = m - 1; i >= 0; i--)
                {
                    var mul = Convert.ToInt32(A[i].ToString()) * Convert.ToInt32(B[j].ToString()) + mul_carry;
                    mul_carry = mul / 10;
                    var add = arr[m + n - 1 - startIndex] + mul % 10 + add_carry;
                    add_carry = add / 10;
                    arr[m + n - 1 - startIndex] = add % 10;
                    startIndex++;
                }
                if (mul_carry > 0)
                    arr[m + n - 1 - startIndex] = mul_carry;
                if (add_carry > 0)
                    arr[m + n - 1 - startIndex] += add_carry;
            }
            string result = "";
            int k = 0;
            while (k < arr.Length)
            {
                if (arr[k] == 0 && result.Length == 0)
                {
                    k++;
                    continue;
                }
                result += arr[k];
                k++;
            }
            return result.Length == 0 ? "0" : result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply("31243242535342", "0"));
        }
    }
}
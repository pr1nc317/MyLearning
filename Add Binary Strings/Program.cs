namespace Add_Binary_Strings
{
    using System;
    using System.Text;

    class Program
    {
        public static string AddBinary(string A, string B)
        {
            if (string.IsNullOrEmpty(B)) return A;
            if (string.IsNullOrEmpty(A)) return B;
            if (A.Length < B.Length)
            {
                var temp = B;
                B = A;
                A = temp;
            }
            int carry = 0;
            StringBuilder sb = new StringBuilder(A);
            int i;
            for (i = 0; i < B.Length || (i < A.Length && carry == 1); i++)
            {
                int digitA = A[A.Length - 1 - i] == '0' ? 0 : 1;
                int digitB = i >= B.Length ? 0 : (B[B.Length - 1 - i] == '0' ? 0 : 1);
                var sum = digitA + digitB + carry;
                sb[sb.Length - 1 - i] = sum % 2 == 0 ? '0' : '1';
                carry = sum / 2;
            }
            if (carry == 1) sb.Insert(0, "1");
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary("111", "1"));
        }
    }
}

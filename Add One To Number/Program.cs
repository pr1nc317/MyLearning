namespace Add_One_To_Number
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> PlusOne(List<int> A)
        {
            int carry = 1, sum = 0;
            var sumArray = new List<int>();
            for (int i = 0; i < A.Count; )
            {
                if (A[i] == 0) A.RemoveAt(i);
                else break;
            }
            for (int i = A.Count - 1; i >= 0; i--)
            {
                sum = (A[i] + carry) % 10;
                carry = (A[i] + carry) / 10;
                sumArray.Insert(0, sum);
            }
            if (carry > 0) sumArray.Insert(0, carry);
            return sumArray;
        }
        static void Main(string[] args)
        {
            PlusOne(new List<int> { 0, 0, 9, 9, 9 });
        }
    }
}

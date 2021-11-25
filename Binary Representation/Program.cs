namespace Binary_Representation
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static string FindDigitsInBinary(int A)
        {
            string ans = "";
            var list = new List<string>();
            while(A>=1)
            {
                list.Insert(0, (A % 2).ToString());
                A /= 2;
            }
            list.ForEach(x => ans += x);
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindDigitsInBinary(3));
        }
    }
}

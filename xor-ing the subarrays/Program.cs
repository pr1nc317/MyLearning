namespace xor_ing_the_subarrays
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int Solve(List<int> A)
        {
            /*
             * LOGIC:
             * since XOR is commutative (a^b = b^a) and associative ((a^b)^c = a^(b^c)), therefore we just need to count the total number of
             * occurences of each element in the total subarrays of the given list. Also, we know that XOR of any number with itself is 0. So,
             * if the occurence of any element is even in all the subarrays then we can ignore that element since it will not contribute to 
             * the final solution. Only the odd occurrences will matter. 
             * To find total number of occurences of an element in the total subarrays, we can use a formula:
             * If there are 'n' elements in the list, then for an index 'i' the total subarrays that will have the element at index i will
             * be = (i + 1) * (n - i)
             */
            if (A.Count % 2 == 0)
                return 0;
            int ans = 0;
            for (int i = 0; i < A.Count; i += 2)
            {
                ans ^= A[i];
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 1, 2, 3 }));
            Console.WriteLine(Solve(new List<int> { 4, 5, 7, 5 }));
        }
    }
}

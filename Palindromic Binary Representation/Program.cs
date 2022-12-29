namespace Palindromic_Binary_Representation
{
    using System;

    class Program
    {
        /*
         * APPROACH: https://www.youtube.com/watch?v=QYoWR8hDCyQ&ab_channel=Pepcoding
         * First, we need to find out what would be the length of the n-th palindrome and what will be the offset from the last group. For this,
         * we will use a formula 2^((len - 1)/2) will give you the total number of palindromes that will come in a given length
         * Then we can calculate offset as well.
         * Then, we know the first bit will always be 1 in a palindrome so left shift 1 by (len - 1) and store it in 'ans'
         * Then, left shift offset by (len/2) and OR it with the 'ans' above
         * Now, right shift the ans by (len/2) and find this number's reverse
         * Reverse can be founded by using the least significant bit everytime and right shifting the input number and left shifting the result
         * After finding the reverse, return (ans |= rev)
         */
        public static int Solve(int A)
        {
            int len = 0;
            int totalNumbers = 0;
            while (totalNumbers < A)
            {
                len++;
                totalNumbers += 1 << ((len - 1) / 2);
            }
            totalNumbers -= (1 << ((len - 1) / 2));
            int offset = A - totalNumbers - 1;
            
            int ans = 1 << (len - 1);
            ans |= (offset << (len / 2));

            int valueToReverse = (ans >> (len / 2));
            int rev = GetReverse(valueToReverse);
            ans |= rev;
            return ans;
        }

        public static int GetReverse(int n)
        {
            int rev = 0;
            while (n != 0)
            {
                int lsb = n & 1;
                rev |= lsb;
                rev <<= 1;
                n >>= 1;
            }
            rev >>= 1;
            return rev;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(10));
        }
    }
}

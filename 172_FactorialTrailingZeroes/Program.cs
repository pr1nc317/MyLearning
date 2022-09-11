namespace _172_FactorialTrailingZeroes
{
    using System;

    class Program
    {
        static int TrailingZeroes(int n)
        {
            /*
            Idea is to calculate number of 5s in any given number because number of trailing zeros are a result of 2x5 or 4x5 which can be
            rewritten as 2x2x5, similarly 8x5 also result in a zero but can be written as 2x2x2x5. So number of zeros = number of 5s in a given number.
            This can be calculated simply by taking floor(n/5), So 10! has 2 zeros, 15! has 3 zeros and 20! has 4.
            But for the case where n is 25, 125, etc we have more than one 5. 
            When we consider 29! we get one extra 5 and the numbers of trailing zeroes becomes 6. 
            To handle this case, we first divide n by 5 and remove all single 5s, then divide by 25 to remove extra 5s and so on.
            So our solution becomes: number of trailing zeros in n! = floor(n/5) + floor(n/25) + floor(n/125)
            */
            int sum = 0;
            for (int i = 5; n/i >= 1; i *= 5)
            {
                sum += (int)Math.Floor((decimal)n/i);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeroes(5));
        }
    }
}

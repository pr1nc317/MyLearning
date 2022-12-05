namespace Convert_to_Palindrome
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            int left = 0; int right = A.Length - 1;
            int count = 0;
            bool failedTwice = false;
            string secondChance = "";
            while (left < right)
            {
                if (A[left] != A[right])
                {
                    count++;
                    if (count == 1)
                    {
                        secondChance = A.Substring(left, right - left);
                    }
                    if (count > 1)
                    {
                        failedTwice = true;
                    }
                    left++;
                }
                else
                {
                    left++; right--;
                }
            }
            if (failedTwice)
            {
                left = 0;
                right = secondChance.Length - 1;
                while (left < right)
                {
                    if (secondChance[left] != secondChance[right]) return 0;
                    left++; right--;
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("baccaba"));
        }
    }
}

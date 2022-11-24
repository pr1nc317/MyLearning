namespace Palindrome_String
{
    using System;

    class Program
    {
        public static int IsPalindrome(string A)
        {
            int start = 0;
            int end = A.Length - 1;
            while (start <= end)
            {
                if (!IsValidChar(A[start]))
                {
                    start++;
                    continue;
                }
                if (!IsValidChar(A[end]))
                {
                    end--;
                    continue;
                }
                if (A[start].ToString().ToLower() != A[end].ToString().ToLower())
                {
                    return 0;
                }
                else
                {
                    start++;
                    end--;
                }
            }
            return 1;
        }

        public static bool IsValidChar(char ch)
        {
            if ((ch >= 48 && ch <= 57) || (ch >= 65 && ch <= 90) || (ch >= 97 && ch <= 122))
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindrome("race a car"));
        }
    }
}

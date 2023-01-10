namespace Palindrome_Numbers
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int Solve(int A, int B, int C)
        {
            // first check if the current number is palindrome or not. if yes, then calculate the difference between current palindrome
            // and the last palindrome. if the difference is <= C, do ans++
            var palindromeList = new List<int>();
            int i;
            for (i = A; i <= B; i++)
                if (IsPalindrome(i))
                    palindromeList.Add(i);
            return GetMaxRangeWithDiffNotMoreThanC(palindromeList, A, B, C);
        }

        public static bool IsPalindrome(int A)
        {
            int res = 0;
            for (int i = A; i > 0; i /= 10)
                res = (res * 10) + (i % 10);
            return res == A ? true : false;
        }

        public static int GetMaxRangeWithDiffNotMoreThanC(List<int> list, int A, int B, int C)
        {
            int start = 0; int end = 1;
            int count = 0; int maxCount = 0;
            if (list.Count == 1)
                if (list[0] - A <= C || list[0] - B <= C) return 1;
            while (end < list.Count)
            {
                while (end < list.Count && list[end] - list[start] <= C)
                {
                    if (count == 0) count = 2;
                    else count++;
                    end++;
                }
                if (count > maxCount)
                    maxCount = count;
                bool startNotChanged = true;
                while (count > 0 && end < list.Count && list[end] - list[start] > C)
                {
                    start++;
                    count--;
                    startNotChanged = false;
                }
                if (startNotChanged) start++;
                if (start == end) end++;
            }
            if (maxCount == 0 && list.Count > 0)
            {
                if (list[0] - A <= C) return 1;
                if (list[list.Count - 1] - B <= C) return 1;
            }
            return maxCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(80, 110, 10)); //2
            Console.WriteLine(Solve(1, 10, 10)); //9
            Console.WriteLine(Solve(11839, 12595, 459)); //5
            Console.WriteLine(Solve(3112, 3166, 530)); //1
            Console.WriteLine(Solve(88, 99, 11)); //2
            Console.WriteLine(Solve(693, 1077, 67)); //8
            Console.WriteLine(Solve(80793, 81703, 61)); //1
            Console.WriteLine(Solve(19708, 19756, 679)); //0
        }
    }
}

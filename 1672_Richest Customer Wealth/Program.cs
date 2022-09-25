namespace _1672_Richest_Customer_Wealth
{
    using System;
    using System.Linq;

    class Program
    {
        static int MaximumWealth(int[][] accounts)
        {
            int ans = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = accounts[i].Aggregate((x, y) => x + y);
                ans = Math.Max(ans, sum);
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaximumWealth(new int[][]
                {
                    new int[] { 2,8,7 },
                    new int[] { 7,1,3 },
                    new int[] { 1,9,5 }
                }));
        }
    }
}

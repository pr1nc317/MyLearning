namespace _322_Coin_Change
{
    using System;

    class Program
    {
        #region Recursion Approach
        //static int CoinsChange(int[] coins, int amount)
        //{
        //    // Base case
        //    if (amount == 0) return 0;

        //    int res = int.MaxValue;

        //    for (int i = 0; i < coins.Length; i++)
        //    {
        //        Console.WriteLine(i + " -- " + coins[i]);
        //        if (coins[i] <= amount)
        //        {
        //            int sub_res = CoinsChange(coins, amount - coins[i]);
        //            Console.WriteLine(sub_res);
        //            if (sub_res + 1 < res )
        //            {
        //                res = sub_res + 1;
        //            }
        //        }
        //    }
        //    return res;
        //}
        #endregion

        #region DP
        static int CoinsChange(int[] coins, int amount)
        {
            int[,] dp = new int[coins.Length + 1, amount + 1];
            for (int i = 0; i <= coins.Length; i++)
            {
                for (int j = 0; j <= amount; j++)
                {
                    if (j == 0) dp[i, j] = 0;
                    else if (i == 0) dp[i, j] = (int)Math.Pow(10, 5);
                    else if (coins[i - 1] > j) dp[i, j] = dp[i - 1, j];
                    else dp[i, j] = Math.Min(dp[i - 1, j], 1 + dp[i, j - coins[i - 1]]);
                }
            }
            return dp[coins.Length, amount] > (int)(Math.Pow(10, 4)) ? -1 : dp[coins.Length, amount];
        }
        #endregion

        static void Main(string[] args)
        {
            int[] coins = new int[] { 2 };
            int amount = 3;
            Array.Sort(coins);
            Console.WriteLine(CoinsChange(coins, amount));
        }
    }
}


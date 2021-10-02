namespace ElectronicsShop_HackerRank
{
    class Program
    {
        static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int currentMaxSum = 0;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    int newMaxSum = keyboards[i] + drives[j];
                    if (newMaxSum > currentMaxSum && newMaxSum <= b)
                    {
                        currentMaxSum = newMaxSum;
                    }
                }
            }
            if (currentMaxSum == 0)
                return -1;
            return currentMaxSum;
        }
        static void Main(string[] args)
        {
            int output = GetMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10);
        }
    }
}

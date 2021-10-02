namespace DivisibleSumPairs_HackerRank
{
    class Program
    {
        static int DivisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0, sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                sum += ar[i];
                for (int j = i + 1; j < n; j++)
                {
                    sum += ar[j];
                    if (sum % k == 0)
                    {
                        count++;
                    }
                    sum = ar[i];
                }
                sum = 0;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int output = DivisibleSumPairs(6, 3, new int[] { 1, 3, 2, 6, 1, 2 });
        }
    }
}

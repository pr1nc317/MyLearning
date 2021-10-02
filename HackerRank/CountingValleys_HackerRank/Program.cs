namespace CountingValleys_HackerRank
{
    class Program
    {
        static int CountingValleys(int n, string s)
        {
            int count = 0, countUp = 0, countDown = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals('U'))
                {
                    countUp++;
                }
                else
                {
                    countDown++;
                }
                if (i > 0 && arr[i] == 'U' && countDown == countUp)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int output = CountingValleys(8, "UDDDUDUU");
        }
    }
}
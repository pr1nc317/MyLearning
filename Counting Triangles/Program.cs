namespace Couting_Triangles
{
    public class A
    {
        public static int nTriang(List<int> A)
        {
            int mod = 1000000007;
            A.Sort();
            #region Appraoch 1
            //int count = 0;
            //for (int i = 0; i < A.Count - 2; i++)
            //{
            //    int k = i + 2;
            //    for (int j = i + 1; j < A.Count - 1; j++)
            //    {
            //        while (k < A.Count && A[i] + A[j] > A[k])
            //        {
            //            k++;
            //        }
            //        count += k - j - 1;
            //        count %= mod;
            //    }
            //}
            #endregion

            #region Approach 2
            int count = 0;
            for (int i = A.Count - 1; i >= 2; i--)
            {
                int left = 0;
                int right = i - 1;
                while (left < right)
                {
                    if (A[left] + A[right] > A[i])
                    {
                        count += right - left;
                        count %= mod;
                        right--;
                    }
                    else left++;
                }
            }
            #endregion
            return count;
        }

        public static void Main()
        {
            //Console.WriteLine(nTriang(new List<int> { 1, 1, 1, 2, 2 }));
            Console.WriteLine(nTriang(new List<int> { 4, 6, 13, 16, 20, 3, 1, 12 }));
        }
    }
}
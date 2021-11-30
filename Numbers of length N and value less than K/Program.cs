namespace Numbers_of_length_N_and_value_less_than_K
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static int Solve(List<int> A, int B, int C)
        {
            int nC = C.ToString().Length;
            int ans = 0;

            // Case 0: When B == 1
            if (B == 1)
            {
                return A.Count(x => x < C);
            }

            // Case 1: When B > C
            if (B > nC) ans = 0;

            // Case 2: When B < C
            else if (B < nC)
            {
                if (A[0] == 0)
                    ans = (A.Count - 1) * (int)Math.Pow(A.Count, B - 1);
                else
                    ans = (int)Math.Pow(A.Count, B);
                if (B == 1 && A[0] == 0)
                    ans++;
            }
            else // Case 3: When B == C
            {
                // Creating temp array for storing variable C
                var temp = new int[nC];
                for (int i = temp.Length - 1; i >=0; i--)
                {
                    temp[i] = C % 10;
                    C /= 10;
                }

                // Count the number of possible permutation
                int count = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] == 0) continue;
                    if (A[i] <= temp[0]) count++;
                    else break;
                }
                ans += count * (int)Math.Pow(A.Count, B - 1);

                // Above ans will have some extra count, now we will try to remove them
                int flag = 0; 
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] == temp[0]) flag = 1;
                }

                int j = 1;
                while (flag == 1 && j <= B-1)
                {
                    flag = 0;
                    int countx = 0;
                    for (int i = 0; i < A.Count; i++)
                    {
                        if (A[i] > temp[j]) countx++;
                        if (A[i] == temp[j]) flag = 1;
                    }
                    ans -= countx * (int)Math.Pow(A.Count, B - j - 1);
                    j++;
                }
                if (flag == 1 && j == B) ans--;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve(new List<int> { 0, 1, 2, 5 }, 2, 8));
        }
    }
}

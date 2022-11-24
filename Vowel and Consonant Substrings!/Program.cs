namespace Vowel_and_Consonant_Substrings_
{
    using System;

    class Program
    {
        public static int Solve(string A)
        {
            #region Approach 1
            //int mod = 1000000007;
            //int res = 0;
            //int cons = 0;
            //int vow = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i].ToString().Equals("a") || A[i].ToString().Equals("e") || A[i].ToString().Equals("i") || A[i].ToString().Equals("o") 
            //        || A[i].ToString().Equals("u"))
            //    {
            //        vow++;
            //        res = (res + cons) % mod;
            //    }
            //    else
            //    {
            //        cons++;
            //        res = (res + vow) % mod;
            //    }
            //}
            //return res;
            #endregion

            #region Approach 2 - Easy way using vowels_count * consonants_count
            int mod = 1000000007;
            int vow = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 'a' || A[i] == 'e' || A[i] == 'i' || A[i] == 'o' || A[i] == 'u')
                {
                    vow++;
                }
            }
            return (vow * (A.Length - vow)) % mod;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("bbebbebe"));
            Console.WriteLine(Solve("inttnikjmjbemrberk"));
            Console.WriteLine(Solve("hgdghnjjqnrqrd"));
        }
    }
}

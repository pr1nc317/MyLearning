namespace _125_ValidPalindrome
{
    using System;

    class Program
    {
        static bool IsPalindrome(string s)
        {
            #region without using in built methods
            //bool ans = true; int left = 0; int right = s.Length - 1;
            //bool notValidChar;
            //while (ans && right > left)
            //{
            //    notValidChar = false;
            //    if (!(((s[left] >= 65 && s[left] <= 90) || ( s[left] >= 97 && s[left] <= 122)) || (s[left] >= 48 && s[left] <= 57)))
            //    {
            //        left++; notValidChar = true;
            //    }
            //    if (!(((s[right] >= 65 && s[right] <= 90) || (s[right] >= 97 && s[right] <= 122)) || (s[right] >= 48 && s[right] <= 57)))
            //    {
            //        right--; notValidChar = true;
            //    }
            //    if (notValidChar) continue;
            //    if (s[left] == s[right])
            //    {
            //        left++; right--; continue;
            //    }
            //    if ((s[left] >= 48 && s[left] <= 57) && (s[right] >= 57 || s[right] <= 48))
            //    {
            //        ans = false;
            //    }
            //    else if (s[left] + 32 == s[right] || s[left] - 32 == s[right])
            //    {
            //        left++; right--; continue;
            //    }
            //    else ans = false;
            //}
            //return ans;
            #endregion

            #region using in built methods
            s = s.Replace(" ", null).ToLower();
            bool ans = true; int left = 0; int right = s.Length - 1;
            bool notValidChar;
            while (right > left && ans)
            {
                notValidChar = false;
                if ((s[left] < 97 && s[left] > 57) || s[left] < 48 || s[left] > 122)
                {
                    notValidChar = true; left++;
                }
                if ((s[right] < 97 && s[right] > 57) || s[right] < 48 || s[right] > 122)
                {
                    notValidChar = true; right--;
                }
                if (notValidChar) continue;
                if (s[left] != s[right]) ans = false;
                right--; left++;
            }
            return ans;
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }
}

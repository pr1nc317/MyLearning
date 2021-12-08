namespace Next_Smallest_Palindrome_
{
    using System;
    using System.Linq;

    class Program
    {
        public static string Solve(string A)
        {
            int[] arr = new int[A.Length];
            int k = 0;
            foreach (var item in A)
            {
                arr[k++] = Convert.ToInt32(item.ToString());
            }

            // Case 1: Number is a palindrome and have all 9s
            bool all9s = true;
            foreach (var item in arr)
            {
                if (item == 9) continue;
                else all9s = false;
            }

            if (all9s)
            {
                return "1" + new string(Enumerable.Repeat('0', arr.Length - 1).ToArray()) + "1";
            }

            // Case 2: Number is a palindrome and does not have all 9s
            // Case 3: Number is not a palindrome

            /*
            We will start with two indices i and j. i pointing to the two middle elements (or pointing to two elements around the middle element in case of n being odd). 
            We one by one move i and j away from each other.

            Step 1. Initially, ignore the part of left side which is same as the corresponding part of right side. For example, if the number is “8 3 4 2 2 4 6 9″, 
            we ignore the middle four elements. i now points to element 3 and j now points to element 6.

            Step 2. After step 1, following cases arise:
            Case 1: Indices i & j cross the boundary. 
            This case occurs when the input number is palindrome. In this case, we just add 1 to the middle digit (or digits in case n is even) 
            propagate the carry towards MSB digit of left side and simultaneously copy mirror of the left side to the right side. 
            For example, if the given number is “1 2 9 2 1”, we increment 9 to 10 and propagate the carry. So the number becomes “1 3 0 3 1”

            Case 2: There are digits left between left side and right side which are not same. So, we just mirror the left side to the right side & 
            try to minimize the number formed to guarantee the next smallest palindrome. 
            In this case, there can be two sub-cases. 

            2.1) Copying the left side to the right side is sufficient, we don’t need to increment any digits and the result is just mirror of left side. 
            Following are some examples of this sub-case. 
            Next palindrome for “7 8 3 3 2 2″ is “7 8 3 3 8 7” 
            Next palindrome for “1 2 5 3 2 2″ is “1 2 5 5 2 1” 
            Next palindrome for “1 4 5 8 7 6 7 8 3 2 2″ is “1 4 5 8 7 6 7 8 5 4 1” 
            How do we check for this sub-case? All we need to check is the digit just after the ignored part in step 1. 
            This digit is highlighted in above examples. If this digit is greater than the corresponding digit in right side digit, 
            then copying the left side to the right side is sufficient and we don’t need to do anything else.

            2.2) Copying the left side to the right side is NOT sufficient. This happens when the above defined digit of left side is smaller. 
            Following are some examples of this case. 
            Next palindrome for “7 1 3 3 2 2″ is “7 1 4 4 1 7” 
            Next palindrome for “1 2 3 4 6 2 8″ is “1 2 3 5 3 2 1” 
            Next palindrome for “9 4 1 8 7 9 7 8 3 2 2″ is “9 4 1 8 8 0 8 8 1 4 9” 
            We handle this subcase like Case 1. We just add 1 to the middle digit (or digits in case n is even) propagate the carry towards 
            MSB digit of left side and simultaneously copy mirror of the left side to the right side.
            */
            int i, j;
            int mid = arr.Length / 2;
            i = mid - 1;
            j = arr.Length % 2 == 0 ? mid : mid + 1;

            while (i >= 0)
            {
                if (arr[i] != arr[j])
                    break;
                i--; j++;
            }

            // Will let us know if we have to increment the mid element or not
            bool isLeftSmaller = false;

            if (i < 0 || arr[i] < arr[j])
            {
                isLeftSmaller = true;
            }

            if (isLeftSmaller)
            {
                // Increment the mid, take carry towards left side and then copy to the right
                int carry = 1;
                if (arr.Length % 2 == 1)
                {
                    // For odd numbers, add 1 to the mid number and take carry for further operation
                    arr[mid] = arr[mid] + carry;
                    carry = Convert.ToInt32(arr[mid].ToString()) / 10;
                    arr[mid] = (char)(Convert.ToInt32(arr[mid].ToString()) % 10);
                }
                i = mid - 1;
                j = arr.Length % 2 == 0? mid: mid+1;
                while (i >= 0)
                {
                    arr[i] = (char)(Convert.ToInt32(arr[i].ToString()) + carry);
                    carry = Convert.ToInt32(arr[i].ToString()) / 10;
                    arr[i] = (char)(Convert.ToInt32(arr[i].ToString()) % 10);
                    arr[j++] = arr[i--];
                }
            }

            else
            {
                // Copy left to right from i moving left till 0
                while (i >= 0)
                {
                    arr[j++] = arr[i--];
                }
            }

            string ans = string.Empty;
            foreach (var item in arr)
            {
                ans += item;
            }

            return ans;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("8"));
        }
    }
}

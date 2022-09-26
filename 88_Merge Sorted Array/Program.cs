namespace _88_Merge_Sorted_Array
{
    using System;

    class Program
    {
        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int j = 0; int temp = 0;
            if (n == 0) return;
            for (int i = 0; i < m; i++)
            {
                if (nums1[i] > nums2[j])
                {
                    temp = nums1[i];
                    nums1[i] = nums2[j];
                    nums2[j] = temp;
                    PlaceCarefully(nums2);
                }
            }
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[i - m];
            }
            for (int k = 0; k < nums1.Length; k++)
            {
                Console.WriteLine(nums1[k]);
            }
        }

        static void PlaceCarefully(int[] nums2)
        {
            int i = 0;
            while (i < nums2.Length - 1 && nums2[i] > nums2[i + 1])
            {
                int temp = nums2[i];
                nums2[i] = nums2[i + 1];
                nums2[i + 1] = temp;
                i++;
            }
        }

        static void Main(string[] args)
        {
            //Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
            //Merge(new int[] { 1, 2, 0, 0, 0 }, 2, new int[] { 2, 5, 6 }, 3);
            //Merge(new int[] { 1, 6, 7, 0, 0, 0 }, 3, new int[] { 2, 5 }, 2);
            Merge(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3);
            //Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);
            //Merge(new int[] { 0, 0 }, 0, new int[] { 2, 3}, 2);
        }
    }
}

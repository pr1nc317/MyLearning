namespace Next_Similar_Number
{
    using System;
    using System.Linq;

    class Program
    {
        public static string Solve(string A)
        {
            #region Solution 1 - With LINQ
            var arr = A.ToCharArray();
            int n = arr.Length;

            for (int i = n - 1; i > 0; i--)
            {
                if (arr[i] > arr[i - 1])
                {
                    var temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;

                    var arr1 = arr.TakeLast(n - i).ToArray();
                    Array.Sort(arr1);

                    return new string(arr.Take(i).ToArray()) + new string(arr1);
                }
            }
            return "-1";
            #endregion

            #region Solution 2 - Without LINQ
            //var arr = A.ToCharArray();
            //int n = arr.Length;
            //int i;
            //if (A.Length == 1) return "-1";
            //for (i = n - 1; i > 0; i--)
            //{
            //    if (arr[i] > arr[i - 1])
            //    {
            //        break;
            //    }
            //    if (i == 1) return "-1";
            //}

            //var eleIndex = i - 1;
            //int diff = int.MaxValue;
            //int eleIndexSwap = 0;
            //for (int a = i; a < n; a++)
            //{
            //    if (arr[a] > arr[eleIndex] && arr[a] - arr[eleIndex] < diff)
            //    {
            //        diff = arr[a] - arr[eleIndex];
            //        eleIndexSwap = a;
            //    }
            //}

            //var temp = arr[eleIndex];
            //arr[eleIndex] = arr[eleIndexSwap];
            //arr[eleIndexSwap] = temp;

            //var arr2 = new char[n - i];
            //for (int j = 0; j < arr2.Length; j++)
            //{
            //    arr2[j] = arr[j + i];
            //}
            //Array.Sort(arr2);
            //var arr1 = new char[i];
            //for (int j = 0; j < arr1.Length; j++)
            //{
            //    arr1[j] = arr[j];
            //}
            //return new string(arr1) + new string(arr2);
            #endregion
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solve("549321"));
        }
    }
}

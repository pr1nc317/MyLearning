namespace CustomSort_Comparer
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        public static int CustomComparer(int x, int y)
        {
            int res = x.CompareTo(y);
            return res > 0 ? -1 : 1; 
        }

        static void Main(string[] args)
        {
            var list = new List<int> { 3, 45, 1, 0, 4, 2, 18, 12, 14 };
            list.Sort(CustomComparer);
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}

namespace Chips_Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<int> Solve(List<int> A)
        {
            #region using LINQ (simple and easy)
            int count = A.Where(x => x == 0).Count();
            A.RemoveAll(x => x == 0);
            while (count > 0)
            {
                A.Add(0);
                count--;
            }
            return A;
            #endregion
        }
        static void Main(string[] args)
        {
            Solve(new List<int> { 1, 2, 0, 4, 0, 5 }).ForEach(x => Console.Write(x + " "));
        }
    }
}
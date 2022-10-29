namespace PRETTYPRINT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static List<List<int>> PrettyPrint(int A)
        {
            int length = 2 * A - 1;
            var list = new List<List<int>>();
            for (int i = 0; i < length; i++)
            {
                list.Add(Enumerable.Repeat(0, length).ToList());
            }
            for (int i = 0; i < A; i++)
            {
                int toFill = A - i;
                for (int j = i; j < length - i; j++)
                {
                    list[i][j] = toFill;
                    list[j][i] = toFill;
                    list[length - 1 - i][length - 1 - j] = toFill;
                    list[length - 1 - j][length - 1 - i] = toFill;
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            PrettyPrint(4).ForEach(x => { x.ForEach(y => Console.Write(y + " ")); Console.WriteLine(); });
        }
    }
}

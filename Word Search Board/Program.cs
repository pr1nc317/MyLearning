namespace Word_Search_Board
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        public static int[] xAxis = new int[] { 0, 1, 0, -1 };
        public static int[] yAxis = new int[] { 1, 0, -1, 0 };

        public class Pair
        {
            public int x;
            public int y;
            public int nextCharIndex;
            public Pair(int x, int y, int nextCharIndex)
            {
                this.x = x; this.y = y; this.nextCharIndex = nextCharIndex;
            }
        }

        public static int Exist(List<string> A, string B)
        {
            Stack<Pair> s = new Stack<Pair>();
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    if (A[i][j] == B[0])
                    {
                        s.Push(new Pair(i, j, 1));
                    }
                }
            }
            if (B.Length == 1)
                if (s.Count >= 1)
                    return 1;
                else return 0;
            while (s.Count > 0)
            {
                var deq = s.Pop();
                // check in 4 directions for the char at nextCharIndex
                for (int i = 0; i < 4; i++)
                {
                    var newX = deq.x + xAxis[i];
                    var newY = deq.y + yAxis[i];
                    if (IsValid(newX, newY, A) && A[newX][newY] == B[deq.nextCharIndex])
                    {
                        if (deq.nextCharIndex == B.Length - 1)
                            return 1;
                        s.Push(new Pair(newX, newY, deq.nextCharIndex + 1));
                    }
                }
            }
            return 0;
        }

        public static bool IsValid(int x, int y, List<string> A)
        {
            if (x < 0 || x >= A.Count || y < 0 || y >= A[x].Length)
                return false;
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Exist(new List<string> { "ABCE", "SFCS", "ADEE" }, "ABCCED"));
            Console.WriteLine(Exist(new List<string> { "ABCE", "SFCS", "ADEE" }, "SEE"));
            Console.WriteLine(Exist(new List<string> { "ABCE", "SFCS", "ADEE" }, "ABCB"));
            Console.WriteLine(Exist(new List<string> { "ABCE", "SFCS", "ADEE" }, "ABFSAB"));
            Console.WriteLine(Exist(new List<string> { "ABCE", "SFCS", "ADEE" }, "ABCD"));
        }
    }
}

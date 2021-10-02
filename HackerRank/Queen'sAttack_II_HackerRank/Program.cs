namespace Queen_sAttack_II_HackerRank
{
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;
    using System.Text;
    using System;

    class Result
    {
        /*
         * Complete the 'queensAttack' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER r_q
         *  4. INTEGER c_q
         *  5. 2D_INTEGER_ARRAY obstacles
         */

        public static int QueensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
        {
            //Attacked Squares
            var top = Top(n, r_q);
            var bottom = Bottom(r_q);
            var left = Left(c_q);
            var right = Right(n, c_q);
            var topLeft = Math.Min(top, left);
            var topRight = Math.Min(top, right);
            var bottomLeft = Math.Min(bottom, left);
            var bottomRight = Math.Min(bottom, right);
            //Blocked Squares because of obstacles
            foreach (var item in obstacles)
            {
                //Verify the quadrant of the obstacle and if its a genuine obstacle to a queen's attack
                //Top
                if (item[1] == c_q && item[0] > r_q)
                {
                    top = Math.Min(top, item[0] - r_q - 1);
                    continue;
                }
                //Bottom
                if (item[1] == c_q && item[0] < r_q)
                {
                    bottom = Math.Min(bottom, r_q - item[0] - 1);
                    continue;
                }
                //Left
                if (item[0] == r_q && item[1] < c_q)
                {
                    left = Math.Min(left, c_q - item[1] - 1);
                    continue;
                }
                //Right
                if (item[0] == r_q && item[1] > c_q)
                {
                    right = Math.Min(right, item[1] - c_q - 1);
                    continue;
                }
                //TopLeft
                if ((item[0] > r_q && c_q > item[1]) && (item[0] - r_q == c_q - item[1]))
                {
                    topLeft = Math.Min(topLeft, c_q - item[1] - 1);
                    continue;
                }
                //TopRight
                if ((item[0] > r_q && c_q < item[1]) && (item[0] - r_q == item[1] - c_q))
                {
                    topRight = Math.Min(topRight, item[1] - c_q - 1);
                    continue;
                }
                //BottomLeft
                if ((item[0] < r_q && c_q > item[1]) && (r_q - item[0] == c_q - item[1]))
                {
                    bottomLeft = Math.Min(bottomLeft, c_q - item[1] - 1);
                    continue;
                }
                //BottomRight
                if ((item[0] < r_q && c_q < item[1]) && (r_q - item[0] == item[1] - c_q))
                {
                    bottomRight = Math.Min(bottomRight, r_q - item[0] - 1);
                    continue;
                }
            }
            return top + left + bottom + right + topLeft + topRight + bottomLeft + bottomRight;
        }

        private static int Top(int n, int r_q)
        {
            return n - r_q;
        }
        private static int Bottom(int r_q)
        {
            return r_q - 1;
        }
        private static int Left(int c_q)
        {
            return c_q - 1;
        }
        private static int Right(int n, int c_q)
        {
            return n - c_q;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            var obstacles1 = new List<List<int>>();
            var lines = File.ReadAllLines(Environment.CurrentDirectory + @"/TextFile1.txt");
            foreach(var item in lines)
            {
                obstacles1.Add(item.Split(' ').ToList().Select(x=> Convert.ToInt32(x)).ToList());
            }
            //obstacles1.Add(new List<int> { 5, 5 });
            //obstacles1.Add(new List<int> { 4, 2 });
            //obstacles1.Add(new List<int> { 2, 3 });
            Console.WriteLine(Result.QueensAttack(100, 100, 48, 81, obstacles1));
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(firstMultipleInput[0]);
            int k = Convert.ToInt32(firstMultipleInput[1]);
            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
            int r_q = Convert.ToInt32(secondMultipleInput[0]);
            int c_q = Convert.ToInt32(secondMultipleInput[1]);
            List<List<int>> obstacles = new List<List<int>>();
            for (int i = 0; i < k; i++)
            {
                obstacles.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(obstaclesTemp => Convert.ToInt32(obstaclesTemp)).ToList());
            }
            int result = Result.QueensAttack(n, k, r_q, c_q, obstacles);
            Console.WriteLine(result);
        }
    }
}

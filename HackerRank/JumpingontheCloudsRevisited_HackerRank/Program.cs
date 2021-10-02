namespace JumpingontheCloudsRevisited_HackerRank
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

    class Solution
    {
        // Complete the jumpingOnClouds function below.
        static int JumpingOnClouds(int[] c, int k)
        {
            var n = c.Length;
            int power = 100;
            for (int i = k % n; i != 0; i = (i + k) % n)
            {
                if (c[i] == 1) power -= 3;
                else if (c[i] == 0) power--;
            }            
            _ = c[0] == 1 ? power -= 3 : power--;
            return power;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(JumpingOnClouds(new int[] { 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1 }, 19));
            string[] nk = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = JumpingOnClouds(c, k);
        }
    }

}

﻿namespace Product_of_All
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        public static List<int> Solve(List<int> A)
        {
            int mod = 1000000007;
            var ans = new List<int>();
            long prod = 1;
            for (int i = 0; i < A.Count; i++)
            {
                prod = (prod * A[i])%mod;
            }
            for (int i = 0; i < A.Count; i++)
            {
                ans.Add((int)prod / A[i]);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Solve(new List<int> { 1, 756, 459, 533, 219, 48, 679, 680, 935, 384, 520, 831, 35, 54, 530, 672, 8, 384, 67, 418, 687, 589, 931, 847, 527, 92, 654, 416, 702, 911, 763, 263, 48, 737, 329, 633, 757, 992, 366, 248, 983, 723, 754, 652, 73, 632, 885, 273, 437, 767, 478, 238, 275, 360, 167, 487, 898, 910, 61, 905, 505, 517, 320, 987, 494, 267, 91, 948, 74, 501, 385, 278, 914, 530, 465, 941, 51, 762, 771, 828, 126, 16, 689, 869, 630, 737, 726, 1000, 889, 234, 307, 352, 514, 592, 846, 413, 842, 270, 416 }).ForEach(x=>Console.Write(x + " "));
        }
    }
}
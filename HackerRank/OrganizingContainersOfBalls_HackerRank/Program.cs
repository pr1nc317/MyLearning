namespace OrganizingContainersOfBalls_HackerRank
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
        * Complete the 'organizingContainers' function below.
        *
        * The function is expected to return a STRING.
        * The function accepts 2D_INTEGER_ARRAY container as parameter.
        */

        public static string OrganizingContainers(List<List<int>> container)
        {
            var size = container[0].Count;
            var containerCapacityList = new List<int>();
            var eachBallTypesCountList = new List<int>();
            //'i' is our container number and 'j' is our ball type
            for (int i = 0; i < size; i++)
            {
                var containerCapacityCount = 0;
                for (int j = 0; j < size; j++)
                {
                    containerCapacityCount += container[i][j];
                }
                containerCapacityList.Add(containerCapacityCount);
            }
            for (int j = 0; j < size; j++)
            {
                var eachBallTypeCount = 0;
                for (int i = 0; i < size; i++)
                {
                    eachBallTypeCount += container[i][j];
                }
                eachBallTypesCountList.Add(eachBallTypeCount);
            }
            containerCapacityList.Sort();
            eachBallTypesCountList.Sort();
            if (containerCapacityList.SequenceEqual(eachBallTypesCountList))
            {
                return "Possible";
            }
            else return "Impossible";
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());
            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());
                List<List<int>> container = new List<List<int>>();
                for (int i = 0; i < n; i++)
                {
                    container.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(containerTemp => Convert.ToInt32(containerTemp)).ToList());
                }
                string result = Result.OrganizingContainers(container);
                Console.WriteLine(result);
            }
        }
    }
}
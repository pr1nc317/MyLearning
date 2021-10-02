using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingTheLeaderboard_HackerRank
{
    class Program
    {
        static int[] ClimbingLeaderboard(int[] scores, int[] alice)
        {
            /*
            #region SOLUTION 1: Using List and 2 FOR LOOPS
            int[] arr = new int[alice.Length];
            List<int> li = new List<int>();
            foreach(var item in scores)
            {
                if (!li.Contains(item)) li.Add(item);
            }
            for (int i = 0; i<alice.Length; i++)
            {
                for (int j = 0; j <li.Count; j++)
                {
                    if (alice[i] < li[j]) continue;
                    else
                    {
                        arr[i] = j + 1; break;
                    }
                }
                if (arr[i] != 0)
                {
                    continue;
                }
                arr[i] = li.Count + 1;
            }
            return arr;
            
            #endregion

            #region SOLUTION 2: Using Sorted List
            int[] arr = new int[alice.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int pos = 1;
            foreach (var item in scores)
            {
                dict.Add(pos, item);
                pos++;
            }
            
            
            foreach (var item in alice)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, pos);
                    pos++;
                }
            }
            return arr;
            #endregion
            */

            //SOLUTION 3 - 2 FOR LOOPS
            int index = 0;
            var result = new int[alice.Length];
            var leaderboard = scores.Distinct().Reverse().ToList();
            int iterator = leaderboard.Count;
            int rank = leaderboard.Count + 1;
            foreach (var item in alice)
            {
                for(int i = leaderboard.Count-iterator; i < leaderboard.Count; i++)
                {
                    if (item < leaderboard[i])
                    {
                        break;
                    }
                    rank--;
                }
                result[index++] = rank;
                if (rank <= leaderboard.Count)
                {
                    iterator = rank - 1;
                    continue;
                }
                rank = leaderboard.Count + 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] output = ClimbingLeaderboard(new int[] { 100, 100, 50, 40, 40, 20, 10}, new int[] { 5, 25, 50, 120 });
        }
    }
}
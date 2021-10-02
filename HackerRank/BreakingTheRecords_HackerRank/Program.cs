using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords_HackerRank
{
    class Program
    {
        static int[] BreakingRecords(int[] scores)
        {
            int bestRecordBreakingCount = 0, worstRecordBreakingCount = 0, maxScore = scores[0], minScore = scores[0];
            foreach(var score in scores)
            {
                if(score > maxScore)
                {
                    maxScore = score;
                    bestRecordBreakingCount++;
                }
                else if (score < minScore)
                {
                    minScore = score;
                    worstRecordBreakingCount++;
                }
            }
            return new int[] { bestRecordBreakingCount, worstRecordBreakingCount };
        }

        static void Main(string[] args)
        {
            int[] output = BreakingRecords(new int[] { 3, 4 ,21, 36, 10, 28, 35, 5, 24, 42 });
        }
    }
}

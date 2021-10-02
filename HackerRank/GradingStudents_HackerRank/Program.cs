using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingStudents_HackerRank
{
    class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < grades.Count(); i++)
            {
                int? temp = grades[i];
                if ((grades[i] % 5) >= 3)
                {
                    grades[i] += 5 - (grades[i] % 5);
                    if (grades[i] >= 40)
                    {
                        result.Add(grades[i]);
                    }
                    else
                    {
                        result.Add(Convert.ToInt32(temp));
                    }
                }
                else
                {
                    result.Add(grades[i]);
                }
                temp = null;
            }
            return result;
        }

        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 33, 37, 38, 39, 40, 41, 42, 43 };
            List<int> output = gradingStudents(input);
        }
    }
}

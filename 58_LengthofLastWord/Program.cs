namespace _58_LengthofLastWord
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;
    using System;
    
    [MemoryDiagnoser]
    public class Program
    {
        [Benchmark]
        [Arguments(" a bb  ")]
        public int LengthOfLastWord(string s)
        {
            bool charSeen = false;
            int ans = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    charSeen = true;
                    ans++;
                }

                if (s[i] == ' ' && charSeen && ans > 0) break;
            }
            return ans;
        }

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Program>(); 
            //Console.WriteLine(LengthOfLastWord(" a bb  "));
        }
    }
}

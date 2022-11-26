namespace Convert_the_amount_in_number_to_words
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        public static int Solve(string A, string B)
        {
            if (A == "1000000000")
            {
                return B == "one-arab" ? 1 : 0;
            }
            Dictionary<string, string> dict1 = new Dictionary<string, string> { { "0", "zero" }, { "1", "one" }, { "2", "two" }, { "3", "three" },
                { "4", "four" }, { "5", "five" }, {"6", "six" }, { "7", "seven" }, { "8", "eight" }, { "9", "nine" } };
            Dictionary<string, string> dict2 = new Dictionary<string, string> { { "10", "ten" }, { "11", "eleven" }, { "12", "twelve" }, { "13", "thirteen" },
                { "14", "fourteen" }, { "15", "fifteen" }, {"16", "sixteen" }, { "17", "seventeen" }, { "18", "eighteen" }, { "19", "nineteen" } };
            Dictionary<string, string> dict3 = new Dictionary<string, string> { { "1", "one" }, { "2", "twenty" }, { "3", "thirty" }, { "4", "forty" },
                { "5", "fifty" }, { "6", "sixty" }, { "7", "seventy" }, { "8", "eighty" }, { "9", "ninety" } };
            var multiplier = new string[] { "", "", "", "hundred", "thousand", "thousand", "lakh", "lakh", "crore", "crore" };
            StringBuilder sb = new StringBuilder();
            int len = A.Length;
            while (len != 0)
            {
                if (A[0] == '0')
                {
                    len--;
                    A = A.Substring(1);
                    continue;
                }
                if (len == 1)
                {
                    if (sb.Length > 0)
                    {
                        if (sb.ToString().Contains("-and-"))
                        {
                            sb.Append(dict1[A]);
                        }
                        else sb.Append("-and-" + dict1[A]);
                    }
                    else sb.Append(dict1[A]);
                    len --;
                }
                if (len == 2)
                {
                    if (A[0] < '2')
                    {
                        if (sb.Length > 0)
                        {
                            if (sb.ToString().Contains("-and-"))
                            {
                                sb.Append(dict2[A]);
                            }
                            else sb.Append("-and-" + dict2[A]);
                        }
                        else sb.Append(dict2[A]);
                        len -= 2;
                    }
                    else
                    {
                        if (sb.Length > 0)
                        {
                            if (sb.ToString().Contains("-and-"))
                            {
                                sb.Append(dict3[A[0].ToString()]);
                            }
                            else sb.Append("-and-" + dict3[A[0].ToString()]);
                        }
                        else sb.Append(dict3[A[0].ToString()]);
                        if (A[1] == '0') break;
                        else
                        {
                            sb.Append("-" + dict1[A[1].ToString()]);
                            break;
                        }
                    }
                }
                if (len == 3)
                {
                    if (sb.Length > 0)
                    {
                        if (!sb.ToString().EndsWith("-"))
                        {
                            sb.Append("-");
                        }
                    }
                    sb.Append(dict1[A[0].ToString()] + "-" + multiplier[len] + "-and-");
                    len--;
                    A = A.Substring(1);
                }
                if (len > 3)
                {
                    if (sb.Length > 0)
                    {
                        if (!sb.ToString().EndsWith("-"))
                        {
                            sb.Append("-");
                        }
                    }
                    if (len % 2 == 0)
                    {
                        sb.Append(dict1[A[0].ToString()] + "-" + multiplier[len]);
                        len--;
                        A = A.Substring(1);
                    }
                    else
                    {
                        if (A[0] == '1')
                        {
                            sb.Append(dict2[A[0].ToString() + A[1].ToString()] + "-" + multiplier[len]);
                        }
                        else
                        {
                            sb.Append(dict3[A[0].ToString()] + "-");
                            if (A[1] != '0')
                                sb.Append(dict1[A[1].ToString()] + "-");
                            sb.Append(multiplier[len]);
                        }
                        A = A.Substring(2);
                        len = A.Length;
                    }
                }
            }
            if (sb.ToString().EndsWith("-and-"))
            {
                sb = new StringBuilder(sb.ToString().Substring(0, sb.Length - 5));
            }
            if (sb.Length.Equals(B.Length) && sb.ToString().Equals(B.Substring(0, sb.Length))) return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Solve("1", "one"));
            //Console.WriteLine(Solve("99", "ninety-nine"));
            //Console.WriteLine(Solve("318", "three-hundred-and-eighteen"));
            //Console.WriteLine(Solve("1234", "one-thousand-two-hundred-and-thirty-four"));
            //Console.WriteLine(Solve("1200", "one-thousand-two-hundred"));
            //Console.WriteLine(Solve("11200", "eleven-thousand-two-hundred"));
            //Console.WriteLine(Solve("1911200", "nineteen-lakh-eleven-thousand-two-hundred"));
            //Console.WriteLine(Solve("821191001", "eighty-two-crore-eleven-lakh-ninety-one-thousand-and-one"));
            Console.WriteLine(Solve("28440447", "two-crore-eighty-four-lakh-forty-thousand-four-hundred-and-forty-seven"));
            //Console.WriteLine(Solve("1000000000", "one-arab"));
        }
    }
}
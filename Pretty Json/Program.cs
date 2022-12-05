namespace Pretty_Json
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        public static List<string> PrettyJSON(string A)
        {
            var result = new List<string>();
            StringBuilder sb = new StringBuilder();
            int indentCount = 0; 
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '{' || A[i] == '[')
                {
                    if (sb.Length > 0)                    
                    {
                        sb = AddTabs(indentCount, sb);
                        result.Add(sb.ToString());
                        sb.Clear();
                    }
                    sb.Append(A[i]);
                    sb = AddTabs(indentCount, sb);
                    result.Add(sb.ToString());
                    sb.Clear();
                    indentCount++;
                }
                else if (A[i] == ',')
                {
                    if (sb.Length == 0)
                    {
                        var temp = result[result.Count - 1];
                        if (temp.EndsWith("}") || temp.EndsWith("]"))
                        {
                            result[result.Count - 1] = temp + ",";
                            continue;
                        }
                    }
                    else
                    {
                        sb.Append(A[i]);
                        sb = AddTabs(indentCount, sb);
                        result.Add(sb.ToString());
                        sb.Clear();
                    }
                }
                else if (A[i] == ' ')
                {
                    continue;
                }
                else if (A[i] == ']' || A[i] == '}')
                {
                    if (sb.Length > 0)
                    { 
                        sb = AddTabs(indentCount, sb);
                        result.Add(sb.ToString());
                        sb.Clear();
                    }
                    indentCount--;
                    sb.Append(A[i]);
                    sb = AddTabs(indentCount, sb);
                    result.Add(sb.ToString());
                    sb.Clear();
                }
                else
                {
                    sb.Append(A[i]);
                }
            }
            return result;
        }

        public static StringBuilder AddTabs(int indentCount, StringBuilder sb)
        {
            while (indentCount > 0)
            {
                sb = sb.Insert(0, "\t");
                indentCount--;
            }
            return sb;
        }

        static void Main(string[] args)
        {
            //PrettyJSON("{A:\"B\",C:{D:\"E\",F:{G:\"H\",I:\"J\"}}}").ForEach(x => Console.WriteLine(x));
            //PrettyJSON("[\"foo\", {\"bar\":[\"baz\",null,1.0,2]}]").ForEach(x => Console.WriteLine(x));
            PrettyJSON("{\"attributes\":[{\"nm\":\"ACCOUNT\",\"lv\":[{\"v\":{\"Id\":null,\"State\":null},\"vt\":\"java.util.Map\",\"cn\":1}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":13585},{\"nm\":\"PROFILE\",\"lv\":[{\"v\":{\"Party\":null,\"Ads\":null},\"vt\":\"java.util.Map\",\"cn\":2}],\"vt\":\"java.util.Map\",\"status\":\"SUCCESS\",\"lmd\":41962}]}").ForEach(x => Console.WriteLine(x));
        }
    }
}

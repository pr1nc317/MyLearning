/*
// Sample code to perform I/O:

name = Console.ReadLine();                  // Reading input from STDIN
Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

// Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
*/

// Write your code here
namespace ZenotiTest
{
    using System;

    class ZenotiTest
    {
        private static void Main()
        {
            //var str = Console.ReadLine();
            Method("xyz abc mnp \"asdf dfaa asdf\" asd \"fdas asdsdafF\"");
        }

        private static void Method(string input)
        {
            var array = input.Split(" ");
            var intermittentString = string.Empty;
            bool quoteStringInPlay = false;
            foreach (var item in array)
            {
                if (!item.Contains("\"") && !quoteStringInPlay)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    quoteStringInPlay = true;
                    if (string.IsNullOrEmpty(intermittentString))
                    {
                        intermittentString += item;
                    }
                    else
                    {
                        intermittentString += " " + item;
                    }
                    if (item.EndsWith("\""))
                    {
                        Console.WriteLine(intermittentString);
                        intermittentString = string.Empty;
                        quoteStringInPlay = false;
                    }
                }
            }
        }
    }
}
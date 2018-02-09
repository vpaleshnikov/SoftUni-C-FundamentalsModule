using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\SoftwareUniversity\SoftUni-C-FundamentalsModule\C#Advanced\05.Streams-Exercises\Resources\text.txt");

            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        Console.WriteLine($"{line}");
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}
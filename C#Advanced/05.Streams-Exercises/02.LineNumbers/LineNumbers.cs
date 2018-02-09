using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\SoftwareUniversity\SoftUni-C-FundamentalsModule\C#Advanced\05.Streams-Exercises\Resources\text.txt"))
            {
                using (var writer = new StreamWriter("textOutput.txt"))
                {
                    string line = reader.ReadLine();
                    var lineCounter = 0;
                    while (line != null)
                    {

                        writer.Write($"Line {lineCounter}: {line}");
                        writer.WriteLine();
                        line = reader.ReadLine();
                        lineCounter++;
                    }
                }
            }
        }
    }
}

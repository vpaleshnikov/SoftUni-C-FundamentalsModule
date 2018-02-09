using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace _01.Regeh
{
    class Regeh
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            //            "\[[a-zA-Z]+<(\d+)REGEH(\d+)>[a-zA-Z]+\]"
            var pattern = @"[[]\w+<(\d+)REGEH(\d+)>\w+[]]";

            Regex regex = new Regex(pattern);

            var match = regex.Matches(input);

            var numbers = new List<int>();

            //foreach (Match matchh in regex.Matches(input))
            //{
            //    numbers.Add(int.Parse(matchh.Groups[1].Value));
            //    numbers.Add(int.Parse(matchh.Groups[2].Value));
            //}

            for (int i = 0; i < match.Count; i++)
            {
                numbers.Add(int.Parse(match[i].Groups[1].Value));
                numbers.Add(int.Parse(match[i].Groups[2].Value));
            }

            //int currentIndex = 0;
            //foreach (var index in numbers)
            //{
            //    currentIndex += index;
            //    var charIndex = currentIndex % (input.Length - 1);
            //    Console.Write(input[charIndex]);
            //}

            var sum = 0;

            var resultNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                resultNumbers.Add(sum += numbers[i]);
            }

            var sb = new StringBuilder();

            for (int i = 0; i < resultNumbers.Count; i++)
            {
                if (resultNumbers[i] >= input.Length)
                {
                    resultNumbers[i] = 0;
                }
                sb.Append(input[resultNumbers[i]]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}

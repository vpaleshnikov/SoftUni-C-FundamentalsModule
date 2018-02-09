using System;
using System.Text.RegularExpressions;

namespace _04.TreasureMap
{
    class TreasureMap
    {
        static void Main(string[] args)
        {
            var pattern =
                @"(#|!)[^#!]*?(?<![a-zA-Z0-9])(?<streetName>([a-zA-Z]{4}))(?![a-zA-Z0-9])[^#!]*(?<!\d)(?<streetNumber>(\d{3}))-(?<pass>(\d{4}|\d{6}))(?!\d)[^#!]*?(#|!)";
            
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var matchCollection = Regex.Matches(input, pattern);

                var correctMatch = matchCollection[matchCollection.Count / 2];

                Console.WriteLine($"Go to str. {correctMatch.Groups["streetName"].Value} {correctMatch.Groups["streetNumber"].Value}. Secret pass: {correctMatch.Groups["pass"].Value}.");
            }
        }
    }
}

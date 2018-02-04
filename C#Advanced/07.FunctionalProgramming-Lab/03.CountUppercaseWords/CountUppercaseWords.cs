using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class CountUppercaseWords
    {
        static void Main(string[] args)
        {
            Func<string, bool> upperCaseChecker = s => char.IsUpper(s[0]);

            Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(upperCaseChecker)
                .ToList()
                .ForEach(s => Console.WriteLine(s));
            
        }
    }
}
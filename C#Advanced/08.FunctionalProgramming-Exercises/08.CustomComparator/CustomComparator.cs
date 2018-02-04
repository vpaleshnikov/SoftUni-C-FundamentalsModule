using System;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(a => a)
                .OrderBy(a => a % 2 == 0)
                .OrderBy(a => a % 2 != 0)
                .ToList()));
        }
    }
}
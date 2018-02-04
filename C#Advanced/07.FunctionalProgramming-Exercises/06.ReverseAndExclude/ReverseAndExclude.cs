using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", input.Where(number => number % n != 0).Reverse()));
        }
    }
}
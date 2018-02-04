using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(
                string.Join(Environment.NewLine,Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Where(a => a.Length <= n)));
        }
    }
}
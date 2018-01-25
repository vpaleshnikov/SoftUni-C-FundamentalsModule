using System;
using System.Collections.Generic;

namespace _01.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input);

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}

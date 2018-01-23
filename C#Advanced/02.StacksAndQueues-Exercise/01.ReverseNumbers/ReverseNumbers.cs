using System;
using System.Collections.Generic;

namespace _01.ReverseNumbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}

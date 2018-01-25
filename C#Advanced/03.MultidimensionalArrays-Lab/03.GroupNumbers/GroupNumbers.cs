using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            var firstResult = new List<int>();
            var secondResult = new List<int>();
            var thirdResult = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Math.Abs(input[i]) % 3 == 0)
                {
                    firstResult.Add(input[i]);
                }
                if (Math.Abs(input[i]) % 3 == 1)
                {
                    secondResult.Add(input[i]);
                }
                if (Math.Abs(input[i]) % 3 == 2)
                {
                    thirdResult.Add(input[i]);
                }
            }

            Console.WriteLine(string.Join(" ",firstResult));
            Console.WriteLine(string.Join(" ", secondResult));
            Console.WriteLine(string.Join(" ", thirdResult));
        }
    }
}
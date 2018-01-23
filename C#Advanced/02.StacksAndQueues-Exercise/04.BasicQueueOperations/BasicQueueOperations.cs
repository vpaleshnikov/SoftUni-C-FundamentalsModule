using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var n = int.Parse(firstLine[0]);
            var s = int.Parse(firstLine[1]);
            var x = int.Parse(firstLine[2]);

            var secondLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(secondLine[i]);
            }
            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count > 0)
            {
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
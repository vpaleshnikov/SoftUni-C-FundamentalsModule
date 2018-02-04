using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var filter = Console.ReadLine();

            var list = new List<int>();
            
            for (int i = input[0]; i <= input[1]; i++)
            {
                list.Add(i);
            }

            if (filter == "odd")
            {
                Console.WriteLine(string.Join(" ",list.Where(n => n % 2 != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", list.Where(n => n % 2 == 0)));
            }
        }
    }
}
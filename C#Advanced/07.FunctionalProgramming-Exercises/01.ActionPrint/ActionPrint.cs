using System;

namespace _01.ActionPrint
{
    class ActionPrint
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(' ');
        var urls = Console.ReadLine().Split(' ');

        var smartphone = new Smartphone();

        foreach (var number in numbers)
        {
            if (number.All(char.IsNumber))
            {
                smartphone.Number = number;
                Console.WriteLine(smartphone.Call());
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        foreach (var url in urls)
        {
            var isValid = true;

            foreach (var symbol in url)
            {
                if (char.IsDigit(symbol))
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                smartphone.Url = url;
                Console.WriteLine(smartphone.Browse());
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}

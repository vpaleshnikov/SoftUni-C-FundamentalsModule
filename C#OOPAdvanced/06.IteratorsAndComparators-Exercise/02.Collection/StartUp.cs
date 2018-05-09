using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var listIterator = new ListyIterator<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var commands = input.Split();
            var currentCommand = commands[0];

            switch (currentCommand)
            {
                case "Create":
                    listIterator.Create(commands.Skip(1).ToArray());
                    break;
                case "Move":
                    Console.WriteLine(listIterator.Move());
                    break;
                case "Print":
                    listIterator.Print();
                    break;
                case "HasNext":
                    Console.WriteLine(listIterator.HasNext());
                    break;
                case "PrintAll":
                    Console.WriteLine(listIterator.PrintAll());
                    break;
            }
        }
    }
}
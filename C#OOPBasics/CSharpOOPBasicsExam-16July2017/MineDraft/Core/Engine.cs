using System;
using System.Linq;

public class Engine
{
    public void Run()
    {
        var draftManager = new DraftManager();

        string input;
        while ((input = Console.ReadLine()) != "Shutdown")
        {
            var arguments = input.Split().ToList();
            var command = arguments[0];
            arguments.RemoveAt(0);

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(arguments));
                    break;
            }
        }
        Console.WriteLine(draftManager.ShutDown());
    }
}
using System;

public class StartUp
{
    static void Main()
    {
        var studentSystem = new StudentSystem();
        string input;
        while ((input = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(input, Console.WriteLine);
        }
    }
}
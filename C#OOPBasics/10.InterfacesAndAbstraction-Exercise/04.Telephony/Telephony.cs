using System;

public class Telephony
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split();
        var urls = Console.ReadLine()
            .Split();


        var smartphone = new Smartphone();

        for (int i = 0; i < numbers.Length; i++)
        {
            try
            {
                smartphone.Number = numbers[i];
                Console.WriteLine(smartphone.Call());
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }

        }

        for (int i = 0; i < urls.Length; i++)
        {
            try
            {
                smartphone.Website = urls[i];
                Console.WriteLine(smartphone.Browse());
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }
    }
}
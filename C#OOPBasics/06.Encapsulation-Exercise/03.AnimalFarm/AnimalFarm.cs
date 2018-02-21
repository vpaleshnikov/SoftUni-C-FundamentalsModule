using System;

public class AnimalFarm
{
    public static void Main()
    {
        var name = Console.ReadLine();
        var age = int.Parse(Console.ReadLine());

        try
        {
            Chicken chicken = new Chicken(name, age);
            Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
            Environment.Exit(0);
        }
    }
}
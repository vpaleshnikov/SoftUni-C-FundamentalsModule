using System;

public class Program
{
    public static void Main()
    {
        var firstDate = new DateModifier().StringToDateTime(Console.ReadLine());
        var lastDate = new DateModifier().StringToDateTime(Console.ReadLine());

        Console.WriteLine(new DateModifier().DaysDifferenceCalculator(firstDate, lastDate));
    }
}
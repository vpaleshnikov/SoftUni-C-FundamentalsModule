using System;

public class HotelReservation
{
    public static void Main()
    {
        var comand = Console.ReadLine();
        var priceCalculator = new PriceCalculator(comand);
        var totalPrice = priceCalculator.CalculatePrice();
        Console.WriteLine(totalPrice);
    }
}
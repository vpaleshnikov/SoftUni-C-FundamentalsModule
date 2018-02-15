using System;

public class HotelReservation
{
    public static void Main()
    {
        var reservationInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        var price = decimal.Parse(reservationInfo[0]);
        var days = int.Parse(reservationInfo[1]);
        var season = reservationInfo[2];

        var calculator = new PriceCalculator(price, days, season);

        if (reservationInfo.Length == 4)
        {
            calculator.DiscountType = reservationInfo[3];
        }

        Console.WriteLine(new PriceCalculator(price,days, season).Calculator(calculator));
    }
}
using System;

public class PriceCalculator
{
    private decimal pricePerNight;
    private int nights;
    private SeasonsEnum season;
    private Discounts discount;

    public PriceCalculator(string command)
    {
        var input = command
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        pricePerNight = decimal.Parse(input[0]);
        nights = int.Parse(input[1]);
        season = Enum.Parse<SeasonsEnum>(input[2]);
        discount = Discounts.None;

        if (input.Length > 3)
        {
            discount = Enum.Parse<Discounts>(input[3]);
        }
    }

    public string CalculatePrice()
    {
        var tempTotal = pricePerNight * nights * (int)season;

        var discountPersentage = ((decimal)100 - (int)discount) / 100;

        var totalPrice = tempTotal * discountPersentage;

        return totalPrice.ToString("F2");
    }
}
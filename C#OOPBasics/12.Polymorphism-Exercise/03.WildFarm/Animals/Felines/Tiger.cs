using System;
using System.Collections.Generic;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
        this.FavouriteFood = FavouriteFoods();
    }

    public override void ProduceSound()
    {
        Console.WriteLine("ROAR!!!");
    }

    public void Eat(int quantity)
    {
        this.Weight += (quantity * 1.00);
        this.FoodEaten += quantity;
    }

    protected List<string> FavouriteFoods()
    {
        this.FavouriteFood.Add("Meat");

        return this.FavouriteFood;
    }
}
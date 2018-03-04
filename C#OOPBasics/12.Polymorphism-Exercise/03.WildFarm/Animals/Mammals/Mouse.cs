using System;
using System.Collections.Generic;

public class Mouse:Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
        this.FavouriteFood = FavouriteFoods();
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }

    public void Eat(int quantity)
    {
        this.Weight += (quantity * 0.10);
        this.FoodEaten += quantity;
    }

    protected List<string> FavouriteFoods()
    {
        this.FavouriteFood.Add("Fruit");
        this.FavouriteFood.Add("Vegetable");

        return this.FavouriteFood;
    }

}
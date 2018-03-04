using System;
using System.Collections.Generic;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
        this.FavouriteFood = FavouriteFoods();
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Hoot Hoot");
    }

    public void Eat(int quantity)
    {
        this.Weight += (quantity * 0.25);
        this.FoodEaten += quantity;
    }

    protected List<string> FavouriteFoods()
    {
        this.FavouriteFood.Add("Meat");

        return this.FavouriteFood;
    }
}
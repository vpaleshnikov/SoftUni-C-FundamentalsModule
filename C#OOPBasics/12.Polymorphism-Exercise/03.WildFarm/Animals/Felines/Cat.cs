using System;
using System.Collections.Generic;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
        this.FavouriteFood = FavouriteFoods();
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }

    public void Eat(int quantity)
    {
        this.Weight += (quantity * 0.30);
        this.FoodEaten += quantity;
    }

    protected List<string> FavouriteFoods()
    {
        this.FavouriteFood.Add("Meat");
        this.FavouriteFood.Add("Vegetable");

        return this.FavouriteFood;
    }
}
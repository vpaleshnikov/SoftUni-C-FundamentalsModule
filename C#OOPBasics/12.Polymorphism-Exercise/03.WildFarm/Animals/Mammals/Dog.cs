using System;
using System.Collections.Generic;

public class Dog:Mammal
{
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
        this.FavouriteFood = FavouriteFoods();
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof");
    }

    public void Eat(int quantity)
    {
        this.Weight += (quantity * 0.40);
        this.FoodEaten += quantity;
    }

    protected List<string> FavouriteFoods()
    {
        this.FavouriteFood.Add("Meat");

        return this.FavouriteFood;
    }
}
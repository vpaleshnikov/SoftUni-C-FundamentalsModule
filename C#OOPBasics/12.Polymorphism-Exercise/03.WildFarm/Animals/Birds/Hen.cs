using System;
using System.Collections.Generic;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
        this.FavouriteFood = FavouriteFoods();
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }

    public void Eat(int quantity)
    {
        this.Weight += (quantity * 0.35);
        this.FoodEaten += quantity;
    }

    protected List<string> FavouriteFoods()
    {
        this.FavouriteFood.Add("Fruit");
        this.FavouriteFood.Add("Meat");
        this.FavouriteFood.Add("Seeds");
        this.FavouriteFood.Add("Vegetable");

        return this.FavouriteFood;
    }
}
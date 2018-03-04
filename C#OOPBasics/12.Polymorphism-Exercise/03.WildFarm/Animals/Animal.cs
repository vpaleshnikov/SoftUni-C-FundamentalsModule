using System.Collections.Generic;

public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
        this.FavouriteFood = new List<string>();
    }

    private string name;
    private double weight;
    private int foodEaten;
    private List<string> favouriteFood;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public double Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }
    
    public List<string> FavouriteFood
    {
        get { return this.favouriteFood; }
        set { this.favouriteFood = value; }
    }

    public abstract void ProduceSound();
}
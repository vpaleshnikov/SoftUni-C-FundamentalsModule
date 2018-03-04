﻿public abstract class Bird : Animal
{
    protected Bird(string name, double weight, double wingSize) 
        : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    private double wingSize;

    public double WingSize
    {
        get { return wingSize; }
        set { wingSize = value; }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;

    private int minLenghtName = 1;
    private int maxLenghtName = 15;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)
                || value.Length < minLenghtName || value.Length > maxLenghtName)
            {
                throw new ArgumentException($"Pizza name should be between {minLenghtName} and {maxLenghtName} symbols.");
            }

            this.name = value;
        }
    }

    public Dough Dough { get; set; }

    public List<Topping> Toppings { get; set; }

    public Pizza(string name)
    {
        this.Name = name;
        this.Dough = dough;
        this.Toppings = new List<Topping>();
    }

    public void AddTopping(Topping topping)
    {
        if (this.Toppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        else
        {
            Toppings.Add(topping);
        }
    }

    public double GetCalories()
    {
        return this.Dough.GetCalories() + this.Toppings.Sum(s => s.GetCalories());
    }
}
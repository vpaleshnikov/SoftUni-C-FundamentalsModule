using System;
using System.Collections.Generic;

public class Person
{
    private string name;

    private decimal money;

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<string> ShoppingBag { get; set; }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.ShoppingBag = new List<string>();
    }
}
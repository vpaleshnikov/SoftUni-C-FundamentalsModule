using System;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumtion, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumtion;
    }

    private double fuelQuantity;
    private double fuelConsumtion;
    private double tankCapacity;

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set
        {
            if (value > this.TankCapacity)
            {
                value = 0;
            }
            this.fuelQuantity = value;
        }
    }

    public double FuelConsumption
    {
        get { return this.fuelConsumtion; }
        set { this.fuelConsumtion = value; }
    }

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }

    public virtual void Drive(double distance)
    {
        var liters = distance * this.FuelConsumption;
        if (liters <= this.FuelQuantity)
        {
            this.FuelQuantity -= liters;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
    }

    public virtual void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (liters > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }
        else
        {
            this.FuelQuantity += liters;
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
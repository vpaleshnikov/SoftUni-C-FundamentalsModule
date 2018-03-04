using System;

public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumtion)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumtion;
    }

    private double fuelQuantity;
    private double fuelConsumtion;

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    public double FuelConsumption
    {
        get { return this.fuelConsumtion; }
        set { this.fuelConsumtion = value; }
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
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
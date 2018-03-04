using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumtion, double tankCapacity) 
        : base(fuelQuantity, fuelConsumtion + 1.6, tankCapacity)
    { }

    public override void Refuel(double liters)
    {
        var truckLiters = liters * 0.95;

        if (truckLiters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else if (truckLiters > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }
        else
        {
            this.FuelQuantity += truckLiters;
        }
    }
}
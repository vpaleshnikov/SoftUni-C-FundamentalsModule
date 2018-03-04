using System;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumtion, double tankCapacity)
        : base(fuelQuantity, fuelConsumtion, tankCapacity)
    { }

    public override void Drive(double distance)
    {
        var liters = distance * (this.FuelConsumption + 1.4);

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

    public void DriveEmpty(double distance)
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
}
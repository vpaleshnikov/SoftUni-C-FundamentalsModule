public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumtion) 
        : base(fuelQuantity, fuelConsumtion + 1.6)
    {
    }

    public override void Refuel(double liters)
    {
        liters = liters * 0.95;
        this.FuelQuantity += liters;
    }
}
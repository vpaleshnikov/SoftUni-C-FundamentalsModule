using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKm;
    private double kilometerTraveled;
    private double fuelConsumption;

    public Car()
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        this.kilometerTraveled = 0.00;
        this.fuelConsumption = 0.00;
    }

    public string Model
    {
        get { return model;}
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelConsumptionPerKm
    {
        get { return fuelConsumptionPerKm; }
        set { this.fuelConsumptionPerKm = value; }
    }

    public double KilometerTraveled
    {
        get { return kilometerTraveled; }
        set { this.kilometerTraveled = value; }
    }

    public bool DistanceChecker(string model, double amountOfKm)
    {
        var fuelConsumption = this.fuelConsumptionPerKm * amountOfKm;

        if (fuelConsumption > this.fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }

        return true;
    }

    public double DistanceCalculator(string model,double amountOfKm)
    {
        if (DistanceChecker(model, amountOfKm))
        {
            var fuelConsumption = amountOfKm * this.fuelConsumptionPerKm;

            this.fuelAmount -= fuelConsumption;
            this.kilometerTraveled += amountOfKm;
        }

        return kilometerTraveled;
    }
}
using System;
using System.Collections.Generic;

public class SpeedRacing
{
    static void Main()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var car = new Car();
            car.Model = tokens[0];
            car.FuelAmount = double.Parse(tokens[1]);
            car.FuelConsumptionPerKm = double.Parse(tokens[2]);

            cars.Add(car);
        }

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var model = tokens[1];
            var distance = double.Parse(tokens[2]);

            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    var distanceTraveled = car
                        .DistanceCalculator(model, distance);
                }
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.KilometerTraveled}");
        }
    }
}
using System;
using System.Collections.Generic;

public class CarSalesman
{
    public static void Main()
    {
        var enginesCount = int.Parse(Console.ReadLine());

        var engines = new List<Engine>();

        for (int engineIndex = 0; engineIndex < enginesCount; engineIndex++)
        {
            var engineInfo = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var engineModel = engineInfo[0];
            var enginePower = engineInfo[1];

            var engine = new Engine(engineModel, enginePower);

            if (engineInfo.Length == 3)
            {
                int number;
                if (int.TryParse(engineInfo[2], out number))
                {
                    engine.Displacement = engineInfo[2];
                }
                else
                {
                    engine.Efficiency = engineInfo[2];
                }
            }
            else if (engineInfo.Length > 3)
            {
                engine.Displacement = engineInfo[2];
                engine.Efficiency = engineInfo[3];
            }

            engines.Add(engine);
        }

        var numberOfCars = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int carIndex = 0; carIndex < numberOfCars; carIndex++)
        {
            var carsInfo = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

            var carModel = carsInfo[0];
            var carEngine = carsInfo[1];

            var car = new Car(carModel, carEngine);

            if (carsInfo.Length == 3)
            {
                int number;
                if (int.TryParse(carsInfo[2], out number))
                {
                    car.Weight = carsInfo[2];
                }
                else
                {
                    car.Color = carsInfo[2];
                }
            }
            else if (carsInfo.Length > 3)
            {
                car.Weight = carsInfo[2];
                car.Color = carsInfo[3];
            }

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model}:");
            foreach (var engine in engines)
            {
                if (car.Engine == engine.Model)
                {
                    Console.WriteLine($"  {engine.Model}:");
                    Console.WriteLine($"    Power: {engine.Power}");
                    Console.WriteLine($"    Displacement: {engine.Displacement}");
                    Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                }
            }
            Console.WriteLine($"  Weight: {car.Weight}");
            Console.WriteLine($"  Color: {car.Color}");
        }
    }
}
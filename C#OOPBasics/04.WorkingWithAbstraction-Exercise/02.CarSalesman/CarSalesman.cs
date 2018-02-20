using System;
using System.Collections.Generic;

public class CarSalesman
{
    static void Main()
    {
        int engineCount = int.Parse(Console.ReadLine());
        var engines = AddEngines(engineCount);

        int carCount = int.Parse(Console.ReadLine());
        var cars = AddCars(carCount);

        PrintResult(engines, cars);
    }

    private static void PrintResult(List<Engine> engines, List<Car> cars)
    {
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

    private static List<Car> AddCars(int carCount)
    {
        var cars = new List<Car>();

        for (int i = 0; i < carCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string model = parameters[0];
            string engineModel = parameters[1];

            var car = new Car(model, engineModel);

            int weight;
            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                car.Weight = parameters[2];
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                car.Color = color;
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                car.Weight = parameters[2];
                car.Color = color;
            }

            cars.Add(car);
        }

        return cars;
    }

    public static List<Engine> AddEngines(int engineCount)
    {
        var engines = new List<Engine>();

        for (int i = 0; i < engineCount; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var engine = new Engine(parameters[0], int.Parse(parameters[1]));
            if (parameters.Length == 3)
            {
                int number;
                if (int.TryParse(parameters[2], out number))
                {
                    engine.Displacement = parameters[2];
                }
                else
                {
                    engine.Efficiency = parameters[2];
                }
            }
            else if (parameters.Length > 3)
            {
                engine.Displacement = parameters[2];
                engine.Efficiency = parameters[3];
            }
            engines.Add(engine);
        }

        return engines;
    }

}
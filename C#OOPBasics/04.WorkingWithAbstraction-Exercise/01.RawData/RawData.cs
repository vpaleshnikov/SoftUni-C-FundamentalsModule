using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    static void Main()
    {
        List<Car> cars = new List<Car>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] parameters = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var car = CreateCar(parameters);

            cars.Add(car);
        }

        string command = Console.ReadLine();
        
        PrintCar(command, cars);
    }

    private static void PrintCar(string command, List<Car> cars)
    {
        if (command == "fragile")
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == command && car.Tyres.Any(tyre => tyre.Pressure < 1))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
        else
        {
            foreach (var car in cars)
            {
                if (car.Cargo.Type == command && car.Engine.Power > 250)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }

    private static Car CreateCar(string[] parameters)
    {
        string model = parameters[0];

        var car = new Car(model);
        car.Engine = new Engine(int.Parse(parameters[1]), int.Parse(parameters[2]));
        car.Cargo = new Cargo(int.Parse(parameters[3]), parameters[4]);

        for (int tyres = 5; tyres < parameters.Length; tyres += 2)
        {
            car.Tyres.Add(new Tyre(double.Parse(parameters[tyres]), int.Parse(parameters[tyres + 1])));
        }

        return car;
    }
}
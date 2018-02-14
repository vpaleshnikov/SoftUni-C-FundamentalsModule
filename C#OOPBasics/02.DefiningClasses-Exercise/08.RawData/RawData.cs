using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    public static void Main()
    {
        var carsAmount = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < carsAmount; i++)
        {
            var carDetails = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var car = new Car(
                carDetails[0],
                new Engine(double.Parse(carDetails[1]), double.Parse(carDetails[2])),
                new Cargo(double.Parse(carDetails[3]), carDetails[4]),
                new List<Tyre>(){
                    new Tyre(double.Parse(carDetails[5]), double.Parse(carDetails[6])),
                    new Tyre(double.Parse(carDetails[7]), double.Parse(carDetails[8])),
                    new Tyre(double.Parse(carDetails[9]), double.Parse(carDetails[10])),
                    new Tyre(double.Parse(carDetails[11]), double.Parse(carDetails[12]))
                });

            cars.Add(car);
        }

        var command = Console.ReadLine();

        if (command == "fragile")
        {
            cars
                .Where(c => c.Cargo.CargoType == "fragile")
                .Where(t => t.Tyres.Any(tyre => tyre.TyrePressure < 1))
                .Select(c => c.Model)
                .ToList()
                .ForEach(m => Console.WriteLine(m));
        }
        else
        {
            cars
                .Where(c => c.Cargo.CargoType == "flamable")
                .Where(e => e.Engine.EnginePower > 250)
                .Select(c => c.Model)
                .ToList()
                .ForEach(e => Console.WriteLine(e));
        }
    }
}
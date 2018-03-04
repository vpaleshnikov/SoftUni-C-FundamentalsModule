using System;

public class Vehicles
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

        var truckInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

        var countCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < countCommands; i++)
        {
            var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var command = input[0];
            var vehicle = input[1];

            if (command == "Drive")
            {
                var distane = double.Parse(input[2]);

                if (vehicle == "Car")
                {
                    car.Drive(distane);
                }
                else if (vehicle == "Truck")
                {
                    truck.Drive(distane);
                }
            }
            else if (command == "Refuel")
            {
                var liters = double.Parse(input[2]);

                if (vehicle == "Car")
                {
                    car.Refuel(liters);
                }
                else if (vehicle == "Truck")
                {
                    truck.Refuel(liters);
                }
            }
        }


        Console.WriteLine(car);
        Console.WriteLine(truck);
    }
}
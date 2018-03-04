using System;

public class VehiclesExtension
{
    public static void Main()
    {
        var carInfo = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

        var truckInfo = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

        var busInfo = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var command = input[0];
            var vehicle = input[1];

            if (command == "Drive")
            {
                var distance = double.Parse(input[2]);

                if (vehicle == "Car")
                {
                    car.Drive(distance);
                }
                else if (vehicle == "Truck")
                {
                    truck.Drive(distance);
                }
                else if (vehicle == "Bus")
                {
                    bus.Drive(distance);
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
                else if (vehicle == "Bus")
                {
                    bus.Refuel(liters);
                }
            }
            else if (command == "DriveEmpty")
            {
                var distance = double.Parse(input[2]);
                var emptyBus = (Bus) bus;
                emptyBus.DriveEmpty(distance);
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }
}
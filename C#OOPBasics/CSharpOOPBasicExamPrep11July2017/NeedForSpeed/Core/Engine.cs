using System;

public class Engine
{
    public Engine()
    {
        this.CarManager = new CarManager();
    }

    public CarManager CarManager { get; set; }

    public void Run()
    {
        string input;
        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            var tokens = input.Split();

            var command = tokens[0];
            var id = 0;
            switch (command)
            {
                case "register":
                    id = int.Parse(tokens[1]);
                    var type = tokens[2];
                    this.CarManager.Register(id, type, tokens[3], tokens[4], int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8]), int.Parse(tokens[9]));
                    break;
                case "check":
                    id = int.Parse(tokens[1]);
                    Console.WriteLine(this.CarManager.Check(id));
                    break;
                case "open":
                    id = int.Parse(tokens[1]);
                    this.CarManager.Open(id, tokens[2], int.Parse(tokens[3]), tokens[4], int.Parse(tokens[5]));
                    break;
                case "participate":
                    this.CarManager.Participate(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                case "start":
                    Console.WriteLine(this.CarManager.Start(int.Parse(tokens[1])));
                    break;
                case "park":
                    id = int.Parse(tokens[1]);
                    this.CarManager.Park(id);
                    break;
                case "unpark":
                    id = int.Parse(tokens[1]);
                    this.CarManager.Unpark(id);
                    break;
                case "tune":
                    var tuneIndex = int.Parse(tokens[1]);
                    var addOn = tokens[2];
                    this.CarManager.Tune(tuneIndex, addOn);
                    break;
            }
        }
    }
}